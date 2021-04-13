using BASECORE.Model;
using BookStore.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class ApplicationUser : BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; } //TODO: 
        public Gender Gender { get; set; }
        public DateTime LastLogin { get; set; }
        public int RoleId { get; set; } //many user -> to one role ***
        public Role Role { get; set; }
        public List<Address> Addresses { get; set; } //many user -> to many addresses ***
        public List<Order> Orders { get; set; } // one user -> to many orders ***
        public List<Ticket> Tickets { get; set; } //one user -> to many tickets ***
    }
}
