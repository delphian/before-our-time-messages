using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.UpdatePassword
{
    public class AccountUpdatePasswordRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("d0269393-51f4-472b-ad96-40761868addf");
        /// <summary>
        /// Account id to update
        /// </summary>
        [JsonProperty(PropertyName = "accountId", Order = 1000)]
        public Guid AccountId { set; get; }
        /// <summary>
        /// Old password
        /// </summary>
        [JsonProperty(PropertyName = "oldPassword", Order = 1100)]
        public string OldPassword { set; get; }
        /// <summary>
        /// New password
        /// </summary>
        [JsonProperty(PropertyName = "newPassword", Order = 1200)]
        public string NewPassword { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountUpdatePasswordRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Update Password Request";
        }
    }
}
