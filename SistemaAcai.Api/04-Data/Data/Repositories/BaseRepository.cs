using System;
using System.Collections.Generic;
using System.Linq;
using Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly SistemaAcaiContext _sistemaAcaiContext;
        private DbSet<T> _entityDbSet;

        public BaseRepository(SistemaAcaiContext SistemaAcaiContext)
        {
            _sistemaAcaiContext = SistemaAcaiContext;
            _entityDbSet = SistemaAcaiContext.Set<T>();
        }

        public T Get(Guid id)
        {
            try
            {
                return _entityDbSet.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> Get()
        {
            try
            {
                return _entityDbSet.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Add(T entity)
        {
            try
            {
                entity.Id = Guid.NewGuid();
                entity.CreateAt = DateTime.UtcNow;
                entity.UpdateAt = DateTime.UtcNow;

                _sistemaAcaiContext.Add(entity);

                _sistemaAcaiContext.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Update(T entity)
        {
            try
            {
                var result = _entityDbSet.Find(entity.Id);
                if (result == null)
                    return null;

                entity.CreateAt = result.CreateAt;
                entity.UpdateAt = DateTime.UtcNow;

                _sistemaAcaiContext.Entry(result).CurrentValues.SetValues(entity);

                _sistemaAcaiContext.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var result = _entityDbSet.Find(id);
                if (result == null)
                    return false;

                _entityDbSet.Remove(result);

                _sistemaAcaiContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}