namespace Domain.Entities.Additional
{
    public class Granola : AdditionalEntity
    {
        public override string Name { get => "Granola"; }
        public override decimal Price { get => 0; }
        public override int PrepTime { get => 0; }
    }
}