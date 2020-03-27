using System;

namespace Domain.DTO.Order
{
    public class OrderResultDto
    {
        public Guid Id { get; set; }
        public string Flavor { get; set; }
        public string AcaiSize { get; set; }
        public string[] Additional { get; set; }
        public decimal Total { get; set; }
        public int PrepTime { get; set; }
    }
}