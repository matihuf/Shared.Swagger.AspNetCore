using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Shared.Swagger.AspNetCore.Models;
using System;
using System.IO;
using System.Reflection;

namespace Shared.Swagger.AspNetCore
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services, SwaggerConfiguration swaggerConfiguration)
        {
            services.AddSwaggerGenNewtonsoftSupport();
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc(swaggerConfiguration.Version, new OpenApiInfo { Title = swaggerConfiguration.Title });
                x.OrderActionsBy(o => o.HttpMethod);
                x.IncludeXmlComments(GetXmlFilePath());
            });
            return services;
        }

        private static string GetXmlFilePath()
        {
            var xmlFile = $"{Assembly.GetEntryAssembly().GetName().Name}.xml";
            var xmlFilePath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            return xmlFilePath;
        }
    }
}
