﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LR8b.Repository
{
    interface IGenericRepository<T> where T: class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void SaveChanges();
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
