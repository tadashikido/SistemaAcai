using System;
using Domain.Model.AcaiSize;

namespace Domain.Factory
{
    public class AcaiSizeFactory
    {
        public static AcaiSizeModel Create(string name)
        {
            switch (name.ToLower())
            {
                case "pequeno":
                    return new SmallSize();

                case "medio":
                    return new MediumSize();

                case "grande":
                    return new BigSize();

                default:
                    throw new ArgumentException($"Tamanho ${name} não suportado");
            }
        }
    }
}