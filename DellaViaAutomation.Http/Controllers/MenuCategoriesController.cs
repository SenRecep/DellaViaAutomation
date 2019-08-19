using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class MenuCategoriesController : BaseController
    {
        // GET: api/MenuCategory
        // GET: api/MenuCategory/Get
        [HttpGet, ResponseType(typeof(IEnumerable<MenuCategory>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.MenuCategoryManager.GetAll());
        }

        // GET: api/MenuCategory/5
        [HttpGet, ResponseType(typeof(MenuCategory))]
        public IHttpActionResult Get(int id)
        {
            var MenuCategory = ManagerBuilder.MenuCategoryManager.GetById(id);
            if (MenuCategory == null)
                return NotFound();
            return Ok(MenuCategory);
        }

        // POST: api/MenuCategory
        [HttpPost, ResponseType(typeof(MenuCategory))]
        public IHttpActionResult Post([FromBody]MenuCategory value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var MenuCategory = ManagerBuilder.MenuCategoryManager.Exists(value);
            if (MenuCategory)
                ManagerBuilder.MenuCategoryManager.Update(value);
            else
                ManagerBuilder.MenuCategoryManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/MenuCategory/5
        [HttpPut, ResponseType(typeof(MenuCategory))]
        public IHttpActionResult Put(int id, [FromBody]MenuCategory value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.MenuCategoryManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.MenuCategoryManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/MenuCategory/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.MenuCategoryManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.MenuCategoryManager.Delete(existing);
            return Ok();
        }
    }
}
