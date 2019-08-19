using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class StatussController : BaseController
    {
        // GET: api/Status
        // GET: api/Status/Get
        [HttpGet, ResponseType(typeof(IEnumerable<Status>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.StatusManager.GetAll());
        }

        // GET: api/Status/5
        [HttpGet, ResponseType(typeof(Status))]
        public IHttpActionResult Get(int id)
        {
            var Status = ManagerBuilder.StatusManager.GetById(id);
            if (Status == null)
                return NotFound();
            return Ok(Status);
        }

        // POST: api/Status
        [HttpPost, ResponseType(typeof(Status))]
        public IHttpActionResult Post([FromBody]Status value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var Status = ManagerBuilder.StatusManager.Exists(value);
            if (Status)
                ManagerBuilder.StatusManager.Update(value);
            else
                ManagerBuilder.StatusManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/Status/5
        [HttpPut, ResponseType(typeof(Status))]
        public IHttpActionResult Put(int id, [FromBody]Status value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.StatusManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.StatusManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/Status/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.StatusManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.StatusManager.Delete(existing);
            return Ok();
        }
    }
}
