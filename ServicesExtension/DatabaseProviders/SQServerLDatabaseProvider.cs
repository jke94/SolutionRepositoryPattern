namespace ServicesExtension.DatabaseProviders
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class DatabaseProvider
    {
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(
                config.GetConnectionString("DefaultConnection")));
        }
    }
}
