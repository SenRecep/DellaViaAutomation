using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class BasketsController : BaseController
    {
        // GET: api/Basket
        // GET: api/Basket/Get
        [HttpGet, ResponseType(typeof(IEnumerable<Basket>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.BasketManager.GetAll());
        }

        // GET: api/Basket/5
        [HttpGet, ResponseType(typeof(Basket))]
        public IHttpActionResult Get(int id)
        {
            var Basket = ManagerBuilder.BasketManager.GetById(id);
            if (Basket == null)
                return NotFound();
            return Ok(Basket);
        }

        // POST: api/Basket
        [HttpPost, ResponseType(typeof(Basket))]
        public IHttpActionResult Post([FromBody]Basket value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var Basket = ManagerBuilder.BasketManager.Exists(value);
            if (Basket)
                ManagerBuilder.BasketManager.Update(value);
            else
                ManagerBuilder.BasketManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/Basket/5
        [HttpPut, ResponseType(typeof(Basket))]
        public IHttpActionResult Put(int id, [FromBody]Basket value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.BasketManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.BasketManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/Basket/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.BasketManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.BasketManager.Delete(existing);
            DataController.DbSave();
            return Ok();
        }
    }
}
