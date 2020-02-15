using ImagicleLibrary.Logging;
using log4net.Config;
using System;

namespace TestImagicleLibrary.prova
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("logconfiguration.xml"));

            var loggerFactory = new LoggerFactory();
            var _log = loggerFactory.GetLogger();
            _log.Debug(log => log.Header("prova").KeyValue("valore 2", true));
            Console.ReadKey();
        }
    }
}