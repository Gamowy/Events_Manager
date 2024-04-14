using EventManager.Models;
using EventManager.Repositories;
using EventManager.Views;

namespace EventManager.Presenters
{
    internal class EventPresenter
    {
        private EventRepository _eventRepository;
        private IEventView _view;
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
        }

        // Methods
        private void loadEventsList()
        { 
            _eventBindingSource.DataSource = _eventRepository.getAll();
        }

        private EventType? getEventType()
        {
            switch (_view.EventType)
            {
                case "Praca":
                    return EventType.Work;
                case "Rodzina":
                    return EventType.Family;
                case "Rozrywka":
                    return EventType.Entertaiment;
                case "Zdrowie":
                    return EventType.Health;
                case "Sport":
                    return EventType.Sport;
                default:
                    return null;
            }
        }
        private EventPriority? getEventPriority()
        {
            switch (_view.EventPriority)
            {
                case "Wysoki":
                    return EventPriority.High;
                case "Standardowy":
                    return EventPriority.Normal;
                case "Niski":
                    return EventPriority.Low;
                default:
                    return null;
            }
        }

        // Event handlers
        private void _addEvent(object? sender, EventArgs e)
        {
            EventType? evType = getEventType();
            EventPriority? evPriority = getEventPriority();

            EventRecord record = new EventRecord(_view.Title, _view.Description, _view.EventDate, evType, evPriority);
            _eventRepository.add(record);
            loadEventsList();
        }

        private void _removeEvent(object? sender, EventArgs e)
        {

        }
    }
}
