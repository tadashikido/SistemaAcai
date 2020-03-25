namespace Domain.Interfaces
{
    public interface IProduct
    {
        string Name { get; }
        decimal Price { get; }
        int PrepTime { get; }
    }
}