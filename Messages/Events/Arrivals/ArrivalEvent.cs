using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Events.Arrivals
{
    /// <summary>
    /// An item has arrived at same location
    /// </summary>
    public class ArrivalEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        public static Guid _Id = new Guid("2d6bb89d-08d3-4d3f-acff-2e0dc0481a56");
        /// <summary>
        /// Unique item identifier
        /// </summary>
        public Guid ItemId { set; get; }
        /// <summary>
        /// Name of item that has arrived
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ArrivalEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item has arrived at location";
        }
    }
}
