// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Descriptions of a column
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ColumnDescription
    {
        /// <summary>
        /// Initializes a new instance of the ColumnDescription class.
        /// </summary>
        public ColumnDescription() { }

        /// <summary>
        /// Initializes a new instance of the ColumnDescription class.
        /// </summary>
        /// <param name="columnName">columnName property</param>
        /// <param name="description">description property</param>
        /// <param name="fromSourceSystem">fromSourceSystem property</param>
        /// <param name="key">key property</param>
        /// <param name="resultSetIndex">resultSetIndex property</param>
        public ColumnDescription(string columnName, string description, bool fromSourceSystem, string key, int? resultSetIndex = default(int?), System.Collections.Generic.IList<RolesItem> roles = default(System.Collections.Generic.IList<RolesItem>))
        {
            ResultSetIndex = resultSetIndex;
            ColumnName = columnName;
            Description = description;
            FromSourceSystem = fromSourceSystem;
            Key = key;
            Roles = roles;
        }

        /// <summary>
        /// Gets or sets resultSetIndex property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resultSetIndex")]
        public int? ResultSetIndex { get; set; }

        /// <summary>
        /// Gets or sets columnName property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.columnName")]
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or sets description property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

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
            if (ColumnName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ColumnName");
            }
            if (Description == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Description");
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
