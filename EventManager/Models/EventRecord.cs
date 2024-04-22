namespace EventManager.Models
{
    enum EventType { Work, Family, Entertaiment, Health, Sport }
    enum EventPriority { High, Normal, Low }

    internal class EventRecord : IEquatable<EventRecord>
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public EventType Type { get; set; }
        public EventPriority Priority { get; set; }

        public EventRecord(string title, string? description, DateTime date, EventType type, EventPriority priority)
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

        public bool Equals(EventRecord? other)
        {
            if (other is not null)
            {
                if (this.Title.Equals(other.Title) && this.Date.Equals(other.Date) && this.Type.Equals(other.Type) && this.Priority.Equals(other.Priority))
                    return true;
            }
            return false;
        }
    }
}
