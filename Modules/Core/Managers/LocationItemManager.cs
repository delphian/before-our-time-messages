﻿using BeforeOurTime.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Dbs;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using System.Linq;

namespace BeforeOurTime.Models.Modules.Core.Managers
{
    public class LocationItemManager : ItemModelManager<LocationItem>, ILocationItemManager
    {
        private ILocationDataRepo LocationDataRepo { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public LocationItemManager(
            IItemRepo itemRepo,
            ILocationDataRepo locationDataRepo) : base(itemRepo)
        {
            LocationDataRepo = locationDataRepo;
        }
        /// <summary>
        /// Get all repositories declared by manager
        /// </summary>
        /// <returns></returns>
        public List<ICrudModelRepository> GetRepositories()
        {
            return new List<ICrudModelRepository>() { LocationDataRepo };
        }
        /// <summary>
        /// Get repository as interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetRepository<T>() where T : ICrudModelRepository
        {
            return GetRepositories().Where(x => x is T).Select(x => (T)x).FirstOrDefault();
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
    }
}