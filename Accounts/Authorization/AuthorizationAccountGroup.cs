using BeforeOurTime.Models;
using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Accounts.Authorization
{
    /// <summary>
    /// Security group membership record. Assigns a group membership to an account
    /// </summary>
    public class AuthorizationAccountGroup : Model
    {
        /// <summary>
        /// Account that should be made member of group
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid AccountId { set; get; }
        [JsonIgnore]
        public virtual Account Account { set; get; }
        /// <summary>
        /// Group of security roles account is member of
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid GroupId { set; get; }
        [JsonIgnore]
        public virtual AuthorizationGroup Group { set; get; }
    }
}
