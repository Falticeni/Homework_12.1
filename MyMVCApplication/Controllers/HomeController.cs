using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descrierea paginii.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Datele de contact.";
            return View();
        }
    }
}