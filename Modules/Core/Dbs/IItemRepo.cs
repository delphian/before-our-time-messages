using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Dbs
{
    /// <summary>
    /// Delegate definition required of attribute repositories to perform 
    /// action after item is created
    /// </summary>
    public delegate void onItemCreate(Item item);
    /// <summary>
    /// Delegate definition required of attribute repositories to perform 
    /// action before item is returned
    /// </summary>
    public delegate void onItemRead(Item item);
    /// <summary>
    /// Delegate definition required of attribute repositories to perform 
    /// action before item is updated
    /// </summary>
    public delegate void onItemUpdate(Item item);
    /// <summary>
    /// Delegate definition required of attribute repositories to perform 
    /// action before item is deleted
    /// </summary>
    public delegate void onItemDelete(Item item);
    /// <summary>
    /// Datastore operations for Items
    /// </summary>
    public interface IItemRepo : ICrudModelRepository<Item>
    {
        /// <summary>
        /// Item attribute repositories may attach to this event to perform action after item is created
        /// </summary>
        /// <remarks>
        /// Actions may include altering item properties or creating and persisting an item attribute
        /// </remarks>
        event onItemCreate OnItemCreate;
        /// <summary>
        /// Item attribute repositories may attach to this event to perform action before item is returned
        /// </summary>
        /// <remarks>
        /// Actions may include altering item properties or adding an item attribute
        /// </remarks>
        event onItemRead OnItemRead;
        /// <summary>
        /// Item attribute repositories may attach to this event to perform action before item is updated
        /// </summary>
        /// <remarks>
        /// Actions may include saving their own attribute property values
        /// </remarks>
        event onItemUpdate OnItemUpdate;
        /// <summary>
        /// Item attribute repositories may attach to this event to perform action before item is deleted
        /// </summary>
        /// <remarks>
        /// Actions may include deleting attributes
        /// </remarks>
        event onItemDelete OnItemDelete;
        /// <summary>
        /// Get the item identifiers of all item's children
        /// </summary>
        /// <param name="itemId">Unique item identifier of potential parent</param>
        /// <returns></returns>
        List<Guid> GetChildrenIds(Guid itemId);
    }
}
