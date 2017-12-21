using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MediaBox.Models
{
    [XmlRoot(ElementName = "AllProjects")]
    public class DataModel
    {
        public string AllProjects { get; set; }

        [XmlElement]
        public Proj[] Proj { get; set; }
    }

    public class Proj
    {
        [XmlElement]
        public string ProjectID { get; set; }

        [XmlElement]
        public string ProjectNumber { get; set; }

        [XmlElement]
        public AllSubmissions AllSubmissions { get; set; }
    }

    public class AllSubmissions
    {
        [XmlElement]
        public Sub[] Sub { get; set; }
    }

    public class Sub
    {
        [XmlAttribute]
        public string Type { get; set; }

        [XmlElement]
        public string SubmissionID { get; set; }

        [XmlElement]
        public string SubmissionNumber { get; set; }
    }
}