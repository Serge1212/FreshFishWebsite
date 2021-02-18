﻿

namespace FreshFishWebsite.Models
{
    public class ShoppingCartProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int? ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }

    }
}
