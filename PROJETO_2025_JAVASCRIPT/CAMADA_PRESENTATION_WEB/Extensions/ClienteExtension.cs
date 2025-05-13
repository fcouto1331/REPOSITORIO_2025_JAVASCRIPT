using CAMADA_PRESENTATION_WEB.Interfaces.Repositories;
using CAMADA_PRESENTATION_WEB.Interfaces.Services;
using CAMADA_PRESENTATION_WEB.Repositories;
using CAMADA_PRESENTATION_WEB.Services;

namespace CAMADA_PRESENTATION_WEB.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection ClienteExtension(this IServiceCollection services)
        {
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IClienteService, ClienteService>();
            return services;
        }
    }
}
