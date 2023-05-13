using NLog;
using PatientVisitDemo.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerService
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public void LogDebuging(string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
           logger?.Error(message);
        }

        public void LogInformation(string message)
        {
            logger.Info(message);
        }

        public void LogWarning(string message)
        {
            logger.Warn(message);
        }
    }
}
