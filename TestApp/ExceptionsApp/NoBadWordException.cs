using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsApp
{
    class NoBadWordException : ApplicationException
    {
        public NoBadWordException()
        {
        }

        public NoBadWordException(string message) : base(message)
        {
        }

        public NoBadWordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoBadWordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
