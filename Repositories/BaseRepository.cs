using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ecomm.api.Data;
using ecomm.api.Data.Interfaces;
using ecomm.api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ecomm.api.Repositories
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T>
        where T : class
    {
        private DataContext _context;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            if(unitOfWork == null) 
                throw new ArgumentNullException(nameof(unitOfWork));
            _context = unitOfWork as DataContext;
        }

        public async Task<T> Get(int id)
        {
            var result = await _context.Set<T>().FindAsync(id);
            return result;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var result = await _context.Set<T>().ToListAsync();
            return result;
        }

        public async Task<T> Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }
        
        public async Task<T> Update(T entity)
        {
            await Task.Run(() => 
            {
                _context.Set<T>().Update(entity);
            });
            return entity;
        }

        public async Task Delete(T entity)
        {
            await Task.Run(() => {
                _context.Set<T>().Remove(entity);
            });   
        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}