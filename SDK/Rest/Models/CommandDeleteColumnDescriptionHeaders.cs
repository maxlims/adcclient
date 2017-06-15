// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for DeleteColumnDescription operation.
    /// </summary>
    public partial class CommandDeleteColumnDescriptionHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CommandDeleteColumnDescriptionHeaders class.
        /// </summary>
        public CommandDeleteColumnDescriptionHeaders() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CommandDeleteColumnDescriptionHeaders class.
        /// </summary>
        public CommandDeleteColumnDescriptionHeaders(string xMsRequestId = default(string), string location = default(string))
        {
            XMsRequestId = xMsRequestId;
            Location = location;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "x-ms-request-id")]
        public string XMsRequestId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
