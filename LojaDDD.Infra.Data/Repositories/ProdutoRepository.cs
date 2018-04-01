using LojaDDD.Domain.Entities;
using LojaDDD.Domain.Interfaces.Repositories;

namespace LojaDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
//        public IEnumerable<Produto> BuscarPorNome(string nome)
//        {
//            return Db.Set<Produto>().Where(p => p.Nome == nome);
//        }
    }
}
