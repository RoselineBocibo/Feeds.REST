using System;
using System.Xml.Serialization;

namespace Feeds.Models
{
    public class Entry
    {
        [XmlElement("published")]
        public DateTime Published { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("author")]
        public Authur Authur { get; set; }
    }
}
