using LojaDDD.Domain.Entities;
using LojaDDD.Domain.Interfaces.Repositories;
using LojaDDD.Domain.Interfaces.Services;

namespace LojaDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>,IClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) 
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }


        
    }
}
