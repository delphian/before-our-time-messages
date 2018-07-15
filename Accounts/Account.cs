using BeforeOurTime.Models.Accounts.Authorization;
using BeforeOurTime.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models.Accounts
{
    /// <summary>
    /// An account keeps track of a user's access to the system
    /// </summary>
    public class Account : Model
    {
        private List<AuthorizationGroup> _groups;
        /// <summary>
        /// Human friendly identifier for account
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 100)]
        public string Name { set; get; }
        /// <summary>
        /// Characters attached to account
        /// </summary>
        [JsonProperty(PropertyName = "characters", Order = 200)]
        public List<Item> Characters { set; get; } = new List<Item>();
        /// <summary>
        /// List of security group membership records. Assigns group membership to an account
        /// </summary>
        [JsonProperty(PropertyName = "groupLinks", Order = 300)]
        public List<AuthorizationAccountGroup> AccountGroups { set; get; }
        /// <summary>
        /// List of security groups assigned to account
        /// </summary>
        /// <remarks>
        /// Read only property for delivery to client
        /// </remarks>
        [JsonIgnore]
        public List<AuthorizationGroup> Groups
        {
            private set { }
            get
            {
                if (this._groups == null)
                {
                    this._groups = this.AccountGroups?.Select(x => x.Group).ToList();
                }
                return this._groups;
            }
        }
    }
}
