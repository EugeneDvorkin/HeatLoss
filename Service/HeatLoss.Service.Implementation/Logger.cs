using System;
using HeatLoss.Dal.Common;
using HeatLoss.Service.Common.Entity;
using NLog;
using ILogger = NLog.ILogger;

namespace HeatLoss.Service.Implementation
{
    public class Logger : Common.IService.ILogger
    {
        private readonly ILogger _logger;

        public Logger()
        {
            _logger = LogManager.GetLogger("database");
        }

        public void Log(DalException.ErrorType lvl, Exception e, string message, string stackTrace, AreaType type)
        {
            LogLevel logLevel;
            if (lvl == DalException.ErrorType.DatabaseException)
            {
                logLevel = LogLevel.Fatal;
            }
            else if (lvl == DalException.ErrorType.ExistDiameter || lvl == DalException.ErrorType.NotFoundDiameter)
            {
                logLevel = LogLevel.Error;
            }
            else
            {
                logLevel = LogLevel.Warn;
            }

            _logger.Log(logLevel, e, e.Message, e.StackTrace, type.ToString());
        }
    }
}