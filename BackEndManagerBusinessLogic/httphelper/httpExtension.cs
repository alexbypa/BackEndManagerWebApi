﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace BackEndManagerBusinessLogic.httphelper;
public static class httpExtension {
    public static IServiceCollection AddHttpClients(this IServiceCollection services, IConfiguration configuration) {
        //services.AddTransient<CustomLoggingHandler>(); 
        var httpclientoptions = configuration.GetSection("HttpClientOptions");

        services.Configure<List<httpClientOptions>>(httpclientoptions);
        List<httpClientOptions>? options = getOptions(httpclientoptions);
        if (options != null)
            foreach (var option in options) {
                services.AddHttpClient<httpsClientHelper>(option.Name)
                    .SetHandlerLifetime(TimeSpan.FromSeconds(30))
                    ;
                    //.AddHttpMessageHandler<CustomLoggingHandler>();
                    //.ConfigurePrimaryHttpMessageHandler(() => new httpBindingOptions()
                    //.getCertificateForHttpHandler(option.Certificate.Path, option.Certificate.Password))
            }

        return services;
    }
    private static List<httpClientOptions>? getOptions(IConfigurationSection httpclientoptions) {
        if (httpclientoptions == null)
            return null;
        else
            return httpclientoptions.Get<List<httpClientOptions>>();
    }
}