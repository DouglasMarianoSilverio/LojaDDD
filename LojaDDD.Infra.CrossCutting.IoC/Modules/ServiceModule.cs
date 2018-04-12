using LojaDDD.Domain.Interfaces.Services;
using LojaDDD.Domain.Services;
using SimpleInjector;

namespace LojaDDD.Infra.CrossCutting.IoC.Modules
{
    public class ServiceModule
    {

        public void Load(Container container)
        {
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>).Assembly);
            container.Register<IClienteService, ClienteService>();
            container.Register<IProdutoService, ProdutoService>();
            container.Register<IVendaService, VendaService>();
            container.Register<IProdutoVendaService, ProdutoVendaService>();

        }
    }

}
