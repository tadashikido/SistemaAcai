using System;
using System.Collections.Generic;
using Domain.DTO.Order;

namespace Domain.Service
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAll(string type);
    }
}