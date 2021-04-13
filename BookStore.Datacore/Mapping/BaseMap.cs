using BASECORE.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Datacore.Mapping
{
    public class BaseMap<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : BaseModel
    {
        public BaseMap()
        {
            HasKey(x => x.Id);
        }
    }
}
