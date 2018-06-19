using BeforeOurTime.Models.Messages.Events.Created;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.Create
{
    /// <summary>
    /// A player has been created
    /// </summary>
    public class CreatePlayerResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        public static Guid _Id = new Guid("ebb9c305-5902-4c59-97ce-6137eebbe472");
        /// <summary>
        /// Event message for player creation
        /// </summary>
        public CreatedPlayerEvent CreatedPlayerEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CreatePlayerResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Create Player Response";
        }
    }
}
