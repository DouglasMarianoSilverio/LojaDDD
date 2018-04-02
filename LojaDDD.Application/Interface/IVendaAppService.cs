using LojaDDD.Domain.Entities;

namespace LojaDDD.Application.Interface
{
    public interface IVendaAppService : IAppServiceBase<Venda>,IAppServiceBaseValidarExclusao<Venda>
    {
    }
}