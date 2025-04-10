using SalesDemo.Infra.IoC.CrossCutting;

namespace SalesDemo.Web.Api.Configuration;

public static class DependencyInjectorConfiguration
{
    public static WebApplicationBuilder AddDependencyInjectorConfiguration(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(nameof(builder));

        builder.RegisterServices();
        
        return builder;
    }
}