using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Business
{ 
    public class Logger : ILogger
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
       (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void logMessage(string message, LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.debug:
                    log.Debug(message);
                    break;
                case LogLevel.message:
                    log.Info(message);
                    break;
                case LogLevel.warning:
                    log.Warn(message);
                    break;
                case LogLevel.error:
                    log.Error(message);
                    break;
                default:
                    break;
            }            
        }

        
    }
}
