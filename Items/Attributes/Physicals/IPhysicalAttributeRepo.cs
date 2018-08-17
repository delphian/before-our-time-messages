using BeforeOurTime.Models;
using BeforeOurTime.Models.Items.Attributes;
using BeforeOurTime.Models.Items.Attributes.Physicals;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes.Physicals
{
    /// <summary>
    /// Central data repository for all physical attributes
    /// </summary>
    public interface IPhysicalAttributeRepo : IRepository<PhysicalAttribute>, IAttributeRepo<PhysicalAttribute>
    {
    }
}
