using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.Create
{
    public class CreatePlayerRequest : Request, IRequest
    {
        /// <summary>
        /// Name of player
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CreatePlayerRequest()
        {
            this.MessageId = new Guid("233f84d1-8734-4429-a155-27bdd473ab66");
            this.MessageName = "Create Player Request";
        }
    }
}
