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
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"F:\\STUDENT DEBIL SEM 5\\PROJEKTZESPOLOWY\\ZLECTO\\ZLECTO.ENTITYFRAMEWORK\\DATABASE\\ZLECTO.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")); 
            //configuration.GetConnectionString("ConnectionStrings: ZTPDB"

            serviceCollection.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<EFDbContext>()
                .AddDefaultTokenProviders();

            // NuGet package service used for mapping db-objects to DTOs:
            serviceCollection.AddAutoMapper(typeof(EFDBMapperProfile));


            // User related services:
            serviceCollection.AddScoped<IUserFcd, UserFcd>();
            serviceCollection.AddScoped<IUserService, UserService>();

            // Collection related services:
            serviceCollection.AddScoped<ICommissionFcd, CommissionFcd>();
            serviceCollection.AddScoped<ICommissionService, CommissionService>();

        }
    }
}
