namespace Domain.Model.AcaiSize
{
    public class BigSize : AcaiSizeModel
    {
        public override string Name { get => "Grande (700ml)"; }
        public override decimal Price { get => 15; }
        public override int PrepTime { get => 10; }
    }
}