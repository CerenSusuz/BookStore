using BASECORE.Model;
using BookStore.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class Ticket : BaseModel
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public TicketStatus Status { get; set; }
        public List<TicketResponse> TicketResponses { get; set; } // one ticket -> many ticket responses ***
        public int OwnerId { get; set; } // many tickets -> to one user ***
        public ApplicationUser Owner { get; set; }
    }
}
