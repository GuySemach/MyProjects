using EventsApi.Models;

namespace EventsApi.Interfaces
{
    public interface INotificationsRepo
    {
        NotificationRecord GetNotificationById(int id);
    }
}