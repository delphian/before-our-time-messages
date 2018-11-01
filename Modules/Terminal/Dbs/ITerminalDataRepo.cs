using BeforeOurTime.Models.Modules.Terminal.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Dbs
{
    public interface ITerminalDataRepo : ICrudModelRepository, ICrudModelRepository<TerminalData>
    {
    }
}
