using System;
using System.Linq;

namespace OMGPonies
{
    public interface IWorkerServiceAgent
    {
        Worker CreateWorker();
    }
}
