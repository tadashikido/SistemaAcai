namespace Domain.Model.Flavor
{
    public class Kiwi : FlavorModel
    {
        public override string Name { get => "Kiwi"; }
        public override decimal Price { get => 0; }
        public override int PrepTime { get => 5; }
    }
}