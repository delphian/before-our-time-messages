using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models
{
    /// <summary>
    /// Options to customize CRUD operation
    /// </summary>
    public class TransactionOptions
    {
        /// <summary>
        /// Do not allow entity framework to track this entity
        /// </summary>
        public bool NoTracking { set; get; } = false;
    }
}
