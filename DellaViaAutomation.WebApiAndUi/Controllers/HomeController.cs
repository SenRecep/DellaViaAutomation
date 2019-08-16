using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DellaViaAutomation.WebApiAndUi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.FullName = DellaViaAutomation.Bll.ComplexType.ManagerBuilder.UserManager.GetById(1).GetFullName;
            return View();
        }
    }
}
