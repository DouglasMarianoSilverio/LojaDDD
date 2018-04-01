using LojaDDD.Domain.Entities;
using LojaDDD.Domain.Interfaces.Repositories;

namespace LojaDDD.Infra.Data.Repositories
{
    public class ProdutoVendaRepository : RepositoryBase<ProdutoVenda>, IProdutoVendaRepository
    {
        //Public IEnumerable<ProdutoVenda>
    }
}
