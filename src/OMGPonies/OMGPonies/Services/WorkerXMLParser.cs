using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;
using System.Xml.Linq;

namespace OMGPonies.Services
{
    public class WorkerXMLParser : IWorkersServiceAgent
    {
        public List<Worker> ParseFile(string FileName)
        {
            List<Worker> workersfromfile = new List<Worker>();
            if (System.IO.File.Exists(FileName))
            {
                var xArr = XDocument.Load(FileName)
                                    .Element("dataWorkers")
                                    .Elements("worker");
                foreach (XElement item in xArr)
                {
                    foreach (XAttribute attr in item.Attributes() )
                    {
                        string ifname = null;
                        string ifworkshop = null;
                        bool ifsalary = false;
                        uint salary = 0;
                        if (attr.Name.ToString().CompareTo("name") == 0)
                        { ifname = attr.Value; }
                        else if (attr.Name.ToString().CompareTo("workshop") == 0)
                        { ifworkshop = attr.Value;  }
                        else if (attr.Name.ToString().CompareTo("salary") == 0)
                        { ifsalary = uint.TryParse(attr.Value, out salary);  }
                        if (ifname != null && ifworkshop != null && ifsalary)
                        {
                            workersfromfile.Add(
                                new Worker
                                {
                                    WorkerName = ifname,
                                    Workshop = ifworkshop,
                                    Salary = salary
                                }
                            );
                        }
                    }
                }
            }
            return workersfromfile;
        }
    }
}
