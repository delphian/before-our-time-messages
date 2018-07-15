using BeforeOurTime.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Accounts.Authorization
{
    /// <summary>
    /// Security role grants permission to perform specific operations
    /// </summary>
    /// <remarks>
    /// Roles are not assigned to accounts directly, but rather collected
    /// into groups, such as the 'admin' group. Group membership is then
    /// assigned to accounts.
    /// </remarks>
    public class AuthorizationRole : Model
    {
        /// <summary>
        /// Human friendly name of security role
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 100)]
        public string Name { set; get; }
        /// <summary>
        /// Unique machine friendly name of role. Used in automated [Authorized] tags
        /// </summary>
        [JsonProperty(PropertyName = "nameUnique", Order = 200)]
        public string NameUnique { set; get; }
    }
}
