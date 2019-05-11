using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ITI.Product.Task.BackendApi.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace ITI.Product.Task.BackendApi.Persistence.Repository
{
    /// <summary>
    /// The generic implementation for the repository
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        // Adding both the context and entity member variables
        private readonly DbContext context;
        protected readonly DbSet<TEntity> _entities;

        public Repository(DbContext context)
        {
            this.context = context;
            _entities = context.Set<TEntity>();
        }


        #region Generic CRUD operations

        

        
        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public TEntity Get(Guid Id)
        {
            return _entities.Find(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities;
        }

        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _entities.RemoveRange(entities);
        }
        #endregion
    }
}
