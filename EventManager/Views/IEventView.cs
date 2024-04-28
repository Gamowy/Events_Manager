using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Views
{
    internal interface IEventView
    {
        // Properties
        string Title { get; set; }
        string? Description { get; set; }
        DateTime EventDate { get; set; }
        string? EventType { get; set; }
        string? EventPriority { get; set; }

        // Events
        event EventHandler? AddNewEvent;
        event EventHandler? RemoveEvent;
        event EventHandler? RemoveAllEvent;
        event EventHandler? SaveFileEvent;
        event EventHandler? LoadFileEvent;

        // Methods
        public bool titleTextBoxNotEmpty();
        public void reloadEventList();
        public void clearForm();
        public void colorizeEventList();
        public void setEventListSource(BindingSource eventList);
    }
}
