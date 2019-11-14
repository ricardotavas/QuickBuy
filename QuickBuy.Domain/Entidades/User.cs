using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entidades
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        /// <summary>
        /// An user can have one or many orders
        /// </summary>
        public ICollection<Order> Orders { get; set; }
    }
}
