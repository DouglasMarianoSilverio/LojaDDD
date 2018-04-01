using LojaDDD.Application;
using LojaDDD.Application.Interface;
using Ninject.Modules;

namespace LojaDDD.Infra.CrossCutting.IoC.Modules
{
    public class ApplicationNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IClienteAppService>().To<ClienteAppService>();
            Bind<IProdutoAppService>().To<ProdutoAppService>();
            Bind<IVendaAppService>().To<VendaAppService>();
            Bind<IProdutoVendaAppService>().To<ProdutoVendaAppService>();
        }
    }
}
