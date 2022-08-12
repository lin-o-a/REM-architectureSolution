using REM.Logic.CoreManagement.SystemErrorManagement.ErrorCollecting;
using System;
using System.Collections.Generic;

namespace REM.Logic.CoreManagement.SystemController
{
    public class SystemServiceResult
    {
        #region public properties
        public Guid Id;
        public string message;
        public List<Error> errors;
        #endregion
    }
}
