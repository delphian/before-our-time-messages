using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Exits
{
    /// <summary>
    /// A one way path from the exit's current location to a specified and static one
    /// </summary>
    public class ExitItemData : ItemData, IItemData
    {
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
        public ExitItemData()
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
            if (typeof(T) == typeof(ExitItemProperty))
            {
                previousValue = previousValue ?? new ExitItemProperty();
                ((ExitItemProperty)previousValue).DestinationId = DestinationLocationId.ToString();
            }
            if (typeof(T) == typeof(CommandItemProperty))
            {
                previousValue = previousValue ?? new CommandItemProperty();
                ((CommandItemProperty)previousValue).Commands = new List<ItemCommand>()
                {
                    new ItemCommand()
                    {
                        ItemId = this.DataItemId,
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
        public override void UseItem(ItemCommand command, Item origin, IModuleManager moduleManager)
        {
            throw new NotImplementedException();
        }
    }
}
