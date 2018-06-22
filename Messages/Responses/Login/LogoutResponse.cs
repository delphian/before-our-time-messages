using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.Login
{
    /// <summary>
    /// Response to logout request
    /// </summary>
    public class LogoutResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        public static Guid _Id = new Guid("05c1f08c-353a-4886-9526-9dc1ad69efc7");
        /// <summary>
        /// Constructor
        /// </summary>
        public LogoutResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Logout Response";
        }
    }
}
