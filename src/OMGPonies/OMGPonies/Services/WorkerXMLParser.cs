using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace OMGPonies.Services
{
    class WorkerXMLParser
    {
        public Worker[] ParseFile(string FileName)
        {
            if (System.IO.File.Exists(FileName))
            {
                var xArr = XDocument.Load(FileName)
                                    .Element("dataWorkers")
                                    .Elements("worker");
                foreach (XElement item in xArr)
                {
                    foreach (XAttribute attr in item.Attributes()
                        .Where(i => i.Name.ToString()
                        .CompareTo("name") == 0))
                    {
                        // getName ?
                    }
                }
            }
            return null;
        }
    }
}
