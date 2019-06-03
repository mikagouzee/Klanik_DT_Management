using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Tools.LogMachine
{
    public interface ILogMachine
    {
        void Log(string message);
    }
}
