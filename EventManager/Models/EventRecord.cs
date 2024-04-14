using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Models
{
    enum EventType { Work, Family, Entertaiment, Health, Sport }
    enum Priority { Low, Medium, High }

    internal class EventRecord
    {
        string Title { get; set; }
        string? Description { get; set; }
        DateTime Date { get; set; }
        EventType Type { get; set; }
        Priority Priority { get; set; }

        EventRecord(string title, string description, DateTime date, EventType type, Priority priority)
        {
            Title = title;
            Description = description;
            Date = date;
            Type = type;
            Priority = priority;
        }

        EventRecord(EventRecord record)
        {
            Title = record.Title;
            Description = record.Description;
            Date = record.Date;
            Type = record.Type;
            Priority = record.Priority;
        }
    }
}
