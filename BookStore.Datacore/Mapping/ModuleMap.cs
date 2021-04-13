using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Datacore.Mapping
{
    public class ModuleMap : BaseMap<Module>
    {
        public ModuleMap()
        {
            ToTable("Modules");

            //many module to many roles
            HasMany(x => x.Roles)
                 .WithMany(x => x.Modules)
                 .Map(x =>
                 {
                     x.MapLeftKey("ModuleId");
                     x.MapRightKey("RoleId");
                 });
        }
    }
}
