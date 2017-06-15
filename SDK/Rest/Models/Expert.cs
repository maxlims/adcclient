// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// The data steward of the asset
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Expert
    {
        /// <summary>
        /// Initializes a new instance of the Expert class.
        /// </summary>
        public Expert() { }

        /// <summary>
        /// Initializes a new instance of the Expert class.
        /// </summary>
        /// <param name="expertProperty">expert property</param>
        /// <param name="fromSourceSystem">fromSourceSystem property</param>
        /// <param name="key">key property</param>
        public Expert(ExpertBodyExpert expertProperty, bool fromSourceSystem, string key, System.Collections.Generic.IList<RolesItem> roles = default(System.Collections.Generic.IList<RolesItem>))
        {
            ExpertProperty = expertProperty;
            FromSourceSystem = fromSourceSystem;
            Key = key;
            Roles = roles;
        }

        /// <summary>
        /// Gets or sets expert property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.expert")]
        public ExpertBodyExpert ExpertProperty { get; set; }

        /// <summary>
        /// Gets or sets fromSourceSystem property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.fromSourceSystem")]
        public bool FromSourceSystem { get; set; }

        /// <summary>
        /// Gets or sets key property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.key")]
        public string Key { get; set; }

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
            if (ExpertProperty == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ExpertProperty");
            }
            if (Key == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Key");
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
