using System.Linq;
using AutoMapper;
using Domain.Entities.AcaiSize;
using Domain.Entities.Flavor;
using Domain.Entities.Additional;
using Domain.Entities.Order;
using Domain.Model.Order;
using Domain.Model.Flavor;
using Domain.Model.AcaiSize;
using Domain.Model.Additional;

namespace CrossCutting.Mapping
{
    public class ModelToEntity : Profile
    {
        public ModelToEntity()
        {
            CreateMap<OrderModel, OrderEntity>();
            CreateMap<FlavorModel, FlavorEntity>();
            CreateMap<AcaiSizeModel, AcaiSizeEntity>();
            CreateMap<AdditionalModel, AdditionalEntity>();
        }
    }
}