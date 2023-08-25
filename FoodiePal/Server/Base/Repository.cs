using FoodiePal.Shared.Base;
using FoodiePal.Shared.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace FoodiePal.Server.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbSet<TEntity> _entities;

        public Repository(DbSet<TEntity> entities) => _entities = entities;

        public async Task AddAsync(TEntity entity) => await _entities.AddAsync(entity);
        public async Task UpdateAsync(TEntity entity) => await Task.Run(() => { _entities.Update(entity); });
        public async Task<TEntity> GetByIdAsync(int id, IEnumerable<string> entitiesToInclude) 
        {
            var result = await _entities
                //.Include(entitiesToInclude)
                .FirstOrDefaultAsync(e => e.Id == id);

            return result;
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync(IEnumerable<Expression<Func<TEntity, bool>>> predicates,
                                                            IEnumerable<string> entitiesToInclude) 
        {
            var result = await _entities
                //.Filter(predicates)
                //.Include(entitiesToInclude)
                .ToListAsync();
            return result;
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync(int skip, int limit, IEnumerable<Expression<Func<TEntity, bool>>> predicates,
                                                                                 IEnumerable<string> entitiesToInclude)
        {
           var result = await _entities
                //.Filter(predicates)
                .Skip(skip)
                .Take(limit)
                //.Include(entitiesToInclude)
                .ToListAsync();
            return result;
        }
        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }
        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { Delete(entity); });
        }
        public async virtual Task<int> Count(IEnumerable<Expression<Func<TEntity, bool>>> predicates = null)
        {
            var result = await _entities
                //.Filter(predicates)
                .CountAsync();
            return result;
        }
        public async Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var result = await _entities.AnyAsync(predicate);
            return result;
        }
    }
}
