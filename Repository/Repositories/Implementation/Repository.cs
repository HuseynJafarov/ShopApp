﻿using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interface;
using System.Linq.Expressions;


namespace Repository.Repositories.Implementation
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;
        public Repository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public async Task Create(T entity)
        {
            if (entity == null) throw new ArgumentNullException();
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException();
            _entities.Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> expression)
        {
            var data = await _entities.Where(expression).AsNoTracking().ToListAsync();

            return data;
        }
            
        public async Task<T> GetById(int id)
        {
            T entity = await _entities.FindAsync(id)?? throw new NotImplementedException();
            return entity;
        }

        public async Task<List<T>> GetAll()
        {
            return await _entities.Where(x=> !x.SoftDeleted).AsNoTracking().ToListAsync();
        }

        public async Task SoftDelete(T entity)
        {
            T? model = await _entities.FirstOrDefaultAsync(m => m.Id == entity.Id);
            if (model == null) throw new NullReferenceException();

            model.SoftDeleted = true;
            _context.SaveChanges();
        }

        public async Task Update(T entity)
        {
            if (entity == null) throw new NullReferenceException();
                
            _entities.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
