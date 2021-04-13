using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Datacore.Mapping
{
    public class RoleMap : BaseMap<Role>
    {
        public RoleMap()
        {
            ToTable("Roles");

        }
    }
}
