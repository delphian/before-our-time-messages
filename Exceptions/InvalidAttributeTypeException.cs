using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Exceptions
{
    public class InvalidAttributeTypeException : Exception
    {
        public InvalidAttributeTypeException()
        {
        }

        public InvalidAttributeTypeException(string message)
            : base(message)
        {
        }

        public InvalidAttributeTypeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
