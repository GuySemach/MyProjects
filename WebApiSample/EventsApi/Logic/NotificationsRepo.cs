using  EventsApi.Interfaces;
using EventsApi.Models;

namespace EventsApi.Logic
{
    public class NotificationsRepo : INotificationsRepo
    {
        public NotificationRecord GetNotificationById(int id)
        {
             NotificationRecord rec = new NotificationRecord();
             rec.Title = "Test Event";
             rec.Id = 1;
             return rec;
        }
    }
}