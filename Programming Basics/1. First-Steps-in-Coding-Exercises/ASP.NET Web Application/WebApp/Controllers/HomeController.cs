using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Calculate(string num1, string num2)
        {
            this.ViewBag.num1 = num1;
            this.ViewBag.num2 = num2;
            decimal n1 = decimal.Parse(num1);
            decimal n2 = decimal.Parse(num2);
            decimal s = n1 + n2;
            this.ViewBag.sum = Convert.ToString(s);
            return View("Index");
        }

    }
}