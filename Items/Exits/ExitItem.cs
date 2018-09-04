using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Exits
{
    /// <summary>
    /// A one way path from one location to another
    /// </summary>
    public class ExitItem : ItemBase
    {
        /// <summary>
        /// Destination location
        /// </summary>
        [JsonProperty(PropertyName = "locationItemId", Order = 100)]
        Guid LocationItemId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ExitItem()
        {
            Type = ItemBaseType.Exit;
        }
    }
}
