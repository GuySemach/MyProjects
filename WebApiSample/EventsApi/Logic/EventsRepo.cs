using  EventsApi.Interfaces;
using EventsApi.Models;

namespace EventsApi.Logic
{
    public class EventsRepo : IEventsRepo
    {
        public EventRecord GetEventById(int id)
        {
             EventRecord rec = new EventRecord();
             rec.EventName = "Test Event";
             rec.Id = 1;
             return rec;
        }
    }
}