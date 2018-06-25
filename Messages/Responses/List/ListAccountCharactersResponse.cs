using BeforeOurTime.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.List
{
    public class ListAccountCharactersResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        public static Guid _Id = new Guid("11753eca-fd29-42ca-8af1-bc24908d29dd");
        /// <summary>
        /// List of character items that an account is able to use as avatars
        /// </summary>
        /// <remarks>
        /// These will be detached items (Db.Set.AsNoTracking()...)
        /// </remarks>
        public List<Item> AccountCharacters { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ListAccountCharactersResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "List Account Characters Response";
        }
    }
}
