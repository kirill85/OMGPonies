using System;
using System.Linq;

namespace OMGPonies
{
    public class MockWorkerServiceAgent : IWorkerServiceAgent
    {
        // Create a fake Worker
        public Worker CreateWorker()
        {
            return new Worker
            {
                WorkerId = 1,
                WorkerName = "John Doe",
                Workshop = "Dallas"
            };
        }
    }
}
