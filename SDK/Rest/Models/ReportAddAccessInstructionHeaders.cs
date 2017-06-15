// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for AddAccessInstruction operation.
    /// </summary>
    public partial class ReportAddAccessInstructionHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ReportAddAccessInstructionHeaders class.
        /// </summary>
        public ReportAddAccessInstructionHeaders() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ReportAddAccessInstructionHeaders class.
        /// </summary>
        public ReportAddAccessInstructionHeaders(string location = default(string), string xMsRequestId = default(string))
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
