using LojaDDD.Domain.Entities;
using LojaDDD.Domain.Interfaces.Repositories;
using LojaDDD.Domain.Interfaces.Services;

namespace LojaDDD.Domain.Services
{
    public class VendaService : ServiceBase<Venda>, IVendaService
    {
        private IVendaRepository _vendaRepository;
        public VendaService(IVendaRepository vendaRepository) : base(vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }
    }
}
