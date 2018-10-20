using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Exceptions
{
    /// <summary>
    /// Base exception for all Before Our Time database related exceptions
    /// </summary>
    public class BotDatabaseException : BeforeOurTimeException
    {
        public BotDatabaseException()
        {
        }

        public BotDatabaseException(string message)
            : base(message)
        {
        }

        public BotDatabaseException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
