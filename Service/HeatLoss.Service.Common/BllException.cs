using System;

namespace HeatLoss.Service.Common
{
    public class BllException : Exception
    {
        public BllException(Exception e, string message, string stackTrace) : base(message, e)
        {
            StackTrace = stackTrace;
        }

        public BllException(string message):base(message)
        { }

        public string StackTrace { get; private set; }
    }
}