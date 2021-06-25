
using System.Collections.Generic;
namespace FreshFishWebsite.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        //посилання на користувача
        public string UserId { get; set; }

        public User User { get; set; }
        //посилання на продукти
        public List<ShoppingCartProduct> Products { get; set; } = new ();
    }
}
