using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class FoodandBeveragesController : BaseController
    {
        // GET: api/FoodandBeverage
        // GET: api/FoodandBeverage/Get
        [HttpGet, ResponseType(typeof(IEnumerable<FoodandBeverage>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.FoodandBeverageManager.GetAll());
        }

        // GET: api/FoodandBeverage/5
        [HttpGet, ResponseType(typeof(FoodandBeverage))]
        public IHttpActionResult Get(int id)
        {
            var FoodandBeverage = ManagerBuilder.FoodandBeverageManager.GetById(id);
            if (FoodandBeverage == null)
                return NotFound();
            return Ok();
        }

        // POST: api/FoodandBeverage
        [HttpPost, ResponseType(typeof(FoodandBeverage))]
        public IHttpActionResult Post([FromBody]FoodandBeverage value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var FoodandBeverage = ManagerBuilder.FoodandBeverageManager.Exists(value);
            if (FoodandBeverage)
                ManagerBuilder.FoodandBeverageManager.Update(value);
            else
                ManagerBuilder.FoodandBeverageManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/FoodandBeverage/5
        [HttpPut, ResponseType(typeof(FoodandBeverage))]
        public IHttpActionResult Put(int id, [FromBody]FoodandBeverage value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.FoodandBeverageManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.FoodandBeverageManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/FoodandBeverage/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.FoodandBeverageManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.FoodandBeverageManager.Delete(existing);
            return Ok();
        }
    }
}
