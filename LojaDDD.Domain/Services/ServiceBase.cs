using System.Collections.Generic;
using LojaDDD.Domain.Interfaces.Repositories;
using LojaDDD.Domain.Interfaces.Services;

namespace LojaDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        //Injeção de dependencia via construtor
        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this._repository = repository;

        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        
        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj); 
        }
    }
}
