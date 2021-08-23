namespace MyWebAPI.Extensions
{
    using Contracts;
    using Entities;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Repository;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using Entities.Models;
    using System;
    using Microsoft.AspNetCore.Builder;

    public static class ServiceExtensions
    {
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(
                config.GetConnectionString("DefaultConnection")));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

        }

        public static void ConfigureRepositoryWrapperAddData(this IServiceCollection services)
        {
            var theService = services.BuildServiceProvider().GetService<IRepositoryWrapper>();

            theService.Owner.Create(new Owner()
            {
                Name = string.Concat("Name-", new Guid().ToString()),
                Address = string.Concat("Adress1-", new Guid().ToString().Substring(0, 3)),
                DateOfBirth = DateTime.Now,
                Accounts = new List<Account>()
                {
                    new Account()
                    {
                        DateCreated = DateTime.Now,
                        AccountType = string.Concat("AcountType-", new Guid().ToString().Substring(0, 3)),
                        Owner = new Owner()
                    },
                    new Account()
                    {
                        DateCreated = DateTime.Now,
                        AccountType = string.Concat("AcountType-", new Guid().ToString().Substring(0, 3)),
                        Owner = new Owner()
                    },
                    new Account()
                    {
                        DateCreated = DateTime.Now,
                        AccountType = string.Concat("AcountType-", new Guid().ToString().Substring(0, 3)),
                        Owner = new Owner()
                    }
                }
            });

            theService.Save();
        }
    }
}
