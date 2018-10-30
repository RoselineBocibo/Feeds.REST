using System.Xml.Serialization;

namespace Feeds.Models
{
    public class Authur
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("uri")]
        public string Url { get; set; }
    }
}
