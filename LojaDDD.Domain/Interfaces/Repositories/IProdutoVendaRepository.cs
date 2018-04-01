using System.Linq;
using LojaDDD.Domain.Entities;
using System.Collections.Generic;

namespace LojaDDD.Domain.Interfaces.Repositories
{
    public interface IProdutoVendaRepository: IRepositoryBase<ProdutoVenda>
    {
        //IEnumerable<ProdutoVenda> GetListByVenda(Venda venda);
    }
}
