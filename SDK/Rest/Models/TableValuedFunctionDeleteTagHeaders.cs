// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for DeleteTag operation.
    /// </summary>
    public partial class TableValuedFunctionDeleteTagHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TableValuedFunctionDeleteTagHeaders class.
        /// </summary>
        public TableValuedFunctionDeleteTagHeaders() { }

        /// <summary>
        /// Initializes a new instance of the
        /// TableValuedFunctionDeleteTagHeaders class.
        /// </summary>
        public TableValuedFunctionDeleteTagHeaders(string xMsRequestId = default(string), string location = default(string))
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
