using BeforeOurTime.Models.Modules.Account.Models;
using BeforeOurTime.Models.Modules.Account.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Dbs
{
    public interface IAccountDataRepo : ICrudModelRepository, ICrudModelRepository<AccountData>
    {
        /// <summary>
        /// Read accounts by login credentials
        /// </summary>
        /// <param name="request">User credentials that may be used for an authentication request</param>
        /// <returns></returns>
        AccountData Read(AuthenticationRequest request);
    }
}
