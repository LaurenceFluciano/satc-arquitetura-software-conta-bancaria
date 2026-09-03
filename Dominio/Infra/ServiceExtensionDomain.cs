using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositorio.Infra;

namespace Dominio.Infra
{
    public static class ServiceExtensionDomain
    {
        public static void ConfigurarDominio(this IServiceCollection services, IConfiguration configuration)
        {
            ServiceExtensionRepository.ConfigurarRepositorio(services, configuration);
        }
    }
}
