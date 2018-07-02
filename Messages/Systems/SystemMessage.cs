using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Systems
{
    /// <summary>
    /// A system communication is a meta communication between client and server
    /// </summary>
    public class SystemMessage : Message, ISystemMessage
    {
    }
}
