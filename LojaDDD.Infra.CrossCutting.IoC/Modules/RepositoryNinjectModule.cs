using LojaDDD.Domain.Interfaces.Repositories;
using LojaDDD.Infra.Data.Repositories;
using Ninject.Modules;

namespace LojaDDD.Infra.CrossCutting.IoC.Modules
{
    class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<IProdutoRepository>().To<ProdutoRepository>();
            Bind<IVendaRepository>().To<VendaRepository>();
            Bind<IProdutoVendaRepository>().To<ProdutoVendaRepository>();
        }
    }
}
