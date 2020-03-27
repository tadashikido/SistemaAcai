using System;
using System.Collections.Generic;
using System.Linq;
using Data.Context;
using Domain.Entities.Order;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class OrderRepository : BaseRepository<OrderEntity>, IOrderRepository
    {
        private DbSet<OrderEntity> _dbSet;
        public OrderRepository(SistemaAcaiContext context) : base(context)
        {
            _dbSet = context.Set<OrderEntity>();
        }

        public OrderEntity GetPedido(Guid id)
        {
            return _dbSet.Include(o => o.AcaiSize)
                         .Include(o => o.Flavor)
                         .Include(o => o.Additional)
                         .FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<OrderEntity> GetAllPedido()
        {
            return _dbSet.Include(o => o.AcaiSize)
                         .Include(o => o.Flavor)
                         .Include(o => o.Additional)
                         .ToList();
        }
    }
}