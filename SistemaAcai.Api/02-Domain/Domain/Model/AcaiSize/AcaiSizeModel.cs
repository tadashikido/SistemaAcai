using System;
using Domain.Interfaces;
using Domain.Model.Order;

namespace Domain.Model.AcaiSize
{
    public abstract class AcaiSizeModel : IProduct
    {
        public Guid Id { get; set; }
        public abstract string Name { get; }
        public abstract decimal Price { get; }
        public abstract int PrepTime { get; }
    }
}