﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.RepositoryLayer.Interfaces
{
    public interface IBaseRepositoryAsync<T> where T : class
    {
        IQueryable<T> Entities { get; }
        Task<T> GetById(int id);

        Task<IEnumerable<T>> GetAll();

        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<T> Delete(T entity);
    }
}
