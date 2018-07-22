using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Exceptions
{
    public class MessageResponseTimeoutException : Exception
    {
        public MessageResponseTimeoutException()
        {
        }

        public MessageResponseTimeoutException(string message)
            : base(message)
        {
        }

        public MessageResponseTimeoutException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
