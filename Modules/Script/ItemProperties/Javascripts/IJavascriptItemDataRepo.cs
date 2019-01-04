using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Script.ItemProperties.Javascripts
{
    /// <summary>
    /// Central data repository for all exit items
    /// </summary>
    public interface IJavascriptItemDataRepo : ICrudItemModelRepository<JavascriptItemData>
    {
        /// <summary>
        /// Read associated javascript data of item
        /// </summary>
        /// <param name="item">Item that may have associated data</param>
        /// <returns></returns>
        JavascriptItemData Read(Item item);
    }
}
