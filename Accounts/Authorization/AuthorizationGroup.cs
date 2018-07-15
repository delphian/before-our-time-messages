using BeforeOurTime.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models.Accounts.Authorization
{
    /// <summary>
    /// Group of security roles that may be applied to an account through membership
    /// </summary>
    public class AuthorizationGroup : Model
    {
        private List<AuthorizationRole> _roles;
        /// <summary>
        /// Human friendly name of group
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { set; get; }
        /// <summary>
        /// List of security group membership records. Assigns a group membership to an account
        /// </summary>
        // [JsonIgnore]
        // public List<AuthorizationAccountGroup> AccountGroups { set; get; }
        /// <summary>
        /// List of security role membership records. Assigns a role membership to a group
        /// </summary>
        [JsonProperty(PropertyName = "roleLinks")]
        public List<AuthorizationGroupRole> GroupRoles { set; get; }
        /// <summary>
        /// List of security roles assigned to group
        /// </summary>
        /// <remarks>
        /// Read only property for delivery to client
        /// </remarks>
        [JsonIgnore]
        [JsonProperty(PropertyName = "roles")]
        public List<AuthorizationRole> Roles {
            private set { }
            get
            {
                if (this._roles == null)
                {
                    this._roles = GroupRoles?.Select(x => x.Role).ToList();
                }
                return this._roles;
            }
        }
    }
}
