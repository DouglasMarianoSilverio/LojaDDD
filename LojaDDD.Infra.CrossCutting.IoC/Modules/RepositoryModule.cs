using LojaDDD.Application;
using LojaDDD.Application.Interface;
using LojaDDD.Domain.Interfaces.Repositories;
using LojaDDD.Infra.Data.Repositories;
using SimpleInjector;


namespace LojaDDD.Infra.CrossCutting.IoC.Modules
{
    public class RepositoryModule 
    {
        public void Load(Container container)
        {
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>).Assembly);
            container.Register<IClienteRepository, ClienteRepository>();
            container.Register<IProdutoRepository, ProdutoRepository>();
            container.Register<IVendaRepository, VendaRepository>();
            container.Register<IProdutoVendaRepository, ProdutoVendaRepository>();
            
        }
    }
}
