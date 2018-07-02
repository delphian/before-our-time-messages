using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Systems.Ping
{
    /// <summary>
    /// Response to login request
    /// </summary>
    public class PingSystemMessage : SystemMessage, ISystemMessage
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        public static Guid _Id = new Guid("c113348e-9cc3-4eaf-abfe-a5d6152792f0");
        /// <summary>
        /// Constructor
        /// </summary>
        public PingSystemMessage()
        {
            this.MessageId = _Id;
            this.MessageName = "Ping System Message";
        }
    }
}
