using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;


namespace RegistrationPage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string name = "First ";
            ViewData["name"] = name;

            List<string> list1 = new List<string> { "red", "green", "blue" };
            ViewData["list1"] = list1;

            List<int> list = new List<int> { 1, 4, 6, 8 };
            ViewBag.list2 = list;
           // SqlConnection connection = new SqlConnection()
            return View();
        }



    }
}