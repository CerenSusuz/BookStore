using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class TicketResponse : BaseModel
    {
        public string Content { get; set; }
        public int TicketId { get; set; } // many responses -> to one ticket ***
        public Ticket Ticket { get; set; }
       
    }
}
