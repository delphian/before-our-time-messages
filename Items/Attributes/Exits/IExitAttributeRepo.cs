using BeforeOurTime.Models.Items.Attributes;
using BeforeOurTime.Models.Items.Attributes.Exits;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes.Exits
{
    /// <summary>
    /// Central data repository for all exit items
    /// </summary>
    public interface IExitAttributeRepo : IAttributeRepo<ExitAttribute>
    {
    }
}
