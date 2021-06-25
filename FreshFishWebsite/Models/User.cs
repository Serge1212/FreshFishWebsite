
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreshFishWebsite.Models
{
    public class User : IdentityUser
    {
        //ім'я користувача
        [Required]
        public string Name { get; set; }
        //прізвище користувача
        [Required]
        public string Usersurname { get; set; }
        //підприємство користувача
        [Required]
        public string Company { get; set; }
        //Адреса підприємства користувача
        [Required]
        public string CompanyAddress { get; set; }
        // Корзина 
        public ShoppingCart ShoppingCart { get; set; }
        // Замовлення
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
