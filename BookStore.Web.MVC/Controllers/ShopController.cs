using BookStore.Business.Repositories;
using BookStore.Web.MVC.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Web.MVC.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        private readonly IMasterCategoryRepository mcRepo;
        private readonly IProductRepository pRepo;
        private readonly ISpesificCategoryRepository sRepo;
        private readonly ICategoryRepository cRepo;

        ShopIndexViewModel sm = new ShopIndexViewModel();

        public ShopController(IMasterCategoryRepository mc_Repo, IProductRepository p_Repo, ISpesificCategoryRepository s_Repo, ICategoryRepository c_Repo)
        {
            mcRepo = mc_Repo;
            pRepo = p_Repo;
            sRepo = s_Repo;
            cRepo = c_Repo;
        }

        public ActionResult Index(int mcId)
        {
            sm.MasterCategory = mcRepo.Get(x => x.Id == mcId, "Name");
            sm.Categories = cRepo.GetList(x => x.MasterCategoryId == mcId, "Name");
            sm.SpesificCategories = sRepo.GetList(x => x.Category.MasterCategoryId == mcId, "Name");
            return View(sm);
        }
      
    }
}