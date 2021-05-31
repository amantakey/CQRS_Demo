using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Core.Models
{
    public class Order
    {
        public int Id { get; set; }

        public OrderItems Items { get; set; }

        public PaymentInfo PaymentInfo { get; set; }
    }
}
