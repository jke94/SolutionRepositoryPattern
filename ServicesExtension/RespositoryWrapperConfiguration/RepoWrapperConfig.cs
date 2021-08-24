namespace ServicesExtension.RespositoryWrapperConfiguration
{
    using Contracts;
    using Microsoft.Extensions.DependencyInjection;
    using Repository;

    public static class RepoWrapperConfig
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}