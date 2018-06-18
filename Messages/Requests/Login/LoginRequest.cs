using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.Login
{
    public class LoginRequest : Request, IRequest
    {
        /// <summary>
        /// Credential's email
        /// </summary>
        public string Email { set; get; }
        /// <summary>
        /// Credential's password
        /// </summary>
        public string Password { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public LoginRequest()
        {
            this.MessageId = new Guid("29908ab8-6403-4094-aa32-1ea0b3af70bf");
            this.MessageName = "Login Request";
        }
    }
}
