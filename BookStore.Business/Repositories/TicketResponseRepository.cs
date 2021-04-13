using BASECORE.Data.EF.Abstract;
using BASECORE.Data.EF.Concrete;
using BookStore.Datacore.Context;
using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Repositories
{
    public interface ITicketResponseRepository : IRepository<TicketResponse> { }
    public class TicketResponseRepository : Repository<BookStoreDbContext, TicketResponse>, ITicketResponseRepository
    {
        public TicketResponseRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}
