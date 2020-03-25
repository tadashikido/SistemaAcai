namespace Domain.Entities.AcaiSize
{
    public class SmallSize : AcaiSizeEntity
    {
        public override string Name { get => "Pequeno (300ml)"; }
        public override decimal Price { get => 10; }
        public override int PrepTime { get => 5; }
    }
}