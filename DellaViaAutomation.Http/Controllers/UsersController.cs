using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    /*[Authorize][AllowAnonymous]*/
    public class UsersController : BaseController
    {
        // GET: api/User
        // GET: api/User/Get
        [HttpGet, ResponseType(typeof(IEnumerable<User>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.UserManager.GetAll());
        }

        // GET: api/User/5
        [HttpGet, ResponseType(typeof(User))]
        public IHttpActionResult Get(int id)
        {
            var user = ManagerBuilder.UserManager.GetById(id);
            if (user == null)
                return NotFound();
            return Ok();
        }

        // POST: api/User
        [HttpPost, ResponseType(typeof(User))]
        public IHttpActionResult Post([FromBody]User value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var user = ManagerBuilder.UserManager.Exists(value);
            if (user)
                ManagerBuilder.UserManager.Update(value);
            else
                ManagerBuilder.UserManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/User/5
        [HttpPut, ResponseType(typeof(User))]
        public IHttpActionResult Put(int id, [FromBody]User value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.UserManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.UserManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/User/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.UserManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.UserManager.Delete(existing);
            return Ok();
        }
    }
}
