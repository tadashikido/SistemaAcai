namespace Domain.Entities.Fruit
{
    public class Banana : FruitEntity
    {
        public override string Name { get => "Banana"; }
        public override decimal Price { get => 0; }
        public override int PrepTime { get => 0; }
    }
}