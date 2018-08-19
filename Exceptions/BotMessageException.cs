using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Exceptions
{
    /// <summary>
    /// Base exception for all Before Our Time message related exceptions
    /// </summary>
    public class BotMessageException : BeforeOurTimeException
    {
        public BotMessageException()
        {
        }

        public BotMessageException(string message)
            : base(message)
        {
        }

        public BotMessageException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
