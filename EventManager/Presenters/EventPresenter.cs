using EventManager.Models;
using EventManager.Repositories;
using EventManager.Views;

namespace EventManager.Presenters
{
    internal class EventPresenter
    {
        private EventRepository _eventRepository;
        private IEventView _view;
        private IEnumerable<EventRecord>? _eventList;
        private BindingSource _eventBindingSource;

        public EventPresenter(IEventView view, EventRepository reposiotry)
        {
            _view = view;
            _eventRepository = reposiotry;
            _eventBindingSource = new BindingSource();
            

            _view.AddNewEvent += _addEvent;
            _view.RemoveEvent += _removeEvent;
            _view.setEventListSource(_eventBindingSource);

            loadEventsList();
            clearForm();
        }

        // Methods
        private void loadEventsList()
        {
            _eventList = _eventRepository.getAll();
            _eventBindingSource.DataSource = _eventList;
            _eventBindingSource.ResetBindings(false);
        }

        private void clearForm()
        {
            _view.Title = "";
            _view.Description = "";
            _view.EventDate = DateTime.Now;
            _view.EventType = "Work";
            _view.EventPriority = "Normal";
        }

        // Event handlers
        private void _addEvent(object? sender, EventArgs e)
        {
            bool parseEvTypeOk = Enum.TryParse<EventType>(_view.EventType, out EventType evType);
            bool parseEvPriorityOk = Enum.TryParse<EventPriority>(_view.EventPriority, out EventPriority evPriority);

            if (_view.titleTextBoxNotEmpty() && parseEvTypeOk && parseEvPriorityOk) {
                EventRecord record = new EventRecord(_view.Title, _view.Description, _view.EventDate, evType, evPriority);
                _eventRepository.add(record);
                loadEventsList();
                clearForm();
            }
        }

        private void _removeEvent(object? sender, EventArgs e)
        {

        }

        private void _selectEvent(object? sender, EventArgs e)
        {
            
        }
    }
}
