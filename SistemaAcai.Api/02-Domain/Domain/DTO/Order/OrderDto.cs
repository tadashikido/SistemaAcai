using System;

namespace Domain.DTO.Order
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public string Flavor { get; set; }
        public string AcaiSize { get; set; }
        public string[] Additional { get; set; }
    }
}