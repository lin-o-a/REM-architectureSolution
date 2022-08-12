using System;
using System.Collections.Generic;

namespace REM.Logic.CoreManagement.SystemErrorManagement.ErrorCollecting
{
    public class ErrorCollector
    {
        private List<Error> _errorList;

        public void Collect(string description, Exception exception = null) {
            var error = new Error(description, exception);
            _errorList.Add(error);
        }

        public List<Error> Get() {
            return _errorList;
        }

        public void Clear() {
            _errorList.Clear();
        }
    }
}
