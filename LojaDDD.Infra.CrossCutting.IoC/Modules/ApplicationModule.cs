using LojaDDD.Application;
using LojaDDD.Application.Interface;
using SimpleInjector;


namespace LojaDDD.Infra.CrossCutting.IoC.Modules
{
    public class ApplicationModule
    {
        public void Load(Container container)
        {
            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>).Assembly);
            container.Register<IClienteAppService,ClienteAppService>();
            container.Register<IProdutoAppService, ProdutoAppService>();
            container.Register<IVendaAppService, VendaAppService>();
            container.Register<IProdutoVendaAppService, ProdutoVendaAppService>();

            
        }
    }
}
