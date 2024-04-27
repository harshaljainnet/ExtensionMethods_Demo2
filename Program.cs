using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods_Demo2
{
    public class Program
    {
        public static void Main(string[] args)
        {       
            DbLogger dbLogger = new DbLogger();
            dbLogger.EmailLog("The CPU limit has crossed threshold..");
        }
    }

    // lets create an extension method - EmailLog for ILogger interface
    public static class ILoggerExtensionMethods
    {
        public static void EmailLog(this ILogger logger, string msg)
        {
            Console.WriteLine("The log has been emailed, log details: " + msg);
        }
    }
}
