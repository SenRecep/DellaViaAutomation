﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DellaViaAutomation.MvcUi.Areas.Admin.Controllers
{
    public class DefaultController : AdminControllerBase
    {
        // GET: Admin/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}