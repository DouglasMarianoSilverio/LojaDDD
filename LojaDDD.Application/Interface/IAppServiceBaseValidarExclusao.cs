using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDDD.Application.Interface
{
    public interface IAppServiceBaseValidarExclusao<TEntity> where TEntity : class
    {
        bool ValidarExclusao(TEntity obj);
    }
}