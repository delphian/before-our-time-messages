using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Exceptions
{
    public class MessageDefinitionInvalidException : Exception
    {
        public MessageDefinitionInvalidException()
        {
        }

        public MessageDefinitionInvalidException(string message)
            : base(message)
        {
        }

        public MessageDefinitionInvalidException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
