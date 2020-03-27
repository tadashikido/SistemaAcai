using System;
using Domain.Interfaces;

namespace Domain.Model.Flavor
{
    public abstract class FlavorModel : IProduct
    {
        public Guid Id { get; set; }
        public abstract string Name { get; }
        public abstract decimal Price { get; }
        public abstract int PrepTime { get; }
    }
}