using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public List<Module> Modules { get; set; } //many role -> to many modules ***
        public List<ApplicationUser> Users { get; set; } //one roles -> to many user ***
    }
}
