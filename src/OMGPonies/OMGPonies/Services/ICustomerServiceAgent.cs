using System;
using System.Collections.Generic;
using System.Linq;

namespace OMGPonies
{
    public interface IWorkerServiceAgent
    {
        Worker CreateWorker();
    }

    public interface IWorkersServiceAgent
    {
        List<Worker> ParseFile(string FileName);
    }
}
