using EventManager.Models;
using System.Reflection.Metadata.Ecma335;

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

        public void RemoveAll()
        {
            eventsDataBase.Clear();
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

        public bool saveToFile()
        {
            string filePath = string.Empty;
            if (eventsDataBase is not null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = saveFileDialog.FileName;
                    }
                }

                if (!filePath.Equals(string.Empty))
                {
                    XmlSerialize.SaveToXMLFile(eventsDataBase, filePath);
                    return true;
                }
            }
            return false;
        }

        public bool loadFromFile()
        {
            string filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            if (!filePath.Equals(string.Empty))
            {
                List<EventRecord>? loadedList = XmlSerialize.LoadFromXMLFile(filePath);
                if (loadedList is not null)
                {
                    eventsDataBase = loadedList;
                    return true;
                }
            }
            return false;
        }
    }
}
