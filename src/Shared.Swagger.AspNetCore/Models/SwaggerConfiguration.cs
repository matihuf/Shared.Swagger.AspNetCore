using System.Diagnostics.CodeAnalysis;

namespace Shared.Swagger.AspNetCore.Models
{
    [ExcludeFromCodeCoverage]
    public class SwaggerConfiguration
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Version { get; set; }
    }
}
