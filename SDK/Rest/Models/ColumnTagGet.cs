// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Tagging a column
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ColumnTagGet : SystemProperty
    {
        /// <summary>
        /// Initializes a new instance of the ColumnTagGet class.
        /// </summary>
        public ColumnTagGet() { }

        /// <summary>
        /// Initializes a new instance of the ColumnTagGet class.
        /// </summary>
        /// <param name="columnName">columnName property</param>
        /// <param name="tag">tag property</param>
        /// <param name="fromSourceSystem">fromSourceSystem property</param>
        /// <param name="key">key property</param>
        /// <param name="id">Id property</param>
        /// <param name="etag">ETag property</param>
        /// <param name="timestamp">Timestamp property</param>
        /// <param name="effectiveRights">EffectiveRights property</param>
        /// <param name="resultSetIndex">resultSetIndex property</param>
        public ColumnTagGet(string columnName, string tag, bool fromSourceSystem, string key, string id = default(string), string etag = default(string), string timestamp = default(string), System.Collections.Generic.IList<RightsItems?> effectiveRights = default(System.Collections.Generic.IList<RightsItems?>), int? resultSetIndex = default(int?), System.Collections.Generic.IList<RolesItem> roles = default(System.Collections.Generic.IList<RolesItem>))
            : base(id, etag, timestamp, effectiveRights)
        {
            ResultSetIndex = resultSetIndex;
            ColumnName = columnName;
            Tag = tag;
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
        /// Gets or sets tag property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tag")]
        public string Tag { get; set; }

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
            if (Tag == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Tag");
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
