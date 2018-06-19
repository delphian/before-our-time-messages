using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.List
{
    /// <summary>
    /// Describe a location and enumerate essential properties
    /// </summary>
    public class ListLocationResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        public static Guid _Id = new Guid("e8de221a-381a-45f3-898f-ca12e1badad1");
        /// <summary>
        /// Unique location item identifier
        /// </summary>
        public Guid ItemId { set; get; }
        /// <summary>
        /// Short name of location
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// Longer paragraph description of location
        /// </summary>
        public string Description { set; get; }
        /// <summary>
        /// Background image for location
        /// </summary>
        public string Image { set; get; }
        /// <summary>
        /// Potential exits from the location
        /// </summary>
        public List<ListExitResponse> Exits = new List<ListExitResponse>();
        /// <summary>
        /// Additional descrete textual adendums to the description
        /// </summary>
        public List<string> Adendums = new List<string>();
        /// <summary>
        /// Constructor
        /// </summary>
        public ListLocationResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Location Response";
        }
    }
}
