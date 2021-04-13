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
    public interface IProductImageRepository : IRepository<ProductImage> { }
    public class ProductImageRepository : Repository<BookStoreDbContext, ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}
