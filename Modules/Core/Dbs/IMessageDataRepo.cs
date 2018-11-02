using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Dbs
{
    /// <summary>
    /// Datastore operations for Items
    /// </summary>
    public interface IMessageDataRepo : ICrudModelRepository<MessageData>
    {
    }
}
