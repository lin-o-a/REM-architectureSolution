using System;

namespace REM.Logic.CoreManagement.SystemErrorManagement.ErrorCollecting
{
    public class Error
    {
        public string Description;
        public Exception Exception;

        public Error(string description, Exception exception = null)
        {
            Description = description;
            Exception = exception;
        }
    }
}
