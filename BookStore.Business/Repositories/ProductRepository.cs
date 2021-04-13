using BASECORE.Data.EF.Abstract;
using BASECORE.Data.EF.Concrete;
using BookStore.Datacore.Context;
using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetProductsByCount(int count, Expression<Func<Product, bool>> filter = null, params string[] includeList);
    }
    public class ProductRepository : Repository<BookStoreDbContext, Product>, IProductRepository
    {
        private readonly BookStoreDbContext ctx;
        public ProductRepository(BookStoreDbContext context) : base(context)
        {
            ctx = context;
        }

        public List<Product> GetProductsByCount(int count, Expression<Func<Product, bool>> filter = null, params string[] includeList)
        {
            List<Product> result = null;

            try
            {
                IQueryable<Product> query = null;
                if (filter == null)
                {
                    query = ctx.Products;
                }
                else
                {
                    query = ctx.Products.Where(filter);
                }
                if (includeList != null)
                {
                    foreach (var includeItem in includeList)
                    {
                        query = query.Include(includeItem);
                    }
                }
                query = query.OrderByDescending(x => x.Created).Take(count);
                result = query.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
    }
}
