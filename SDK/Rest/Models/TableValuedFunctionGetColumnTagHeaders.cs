// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for GetColumnTag operation.
    /// </summary>
    public partial class TableValuedFunctionGetColumnTagHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TableValuedFunctionGetColumnTagHeaders class.
        /// </summary>
        public TableValuedFunctionGetColumnTagHeaders() { }

        /// <summary>
        /// Initializes a new instance of the
        /// TableValuedFunctionGetColumnTagHeaders class.
        /// </summary>
        public TableValuedFunctionGetColumnTagHeaders(string contentType = default(string), string location = default(string))
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
