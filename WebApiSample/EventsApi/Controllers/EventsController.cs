using EventsApi.Logic;
using EventsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventsApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventsRepo _repository = new EventsRepo(); 

        [HttpGet("{id}")]
        public ActionResult<EventRecord> GetEventById(int id)
        {
            var eventRec = _repository.GetEventById(id);
            return Ok(eventRec);
        }
    }
}