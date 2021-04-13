using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class Module : BaseModel
    {
        public string Name { get; set; }
        public List<Role> Roles { get; set; } // many module -> to many roles  ***
    }
}
