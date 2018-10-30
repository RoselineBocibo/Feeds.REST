using System.Collections.Generic;
using System.Xml.Serialization;

namespace Feeds.Models
{
    [XmlRoot("feed", Namespace = "http://www.w3.org/2005/Atom")]
    public class Feed
    {
        [XmlElement("id")]
        public string ID { get; set; }
        [XmlElement("entry")]
        public List<Entry> Entries { get; set; }

    }
}
