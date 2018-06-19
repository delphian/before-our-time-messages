using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Events.Ticks
{
    /// <summary>
    /// Game tick
    /// </summary>
    public class TickEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        public static Guid _Id = new Guid("a5af1bbb-3b82-4103-91f9-b26d25543a0c");
        /// <summary>
        /// Constructor
        /// </summary>
        public TickEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Game tick";
        }
    }
}
