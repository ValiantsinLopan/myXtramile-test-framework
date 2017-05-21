using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Framework.BusinessObjects
{
    [Serializable]
    public class Jobs
    {
        [XmlElement("job")]
        public List<Job> jobs { get; set; }

        public static Jobs DeserialiseUsers(string filePath)
        {
            var jobSerialiser = new XmlSerializer(typeof(Jobs));
            return (Jobs)jobSerialiser.Deserialize(new XmlTextReader(filePath));
        }
    }
}