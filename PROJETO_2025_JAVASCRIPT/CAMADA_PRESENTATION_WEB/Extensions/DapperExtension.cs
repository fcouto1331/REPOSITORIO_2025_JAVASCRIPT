using CAMADA_PRESENTATION_WEB.Dapper;

namespace CAMADA_PRESENTATION_WEB.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection DapperExtension(this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
            return services;
        }
    }
}
