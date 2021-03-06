using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;

using Microsoft.AspNetCore.Identity;
using AutoMapper;

using ZTP.EntityFramework;
using ZTP.EntityFramework.Services;
using ZTP.EntityFramework.Models;
using ZTP.Interfaces.Facades;
using ZTP.Facades;
using ZTP.Interfaces.Infrastructure;

namespace ZTP.DI
{
    public static class DependencyMapper
    {
        public static void AddDependencies(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<EFDbContext>(options =>
                options.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\student debil sem 5\\ZTP project\\ZTP-project\\ZTP.EntityFramework\\Data\\ZTP-back.mdf\";Integrated Security=True;")
                );
            //configuration.GetConnectionString("ConnectionStrings: ZTPDB"

            // NuGet package service used for mapping db-objects to DTOs:
            serviceCollection.AddAutoMapper(typeof(EFDBMapperProfile));


            // User related services:
            serviceCollection.AddScoped<IGameFcd, GameFcd>();
            serviceCollection.AddScoped<IGameService, GameService>();

        }
    }
}
