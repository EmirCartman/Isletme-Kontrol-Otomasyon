using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Linq.Expressions;

namespace Otomasyon.Entities.Interface
{

   public interface IEntityRepository<TContext, TEntity>

         where TContext : DbContext, new()
         where TEntity : class,IEntity, new()

    {
        List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null);
        TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>>filter);
        bool AddOrUpdate(TContext context, TEntity entity);
        void Delete(TContext context,Expression<Func<TEntity,bool>>filter);
        void Save(TContext context);

    }
}
