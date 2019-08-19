using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DellaViaAutomation.MvcUi.Areas.Admin
{
    public class AdminControllerBase:Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            if (requestContext.HttpContext.Session["AdminLoginUser"] == null)
                requestContext.HttpContext.Response.Redirect("/Admin/AdminLogin");
            else
                base.Initialize(requestContext);
        }
    }
}