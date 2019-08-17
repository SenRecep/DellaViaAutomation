using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Http.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DellaViaAutomation.Http.Controllers
{
    [Authorize]//[AllowAnonymous]
    public class HomeController : BaseController
    {

        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            return Ok(ManagerBuilder.UserManager.GetAll().ToList());
        }
    }
}
