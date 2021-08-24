namespace ServicesExtension.DatabaseProviders
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System.Threading.Tasks;

    public static class SQLiteDatabaseProvider
    {
        public static async Task ConfigureSqlLiteServerContextAsync(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<RepositoryContext>(options => options.UseSqlite(
                config.GetConnectionString("SQLiteDefaultConnection")));

            using (var servicesProvider = services.BuildServiceProvider())
            {
                var context = servicesProvider.GetRequiredService<RepositoryContext>();

                await context.Database.MigrateAsync();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

            }
        }
    }
}

