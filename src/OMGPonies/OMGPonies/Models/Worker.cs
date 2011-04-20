using System;
using System.Linq;
using System.Collections.Generic;

using SimpleMvvmToolkit;

namespace OMGPonies
{
    public class Worker : ModelBase<Worker>
    {
        private string workerName;
        public string WorkerName
        {
            get { return workerName; }
            set
            {
                workerName = value;
                NotifyPropertyChanged(m => m.WorkerName);
            }
        }

        private string workshop;
        public string Workshop
        {
            get { return workshop; }
            set
            {
                workshop = value;
                NotifyPropertyChanged(m => m.Workshop);
            }
        }

        private uint salary;
        public uint Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                NotifyPropertyChanged(m => m.Salary);
            }
        }
    }
}
