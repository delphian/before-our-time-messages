using BeforeOurTime.Models.ItemAttributes;
using BeforeOurTime.Models.ItemAttributes.Exits;
using BeforeOurTime.Models.ItemAttributes.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Exits
{
    /// <summary>
    /// Central data repository for all exit items
    /// </summary>
    public interface IExitAttributeRepo : IAttributeRepo<ExitAttribute>
    {
        /// <summary>
        /// Read all exit attributes that target the same destination
        /// </summary>
        /// <param name="locationAttribute">Location that is the destination</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        /// <returns></returns>
        List<ExitAttribute> ReadWithDestination(
            LocationAttribute locationAttribute,
            TransactionOptions options = null);
    }
}
