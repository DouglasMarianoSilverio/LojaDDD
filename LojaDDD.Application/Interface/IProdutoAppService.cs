using LojaDDD.Domain.Entities;

namespace LojaDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>,IAppServiceBaseValidarExclusao<Produto>
    {
    }
}
