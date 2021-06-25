

namespace FreshFishWebsite.Models
{
    public class ShoppingCartProduct
    {
        public int Id { get; set; }
        //кількість певної одиниці продукту в корзині
        public int Quantity { get; set; }
        //посилання на продукт
        public int ProductId { get; set; }
        public Product Product { get; set; }
        //посилання на корзину
        public int? ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        //посилання на замовлення
        public int? OrderId { get; set; }
        public Order Order { get; set; }
    }
}
