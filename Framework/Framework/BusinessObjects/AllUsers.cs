using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Framework.BusinessObjects
{
    [Serializable]
    public class AllUsers
    {
        [XmlElement("user")]
        public List<User> Users { get; set; }

        public static AllUsers DeserialiseUsers (string filePath)
        {
            var userSerialiser = new XmlSerializer(typeof(AllUsers));
            return (AllUsers)userSerialiser.Deserialize(new XmlTextReader(filePath));
        }
    }
}
