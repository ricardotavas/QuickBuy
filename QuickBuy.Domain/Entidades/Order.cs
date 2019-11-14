using QuickBuy.Domain.Valuables;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entidades
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryForecastDate { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int AddressNumber { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Order must mave at least one order item
        /// </summary>
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
