﻿using System;

namespace CarTraders.DAL.DTO
{
    public class OrderItemDto
    {
        public int Index { get; set; }
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
