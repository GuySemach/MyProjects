using EventsApi.Models;

namespace EventsApi.Interfaces
{
    public interface IEventsRepo
    {
        EventRecord GetEventById(int id);
    }
}