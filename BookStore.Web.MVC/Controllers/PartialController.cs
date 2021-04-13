using BookStore.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Web.MVC.Controllers
{
    public class PartialController : Controller
    {
        // GET: PartialView

        private readonly IMasterCategoryRepository mcRepo;
        private readonly IProductRepository prRepo;
        public PartialController(IMasterCategoryRepository mc_Repo, IProductRepository pr_Repo)
        {
            mcRepo = mc_Repo;
            prRepo = pr_Repo;
        }
        public PartialViewResult RenderHeader()
        {
            var mcats = mcRepo.GetList(x => x.IsActive && !x.IsDeleted);
            return PartialView("~/Views/Shared/header.cshtml", mcats);
        }
        public PartialViewResult RenderFooter()
        {
            return PartialView("~/Views/Shared/footer.cshtml");
        }
        public PartialViewResult RenderMainBanner()
        {
            return PartialView("~/Views/Shared/Sections/mainBanner.cshtml");
        }
        public PartialViewResult RenderNewArrivals()
        {
            var products = prRepo.GetList(x => x.Id < 3);
            return PartialView("~/Views/Shared/Sections/newArrivals.cshtml",products);
        }

        public PartialViewResult RenderAdvantages()
        {
            return PartialView("~/Views/Shared/Sections/advantages.cshtml");
        }
    }
}