using CosmeticsStore.Models.Configurations;

namespace CosmeticsStore.ServiceExtensions
{
    public static class ServiceConfigurationsExtensions
    {
        public static IServiceCollection AddConfigurations(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<MongoDbConfiguration>(
                configuration.GetSection(nameof(MongoDbConfiguration)));
            return services;
        }
    }
}
