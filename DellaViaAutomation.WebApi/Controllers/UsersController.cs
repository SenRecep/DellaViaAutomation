using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DellaViaAutomation.WebApi.Controllers
{
    // Daha Tamamlanmadı
    public class UsersController : ApiController
    {
        public IEnumerable<User> Get()
        {
            return ManagerBuilder.UserManager.GetAll();
        }

        // GET api/values/5
        public User Get(int id)
        {
            return ManagerBuilder.UserManager.GetById(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
