using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace EventManager.Models
{
    internal class XmlSerialize
    {
        static public void SaveToXMLFile(List<EventRecord> list, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<EventRecord>));
            using (StreamWriter writer = new StreamWriter(path))
            {
                xmlSerializer.Serialize(writer, list);
            }
        }
        static public List<EventRecord>? LoadFromXMLFile(string path)
        {
            List<EventRecord>? list;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<EventRecord>));
            using (StreamReader reader = new StreamReader(path))
            {
                list = (List<EventRecord>?)xmlSerializer.Deserialize(reader);
            }
            return list;
        }
    }
}
