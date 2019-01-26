using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Core.Models.Items;

namespace BeforeOurTime.Models.Modules.Script.ItemProperties.Javascripts
{
    public interface IJavascriptItemDataManager : IItemModelManager
    {
        /// <summary>
        /// Read all javascript function definitions
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="mm">Module manager</param>
        /// <param name="response"></param>
        IResponse HandleReadJSDefinitionsRequest(
            IMessage message,
            Item origin,
            IModuleManager mm,
            IResponse response);
    }
}
