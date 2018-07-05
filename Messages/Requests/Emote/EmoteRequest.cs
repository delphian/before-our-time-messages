﻿using BeforeOurTime.Models.Messages.Events.Emotes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.Emote
{
    /// <summary>
    /// Request an emote be sent to current location
    /// </summary>
    public class EmoteRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        public static Guid _Id = new Guid("1f817b6e-aaf6-4418-a9fe-ad4d4a65e898");
        /// <summary>
        /// Type of emote
        /// </summary>
        public EmoteType Type { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public EmoteRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Emote Request";
        }
    }
}