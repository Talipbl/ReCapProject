using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    //entity framework public area 
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        private static int TContextEntry(TEntity entity, EntityState state)
        {
            using (TContext db = new TContext())
            {
                db.Entry<TEntity>(entity).State = state;
                return db.SaveChanges();
            }
        }
        public int Add(TEntity entity)
        {
            return TContextEntry(entity, EntityState.Added);
        }

        public int Delete(TEntity entity)
        {
            return TContextEntry(entity, EntityState.Deleted);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext db = new TContext())
            {
                return db.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)//filter = lambda expression
        {
            using (TContext db = new TContext())
            {
                return filter == null ? db.Set<TEntity>().ToList() : db.Set<TEntity>().Where(filter).ToList();
            }
        }

        public int Update(TEntity entity)
        {
            return TContextEntry(entity, EntityState.Modified);
        }
    }
}
