using LojaDDD.Domain.Entities;
using LojaDDD.Domain.Interfaces.Repositories;
using LojaDDD.Domain.Interfaces.Services;


namespace LojaDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            this._produtoRepository = produtoRepository;
        }
        
    }
}
