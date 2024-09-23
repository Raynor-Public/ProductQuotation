using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProdQ.Domain.Abstraction.Repository;
using ProdQ.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace ProdQ.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        //public readonly ApplicationDbContext _context;
        //public BaseRepository(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //public async Task<T> GetAsync(int id)
        //{
        //    return await _context.Set<T>().FindAsync(id);
        //}
        //public async Task<IEnumerable<T>> GetAllAsync()
        //{
        //    return await _context.Set<T>().ToListAsync();
        //}
        //public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        //{
        //    return await _context.Set<T>().Where(predicate).ToListAsync();
        //}
        //public async Task<T> AddAsync(T entity)
        //{
        //    var entityEntry = await _context.Set<T>().AddAsync(entity);            
        //    await _context.SaveChangesAsync();
        //    return entityEntry.Entity;
        //}                

        //public void AddRange(IEnumerable<T> entities)
        //{
        //    _context.Set<T>().AddRange(entities);
        //}
        //public async Task<T> Update(T entity)
        //{
        //   var updateDt = _context.Set<T>().Update(entity).Entity;
        //    await _context.SaveChangesAsync();
        //    return updateDt;
        //}
        //public async Task<T> DeleteAsync(T entity)
        //{
        //    var entityEntry = _context.Set<T>().Remove(entity).Entity;
        //    await _context.SaveChangesAsync();
        //    return entityEntry;
        //}
        //public void DeleteRange(IEnumerable<T> entities)
        //{
        //    _context.Set<T>().RemoveRange(entities);
        //}
    }
}
