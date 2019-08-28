using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class MenusController : BaseController
    {
        // GET: api/Menu
        // GET: api/Menu/Get
        [HttpGet, ResponseType(typeof(IEnumerable<Menu>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.MenuManager.GetAll());
        }

        // GET: api/Menu/5
        [HttpGet, ResponseType(typeof(Menu))]
        public IHttpActionResult Get(int id)
        {
            var Menu = ManagerBuilder.MenuManager.GetById(id);
            if (Menu == null)
                return NotFound();
            return Ok(Menu);
        }

        // POST: api/Menu
        [HttpPost, ResponseType(typeof(Menu))]
        public IHttpActionResult Post([FromBody]Menu value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var Menu = ManagerBuilder.MenuManager.Exists(value);
            if (Menu)
                ManagerBuilder.MenuManager.Update(value);
            else
                ManagerBuilder.MenuManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/Menu/5
        [HttpPut, ResponseType(typeof(Menu))]
        public IHttpActionResult Put(int id, [FromBody]Menu value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.MenuManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.MenuManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/Menu/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.MenuManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.MenuManager.Delete(existing);
            DataController.DbSave();
            return Ok();
        }
    }
}
