using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class OrderPaymentsController : BaseController
    {
        // GET: api/OrderPayment
        // GET: api/OrderPayment/Get
        [HttpGet, ResponseType(typeof(IEnumerable<OrderPayment>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.OrderPaymentManager.GetAll());
        }

        // GET: api/OrderPayment/5
        [HttpGet, ResponseType(typeof(OrderPayment))]
        public IHttpActionResult Get(int id)
        {
            var OrderPayment = ManagerBuilder.OrderPaymentManager.GetById(id);
            if (OrderPayment == null)
                return NotFound();
            return Ok();
        }

        // POST: api/OrderPayment
        [HttpPost, ResponseType(typeof(OrderPayment))]
        public IHttpActionResult Post([FromBody]OrderPayment value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var OrderPayment = ManagerBuilder.OrderPaymentManager.Exists(value);
            if (OrderPayment)
                ManagerBuilder.OrderPaymentManager.Update(value);
            else
                ManagerBuilder.OrderPaymentManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/OrderPayment/5
        [HttpPut, ResponseType(typeof(OrderPayment))]
        public IHttpActionResult Put(int id, [FromBody]OrderPayment value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.OrderPaymentManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.OrderPaymentManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/OrderPayment/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.OrderPaymentManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.OrderPaymentManager.Delete(existing);
            return Ok();
        }
    }
}
