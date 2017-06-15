// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for Register operation.
    /// </summary>
    public partial class KPIRegisterHeaders
    {
        /// <summary>
        /// Initializes a new instance of the KPIRegisterHeaders class.
        /// </summary>
        public KPIRegisterHeaders() { }

        /// <summary>
        /// Initializes a new instance of the KPIRegisterHeaders class.
        /// </summary>
        public KPIRegisterHeaders(string location = default(string))
        {
            Location = location;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
