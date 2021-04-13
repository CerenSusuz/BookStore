using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Datacore.Mapping
{
    public class CategoryMap : BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("Categories");

            //many categories to one master category
            HasRequired(x => x.MasterCategory)
                .WithMany(x => x.Categories)
                .HasForeignKey(x => x.MasterCategoryId)
                .WillCascadeOnDelete(false);

            //one category to many spesific categories
            HasMany(x => x.SpesificCategories)
                .WithRequired(x => x.Category)
                .HasForeignKey(x => x.CategoryId)
                .WillCascadeOnDelete(false);
        }
    }
}
