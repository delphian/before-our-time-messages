using BeforeOurTime.Models;
using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Accounts.Authorization
{
    /// <summary>
    /// Security role membership record. Assigns a role membership to a group
    /// </summary>
    /// <remarks>
    /// A linking table between groups and roles
    /// </remarks>
    public class AuthorizationGroupRole : Model
    {
        /// <summary>
        /// Security role grants permission to perform specific operations
        /// </summary>
        [JsonProperty(PropertyName = "roleId")]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid RoleId { set; get; }
        [JsonIgnore]
        public virtual AuthorizationRole Role { set; get; }
        /// <summary>
        /// Group of security roles that may be applied to an account through membership
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid GroupId { set; get; }
        [JsonIgnore]
        public virtual AuthorizationGroup Group { set; get; }
    }
}
