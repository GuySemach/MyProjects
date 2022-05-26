using EventsApi.Interfaces;
using EventsApi.Models;
using EventsApi.Logic;

namespace EventsApi.Logic
{
    public class SqlNotificationRepo : INotificationsRepo
    {
        private readonly NotificationContext _context;

        public SqlNotificationRepo(NotificationContext context)
        {
            _context = context;
        }
        public NotificationRecord GetNotificationById(int id)
        {
            var record = _context.Notifications.FirstOrDefault(noti => noti.Id == id);
            return record;
        }
    }   
}