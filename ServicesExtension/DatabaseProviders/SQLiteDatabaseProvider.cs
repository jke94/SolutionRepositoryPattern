namespace ServicesExtension.DatabaseProviders
{
    using Entities.Context;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class SQLiteDatabaseProvider
    {
        public static void ConfigureSqlLiteServerContextAsync(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<RepositoryContext>(options =>
                {
                    options.UseSqlite(config.GetConnectionString("SQLiteDefaultConnection"));
                }   
            );

            using (var servicesProvider = services.BuildServiceProvider())
            {
                var context = servicesProvider.GetRequiredService<RepositoryContext>();

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}

