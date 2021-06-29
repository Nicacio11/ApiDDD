using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RestApiModeloDDD.Domain.Core.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where);

        TEntity GetById(int id);
    }
}