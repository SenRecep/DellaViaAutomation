using DellaViaAutomation.Bll.Concreate;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DellaViaAutomation.MvcUi.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: Admin/AdminLogin
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.AdminLoginStatus = 0;
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Index(FormCollection fc)
        {
            ViewBag.AdminLoginStatus = 0;
            string email = fc["email"];
            string pass = fc["pass"];
            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(pass))
            {
                User user = await ApiCenter<User>.AdminLogin(email,pass) as User;
                if (user!=null)
                {
                    Session["AdminLoginUser"] = user;
                    return Redirect("/Admin");
                }
                else
                    ViewBag.AdminLoginStatus = 2;
            }
            else
                ViewBag.AdminLoginStatus = 1;
            return View();
        }
    }
}