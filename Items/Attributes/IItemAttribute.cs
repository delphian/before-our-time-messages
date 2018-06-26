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
    }
}
