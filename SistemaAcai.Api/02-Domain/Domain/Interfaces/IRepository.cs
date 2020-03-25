using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> Get();
        T Get(Guid Id);
        T Add(T entity);
        T Update(T entity);
        bool Delete(Guid Id);
    }
}