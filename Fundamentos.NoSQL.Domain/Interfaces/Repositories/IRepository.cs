﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Fundamentos.NoSQL.Domain.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        List<T> QueryAll(int? limit = 0);
        T Query(Expression<Func<T, bool>> expression);
        T GetById(Guid id);
        void Insert(T obj);
        void Replace(Guid id, T obj);
        void Update(Expression<Func<T, bool>> condicao, Expression<Func<T, object>> field, object value);
        void Push(Expression<Func<T, bool>> condicao, Expression<Func<T, IEnumerable<object>>> field, object value);
        void Pull<TEntityArray>(Expression<Func<T, bool>> condicao, Expression<Func<T, IEnumerable<TEntityArray>>> field, Expression<Func<TEntityArray, bool>> filter);
        void Delete(Guid id);
    }
}