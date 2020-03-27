using System;
using Domain.Model.Flavor;

namespace Domain.Factory
{
    public class FlavorFactory
    {
        public static FlavorModel Create(string name)
        {
            switch (name.ToLower())
            {
                case "banana":
                    return new Banana();

                case "morango":
                    return new Morango();

                case "kiwi":
                    return new Kiwi();

                default:
                    throw new ArgumentException($"Sabor ${name} não suportado");
            }
        }
    }
}