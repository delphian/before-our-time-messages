using BeforeOurTime.Models.ItemAttributes;
using BeforeOurTime.Models.ItemAttributes.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Locations
{
    /// <summary>
    /// Central data repository for all location items
    /// </summary>
    public interface ILocationAttributeRepo : IAttributeRepo<LocationAttribute>
    {
    }
}
