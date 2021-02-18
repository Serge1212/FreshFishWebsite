﻿
using System;
using System.Collections.Generic;

namespace FreshFishWebsite.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double PricePerKg { get; set; }
        public DateTime Date { get; set; }
        public double QuantityKg { get; set; }
        public bool IsSold { get; set; } = false;
        public int StorageId { get; set; }
        public Storage Storage { get; set; }
        public List<ShoppingCartProduct> ShoppingCartProducts { get; set; }
            = new List<ShoppingCartProduct>();
    }
}