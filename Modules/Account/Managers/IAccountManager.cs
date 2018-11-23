using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Account.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Terminal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Managers
{
    public interface IAccountManager : IModelManager
    {
        /// <summary>
        /// Attach terminal data to item
        /// </summary>
        /// <param name="item"></param>
        void OnItemRead(Item item);
        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="name">Login name</param>
        /// <param name="password">Login password</param>
        /// <param name="temporary">Account is temporary for trial purposes</param>
        /// <param name="admin">Account has administrative rights</param>
        AccountData Create(
            string name, 
            string password, 
            bool temporary = false,
            bool admin = false);
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
        /// Update account password
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="mm">Module manager</param>
        /// <param name="response"></param>
        IResponse HandleUpdatePasswordRequest(
            IMessage message,
            Item origin,
            IModuleManager mm,
            IResponse response);
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="mm">Module manager</param>
        /// <param name="response"></param>
        IResponse HandleCreateAccountRequest(
            IMessage message,
            Item origin,
            IModuleManager mm,
            IResponse response);
        /// <summary>
        /// Read account data endpoint
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="mm">Module manager</param>
        /// <param name="response"></param>
        IResponse HandleReadAccountRequest(
            IMessage message,
            Item origin,
            IModuleManager mm,
            IResponse response);
        /// <summary>
        /// Read account data json endpoint
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="mm">Module manager</param>
        /// <param name="response"></param>
        IResponse HandleJsonReadAccountRequest(
            IMessage message,
            Item origin,
            IModuleManager mm,
            IResponse response);
        /// <summary>
        /// Update account endpoint
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="mm">Module manager</param>
        /// <param name="response"></param>
        IResponse HandleUpdateAccountRequest(
            IMessage message,
            Item origin,
            IModuleManager mm,
            IResponse response);
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="mm">Module manager</param>
        /// <param name="response"></param>
        IResponse HandleLoginAccountRequest(
            IMessage message,
            Item origin,
            IModuleManager mm,
            IResponse response);
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="mm">Module manager</param>
        /// <param name="response"></param>
        IResponse HandleLogoutAccountRequest(
            IMessage message,
            Item origin,
            IModuleManager mm,
            IResponse response);
        /// <summary>
        /// Erase all accounts and restore from backup json data
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="mm">Module manager</param>
        /// <param name="response"></param>
        IResponse HandleJsonRestoreAccountRequest(
            IMessage message,
            Item origin,
            IModuleManager mm,
            IResponse response);
    }
}
