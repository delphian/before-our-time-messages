using BeforeOurTime.Models.Accounts.Authentication;
using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models.Accounts;
using BeforeOurTime.Models;

namespace BeforeOurTime.Repository.Models.Accounts
{
    public interface IAccountRepo : IRepository<Account>
    {
        /// <summary>
        /// Read accounts by login credentials
        /// </summary>
        /// <param name="request">User credentials that may be used for an authentication request</param>
        /// <returns></returns>
        List<Account> Read(AuthenticationRequest request);
    }
}
