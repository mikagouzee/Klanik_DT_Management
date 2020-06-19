using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Implementations
{
    public class AssemblyLocator
    {
        public static string GetAssemblyLocation()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            var assemblyPath = Path.GetDirectoryName(path);
            return assemblyPath;
        }
    }
}
