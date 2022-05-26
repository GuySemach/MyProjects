namespace EventsApi.Models
{
    public class NotificationRecord
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }

    }
}