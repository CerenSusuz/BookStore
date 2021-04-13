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
    public interface ISpesificCategoryRepository : IRepository<SpesificCategory> { }
    public class SpesificCategoryRepository : Repository<BookStoreDbContext, SpesificCategory>, ISpesificCategoryRepository
    {
        public SpesificCategoryRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}
