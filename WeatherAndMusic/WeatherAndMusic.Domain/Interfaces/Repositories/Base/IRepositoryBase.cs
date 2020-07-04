using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace WeatherAndMusic.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntity, TId>
       where TEntity : class
       where TId : struct
    {
        IQueryable<TEntity> ListBy(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> ListOrderBy<TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> order, bool asc = true, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity GetBy(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] includeProperties);

        bool Exist(Func<TEntity, bool> where);

        IQueryable<TEntity> List(params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> ListOrderBy<TKey>(Expression<Func<TEntity, TKey>> ordem, bool asc = true, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity GetById(TId id, params Expression<Func<TEntity, object>>[] includeProperties);

        void Add(TEntity entity);

        TEntity Edit(TEntity entity);

        void Remove(TEntity entity);

        void AddList(IEnumerable<TEntity> entities);
    }
}
