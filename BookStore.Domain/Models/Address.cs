using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class Address : BaseModel
    {
        public string City { get; set; }
        public string District { get; set; }
        public string FullAddress { get; set; }
        public List<ApplicationUser> Users { get; set; } //many address -> to many users ***
        public List<Order> Orders { get; set; } //one address -> to many order ***
    }
}
