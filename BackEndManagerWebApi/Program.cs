using Asp.Versioning;
using BackEndManagerBusinessLogic.httphelper;
using Microsoft.Extensions.Options;
using System.Reflection.Metadata.Ecma335;
var builder = WebApplication.CreateBuilder(args);

#region Versioning 
builder.Services.AddApiVersioning(options => {
    options.ApiVersionReader = new QueryStringApiVersionReader("api-version");
    options.DefaultApiVersion = new ApiVersion(new DateOnly(2024, 1, 1));
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
}).AddApiExplorer();
#endregion

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region Config
builder.Services.AddOptions();
#endregion

#region HttpClient
builder.Services.AddHttpClients(builder.Configuration);
#endregion

var app = builder.Build();

#region Versioning 
//install Asp.Versioning.Mvc.ApiExplorer    ( minimal api ) 
//install Asp.Versioning.Http               ( Controller ) 


var apiVersionSet = app.NewApiVersionSet()
    .HasApiVersion(new ApiVersion(new DateOnly(2024, 1, 1)))
    .HasApiVersion(new ApiVersion(new DateOnly(2024, 9, 20))) //Versioni Supportate !
    .Build();
app.UseHttpsRedirection();

app.MapGet("api/ping", () => {
    return TypedResults.Ok("asdasd");
})
.WithApiVersionSet(apiVersionSet)
.MapToApiVersion(new DateOnly(2024,1,1))
.WithOpenApi();

app.MapGet("api/ping", () => {
    return TypedResults.Ok("l'utili su");
})
.WithApiVersionSet(apiVersionSet)
.MapToApiVersion(new DateOnly(2024,9,20))
.WithOpenApi();

#endregion

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
