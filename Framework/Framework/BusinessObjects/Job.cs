using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Framework.BusinessObjects
{
    [Serializable]
    public class Job
    {
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("type")]
        public string Type { get; set; }
        [XmlElement("country")]
        public string Country { get; set; }
        [XmlElement("keywords")]
        public string Keywords { get; set; }
        [XmlElement("category")]
        public string Category { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("videoUrl")]
        public string VideoUrl { get; set; }
        [XmlElement("budget")]
        public decimal Budget { get; set; }
        [XmlElement("startDate")]
        public string StartDate { get; set; }
        [XmlElement("briefDescription")]
        public string BriefDescription { get; set; }
        [XmlElement("mediaType")]
        public string MediaType { get; set; }
        public Job()
        {

        }
        public Job(string title, string type, string country, string category, string description, decimal budget, string startdate, string briefdescription, string mediatype)
        {
            Title = title;
            Type = type;
            Country = country;
            Category = category;
            Description = description;
            Budget = budget;
            StartDate = startdate;
            BriefDescription = briefdescription;
            MediaType = mediatype;
        }
    }
}
