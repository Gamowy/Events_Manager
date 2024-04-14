namespace EventManager.Models
{
    enum EventType { Work, Family, Entertaiment, Health, Sport }
    enum EventPriority { High, Normal, Low }

    internal class EventRecord
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public EventType? Type { get; set; }
        public EventPriority? Priority { get; set; }

        public EventRecord(string title, string? description, DateTime? date, EventType? type, EventPriority? priority)
        {
            Title = title;
            Description = description;
            Date = date;
            Type = type;
            Priority = priority;
        }

        public EventRecord(EventRecord record)
        {
            Title = record.Title;
            Description = record.Description;
            Date = record.Date;
            Type = record.Type;
            Priority = record.Priority;
        }
    }
}
