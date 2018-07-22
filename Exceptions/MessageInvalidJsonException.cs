using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Exceptions
{
    public class MessageInvalidJsonException : Exception
    {
        public MessageInvalidJsonException()
        {
        }

        public MessageInvalidJsonException(string message)
            : base(message)
        {
        }

        public MessageInvalidJsonException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
