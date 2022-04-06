using EventsApi.Logic;
using EventsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventsApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly NotificationsRepo _repository = new NotificationsRepo(); 

        [HttpGet("{id}")]
        public ActionResult<NotificationRecord> GetNotificationById(int id)
        {
            var notificationRec = _repository.GetNotificationById(id);
            return Ok(notificationRec);
        }
    }
}