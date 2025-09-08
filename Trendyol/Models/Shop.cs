﻿namespace Trendyol.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<ProductShop> Products { get; set; } = new List<ProductShop>();
    }
}
