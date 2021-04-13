using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class Order : BaseModel
    {
        public int AddressId { get; set; } //many order -> to one address ***
        public Address Address { get; set; }
        public int ApplicationUserId { get; set; } //many orders -> to one user ***
        public ApplicationUser ApplicationUser { get; set; }
        public List<OrderItem> OrderItems { get; set; } //one order -> to many orderitems ***
    }
}
