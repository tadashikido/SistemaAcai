using System;
using Domain.Model.Order;
using Domain.Interfaces;

namespace Domain.Model.Additional
{
    public abstract class AdditionalModel : IProduct
    {
        public Guid Id { get; set; }
        public abstract string Name { get; }
        public abstract decimal Price { get; }
        public abstract int PrepTime { get; }
    }
}