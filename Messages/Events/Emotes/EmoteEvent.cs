using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Events.Emotes
{
    /// <summary>
    /// An item has emoted
    /// </summary>
    public class EmoteEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        public static Guid _Id = new Guid("6cedfd1c-89ec-4389-998b-1e076c9d7b48");
        /// <summary>
        /// Unique item identifier
        /// </summary>
        public Guid ItemId { set; get; }
        /// <summary>
        /// Name of item that has emoted
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// Type of emote
        /// </summary>
        public EmoteType Type { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public EmoteEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item has emoted";
        }
    }
}
