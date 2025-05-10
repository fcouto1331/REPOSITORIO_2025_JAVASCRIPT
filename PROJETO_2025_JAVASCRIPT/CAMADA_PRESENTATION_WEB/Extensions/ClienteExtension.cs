using CAMADA_PRESENTATION_WEB.Interfaces;
using CAMADA_PRESENTATION_WEB.Repositories;

namespace CAMADA_PRESENTATION_WEB.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection ClienteExtension(this IServiceCollection services)
        {
            services.AddTransient<IClienteRepository, ClienteRepository>();
            return services;
        }
    }
}
