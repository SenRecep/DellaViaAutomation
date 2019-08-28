using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class CategoriesController : BaseController
    {
        // GET: api/Category
        // GET: api/Category/Get
        [HttpGet, ResponseType(typeof(IEnumerable<Category>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.CategoryManager.GetAll());
        }

        // GET: api/Category/5
        [HttpGet, ResponseType(typeof(Category))]
        public IHttpActionResult Get(int id)
        {
            var Category = ManagerBuilder.CategoryManager.GetById(id);
            if (Category == null)
                return NotFound();
            return Ok(Category);
        }

        // POST: api/Category
        [HttpPost, ResponseType(typeof(Category))]
        public IHttpActionResult Post([FromBody]Category value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var Category = ManagerBuilder.CategoryManager.Exists(value);
            if (Category)
                ManagerBuilder.CategoryManager.Update(value);
            else
                ManagerBuilder.CategoryManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/Category/5
        [HttpPut, ResponseType(typeof(Category))]
        public IHttpActionResult Put(int id, [FromBody]Category value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.CategoryManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.CategoryManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/Category/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.CategoryManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.CategoryManager.Delete(existing);
            DataController.DbSave();
            return Ok();
        }
    }
}
