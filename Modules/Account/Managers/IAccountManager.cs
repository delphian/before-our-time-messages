using BeforeOurTime.Models.Apis;
using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Account.Models.Data;
using BeforeOurTime.Models.Terminals;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Managers
{
    public interface IAccountManager : IModelManager
    {
        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="name">Login name</param>
        /// <param name="password">Login password</param>
        /// <param name="temporary">Account is temporary for trial purposes</param>
        AccountData Create(string name, string password, bool temporary = false);
        /// <summary>
        /// Update existing account
        /// </summary>
        /// <param name="accountData">AccountData containing updated properties</param>
        /// <returns></returns>
        AccountData Update(AccountData accountData);
        /// <summary>
        /// Authenticate a user name and password
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns>User account if authenticated, otherwise null</returns>
        AccountData Authenticate(string name, string password);
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="mm">Module manager</param>
        /// <param name="terminal">Terminal that initiated request</param>
        /// <param name="response"></param>
        IResponse HandleCreateAccountRequest(
            IMessage message,
            IModuleManager mm,
            ITerminal terminal,
            IResponse response);
        /// <summary>
        /// Update account endpoint
        /// </summary>
        /// <param name="message"></param>
        /// <param name="mm">Module manager</param>
        /// <param name="terminal">Terminal that initiated request</param>
        /// <param name="response"></param>
        IResponse HandleUpdateAccountRequest(
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
        IResponse HandleLoginAccountRequest(
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
        IResponse HandleLogoutAccountRequest(
            IMessage message,
            IModuleManager mm,
            ITerminal terminal,
            IResponse response);
    }
}
