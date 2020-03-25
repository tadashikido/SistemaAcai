using Domain.Interfaces;

namespace Domain.Entities.Additional
{
    public abstract class AdditionalEntity : IProduct
    {
        public abstract string Name { get; }
        public abstract decimal Price { get; }
        public abstract int PrepTime { get; }
    }
}