// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// The schema of the asset
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class CommandSchemaGet : SystemProperty
    {
        /// <summary>
        /// Initializes a new instance of the CommandSchemaGet class.
        /// </summary>
        public CommandSchemaGet() { }

        /// <summary>
        /// Initializes a new instance of the CommandSchemaGet class.
        /// </summary>
        /// <param name="parameterSet">parameterSet property</param>
        /// <param name="resultSets">resultSets property</param>
        /// <param name="fromSourceSystem">fromSourceSystem property</param>
        /// <param name="id">Id property</param>
        /// <param name="etag">ETag property</param>
        /// <param name="timestamp">Timestamp property</param>
        /// <param name="effectiveRights">EffectiveRights property</param>
        public CommandSchemaGet(CommandSchemaBodyParameterSet parameterSet, System.Collections.Generic.IList<ResultSet> resultSets, bool fromSourceSystem, string id = default(string), string etag = default(string), string timestamp = default(string), System.Collections.Generic.IList<RightsItems?> effectiveRights = default(System.Collections.Generic.IList<RightsItems?>), System.Collections.Generic.IList<RolesItem> roles = default(System.Collections.Generic.IList<RolesItem>))
            : base(id, etag, timestamp, effectiveRights)
        {
            ParameterSet = parameterSet;
            ResultSets = resultSets;
            FromSourceSystem = fromSourceSystem;
            Roles = roles;
        }

        /// <summary>
        /// Gets or sets parameterSet property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.parameterSet")]
        public CommandSchemaBodyParameterSet ParameterSet { get; set; }

        /// <summary>
        /// Gets or sets resultSets property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resultSets")]
        public System.Collections.Generic.IList<ResultSet> ResultSets { get; set; }

        /// <summary>
        /// Gets or sets fromSourceSystem property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.fromSourceSystem")]
        public bool FromSourceSystem { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "roles")]
        public System.Collections.Generic.IList<RolesItem> Roles { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ParameterSet == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ParameterSet");
            }
            if (ResultSets == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ResultSets");
            }
            if (this.ResultSets != null)
            {
                foreach (var element in this.ResultSets)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Roles != null)
            {
                foreach (var element1 in this.Roles)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
