using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Datacore.Mapping
{
    public class OrderMap : BaseMap<Order>
    {
        public OrderMap()
        {
            ToTable("Orders");

            //one order to many orderitems
            HasMany(x => x.OrderItems)
                .WithRequired(x => x.Order)
                .HasForeignKey(x => x.OrderId)
                .WillCascadeOnDelete(false);
        }
    }
}
