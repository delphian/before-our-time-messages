using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.Login
{
    public class LogoutRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        public static Guid _Id = new Guid("96f05cd2-2042-46e6-b4cb-fef35b2ff05a");
        /// <summary>
        /// Constructor
        /// </summary>
        public LogoutRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Logout Request";
        }
    }
}
