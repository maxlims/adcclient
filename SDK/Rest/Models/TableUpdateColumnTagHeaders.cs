// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for UpdateColumnTag operation.
    /// </summary>
    public partial class TableUpdateColumnTagHeaders
    {
        /// <summary>
        /// Initializes a new instance of the TableUpdateColumnTagHeaders
        /// class.
        /// </summary>
        public TableUpdateColumnTagHeaders() { }

        /// <summary>
        /// Initializes a new instance of the TableUpdateColumnTagHeaders
        /// class.
        /// </summary>
        public TableUpdateColumnTagHeaders(string location = default(string), string xMsRequestId = default(string))
        {
            Location = location;
            XMsRequestId = xMsRequestId;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "x-ms-request-id")]
        public string XMsRequestId { get; set; }

    }
}