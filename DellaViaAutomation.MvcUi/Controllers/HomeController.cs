using DellaViaAutomation.Bll.Concreate;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DellaViaAutomation.MvcUi.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var data = await ApiCenter<User>.GetAsync();
            return View("Index", data);
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