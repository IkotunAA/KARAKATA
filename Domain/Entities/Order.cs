using KARAKATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public User Buyer { get; set; } = default!;
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public decimal TotalAmount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; } = default!;
        public string PaymentMethod { get; set; } = default!;
        public string ShippingMethod { get; set; } = default!;
    }

}
