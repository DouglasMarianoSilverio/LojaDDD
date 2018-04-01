using LojaDDD.Application.Interface;
using LojaDDD.Domain.Entities;
using LojaDDD.Domain.Interfaces.Services;

namespace LojaDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) 
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        
    }
}
