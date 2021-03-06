using Application.Interface;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Application
{
    public class BaseAppService<TEntity> : IDisposable, IBaseAppService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> _serviceBase;

        public BaseAppService(IBaseService<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}