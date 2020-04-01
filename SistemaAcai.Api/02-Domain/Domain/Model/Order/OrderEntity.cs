using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Model.AcaiSize;
using Domain.Model.Additional;
using Domain.Model.Flavor;

namespace Domain.Model.Order
{
    public class OrderModel
    {
        public Guid Id { get; }
        public FlavorModel Flavor { get; }
        public AcaiSizeModel AcaiSize { get; }
        public List<AdditionalModel> Additional { get; }

        public decimal Total
        {
            get
            {
                var flavorPrice = Flavor != null ? Flavor.Price : 0;
                var acaiSizePrice = AcaiSize != null ? AcaiSize.Price : 0;
                var additionalPrice = Additional != null ? Additional.Sum(a => a.Price) : 0;

                return flavorPrice + acaiSizePrice + additionalPrice;
            }
        }

        public int PrepTime
        {
            get
            {
                var flavorPrepTime = Flavor != null ? Flavor.PrepTime : 0;
                var acaiSizePrepTime = AcaiSize != null ? AcaiSize.PrepTime : 0;
                var additionalPrepTime = Additional != null ? Additional.Sum(a => a.PrepTime) : 0;

                return flavorPrepTime + acaiSizePrepTime + additionalPrepTime;
            }
        }

        public OrderModel(Guid id, FlavorModel flavor, AcaiSizeModel acaiSize, List<AdditionalModel> additional)
        {
            Id = id;
            Flavor = flavor;
            AcaiSize = acaiSize;
            Additional = additional;
        }
    }
}