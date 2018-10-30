using System.IO;
using System.Xml.Serialization;

namespace Feeds.Repository
{
    public static class Helper
    {
        public static T Deserialize<T>(this StreamReader stream, string defaultSchema = null)
        {
            var xmlSerializer = new XmlSerializer(typeof(T), defaultSchema);
            return (T)xmlSerializer.Deserialize(stream);
        }

    }

}
