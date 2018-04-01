using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDDD.Application.Interface;
using LojaDDD.Domain.Entities;
using LojaDDD.Domain.Interfaces.Services;

namespace LojaDDD.Application
{
    public class ProdutoVendaAppService : AppServiceBase<ProdutoVenda>,IProdutoVendaAppService
    {
        private readonly IProdutoVendaService _produtoVendaService; 
        public ProdutoVendaAppService(IProdutoVendaService produtoVendaService) : base(produtoVendaService)
        {
            _produtoVendaService = produtoVendaService;
        }
    }
}
