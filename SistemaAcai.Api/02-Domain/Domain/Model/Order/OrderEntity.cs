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
            get => Flavor.Price + AcaiSize.Price + Additional.Sum(a => a.Price);
        }

        public int PrepTime
        {
            get => Flavor.PrepTime + AcaiSize.PrepTime + Additional.Sum(a => a.PrepTime);
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