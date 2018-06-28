using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes
{
    /// <summary>
    /// Additional information wrapping, but based on an item's type
    /// </summary>
    public interface IItemAttribute
    {
        /// <summary>
        /// Get item to which detail information is attached
        /// </summary>
        /// <returns></returns>
        Item GetItem();
        /// <summary>
        /// Modify the item name before it is returned
        /// </summary>
        /// <param name="name">Previous name of item</param>
        /// <returns></returns>
        string GetName(string name);
        /// <summary>
        /// Modify the item description before it is returned
        /// </summary>
        /// <param name="name">Previous description of item</param>
        /// <returns></returns>
        string GetDescription(string description);
    }
}
