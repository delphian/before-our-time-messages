using BeforeOurTime.Business.Apis.Items.Attributes.Exits;
using BeforeOurTime.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models.ItemAttributes.Exits;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Managers;
using BeforeOurTime.Models.Modules.Core.Dbs;
using BeforeOurTime.Models.Modules.Core.Models.Items;

namespace BeforeOurTime.Models.Modules.Core.Managers
{
    public class LocationItemManager : DataManager<LocationData>, ILocationItemManager
    {
        private ILocationDataRepo LocationDataRepo { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public LocationItemManager(
            IItemRepo itemRepo,
            ILocationDataRepo locationDataRepo) : base(itemRepo, locationDataRepo)
        {
            LocationDataRepo = locationDataRepo;
        }
        /// <summary>
        /// Create an empty new location and connecting exits from a provided location
        /// </summary>
        /// <param name="currentLocationItemId">Existing location item to link to new location with exits</param>
        /// <returns></returns>
        public LocationItem CreateFromHere(Guid currentLocationItemId)
        {
//            var currentLocation = ItemRepo.Read(currentLocationItemId);
//            var locationAttribute = new LocationAttribute()
//            {
//                Name = "A New Location",
//                Description = "The relatively new construction of this place is apparant everywhere you look. In several places the c# substrate seems to be leaking from above, while behind you a small puddle of sql statements have coalesced into a small puddle. Ew..."
//            };
//            var defaultGameItemId = ModuleManager.GetModule<ICoreModule>().GetDefaultGame().Id;
//            var locationItem = Create(locationAttribute, defaultGameItemId).GetAsItem<LocationItem>();
//            var toExitAttribute = new ExitAttribute()
//            {
//                Name = "A New Exit",
//                Description = "The paint is still wet on this sign!",
//                DestinationLocationId = locationAttribute.Id
//            };
//            ExitAttributeManager.Create(toExitAttribute, currentLocationItemId);
//            var froExitAttribute = new ExitAttribute()
//            {
//                Name = "A Return Path",
//                Description = "Escape back to the real world",
//                DestinationLocationId = currentLocation.GetAttribute<LocationAttribute>().Id
//            };
//            ExitAttributeManager.Create(froExitAttribute, locationItem.Id);
//            return locationItem;
return null;
        }
        /// <summary>
        /// Read item's detailed location
        /// </summary>
        /// <remarks>
        /// If item itself has no location detail then item's parents will be 
        /// traversed until one is found
        /// </remarks>
        /// <param name="item">Item that has attached detail location data</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        /// <returns>The Item's detailed location data. Null if none found</returns>
        new public LocationData Read(Item item, TransactionOptions options = null)
        {
            LocationData location = null;
            Item traverseItem = item;
            while (traverseItem.ParentId != null && !IsManaging(traverseItem))
            {
                traverseItem = ItemRepo.Read(traverseItem.ParentId.Value, options);
            }
            if (IsManaging(traverseItem))
            {
                location = traverseItem.GetData<LocationData>();
            }
            return location;
        }
    }
}