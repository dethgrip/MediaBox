using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MediaBox
{
    public static class Converter
    {
        public static Models.DataModel CreateDataModelObject()
        {
            string xml = @"<AllProjects><Proj><ProjectID>1234</ProjectID><ProjectNumber>Test Project 1</ProjectNumber><AllSubmissions><Sub Type='Primary Submission'><SubmissionID>1</SubmissionID><SubmissionNumber>ABC_XYZ</SubmissionNumber></Sub><Sub Type='Secondary Submission'><SubmissionID>1</SubmissionID><SubmissionNumber>ABC_XYZ_2</SubmissionNumber></Sub></AllSubmissions></Proj><Proj><ProjectID>5678</ProjectID><ProjectNumber>Test Project 2</ProjectNumber><AllSubmissions><Sub Type='Primary Submission'><SubmissionID>1</SubmissionID><SubmissionNumber>BlahBlah</SubmissionNumber></Sub><Sub Type='Secondary Submission'><SubmissionID>1</SubmissionID><SubmissionNumber>NadaNada</SubmissionNumber></Sub></AllSubmissions></Proj><Proj><ProjectID>9999</ProjectID><ProjectNumber>Test Project 3</ProjectNumber></Proj></AllProjects>";
            XmlSerializer serializer = new XmlSerializer(typeof(Models.DataModel));
            Models.DataModel dm = (Models.DataModel)serializer.Deserialize(new StringReader(xml));

            return dm;
        }
    }
}