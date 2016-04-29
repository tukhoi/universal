using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davang.Enterprise.Portable
{
    public class AppException : Exception
    {
        public string AppMessage { get; set; }
        public Exception Exception { get; set; }

        public AppException(string message)
            : this(message, null)
        { }

        public AppException(string message, Exception exception)
        {
            AppMessage = message;
            Exception = exception;

        }
    }
}