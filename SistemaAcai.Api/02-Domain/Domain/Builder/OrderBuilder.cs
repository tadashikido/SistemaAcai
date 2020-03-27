using System;
using System.Collections.Generic;
using Domain.Factory;
using Domain.Model.AcaiSize;
using Domain.Model.Additional;
using Domain.Model.Flavor;
using Domain.Model.Order;

namespace Domain.Builder
{
    public class OrderBuilder
    {
        private Guid _id;
        private FlavorModel _flavor;
        private AcaiSizeModel _acaiSize;
        private List<AdditionalModel> _aditionais;

        public OrderBuilder()
        {
            _aditionais = new List<AdditionalModel>();
        }

        public OrderBuilder SetId(Guid id)
        {
            _id = id;
            return this;
        }

        public OrderBuilder SetFlavor(string flavor)
        {
            _flavor = FlavorFactory.Create(flavor);
            return this;
        }

        public OrderBuilder SetSize(string size)
        {
            _acaiSize = AcaiSizeFactory.Create(size);
            return this;
        }

        public OrderBuilder AddAdditional(string additional)
        {
            _aditionais.Add(AdditionalFactory.Create(additional));
            return this;
        }

        public OrderModel Build()
        {
            return new OrderModel(_id, _flavor, _acaiSize, _aditionais);
        }
    }
}