using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Exceptions
{
    public class AuthenticationDeniedException : Exception
    {
        public AuthenticationDeniedException()
        {
        }

        public AuthenticationDeniedException(string message)
            : base(message)
        {
        }

        public AuthenticationDeniedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
