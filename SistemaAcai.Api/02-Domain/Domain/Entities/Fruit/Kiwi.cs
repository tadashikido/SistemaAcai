namespace Domain.Entities.Fruit
{
    public class Kiwi : FruitEntity
    {
        public override string Name { get => "Kiwi"; }
        public override decimal Price { get => 0; }
        public override int PrepTime { get => 5; }
    }
}