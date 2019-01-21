using System;

namespace HeatLoss.Dal.Common
{
    public class DalException : Exception
    {
        public ErrorType Error { get; private set; }

        public LayingType Laying { get; private set; }

        public DalException(ErrorType errorType, LayingType layingType)
        {
            Error = errorType;
            Laying = Laying;
        }

        public DalException(ErrorType errorType, LayingType layingType, string message) : base(message)
        {
            Error = errorType;
            Laying = layingType;
        }

        public DalException(ErrorType errorType, LayingType layingType, string message, Exception innerException) : base(message, innerException)
        {
            Error = errorType;
            Laying = layingType;
        }

        public enum ErrorType
        {
            ExistDiameter,
            NorFoundDiameter,
            DatabaseException
        }

        public enum LayingType
        {
            UndergroundLaying,
            OverGroundCanalLaying,
            CommonLaying
        }
    }
}