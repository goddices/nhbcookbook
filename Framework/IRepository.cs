using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NHibernateCookbook.Framework
{
    public interface IRepository<TEntity, TID> where TEntity : IEntity<TID>
    { 
        TEntity Save(TEntity entity);
         
        bool Delete(TEntity entity);
         
        TEntity GetById(TID id);
         
        IEnumerable<TEntity> GetMany(Func<TEntity, bool> where); 
    }
}
