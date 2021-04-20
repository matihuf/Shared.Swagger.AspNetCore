using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Shared.Swagger.AspNetCore;
using Shared.Swagger.AspNetCore.Models;
using System;

namespace Shared.Swagger.AspNetCore
{
    public static class ApplicationBuilderExtensions
    { 
        public static IApplicationBuilder UseSwagger(this IApplicationBuilder applicationBuilder, SwaggerConfiguration swaggerConfiguration)
        {

            applicationBuilder.UseSwagger();
            applicationBuilder.UseSwaggerUI(x =>
            {
                x.RoutePrefix = string.Empty;
                x.SwaggerEndpoint(swaggerConfiguration.Url, swaggerConfiguration.Version);
            });
            return applicationBuilder;
        }
    }
}
