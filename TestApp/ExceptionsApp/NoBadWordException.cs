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
        public int charCount { get; set; }
        public NoBadWordException()
        {
        }

        public NoBadWordException(string message, string word) : base(message)
        {
            this.charCount = word.Length;
        }

        public NoBadWordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoBadWordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
