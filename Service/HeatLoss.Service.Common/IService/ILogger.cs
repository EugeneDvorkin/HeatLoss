using System;
using HeatLoss.Dal.Common;
using HeatLoss.Service.Common.Entity;

namespace HeatLoss.Service.Common.IService
{
    public interface ILogger
    {
        void Log(DalException.ErrorType lvl, Exception e, string message, string stackTrace, AreaType type);
    }
}