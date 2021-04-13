using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class SpesificCategory : BaseModel 
    {
        public string Name { get; set; }
        public int CategoryId { get; set; } //many spesific categories -> to one category ***
        public Category Category { get; set; }
        public List<Product> Products { get; set; } //one spesific category -> to  many products ***
    }
}
