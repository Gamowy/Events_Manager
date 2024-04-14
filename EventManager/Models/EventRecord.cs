namespace EventManager.Models
{
    enum EventType { Work, Family, Entertaiment, Health, Sport }
    enum EventPriority { High, Normal, Low }

    internal class EventRecord
    {
        string Title { get; set; }
        string? Description { get; set; }
        DateTime? Date { get; set; }
        EventType? Type { get; set; }
        EventPriority? Priority { get; set; }

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
