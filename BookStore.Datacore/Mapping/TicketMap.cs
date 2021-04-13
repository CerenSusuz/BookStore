using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Datacore.Mapping
{
    public class TicketMap : BaseMap<Ticket>
    {
        public TicketMap()
        {
            ToTable("Tickets");

            //one ticket to many ticketresponses
            HasMany(x => x.TicketResponses)
                .WithRequired(x => x.Ticket)
                .HasForeignKey(x => x.TicketId)
                .WillCascadeOnDelete(false);
        }
    }
}
