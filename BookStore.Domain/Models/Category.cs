using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public int MasterCategoryId { get; set; } //many categories -> to one mastercategory ***
        public MasterCategory MasterCategory { get; set; }
        public List<SpesificCategory> SpesificCategories { get; set; } //one category -> many spesific categories ***
    }
}
