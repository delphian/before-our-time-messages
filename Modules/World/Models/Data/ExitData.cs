using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Core.Managers;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using BeforeOurTime.Models.Modules.Terminal.Managers;
using BeforeOurTime.Models.Modules.Terminal.Models.Data;
using BeforeOurTime.Models.Modules.World.Managers;
using BeforeOurTime.Models.Modules.World.Messages.Location.ReadLocationSummary;
using BeforeOurTime.Models.Modules.World.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Models.Data
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
            if (typeof(T) == typeof(UseProperty))
            {
                previousValue = previousValue ?? new UseProperty();
                ((UseProperty)previousValue).Uses = new List<Use>()
                {
                    new Use()
                    {
                        Id = new Guid("c558c1f9-7d01-45f3-bc35-dcab52b5a37c"),
                        Name = "Go"
                    }
                };
            }
            return (T)previousValue;
        }
        /// <summary>
        /// Execute a command that this data provides
        /// </summary>
        /// <param name="command">Command to be performed</param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="moduleManager">Manager of all modules</param>
        public override void UseItem(Use command, Item origin, IModuleManager moduleManager)
        {
            throw new NotImplementedException();
        }
    }
}
