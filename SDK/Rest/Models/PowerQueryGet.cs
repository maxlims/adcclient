// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Power query
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class PowerQueryGet : SystemProperty
    {
        /// <summary>
        /// Initializes a new instance of the PowerQueryGet class.
        /// </summary>
        public PowerQueryGet() { }

        /// <summary>
        /// Initializes a new instance of the PowerQueryGet class.
        /// </summary>
        /// <param name="queryShape">queryShape property</param>
        /// <param name="fromSourceSystem">fromSourceSystem property</param>
        /// <param name="id">Id property</param>
        /// <param name="etag">ETag property</param>
        /// <param name="timestamp">Timestamp property</param>
        /// <param name="effectiveRights">EffectiveRights property</param>
        public PowerQueryGet(string queryShape, bool fromSourceSystem, string id = default(string), string etag = default(string), string timestamp = default(string), System.Collections.Generic.IList<RightsItems?> effectiveRights = default(System.Collections.Generic.IList<RightsItems?>), System.Collections.Generic.IList<RolesItem> roles = default(System.Collections.Generic.IList<RolesItem>))
            : base(id, etag, timestamp, effectiveRights)
        {
            QueryShape = queryShape;
            FromSourceSystem = fromSourceSystem;
            Roles = roles;
        }

        /// <summary>
        /// Gets or sets queryShape property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.queryShape")]
        public string QueryShape { get; set; }

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
            if (QueryShape == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "QueryShape");
            }
            if (this.Roles != null)
            {
                foreach (var element in this.Roles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
