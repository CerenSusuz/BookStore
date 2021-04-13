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
    public interface IAddressRepository : IRepository<Address>
    {
    }
    public class AddressRepository : Repository<BookStoreDbContext, Address>, IAddressRepository
    {
        public AddressRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}
