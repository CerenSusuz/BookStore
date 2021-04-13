using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Datacore.Mapping
{
    public class UserMap : BaseMap<ApplicationUser>
    {
        public UserMap()
        {
            ToTable("ApplicationUsers");

            //many users to one role
            HasRequired(x => x.Role)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.RoleId)
                .WillCascadeOnDelete(false);

            // one user to many orders
            HasMany(x => x.Orders)
                .WithRequired(x => x.ApplicationUser)
                .HasForeignKey(x => x.ApplicationUserId)
                .WillCascadeOnDelete(false);

            //one user to many tickets
            HasMany(x => x.Tickets)
                .WithRequired(x => x.Owner)
                .HasForeignKey(x => x.OwnerId)
                .WillCascadeOnDelete(false);

           
        }
    }
}
