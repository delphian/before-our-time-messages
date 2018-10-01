﻿using BeforeOurTime.Models.Apis;
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
        AccountData Create(string name, string password);
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
        /// <param name="api"></param>
        /// <param name="message"></param>
        /// <param name="terminal"></param>
        /// <param name="response"></param>
        IResponse HandleCreateAccountRequest(IMessage message, IApi api, ITerminal terminal, IResponse response);
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="api"></param>
        /// <param name="message"></param>
        /// <param name="terminal"></param>
        /// <param name="response"></param>
        IResponse HandleLoginAccountRequest(IMessage message, IApi api, ITerminal terminal, IResponse response);
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="api"></param>
        /// <param name="message"></param>
        /// <param name="terminal"></param>
        /// <param name="response"></param>
        IResponse HandleLogoutAccountRequest(IMessage message, IApi api, ITerminal terminal, IResponse response);
    }
}
