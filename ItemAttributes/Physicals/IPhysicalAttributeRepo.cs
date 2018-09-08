using BeforeOurTime.Models;
using BeforeOurTime.Models.ItemAttributes;
using BeforeOurTime.Models.ItemAttributes.Physicals;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Physicals
{
    /// <summary>
    /// Central data repository for all physical attributes
    /// </summary>
    public interface IPhysicalAttributeRepo : IRepository<PhysicalAttribute>, IAttributeRepo<PhysicalAttribute>
    {
    }
}
