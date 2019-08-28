using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class ProductsController : BaseController
    {
        // GET: api/Product
        // GET: api/Product/Get
        [HttpGet, ResponseType(typeof(IEnumerable<Product>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.ProductManager.GetAll());
        }

        // GET: api/Product/5
        [HttpGet, ResponseType(typeof(Product))]
        public IHttpActionResult Get(int id)
        {
            var Product = ManagerBuilder.ProductManager.GetById(id);
            if (Product == null)
                return NotFound();
            return Ok(Product);
        }

        // POST: api/Product
        [HttpPost, ResponseType(typeof(Product))]
        public IHttpActionResult Post([FromBody]Product value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var Product = ManagerBuilder.ProductManager.Exists(value);
            if (Product)
                ManagerBuilder.ProductManager.Update(value);
            else
                ManagerBuilder.ProductManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/Product/5
        [HttpPut, ResponseType(typeof(Product))]
        public IHttpActionResult Put(int id, [FromBody]Product value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.ProductManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.ProductManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/Product/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.ProductManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.ProductManager.Delete(existing);
            DataController.DbSave();
            return Ok();
        }
    }
}
