﻿using AgateMountainWarehouse.Application.Interfaces;
using AgateMountainWarehouse.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AgateMountainWarehouse.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddDbContext<WarehouseDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("AMWarehouseConnectionString"));
        });

        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}