namespace ServicesExtension
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using ServicesExtension.DatabaseProviders;
    using ServicesExtension.DatabaseSeederProvider;
    using ServicesExtension.RespositoryWrapperConfiguration;

    public static class ServiceExtensions
    {
        /// <summary>
        ///     Initialize all services.
        /// </summary>
        /// <param name="services">Services collection</param>
        /// <param name="configuration">Configuration section</param>
        public static void InitializeAllApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // 1    -   Providers Configuration
            services.ConfigureSqlServerContext(configuration);
            services.ConfigureSqlLiteServerContextAsync(configuration);

            // 2    -   Configure Repository Wrapper.
            services.ConfigureRepositoryWrapper();

            // 3    -   Data Seed: Add data in the application.
            services.AddDataInRepositoryWrapper();
        }
    }
}
