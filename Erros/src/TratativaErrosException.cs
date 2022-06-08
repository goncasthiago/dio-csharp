using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Erros.src
{
    [Serializable]
        public class TratativaErrosException : Exception
    {
        public TratativaErrosException()
        {

        }
        public TratativaErrosException(string? message) : base(message)
        {

        }
        public TratativaErrosException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
        protected TratativaErrosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
        public string? MyProperty { get; set; }

    }
}