using BookStore.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private readonly IMasterCategoryRepository mcRepo;
       
        public HomeController(IMasterCategoryRepository mc_Repo)
        {
            mcRepo = mc_Repo;
            
        }
        public ActionResult Index()
        {
            //PageSessions.CurrentPage = "Home";
            var masters = mcRepo.GetList();
            return View(masters);
        }
       
    }
}
