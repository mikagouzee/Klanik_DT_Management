using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.LogMachines
{
    public interface ILogMachine
    {
        void Log(string message);
    }
}
