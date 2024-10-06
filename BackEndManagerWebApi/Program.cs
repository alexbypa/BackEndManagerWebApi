using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using BackEndManagerBusinessLogic.signalr.hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);

#region signalr
builder.Services.AddCors(options => options.AddPolicy(name: "enablecorsforclient", builder => {
    builder.AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
    .WithOrigins("http://localhost:5051")
    .SetIsOriginAllowed((host) => true);
}));
builder.Services.AddScoped<NotificationHub>();
builder.Services.AddSignalR().AddHubOptions<NotificationHub>(options => {
    options.EnableDetailedErrors = true;
});
builder.Services.AddSingleton<INotificationService, NotificationService>();
builder.Services.AddTransient<yourBusinessLogic>();
#endregion

builder.Services.AddApiVersioning(options => {
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
    options.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new HeaderApiVersionReader("X-Api-Version")
    );
})
.AddApiExplorer(options => {
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API - V1", Version = "v1.0" });
    c.SwaggerDoc("v1.1", new OpenApiInfo { Title = "My API - V1.1", Version = "v1.1" });
    c.SwaggerDoc("v2", new OpenApiInfo { Title = "My API - V2", Version = "v2.0" });
});
#region Config
builder.Services.AddOptions();
#endregion

#region HttpClient
builder.Services.AddHttpClient<GitHubService>(httpClient => {
    httpClient.BaseAddress = new Uri("https://api.github.com");
});
builder.Services.AddTransient<LoggingDelegatingHandler>();

builder.Services.AddHttpClient<GitHubService>(httpClient => {
    httpClient.BaseAddress = new Uri("https://api.github.com");
})
.AddHttpMessageHandler<LoggingDelegatingHandler>();
#endregion

var app = builder.Build();

app.UseStaticFiles();
#region signalr
app.UseCors("enablecorsforclient");
//app.MapHub<ChatHub>("/chatHub");
app.MapHub<NotificationHub>("/NotificationHub");
#endregion

//TODO:=======
app.MapGet("api/users/{username}", async (
    string username,
    GitHubService gitHubService) => {
        var content = await gitHubService.GetByUsernameAsync(username);

        return Results.Ok(content);
    });

var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI(options => {
        foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions) {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                description.GroupName.ToUpperInvariant());
        };
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();

//TODO:====
public class GitHubService(HttpClient client) {
    public async Task<string> GetByUsernameAsync(string username) {
        var url = $"users/{username}";

        return await client.GetStringAsync(url);
    }
}

public class LoggingDelegatingHandler(ILogger<LoggingDelegatingHandler> logger)
    : DelegatingHandler {
    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken) {
        try {
            logger.LogInformation("Before HTTP request");

            var result = await base.SendAsync(request, cancellationToken);

            result.EnsureSuccessStatusCode();

            logger.LogInformation("After HTTP request");

            return result;
        } catch (Exception e) {
            logger.LogError(e, "HTTP request failed");

            throw;
        }
    }
}