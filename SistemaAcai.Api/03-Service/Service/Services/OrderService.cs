using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Domain.Builder;
using Domain.DTO.Order;
using Domain.Entities.Order;
using Domain.Interfaces;
using Domain.Model.Order;
using Domain.Repositories;
using Domain.Service;

namespace Service.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _repository;
        private IMapper _mapper;

        public OrderService(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public OrderResultDto Get(Guid id)
        {
            var result = _repository.GetPedido(id);

            return _mapper.Map<OrderResultDto>(result); ;
        }

        public IEnumerable<OrderResultDto> GetAll()
        {
            var order = _repository.GetAllPedido();
            var orderDto = _mapper.Map<IEnumerable<OrderEntity>, IEnumerable<OrderResultDto>>(order);
            return orderDto;
        }

        public OrderResultDto Post(OrderDto orderDto)
        {
            var orderBuilder = new OrderBuilder();
            orderBuilder.SetFlavor(orderDto.Flavor);
            orderBuilder.SetSize(orderDto.AcaiSize);
            orderDto.Additional.ToList().ForEach(a =>
            {
                orderBuilder.AddAdditional(a);
            });
            var orderModel = orderBuilder.Build();

            var orderEntity = _mapper.Map<OrderEntity>(orderModel);

            return _mapper.Map<OrderResultDto>(_repository.Add(orderEntity));
        }

        public OrderResultDto Put(OrderDto orderDto)
        {
            var orderBuilder = new OrderBuilder();
            orderBuilder.SetId(orderDto.Id);
            orderBuilder.SetFlavor(orderDto.Flavor);
            orderBuilder.SetSize(orderDto.AcaiSize);
            orderDto.Additional.ToList().ForEach(a =>
            {
                orderBuilder.AddAdditional(a);
            });
            var orderModel = orderBuilder.Build();

            var orderEntity = _mapper.Map<OrderModel, OrderEntity>(orderModel);

            return _mapper.Map<OrderResultDto>(_repository.Update(orderEntity));
        }

        public bool Delete(Guid id)
        {
            return _repository.Delete(id);
        }
    }
}