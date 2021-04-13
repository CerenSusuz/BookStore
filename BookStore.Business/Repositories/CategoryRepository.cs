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
    public interface ICategoryRepository : IRepository<Category> { }
    public class CategoryRepository : Repository<BookStoreDbContext, Category>, ICategoryRepository
    {
        public CategoryRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}
