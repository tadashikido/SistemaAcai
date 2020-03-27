using System.Linq;
using AutoMapper;
using Domain.DTO.Order;
using Domain.Entities.Order;

namespace CrossCutting.Mapping
{
    public class EntityToDto : Profile
    {
        public EntityToDto()
        {
            CreateMap<OrderEntity, OrderResultDto>()
                .ForMember(o => o.Id, m => m.MapFrom(e => e.Id))
                .ForMember(o => o.Flavor, m => m.MapFrom(e => e.Flavor.Name))
                .ForMember(o => o.AcaiSize, m => m.MapFrom(e => e.AcaiSize.Name))
                .ForMember(o => o.Additional, m => m.MapFrom(e => e.Additional.Select(a => a.Name)))
                .ForMember(o => o.Total, m => m.MapFrom(e => e.Flavor.Price + e.AcaiSize.Price + e.Additional.Sum(a => a.Price)))
                .ForMember(o => o.PrepTime, m => m.MapFrom(e => e.Flavor.PrepTime + e.AcaiSize.PrepTime + e.Additional.Sum(a => a.PrepTime)));
        }
    }
}