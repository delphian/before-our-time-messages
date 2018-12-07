using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Properties;

namespace BeforeOurTime.Models.Modules.Core.Models.Data
{
    /// <summary>
    /// Additional information wrapping, but based on an item's type
    /// </summary>
    public interface IItemData
    {
        /// <summary>
        /// Execute a command that this data provides
        /// </summary>
        /// <param name="command">Command to be performed</param>
        /// <param name="user">Item that is initiating the command</param>
        /// <param name="moduleManager">Manager of all modules</param>
        void UseItem(ItemCommand command, Item user, IModuleManager moduleManager);
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
