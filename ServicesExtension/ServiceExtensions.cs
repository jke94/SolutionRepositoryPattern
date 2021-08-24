using System;

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
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void InitializeAllApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // 1    -   Providers Configuration
            services.ConfigureSqlServerContext(configuration);

            // 2    -   Configure Repository Wrapper.
            services.ConfigureRepositoryWrapper();

            // 3    -   Data Seed: Add data in the application.
            services.AddDataInRepositoryWrapper();
        }
    }
}
