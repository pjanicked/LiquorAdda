using LiquorAdda.Core.DataContext;
using LiquorAdda.Core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorAdda.Core.Repository
{
    /// <summary>
    /// Generic Class For CRUD
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class GenericRepository<TEntity> : IGenericRepoistory<TEntity> where TEntity : class
    {
        /// <summary>
        /// Insert into table
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TEntity Add(TEntity entity)
        {
            try
            {
                if (entity != null)
                {
                    using (var DbContext = new DatabaseContext())
                    {
                        DbContext.Set<TEntity>().Add(entity);
                        if (DbContext.SaveChanges() > 0)
                        {
                            return entity;
                        }
                        else
                        {
                            throw new Exception(String.Format("{0} not saved in DB", typeof(TEntity).Name));
                        }
                    }
                }
                else
                {
                    throw new Exception("Parameter is null");
                }
            }
            catch (Exception)
            {
                throw new Exception(String.Format("{0} not saved in DB", typeof(TEntity).Name));
            }
        }

        /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TEntity Delete(TEntity entity)
        {
            try
            {
                if (entity != null)
                {
                    using (var DbContext = new DatabaseContext())
                    {
                        DbContext.Entry(entity).State = System.Data.EntityState.Deleted;
                        if (DbContext.SaveChanges() > 0)
                        {
                            return entity;
                        }
                        else
                        {
                            throw new Exception(String.Format("{0} not deleted in DB", typeof(TEntity).Name));
                        }
                    }
                }
                else
                {
                    throw new Exception("Parameter is null");
                }
            }
            catch (Exception)
            {
                throw new Exception(String.Format("{0} not deleted in DB", typeof(TEntity).Name));
            }
        }

        /// <summary>
        /// Update entity - Used AddOrUpdate() as update statement is less complex/not long
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TEntity Update(TEntity entity)
        {
            try
            {
                if (entity != null)
                {
                    using (var DbContext = new DatabaseContext())
                    {
                        DbContext.Set<TEntity>().AddOrUpdate(entity);
                        if (DbContext.SaveChanges() > 0)
                        {
                            return entity;
                        }
                        else
                        {
                            throw new Exception(String.Format("{0} not updated in DB", typeof(TEntity).Name));
                        }
                    }
                }
                else
                {
                    throw new Exception("Parameter is null");
                }
            }
            catch (Exception)
            {
                throw new Exception(String.Format("{0} not updated in DB", typeof(TEntity).Name));
            }
        }

        public IList<TEntity> GetSelectList()
        {
            try
            {
                using (var DbContext = new DatabaseContext())
                {
                    var objList = DbContext.Set<TEntity>().ToList();
                    return objList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
