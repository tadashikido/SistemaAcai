using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Entities.Order;
using Domain.Interfaces;

namespace Domain.Repositories
{
    public interface IOrderRepository : IRepository<OrderEntity>
    {
        OrderEntity GetPedido(Guid id);

        IEnumerable<OrderEntity> GetAllPedido();
    }
}