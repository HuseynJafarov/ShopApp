﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task SoftDelete(T entity);
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>> expression);
    }
}
