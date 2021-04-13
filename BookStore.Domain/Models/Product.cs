using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class Product : BaseModel
    {
        public Product()
        {
            Barcode = Guid.NewGuid().ToString();
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Barcode { get; set; }
        public int SpesificCategoryId { get; set; } //many products -> to  one specategory ***
        public SpesificCategory SpesificCategory { get; set; }
        public List<ProductImage> Images { get; set; } //one product -> to many images ***
        public List<Detail> Details { get; set; } //one product -> to many details ***
        public int Pub_hId { get; set; } // many products -> to one publishinghouse ***
        public PublishingHouse PublishingHouse { get; set; }
        public List<OrderItem> OrderItems { get; set; } //one product -> to many orderitems (bir üründen 5 tane sipariş edilmesi) ***



    }
}
