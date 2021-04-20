# Shared.Swagger

Shared configuration for all DoNotBuy projects

### How to use
1. Provide configuration in appsettings.json
```json
  "SwaggerConfiguration": {
    "title": "API",
    "version": "v1",
    "url": "/swagger/v1/swagger.json"
  }
 ````
 2. Add xml documentation to project file
 ```xml
  <PropertyGroup>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <NoWarn>$(NoWarn);1591</NoWarn>
  </PropertyGroup>
```
3. Configure service in Startup.cs
```csharp
    services.AddSwagger(Configuration.GetSection(nameof(SwaggerConfiguration)).Get<SwaggerConfiguration>());
```
4. Enable Swagger middleware 
```csharp
    app.UseSwagger(Configuration.GetSection(nameof(SwaggerConfiguration)).Get<SwaggerConfiguration>());
```
