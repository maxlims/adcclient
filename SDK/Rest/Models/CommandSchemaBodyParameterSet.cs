// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// parameterSet property
    /// </summary>
    public partial class CommandSchemaBodyParameterSet
    {
        /// <summary>
        /// Initializes a new instance of the CommandSchemaBodyParameterSet
        /// class.
        /// </summary>
        public CommandSchemaBodyParameterSet() { }

        /// <summary>
        /// Initializes a new instance of the CommandSchemaBodyParameterSet
        /// class.
        /// </summary>
        /// <param name="parameters">parameters property</param>
        public CommandSchemaBodyParameterSet(System.Collections.Generic.IList<Parameter> parameters = default(System.Collections.Generic.IList<Parameter>))
        {
            Parameters = parameters;
        }

        /// <summary>
        /// Gets or sets parameters property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.IList<Parameter> Parameters { get; set; }

    }
}
