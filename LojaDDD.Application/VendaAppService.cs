using LojaDDD.Application.Interface;
using LojaDDD.Domain.Entities;
using LojaDDD.Domain.Interfaces.Services;

namespace LojaDDD.Application
{
    public class VendaAppService : AppServiceBase<Venda>, IVendaAppService
    {
        private readonly IVendaService _vendaService;
        public VendaAppService(IVendaService vendaService) : base(vendaService)
        {
            _vendaService = vendaService;
        }
    }
}
