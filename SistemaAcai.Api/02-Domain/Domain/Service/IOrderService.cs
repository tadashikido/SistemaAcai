using System;
using System.Collections.Generic;
using Domain.DTO.Order;
using Domain.Model.Order;

namespace Domain.Service
{
    public interface IOrderService
    {
        OrderResultDto Get(Guid id);
        IEnumerable<OrderResultDto> GetAll();
        OrderResultDto Post(OrderDto orderEntity);
        OrderResultDto Put(OrderDto orderEntity);
        bool Delete(Guid id);
    }
}