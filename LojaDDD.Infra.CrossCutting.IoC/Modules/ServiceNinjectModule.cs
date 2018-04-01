using LojaDDD.Domain.Interfaces.Services;
using LojaDDD.Domain.Services;
using Ninject.Modules;

namespace LojaDDD.Infra.CrossCutting.IoC.Modules
{
    public class ServiceNinjectModule: NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IClienteService>().To<ClienteService>();
            Bind<IProdutoService>().To<ProdutoService>();
            Bind<IVendaService>().To<VendaService>();
            Bind<IProdutoVendaService>().To<ProdutoVendaService>();

        }
    }
}
