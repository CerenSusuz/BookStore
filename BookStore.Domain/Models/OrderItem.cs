using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class OrderItem : BaseModel
    {
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public int ProductId { get; set; } //many orderitems -> to one product ***
        public Product Product { get; set; }
        public int OrderId { get; set; } //many orderitems -> to one order ***
        public Order Order { get; set; }
    }
}
