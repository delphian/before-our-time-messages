using BeforeOurTime.Models;
using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Data;
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
        /// Get all unique item identifiers of managed items
        /// </summary>
        /// <returns></returns>
        List<Guid> GetItemIds();
        /// <summary>
        /// Append attribute to base item when it is loaded
        /// </summary>
        /// <param name="item">Base item just read from datastore</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        void OnItemRead(Item item, TransactionOptions options = null);
        /// <summary>
        /// Create attribute, if present, after item is created
        /// </summary>
        /// <param name="item">Base item just created from datastore</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        void OnItemCreate(Item item, TransactionOptions options = null);
        /// <summary>
        /// Append attribute to base item when it is loaded
        /// </summary>
        /// <param name="item">Base item about to be persisted to datastore</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        void OnItemUpdate(Item item, TransactionOptions options = null);
        /// <summary>
        /// Delete attribute of base item before base item is deleted
        /// </summary>
        /// <param name="item">Base item about to be deleted</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        void OnItemDelete(Item item, TransactionOptions options = null);
    }
}
