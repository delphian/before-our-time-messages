using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models
{
    public interface IModel
    {
        /// <summary>
        /// Copy all source properties into our properties
        /// </summary>
        /// <param name="source"></param>
        void Copy(object source);
    }
}
