namespace ServicesExtension.DatabaseSeederProvider
{
    using Contracts;
    using Entities.Models;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;

    public static class SQLServerDbSeeder
    {
        public static void AddDataInRepositoryWrapper(this IServiceCollection services)
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
