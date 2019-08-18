using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class PostalCodesController : BaseController
    {
        // GET: api/PostalCode
        // GET: api/PostalCode/Get
        [HttpGet, ResponseType(typeof(IEnumerable<PostalCode>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.PostalCodeManager.GetAll());
        }

        // GET: api/PostalCode/5
        [HttpGet, ResponseType(typeof(PostalCode))]
        public IHttpActionResult Get(int id)
        {
            var PostalCode = ManagerBuilder.PostalCodeManager.GetById(id);
            if (PostalCode == null)
                return NotFound();
            return Ok();
        }

        // POST: api/PostalCode
        [HttpPost, ResponseType(typeof(PostalCode))]
        public IHttpActionResult Post([FromBody]PostalCode value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var PostalCode = ManagerBuilder.PostalCodeManager.Exists(value);
            if (PostalCode)
                ManagerBuilder.PostalCodeManager.Update(value);
            else
                ManagerBuilder.PostalCodeManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/PostalCode/5
        [HttpPut, ResponseType(typeof(PostalCode))]
        public IHttpActionResult Put(int id, [FromBody]PostalCode value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.PostalCodeManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.PostalCodeManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/PostalCode/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.PostalCodeManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.PostalCodeManager.Delete(existing);
            return Ok();
        }
    }
}
