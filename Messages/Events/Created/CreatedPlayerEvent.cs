using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Events.Created
{
    /// <summary>
    /// A player has been created
    /// </summary>
    public class CreatedPlayerEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        public static Guid _Id = new Guid("662e5eb5-8f4a-41e3-a148-52eeacc04121");
        /// <summary>
        /// Unique item identifier of player
        /// </summary>
        public Guid ItemId { set; get; }
        /// <summary>
        /// Name of player
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CreatedPlayerEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Player has been created";
        }
    }
}
