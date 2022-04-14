using System;

namespace DependencyInjection
{
    interface ILogger
    {
        void Info(string message);
    }

    class Logger
    {
        private ILogger _logger;

        //1. DI Using Constructor
        public Logger(ILogger objLogger)
        {
            _logger = objLogger;
        }
        

        /*2. DI Using Properties
        public ILogger PLogger
        {
            get { return _logger; }
            set { _logger = value; }
        }
        */

        /* 3. DI Using Methods
        public void MLogger(ILogger logger)
        {
            _logger = logger;
        }
        */
        public void callMe(string message)
        {
            _logger.Info(message);
        }
    }

    //FileLogger Class
    class FileLogger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine("File Logger Instantiation : " + message);
        }
    }

    //EmailLogger Class
    class EmailLogger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine("Email Logger Instantiation : " + message);
        }
    }
}