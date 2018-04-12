using System;
using System.Collections.Generic;
using System.Linq;
using LojaDDD.Domain.Interfaces.Repositories;
using LojaDDD.Infra.Data.Context;


namespace LojaDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> :  IRepositoryBase<TEntity> where TEntity : class
    {
        protected LojaDDDContext Db = new LojaDDDContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }



        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();

            //return Db.Set<TEntity>().AsNoTracking().ToList();
            //nao faz o lazyloading
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }


        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

    }
}
