﻿using System;
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
        /// <summary>
        /// Modify the item image icon before it is returned
        /// </summary>
        /// <param name="imageIcon">Previous value of item image icon</param>
        /// <returns></returns>
        string GetImageIcon(string imageIcon);
        /// <summary>
        /// Get priority order of attribute in comparison to other attributes
        /// </summary>
        /// <remarks>
        /// Defaults to 1000. Higher number has higher priority and will be executed _last_
        /// </remarks>
        /// <returns></returns>
        int GetOrder();
    }
}
