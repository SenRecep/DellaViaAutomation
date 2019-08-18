using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class OrderProductsController : BaseController
    {
        // GET: api/OrderProduct
        // GET: api/OrderProduct/Get
        [HttpGet, ResponseType(typeof(IEnumerable<OrderProduct>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.OrderProductManager.GetAll());
        }

        // GET: api/OrderProduct/5
        [HttpGet, ResponseType(typeof(OrderProduct))]
        public IHttpActionResult Get(int id)
        {
            var OrderProduct = ManagerBuilder.OrderProductManager.GetById(id);
            if (OrderProduct == null)
                return NotFound();
            return Ok();
        }

        // POST: api/OrderProduct
        [HttpPost, ResponseType(typeof(OrderProduct))]
        public IHttpActionResult Post([FromBody]OrderProduct value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var OrderProduct = ManagerBuilder.OrderProductManager.Exists(value);
            if (OrderProduct)
                ManagerBuilder.OrderProductManager.Update(value);
            else
                ManagerBuilder.OrderProductManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/OrderProduct/5
        [HttpPut, ResponseType(typeof(OrderProduct))]
        public IHttpActionResult Put(int id, [FromBody]OrderProduct value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.OrderProductManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.OrderProductManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/OrderProduct/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.OrderProductManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.OrderProductManager.Delete(existing);
            return Ok();
        }
    }
}
