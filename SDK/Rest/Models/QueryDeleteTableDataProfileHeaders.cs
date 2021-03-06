// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for DeleteTableDataProfile operation.
    /// </summary>
    public partial class QueryDeleteTableDataProfileHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// QueryDeleteTableDataProfileHeaders class.
        /// </summary>
        public QueryDeleteTableDataProfileHeaders() { }

        /// <summary>
        /// Initializes a new instance of the
        /// QueryDeleteTableDataProfileHeaders class.
        /// </summary>
        public QueryDeleteTableDataProfileHeaders(string xMsRequestId = default(string), string location = default(string))
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
