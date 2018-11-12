using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Exceptions
{
    /// <summary>
    /// Base exception for all Before Our Time database related exceptions
    /// </summary>
    public class BotAuthorizationDeniedException : BeforeOurTimeException
    {
        public BotAuthorizationDeniedException()
        {
        }

        public BotAuthorizationDeniedException(string message)
            : base(message)
        {
        }

        public BotAuthorizationDeniedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
