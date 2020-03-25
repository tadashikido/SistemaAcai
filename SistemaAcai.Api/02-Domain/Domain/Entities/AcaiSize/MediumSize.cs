namespace Domain.Entities.AcaiSize
{
    public class MediumSize : AcaiSizeEntity
    {
        public override string Name { get => "Médio (500ml)"; }
        public override decimal Price { get => 0; }
        public override int PrepTime { get => 0; }
    }
}