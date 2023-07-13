using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MisExepciones : Exception
    {
        public MisExepciones()
        {
        }

        public MisExepciones(string? message) : base(message)
        {
        }

        public MisExepciones(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MisExepciones(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
