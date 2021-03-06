// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Parameter format
    /// </summary>
    public partial class Parameter
    {
        /// <summary>
        /// Initializes a new instance of the Parameter class.
        /// </summary>
        public Parameter() { }

        /// <summary>
        /// Initializes a new instance of the Parameter class.
        /// </summary>
        /// <param name="name">name property</param>
        /// <param name="type">type property</param>
        /// <param name="mode">mode property</param>
        /// <param name="precision">precision property</param>
        /// <param name="isNullable">isNullable property</param>
        /// <param name="maxLength">maxLength property</param>
        /// <param name="defaultValue">defaultValue property</param>
        public Parameter(string name, string type, string mode, string precision = default(string), bool? isNullable = default(bool?), int? maxLength = default(int?), string defaultValue = default(string))
        {
            Name = name;
            Type = type;
            Precision = precision;
            Mode = mode;
            IsNullable = isNullable;
            MaxLength = maxLength;
            DefaultValue = defaultValue;
        }

        /// <summary>
        /// Gets or sets name property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets type property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets precision property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "precision")]
        public string Precision { get; set; }

        /// <summary>
        /// Gets or sets mode property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets isNullable property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isNullable")]
        public bool? IsNullable { get; set; }

        /// <summary>
        /// Gets or sets maxLength property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxLength")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Gets or sets defaultValue property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (Type == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Type");
            }
            if (Mode == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Mode");
            }
        }
    }
}
