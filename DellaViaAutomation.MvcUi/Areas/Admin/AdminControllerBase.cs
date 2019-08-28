using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DellaViaAutomation.MvcUi.Areas.Admin
{
    public class AdminControllerBase : Controller
    {
        public User loginUser { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (requestContext.HttpContext.Session["AdminLoginUser"] == null)
            {
                loginUser = null;
                requestContext.HttpContext.Response.Redirect("/Admin/AdminLogin");
            }
            else
            {
                loginUser = requestContext.HttpContext.Session["AdminLoginUser"] as User;
                base.Initialize(requestContext);
            }
        }
    }
}