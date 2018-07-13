using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace BeforeOurTime.Models
{
    /// <summary>
    /// All models inherit from this
    /// </summary>
    public class Model
    {
        private Guid _id { set; get; }
        /// <summary>
        /// Unique identifier
        /// </summary>
        [JsonProperty(PropertyName = "id", Order = 10)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid Id
        {
            set { _id = value; }
            get
            {
                if (_id == null)
                {
                    _id = Guid.NewGuid();
                }
                return _id;
            }
        }
        /// <summary>
        /// Compress and base64 encode a string
        /// </summary>
        /// <param name="text">Normal string</param>
        /// <returns></returns>
        public static string Compress(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            byte[] raw = Encoding.UTF8.GetBytes(text);
            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory,
                    CompressionMode.Compress, true))
                {
                    gzip.Write(raw, 0, raw.Length);
                }
                return Convert.ToBase64String(memory.ToArray());
            }
        }
        /// <summary>
        /// Decompress a string that was compressed and then base64 encoded
        /// </summary>
        /// <param name="compressedText">Compressed and base64 encoded string</param>
        /// <returns></returns>
        public static string Decompress(string compressedText)
        {
            if (string.IsNullOrEmpty(compressedText))
                return "";
            byte[] gzip = Convert.FromBase64String(compressedText);
            // Create a GZIP stream with decompression mode.
            // ... Then create a buffer and write into while reading from the GZIP stream.
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip),
                CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return Encoding.UTF8.GetString(memory.ToArray());
                }
            }
        }
    }
}
