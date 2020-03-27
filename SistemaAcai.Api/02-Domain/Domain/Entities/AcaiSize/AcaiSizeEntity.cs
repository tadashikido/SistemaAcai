using System;
using Domain.Entities.Order;
using Domain.Interfaces;

namespace Domain.Entities.AcaiSize
{
    public class AcaiSizeEntity : BaseEntity, IProduct
    {
        public Guid OrderId { get; set; }
        public OrderEntity Order { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int PrepTime { get; set; }
    }
}