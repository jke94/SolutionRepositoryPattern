namespace ServicesExtension.RespositoryWrapperConfiguration
{
    using Microsoft.Extensions.DependencyInjection;
    using Repository;
    using Repository.Interfaces;

    public static class RepoWrapperConfig
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}