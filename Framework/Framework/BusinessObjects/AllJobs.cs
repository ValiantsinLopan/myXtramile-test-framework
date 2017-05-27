using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Framework.BusinessObjects
{
    [Serializable]
    public class AllJobs
    {
        [XmlElement("job")]
        public List<Job> jobs { get; set; }

        public static AllJobs DeserialiseJobs(string filePath)
        {
            var jobSerialiser = new XmlSerializer(typeof(AllJobs));
            return (AllJobs)jobSerialiser.Deserialize(new XmlTextReader(filePath));
        }
    }
}