using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class UserAddressesController : BaseController
    {
        // GET: api/UserAddress
        // GET: api/UserAddress/Get
        [HttpGet, ResponseType(typeof(IEnumerable<UserAddress>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.UserAddressManager.GetAll());
        }

        // GET: api/UserAddress/5
        [HttpGet, ResponseType(typeof(UserAddress))]
        public IHttpActionResult Get(int id)
        {
            var UserAddress = ManagerBuilder.UserAddressManager.GetById(id);
            if (UserAddress == null)
                return NotFound();
            return Ok(UserAddress);
        }

        // POST: api/UserAddress
        [HttpPost, ResponseType(typeof(UserAddress))]
        public IHttpActionResult Post([FromBody]UserAddress value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var UserAddress = ManagerBuilder.UserAddressManager.Exists(value);
            if (UserAddress)
                ManagerBuilder.UserAddressManager.Update(value);
            else
                ManagerBuilder.UserAddressManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/UserAddress/5
        [HttpPut, ResponseType(typeof(UserAddress))]
        public IHttpActionResult Put(int id, [FromBody]UserAddress value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.UserAddressManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.UserAddressManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/UserAddress/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.UserAddressManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.UserAddressManager.Delete(existing);
            DataController.DbSave();
            return Ok();
        }
    }
}
