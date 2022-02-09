using System;

namespace CarTraders.DAL.DTO
{
    public class ProductCardDto
    {
        public string ImageName { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductType { get; set; }
    }
}
