using System.Collections.Generic;
using Domain.Entities.AcaiSize;
using Domain.Entities.Additional;
using Domain.Entities.Fruit;

namespace Domain.Entities
{
    public class Acai
    {
        public FruitEntity Fruit { get; set; }
        public AcaiSizeEntity AcaiSize { get; set; }
        public List<AdditionalEntity> Additional { get; set; }
    }
}