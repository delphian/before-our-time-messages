using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Events.Departures
{
    /// <summary>
    /// An item has departed location
    /// </summary>
    public class DepartureEvent : Event, IEvent
    {
        /// <summary>
        /// Unique item identifier
        /// </summary>
        public Guid ItemId { set; get; }
        /// <summary>
        /// Name of item
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public DepartureEvent()
        {
            this.MessageId = new Guid("1e889a17-2171-488d-b3c9-9920ef664fca");
            this.MessageName = "Item has departed from location";
        }
    }
}
