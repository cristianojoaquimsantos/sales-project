using Microsoft.EntityFrameworkCore;
using SalesDemo.Web.Api.Configuration;
using SalesDemon.Infra.Data.Context;

namespace SalesDemo.Web.Api;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddAuthorization()
            .AddEndpointsApiExplorer()
            .AddSwaggerGen();

        builder.AddApiConfiguration()
            .AddDatabaseConfiguration()
            .AddDependencyInjectorConfiguration();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();
        app.Run();
    }
}