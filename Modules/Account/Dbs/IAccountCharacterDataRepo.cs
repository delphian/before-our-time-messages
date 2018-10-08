using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Modules.Account.Models;
using BeforeOurTime.Models.Modules.Account.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Dbs
{
    public interface IAccountCharacterDataRepo : ICrudModelRepository, ICrudModelRepository<AccountCharacterData>
    {
        /// <summary>
        /// Read all account character item identifiers associated with an account 
        /// </summary>
        /// <param name="accountIds"></param>
        /// <returns></returns>
        List<AccountCharacterData> ReadByAccount(List<Guid> accountIds);
    }
}
