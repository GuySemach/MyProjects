using EventsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EventsApi.Logic
{
    public class NotificationContext : DbContext
    {
        public NotificationContext(DbContextOptions<NotificationContext> opt) : base(opt)
        {

        }

        public DbSet<NotificationRecord> Notifications { get; set; }
    }
}