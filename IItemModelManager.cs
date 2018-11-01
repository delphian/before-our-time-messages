using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Core.Messages.UseItem;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Terminal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models
{
    public interface IItemModelManager : IModelManager
    {
        /// <summary>
        /// Report if manager is in charge of an item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool IsManaging(Item item);
        /// <summary>
        /// Determine if an item property type is managable
        /// </summary>
        /// <param name="propertyType">Property type that might be managable</param>
        bool IsManagingProperty(Type propertyType);
        /// <summary>
        /// Determine if item data type is managable
        /// </summary>
        /// <param name="propertyData">Item data type that might be managable</param>
        bool IsManagingData(Type dataType);
        /// <summary>
        /// Get all unique item identifiers of managed items
        /// </summary>
        /// <returns></returns>
        List<Guid> GetItemIds();
        /// <summary>
        /// Execute a use item request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="user"></param>
        /// <returns>Description of error, or null on success</returns>
        string UseItem(CoreUseItemRequest request, Item user, ITerminal terminal, IResponse response);
        /// <summary>
        /// Append attribute to base item when it is loaded
        /// </summary>
        /// <param name="item">Base item just read from datastore</param>
        void OnItemRead(Item item);
        /// <summary>
        /// Create attribute, if present, after item is created
        /// </summary>
        /// <param name="item">Base item just created from datastore</param>
        void OnItemCreate(Item item);
        /// <summary>
        /// Append attribute to base item when it is loaded
        /// </summary>
        /// <param name="item">Base item about to be persisted to datastore</param>
        void OnItemUpdate(Item item);
        /// <summary>
        /// Delete attribute of base item before base item is deleted
        /// </summary>
        /// <param name="item">Base item about to be deleted</param>
        void OnItemDelete(Item item);
    }
}
