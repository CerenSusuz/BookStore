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
    public interface IRoleRepository : IRepository<Role> { }
    public class RoleRepository : Repository<BookStoreDbContext, Role>, IRoleRepository
    {
        public RoleRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}
