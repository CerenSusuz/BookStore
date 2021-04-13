using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Datacore.Mapping
{
    public class ProductMap : BaseMap<Product>
    {
        public ProductMap()
        {
            ToTable("Products");

            //one product to many order items
            HasMany(x => x.OrderItems)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                .WillCascadeOnDelete(false);

            //many product to one phouse
            HasRequired(x => x.PublishingHouse)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.Pub_hId)
                .WillCascadeOnDelete(false);

            //one product to many details
            HasMany(x => x.Details)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                .WillCascadeOnDelete(false);

            //one product to many images
            HasMany(x => x.Images)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                .WillCascadeOnDelete(false);

            //many products to one spesific category
            HasRequired(x => x.SpesificCategory)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.SpesificCategoryId)
                .WillCascadeOnDelete(false);


        }
    }
}
