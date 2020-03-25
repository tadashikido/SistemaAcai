using Domain.Interfaces;

namespace Domain.Entities.Fruit
{
    public abstract class FruitEntity : IProduct
    {
        public abstract string Name { get; }
        public abstract decimal Price { get; }
        public abstract int PrepTime { get; }
    }
}