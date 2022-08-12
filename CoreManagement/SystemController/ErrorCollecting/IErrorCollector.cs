using System;
using System.Collections.Generic;

namespace REM.Logic.CoreManagement.SystemErrorManagement.ErrorCollecting
{
    public interface IErrorCollector
    {
        void Collect(string description, Exception exception = null);
        List<Error> Get();
        void Clear();
    }
}
