// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Access instructions are used to specify how to connect to the data
    /// source
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class AccessInstruction
    {
        /// <summary>
        /// Initializes a new instance of the AccessInstruction class.
        /// </summary>
        public AccessInstruction() { }

        /// <summary>
        /// Initializes a new instance of the AccessInstruction class.
        /// </summary>
        /// <param name="mimeType">mimeType property</param>
        /// <param name="fromSourceSystem">fromSourceSystem property</param>
        /// <param name="content">content property</param>
        public AccessInstruction(string mimeType, bool fromSourceSystem, string content = default(string), System.Collections.Generic.IList<RolesItem> roles = default(System.Collections.Generic.IList<RolesItem>))
        {
            MimeType = mimeType;
            Content = content;
            FromSourceSystem = fromSourceSystem;
            Roles = roles;
        }

        /// <summary>
        /// Gets or sets mimeType property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.mimeType")]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets content property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.content")]
        public string Content { get; set; }

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
            if (MimeType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "MimeType");
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