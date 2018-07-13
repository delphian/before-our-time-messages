using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Primitives.Images
{
    /// <summary>
    /// Interpret the image value as a recoure identifier or the resource itself
    /// </summary>
    public enum ImageLocation : int
    {
        /// <summary>
        /// An impossible condition
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// The contents of value is the image itself
        /// </summary>
        Inline = 100,
        /// <summary>
        /// Universal resource locator
        /// </summary>
        Url = 200
    }
}
