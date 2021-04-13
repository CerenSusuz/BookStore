using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class MasterCategory : BaseModel
    {
        public string Name { get; set; }
        public List<Category> Categories { get; set; } //one mastercategory -> to many categories ***
    }
}
