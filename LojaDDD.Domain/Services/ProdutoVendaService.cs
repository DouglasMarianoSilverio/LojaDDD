using LojaDDD.Domain.Entities;
using LojaDDD.Domain.Interfaces.Repositories;
using LojaDDD.Domain.Interfaces.Services;

namespace LojaDDD.Domain.Services
{
    public class ProdutoVendaService: ServiceBase<ProdutoVenda>, IProdutoVendaService
    {
        private IProdutoVendaRepository  _produtoVendaRepository;
        public ProdutoVendaService(IProdutoVendaRepository produtoVendaRepository) : base(produtoVendaRepository)
        {
            _produtoVendaRepository = produtoVendaRepository;
        }
    }
}
