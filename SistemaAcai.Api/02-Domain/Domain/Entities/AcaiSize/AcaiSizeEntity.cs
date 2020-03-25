using Domain.Interfaces;

namespace Domain.Entities.AcaiSize
{
    public abstract class AcaiSizeEntity : IProduct
    {
        public abstract string Name { get; }
        public abstract decimal Price { get; }
        public abstract int PrepTime { get; }
    }
}