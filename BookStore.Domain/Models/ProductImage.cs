using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class ProductImage : BaseModel
    {
        public string Path { get; set; }
        public int ProductId { get; set; } //many images -> to one product ***
        public Product Product { get; set; }
    }
}
