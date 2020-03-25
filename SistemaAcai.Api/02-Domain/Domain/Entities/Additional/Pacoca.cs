namespace Domain.Entities.Additional
{
    public class Pacoca : AdditionalEntity
    {
        public override string Name { get => "Paçoca"; }
        public override decimal Price { get => 3; }
        public override int PrepTime { get => 3; }
    }
}