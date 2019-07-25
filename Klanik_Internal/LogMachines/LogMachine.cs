using System.IO;
using System.Linq;

namespace Klanik_Internal.LogMachines {
    public class LogMachine : ILogMachine {
        private string logFile;

        public LogMachine()
        {
            string logFolderPath = "";

            var assemblyPath = AssemblyLocator.GetAssemblyLocation();

            var logFolder = Directory.GetDirectories(assemblyPath).FirstOrDefault(x => x == "logfolder");

            if (logFolder == null)
            {
                Directory.CreateDirectory(Path.Combine(assemblyPath, "logFolder"));
            }

            logFolderPath = Path.GetFullPath(Path.Combine(assemblyPath, "logFolder"));

            logFile = Path.Combine(logFolderPath, "log.txt");

            if (!File.Exists(logFile))
            {
                File.Create(logFile).Close();
            }
        }

        public void Log(string content)
        {
            //using (StreamWriter file = new StreamWriter(logFile, true))
            //{
            //    file.WriteLine(DateTime.Now + " : " + content);
            //    //file.WriteLine(Environment.NewLine);             
            //}

        }
    }
}
