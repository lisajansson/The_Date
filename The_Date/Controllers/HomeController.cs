using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using The_Date.Models;

namespace The_Date.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Visar 3 användare från start.
            var User = new UserDbContext().Users.ToList().Take(1);
            return View(User);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}