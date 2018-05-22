using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NHibernateCookbook.Framework
{
    public interface IRepository<TEntity>
    {
        TEntity Save(TEntity entity);
        bool Delete(TEntity entity);
        TEntity GetById<TEntityId>(TEntityId id);
        IEnumerable<TEntity> GetMany(Func<TEntity, bool> where);
    }
}
