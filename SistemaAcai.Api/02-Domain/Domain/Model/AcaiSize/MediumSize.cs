namespace Domain.Model.AcaiSize
{
    public class MediumSize : AcaiSizeModel
    {
        public override string Name { get => "Médio (500ml)"; }
        public override decimal Price { get => 13; }
        public override int PrepTime { get => 7; }
    }
}