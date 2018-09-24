using BeforeOurTime.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeforeOurTime.Business.Apis.Items;
using BeforeOurTime.Models.Modules.Core.Dbs;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Managers;

namespace BeforeOurTime.Models.Modules.Core.Managers
{
    public class GameItemManager : DataManager<GameData>, IGameItemManager
    {
        private IGameDataRepo GameDataRepo { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public GameItemManager(
            IItemRepo itemRepo,
            IGameDataRepo gameDataRepo) : base(itemRepo, gameDataRepo)
        {
            GameDataRepo = gameDataRepo;
        }
        /// <summary>
        /// Get all repositories declared by manager
        /// </summary>
        /// <returns></returns>
        public ICrudDataRepository GetRepository()
        {
            return GameDataRepo;
        }
        /// <summary>
        /// Get repository as interface
        /// </summary>
        /// <typeparam name="TRepo"></typeparam>
        /// <returns></returns>
        public TRepo GetRepository<TRepo>() where TRepo : IDataRepository
        {
            return (TRepo)GameDataRepo;
        }
        /// <summary>
        /// Determine if an item has attributes that may be managed
        /// </summary>
        /// <param name="item">Item that may posses attributes</param>
        public bool IsManaging(Item item)
        {
            var managed = false;
            if (GameDataRepo.Read(item) != null)
            {
                managed = true;
            }
            return managed;
        }
        /// <summary>
        /// Update games's default location
        /// </summary>
        /// <param name="id">Unique game attribute identifier</param>
        /// <param name="locationId">Game's new default location</param>
        /// <returns></returns>
        public GameData UpdateDefaultLocation(Guid id, Guid locationId)
        {
            var gameAttribute = Read(id);
            gameAttribute.DefaultLocationId = locationId;
            return Update(gameAttribute);
        }
    }
}
