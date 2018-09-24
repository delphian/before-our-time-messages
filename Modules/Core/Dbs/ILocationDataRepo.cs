using BeforeOurTime.Models.Modules.Core.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Dbs
{
    /// <summary>
    /// Central data repository for all location items
    /// </summary>
    public interface ILocationDataRepo : ICrudDataRepository, ICrudDataRepository<LocationData>
    {
    }
}
