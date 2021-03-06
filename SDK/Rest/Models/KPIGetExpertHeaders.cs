// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for GetExpert operation.
    /// </summary>
    public partial class KPIGetExpertHeaders
    {
        /// <summary>
        /// Initializes a new instance of the KPIGetExpertHeaders class.
        /// </summary>
        public KPIGetExpertHeaders() { }

        /// <summary>
        /// Initializes a new instance of the KPIGetExpertHeaders class.
        /// </summary>
        public KPIGetExpertHeaders(string contentType = default(string), string location = default(string))
        {
            ContentType = contentType;
            Location = location;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
