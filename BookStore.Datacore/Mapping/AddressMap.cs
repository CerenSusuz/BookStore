using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Datacore.Mapping
{
    public class AddressMap : BaseMap<Address>
    {
        public AddressMap()
        {
            ToTable("Addresses");

            //many addresses to many user
            HasMany(x => x.Users)
                 .WithMany(x => x.Addresses)
                 .Map(x =>
                 {
                     x.MapLeftKey("AddressId");
                     x.MapRightKey("UserId");
                 });

            //one addresses to many orders
            HasMany(x => x.Orders)
               .WithRequired(x => x.Address)
               .HasForeignKey(x => x.AddressId)
               .WillCascadeOnDelete(false);
        }
    }
}
