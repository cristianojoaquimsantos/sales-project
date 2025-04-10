using Microsoft.EntityFrameworkCore;
using SalesDemon.Infra.Data.Context;

namespace SalesDemo.Web.Api.Configuration;

public static class DatabaseConfiguration
{
    public static WebApplicationBuilder AddDatabaseConfiguration(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(nameof(builder));

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        return builder;
    }
}