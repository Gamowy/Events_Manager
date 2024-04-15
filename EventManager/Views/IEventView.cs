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

        // Methods
        public bool titleTextBoxNotEmpty();
        void setEventListSource(BindingSource eventList);
    }
}
