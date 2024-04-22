using EventManager.Models;

namespace EventManager.Repositories
{
    internal class EventRepository
    {
        private static EventRepository? _instance;
        private List<EventRecord> eventsDataBase;

        private EventRepository()
        {
            eventsDataBase = new List<EventRecord>();
        }

        public static EventRepository getInstance()
        {
            if (_instance == null)
            {
                _instance = new EventRepository();
            }
            return _instance;
        }

        public IEnumerable<EventRecord> getAll()
        {
            return eventsDataBase;
        }

        public void add(EventRecord record)
        {
            eventsDataBase.Add(record);
        }

        public bool remove(EventRecord record)
        {
            foreach (EventRecord ev in eventsDataBase)
            {
                if (ev.Equals(record))
                {
                    eventsDataBase.Remove(ev);
                    return true;
                }
            }
            return false;
        }
    }
}
