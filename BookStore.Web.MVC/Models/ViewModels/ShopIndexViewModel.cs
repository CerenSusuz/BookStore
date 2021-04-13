using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Web.MVC.Models.ViewModels
{
    public class ShopIndexViewModel
    {
        public List<Product> Products { get; set; }
        public MasterCategory MasterCategory { get; set; }
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
        public List<SpesificCategory> SpesificCategories { get; set; }
    }
}