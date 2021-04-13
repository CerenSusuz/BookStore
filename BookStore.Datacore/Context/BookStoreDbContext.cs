using BookStore.Datacore.Mapping;
using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Datacore.Context
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext() : base("name=CstrBookStore")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Configuration.LazyLoadingEnabled = false;

            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new DetailMap());
            modelBuilder.Configurations.Add(new MasterCategoryMap());
            modelBuilder.Configurations.Add(new ModuleMap());
            modelBuilder.Configurations.Add(new OrderItemMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductImageMap());
            modelBuilder.Configurations.Add(new ProductMap()) ;
            modelBuilder.Configurations.Add(new PublishingHouseMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new SpesificCategoryMap());
            modelBuilder.Configurations.Add(new TicketMap());
            modelBuilder.Configurations.Add(new TicketResponseMap());
            modelBuilder.Configurations.Add(new UserMap());


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<PublishingHouse> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MasterCategory> MasterCategories { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SpesificCategory> SpesificCategories { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketResponse> TicketResponses { get; set; }

    }
}
