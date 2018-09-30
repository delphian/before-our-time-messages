using BeforeOurTime.Models.Modules.Account.Models.Data;
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
    }
}
