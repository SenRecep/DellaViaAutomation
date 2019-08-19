using DellaViaAutomation.Bll.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using DellaViaAutomation.Http.Helpers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace DellaViaAutomation.Http.Controllers
{
    public class TicketsController : BaseController
    {
        // GET: api/Ticket
        // GET: api/Ticket/Get
        [HttpGet, ResponseType(typeof(IEnumerable<Ticket>))]
        public IHttpActionResult Get()
        {
            return Ok(ManagerBuilder.TicketManager.GetAll());
        }

        // GET: api/Ticket/5
        [HttpGet, ResponseType(typeof(Ticket))]
        public IHttpActionResult Get(int id)
        {
            var Ticket = ManagerBuilder.TicketManager.GetById(id);
            if (Ticket == null)
                return NotFound();
            return Ok(Ticket);
        }

        // POST: api/Ticket
        [HttpPost, ResponseType(typeof(Ticket))]
        public IHttpActionResult Post([FromBody]Ticket value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var Ticket = ManagerBuilder.TicketManager.Exists(value);
            if (Ticket)
                ManagerBuilder.TicketManager.Update(value);
            else
                ManagerBuilder.TicketManager.Add(value);
            DataController.DbSave();
            return Ok(value);
        }

        // PUT: api/Ticket/5
        [HttpPut, ResponseType(typeof(Ticket))]
        public IHttpActionResult Put(int id, [FromBody]Ticket value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = ManagerBuilder.TicketManager.GetById(id);
            if (existing == null)
                return NotFound();

            ManagerBuilder.TicketManager.Update(value);
            DataController.DbSave();
            return Ok(value);
        }

        // DELETE: api/Ticket/5
        [HttpDelete, ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            var existing = ManagerBuilder.TicketManager.GetById(id);
            if (existing == null)
                return NotFound();
            ManagerBuilder.TicketManager.Delete(existing);
            return Ok();
        }
    }
}
