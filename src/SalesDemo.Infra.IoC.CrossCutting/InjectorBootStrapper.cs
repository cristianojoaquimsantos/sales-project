using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SalesDemon.Infra.Data.Context;

namespace SalesDemo.Infra.IoC.CrossCutting;

public static class InjectorBootStrapper
{
    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(nameof(builder));

        builder.Services.AddScoped<AppDbContext>();
    }
}