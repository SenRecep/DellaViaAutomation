using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class OrdersController : BaseController
    {
        // GET: api/Order
        // GET: api/Order/Get
        [HttpGet, ResponseType(typeof(IEnumerable<Order>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.OrderManager.GetAll());
        }

        // GET: api/Order/5
        [HttpGet, ResponseType(typeof(Order))]
        public IHttpActionResult Get(int id)
        {
            var Order = ManagerBuilder.OrderManager.GetById(id);
            if (Order == null)
                return NotFound();
            return Ok(Order);
        }

        // POST: api/Order
        [HttpPost, ResponseType(typeof(Order))]
        public IHttpActionResult Post([FromBody]Order value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var Order = ManagerBuilder.OrderManager.Exists(value);
            if (Order)
                ManagerBuilder.OrderManager.Update(value);
            else
                ManagerBuilder.OrderManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/Order/5
        [HttpPut, ResponseType(typeof(Order))]
        public IHttpActionResult Put(int id, [FromBody]Order value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.OrderManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.OrderManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/Order/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.OrderManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.OrderManager.Delete(existing);
            DataController.DbSave();
            return Ok();
        }
    }
}
