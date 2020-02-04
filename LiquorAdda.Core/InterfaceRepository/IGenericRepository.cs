using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorAdda.Core.InterfaceRepository
{
    /// <summary>
    /// Interface of Generic
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    interface IGenericRepoistory<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        TEntity Delete(TEntity entity);

        IList<TEntity> GetSelectList();
    }
}
