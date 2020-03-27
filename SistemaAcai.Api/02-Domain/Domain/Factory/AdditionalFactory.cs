using System;
using Domain.Model.Additional;

namespace Domain.Factory
{
    public class AdditionalFactory
    {
        public static AdditionalModel Create(string name)
        {
            switch (name.ToLower())
            {
                case "paçoca":
                    return new Pacoca();

                case "leite ninho":
                    return new LeiteNinho();

                case "granola":
                    return new Granola();

                default:
                    throw new ArgumentException($"Adicional ${name} não suportado");
            }
        }
    }
}