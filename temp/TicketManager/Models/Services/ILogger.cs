using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models.Services
{
    public interface ILogger
    {
        void logMessage(string message, LogLevel logLevel);
    }

    public enum LogLevel
    {
        debug,
        message,
        warning,
        error
    }
}
