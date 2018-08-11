﻿using BeforeOurTime.Models.Items.Attributes.Locations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes.Exits
{
    /// <summary>
    /// A one way path from the exit's current location to a specified and static one
    /// </summary>
    public class ExitAttribute : ItemAttribute, IItemAttribute
    {
        /// <summary>
        /// Short description of exit
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { set; get; }
        /// <summary>
        /// Long description of exit
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { set; get; }
        /// <summary>
        /// Destination location
        /// </summary>
        [JsonProperty(PropertyName = "destinationLocationId", Order = 30)]
        public Guid DestinationLocationId { set; get; }
        [JsonIgnore]
        public virtual LocationAttribute DestinationLocation { set; get; }
        /// <summary>
        /// Time in seconds journey will consume
        /// </summary>
        [JsonProperty(PropertyName = "time", Order = 40)]
        public int Time { set; get; }
        /// <summary>
        /// Energy in % (0 - 100) that journey will consume
        /// </summary>
        [JsonProperty(PropertyName = "effort", Order = 50)]
        public int Effort { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ExitAttribute()
        {
            AttributeType = this.GetType().ToString();
        }
        /// <summary>
        /// Modify the item name before it is returned
        /// </summary>
        /// <param name="name">Previous name of item</param>
        /// <returns></returns>
        public override string GetName(string name)
        {
            return Name;
        }
        /// <summary>
        /// Modify the item description before it is returned
        /// </summary>
        /// <param name="name">Previous description of item</param>
        /// <returns></returns>
        public override string GetDescription(string description)
        {
            return Description;
        }
        /// <summary>
        /// Copy all source properties into our properties
        /// </summary>
        /// <param name="source"></param>
        public override void Copy(object source)
        {
            var exitAttribute = (ExitAttribute)source;
            Name = exitAttribute.Name;
            Description = exitAttribute.Description;
            DestinationLocationId = exitAttribute.DestinationLocationId;
        }
    }
}
