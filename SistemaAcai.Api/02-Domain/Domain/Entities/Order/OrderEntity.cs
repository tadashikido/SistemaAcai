using System.Collections.Generic;
using System.Linq;
using Domain.Entities.AcaiSize;
using Domain.Entities.Additional;
using Domain.Entities.Flavor;

namespace Domain.Entities.Order
{
    public class OrderEntity : BaseEntity
    {
        public virtual FlavorEntity Flavor { get; set; }
        public virtual AcaiSizeEntity AcaiSize { get; set; }
        public virtual List<AdditionalEntity> Additional { get; set; }
    }
}