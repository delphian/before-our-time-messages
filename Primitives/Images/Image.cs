using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Primitives.Images
{
    /// <summary>
    /// Wrapper for image that allows meta data
    /// </summary>
    public class Image : Model
    {
        /// <summary>
        /// Type of image (jpg, gif, etc...)
        /// </summary>
        [JsonProperty(PropertyName = "type", Order = 100)]
        public ImageType Type { set; get; }
        /// <summary>
        /// Interpret the image value as a resource identifier or the resource itself
        /// </summary>
        [JsonProperty(PropertyName = "location", Order = 110)]
        public ImageLocation Location { set; get; }
        /// <summary>
        /// Value has been gzipped
        /// </summary>
        [JsonProperty(PropertyName = "gzipped", Order = 120)]
        public bool Gzipped { set; get; }
        /// <summary>
        /// Value has been base64 encoded
        /// </summary>
        [JsonProperty(PropertyName = "base64", Order = 130)]
        public bool Base64 { set; get; }
        /// <summary>
        /// Image data
        /// </summary>
        [JsonProperty(PropertyName = "value", Order = 200)]
        public string Value { set; get; }
    }
}
