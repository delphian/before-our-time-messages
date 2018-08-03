using BeforeOurTime.Models.Items.Attributes;
using BeforeOurTime.Models.Items.Attributes.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes.Locations
{
    /// <summary>
    /// Central data repository for all location items
    /// </summary>
    public interface IAttributeLocationRepo : IAttributeRepo<LocationAttribute>
    {
    }
}
