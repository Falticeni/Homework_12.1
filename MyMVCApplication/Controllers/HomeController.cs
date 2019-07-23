using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //throw new Exception("Am aruncat o exceptie");
            TempData["name"] = "Test data";
            TempData["age"] = 30;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descrierea paginii.";

            string userName;
            int userAge;

            if (TempData.ContainsKey("name"))
                userName = TempData["name"].ToString();

            if (TempData.ContainsKey("age"))
                userAge = int.Parse(TempData["age"].ToString());
            TempData.Keep();
            return View();
        }

        [HandleError]
        public ActionResult Contact()
        {
            ViewBag.Message = "Datele de contact.";
            return View();
        }
        public ActionResult HTML_Helpers()
        {
            return View();
        }

    }

}