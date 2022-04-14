using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1. DI Using Constructor
            Logger objLogger = new Logger(new FileLogger());
            objLogger.callMe("Nikhil Goyal");
            

            /*
            2. DI Using Properties
            Logger objLogger = new Logger();
            objLogger.PLogger = new FileLogger();
            objLogger.callMe("Nikhil Goyal");
            Console.ReadKey();
            */

            /* 3. DI Using Methods
            Logger objLogger = new Logger();
            objLogger.MLogger(new FileLogger());
            objLogger.callMe("Nikhil Goyal");
            */

            Console.ReadKey();
        }
    }
}