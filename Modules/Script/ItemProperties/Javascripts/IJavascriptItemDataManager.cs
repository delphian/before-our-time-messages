using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Jint;

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
        /// <summary>
        /// Add a javascript function definition
        /// </summary>
        /// <param name="function"></param>
        void AddFunctionDefinition(JavascriptFunctionDefinition function);
        /// <summary>
        /// Execute a javascript function of an item
        /// </summary>
        /// <param name="item"></param>
        /// <param name="name"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        object ExecuteFunction(Item item, string name, params object[] parameters);
        Engine GetJSEngine();
    }
}
