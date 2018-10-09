using BeforeOurTime.Business.Apis.Items.Attributes;
using BeforeOurTime.Models;
using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.ItemAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeforeOurTime.Models.Modules.Core.Models.Data;

namespace BeforeOurTime.Models
{
    /// <summary>
    /// Manage details of an item's extended attributes
    /// </summary>
    public abstract class ItemModelManager<T> : ModelManager<T> where T : Item
    {
        /// <summary>
        /// Determine if an item has dat that may be managed
        /// </summary>
        /// <param name="item">Item that may have managable data</param>
        public bool IsManaging(Item item)
        {
            return item is T;
        }
    }
}
