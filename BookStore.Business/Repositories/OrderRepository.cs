using BASECORE.Data.EF.Abstract;
using BASECORE.Data.EF.Concrete;
using BookStore.Datacore.Context;
using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Repositories
{
    public interface IOrderRepository : IRepository<Order> { }
    public class OrderRepository : Repository<BookStoreDbContext, Order>, IOrderRepository
    {
        public OrderRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}
