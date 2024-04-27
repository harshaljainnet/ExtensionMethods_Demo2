using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods_Demo2
{
    public class DbLogger : ILogger
    {
        public void LogInfo(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
