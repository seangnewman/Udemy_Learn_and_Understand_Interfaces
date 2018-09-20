using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implementation_Demo
{
    class Job : IRemoteJob, ILocalJob
    {
        public void Run2()
        {
            throw new NotImplementedException();
        }

        void IRemoteJob.Run()
        {
            throw new NotImplementedException();
        }

        void ILocalJob.Run()
        {
            throw new NotImplementedException();
        }
    }
}
