using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BASECORE.Data.EF.Abstract
{
    public interface IRepository<TEntity> : IDisposable
       where TEntity : BaseModel
    {
        List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, params string[] includeList);
        TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includeList);
        bool Insert(TEntity model);
        bool Delete(TEntity model);
        bool Update(TEntity model);
    }
}
