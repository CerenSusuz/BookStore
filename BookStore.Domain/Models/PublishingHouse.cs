using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class PublishingHouse : BaseModel
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; } //one pubhouse -> to many products ***
    }
}
