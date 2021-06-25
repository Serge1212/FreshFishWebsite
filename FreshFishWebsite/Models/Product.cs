
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshFishWebsite.Models
{
    public class Product
    {
        public int Id { get; set; }
        //назва продукту
        public string ProductName { get; set; }
        //ціна за кг
        public double PricePerKg { get; set; }
        //дата виготовлення
        public DateTime Date { get; set; }
        //кількість в кг
        public int QuantityKg { get; set; }
        //залишок продукції в кг
        public int RemainingQuantityKg { get; set; }
        //чи продана дана продукція повністю
        public bool IsSold { get; set; } = false;
        //посилання на склад, в якому перебуватиме продукт
        public int StorageId { get; set; }
        public Storage Storage { get; set; }
        //зображення продукту
        public string Image { get; set; }
        //опис продукту
        public string Description { get; set; }
        //кількість калорій
        public int Calories { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        //посилання на корзину
        public List<ShoppingCartProduct> ShoppingCartProducts { get; set; } = new();
        //посилання на басейни
        public List<ProductInPool> ProductsInPool { get; set; } = new();
    }
}
