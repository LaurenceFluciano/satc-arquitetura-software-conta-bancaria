
using Microsoft.Extensions.DependencyInjection;

namespace Repositorio.Infra
{
    public static class GeradorDeServico
    {
        public static ServiceProvider ServiceProvider;

        public static DataContext CarregarContexto()
        {
            return ServiceProvider.GetService<DataContext>();
        }
    }
}
