using BeforeOurTime.Models.Apis;
using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Account.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Terminals;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Managers
{
    public interface IAccountCharacterManager : IModelManager
    {
        /// <summary>
        /// Create a new account character
        /// </summary>
        /// <param name="accountId">Unique account identifer to create character for</param>
        /// <param name="name">Name of character</param>
        /// <param name="temporary">Character is for trial purpose only</param>
        /// <returns></returns>
        Item Create(Guid accountId, string name, bool temporary = false);
        /// <summary>
        /// Create a new account character based on an existing item
        /// </summary>
        /// <param name="accountId">Unique identifier of account</param>
        /// <param name="password">Unique identifier of item to register as account character</param>
        AccountCharacterData Create(Guid accountId, Guid characterItemId);
        /// <summary>
        /// Read all account characters for a single account
        /// </summary>
        /// <param name="accountId">Unique account identifier</param>
        /// <returns></returns>
        List<AccountCharacterData> ReadByAccount(Guid accountId);
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="mm">Module manager</param>
        /// <param name="terminal">Terminal that initiated request</param>
        /// <param name="response"></param>
        IResponse HandleReadCharacterRequest(
            IMessage message,
            IModuleManager mm,
            ITerminal terminal,
            IResponse response);
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="mm">Module manager</param>
        /// <param name="terminal">Terminal that initiated request</param>
        /// <param name="response"></param>
        IResponse HandleCreateCharacterRequest(
            IMessage message,
            IModuleManager mm,
            ITerminal terminal,
            IResponse response);
    }
}
