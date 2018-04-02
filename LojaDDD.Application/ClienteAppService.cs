using LojaDDD.Application.Interface;
using LojaDDD.Domain.Entities;
using LojaDDD.Domain.Interfaces.Services;

namespace LojaDDD.Application
{
    public class ClienteAppService:AppServiceBase<Cliente>,IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) 
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public bool ValidarExclusao(Cliente cliente)
        {
            return cliente.Vendas.Count == 0;
        }
    }
}
