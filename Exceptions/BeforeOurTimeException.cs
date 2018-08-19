using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Exceptions
{
    /// <summary>
    /// Base exception for all Before Our Time generated exceptions
    /// </summary>
    public class BeforeOurTimeException : Exception
    {
        public BeforeOurTimeException()
        {
        }

        public BeforeOurTimeException(string message)
            : base(message)
        {
        }

        public BeforeOurTimeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
