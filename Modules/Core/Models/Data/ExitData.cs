using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using BeforeOurTime.Models.Modules.Core.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Models.Data
{
    /// <summary>
    /// A one way path from the exit's current location to a specified and static one
    /// </summary>
    public class ExitData : ItemData, IItemData
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
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid DestinationLocationId { set; get; }
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
        public ExitData()
        {
            DataType = this.GetType().ToString();
        }
        /// <summary>
        /// Populate an item property value
        /// </summary>
        /// <typeparam name="T">Type of property to populate with value</typeparam>
        /// <param name="propertyName">Name of item property to populate with value</param>
        /// <param name="previousValue">Value assigned to property by previous attribute</param>
        /// <returns></returns>
        public override T GetProperty<T>(string propertyName, object previousValue)
        {
            if (typeof(T) == typeof(VisibleProperty))
            {
                previousValue = previousValue ?? new VisibleProperty();
                ((VisibleProperty)previousValue).Name = Name;
                ((VisibleProperty)previousValue).Description = Description;
            }
            if (typeof(T) == typeof(ExitProperty))
            {
                previousValue = previousValue ?? new ExitProperty();
                ((ExitProperty)previousValue).DestinationId = DestinationLocationId.ToString();
            }
            return (T)previousValue;
        }
    }
}
