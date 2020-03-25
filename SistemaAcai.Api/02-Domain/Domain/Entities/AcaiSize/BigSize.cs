namespace Domain.Entities.AcaiSize
{
    public class BigSize : AcaiSizeEntity
    {
        public override string Name { get => "Grande (700ml)"; }
        public override decimal Price { get => 15; }
        public override int PrepTime { get => 10; }
    }
}