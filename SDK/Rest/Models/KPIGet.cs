// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// KPI assets
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class KPIGet : SystemProperty
    {
        /// <summary>
        /// Initializes a new instance of the KPIGet class.
        /// </summary>
        public KPIGet() { }

        /// <summary>
        /// Initializes a new instance of the KPIGet class.
        /// </summary>
        /// <param name="name">name property</param>
        /// <param name="fromSourceSystem">fromSourceSystem property</param>
        /// <param name="id">Id property</param>
        /// <param name="etag">ETag property</param>
        /// <param name="timestamp">Timestamp property</param>
        /// <param name="effectiveRights">EffectiveRights property</param>
        /// <param name="containerId">containerId property</param>
        /// <param name="goalExpression">goalExpression property</param>
        /// <param name="valueExpression">valueExpression property</param>
        /// <param name="statusExpression">statusExpression property</param>
        /// <param name="trendExpression">trendExpression property</param>
        /// <param name="measureGroup">measureGroup property</param>
        /// <param name="descriptions">Description property, used to describe
        /// assets</param>
        /// <param name="experts">The data steward of the asset</param>
        /// <param name="tags">Taging the asset</param>
        /// <param name="termTags">Taging the asset using glossary terms, this
        /// is a feature only for standard SKU</param>
        public KPIGet(string name, Dsl dsl, DataSource dataSource, LastRegisteredBy lastRegisteredBy, bool fromSourceSystem, string id = default(string), string etag = default(string), string timestamp = default(string), System.Collections.Generic.IList<RightsItems?> effectiveRights = default(System.Collections.Generic.IList<RightsItems?>), System.Collections.Generic.IList<RolesItem> roles = default(System.Collections.Generic.IList<RolesItem>), double? containerId = default(double?), string goalExpression = default(string), string valueExpression = default(string), string statusExpression = default(string), string trendExpression = default(string), string measureGroup = default(string), System.Collections.Generic.IList<Description> descriptions = default(System.Collections.Generic.IList<Description>), System.Collections.Generic.IList<Expert> experts = default(System.Collections.Generic.IList<Expert>), AccessInstruction accessInstructions = default(AccessInstruction), Documentation documentation = default(Documentation), FriendlyName friendlyName = default(FriendlyName), System.Collections.Generic.IList<Tag> tags = default(System.Collections.Generic.IList<Tag>), System.Collections.Generic.IList<TermTag> termTags = default(System.Collections.Generic.IList<TermTag>))
            : base(id, etag, timestamp, effectiveRights)
        {
            Roles = roles;
            Name = name;
            Dsl = dsl;
            DataSource = dataSource;
            LastRegisteredBy = lastRegisteredBy;
            FromSourceSystem = fromSourceSystem;
            ContainerId = containerId;
            GoalExpression = goalExpression;
            ValueExpression = valueExpression;
            StatusExpression = statusExpression;
            TrendExpression = trendExpression;
            MeasureGroup = measureGroup;
            Descriptions = descriptions;
            Experts = experts;
            AccessInstructions = accessInstructions;
            Documentation = documentation;
            FriendlyName = friendlyName;
            Tags = tags;
            TermTags = termTags;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "roles")]
        public System.Collections.Generic.IList<RolesItem> Roles { get; set; }

        /// <summary>
        /// Gets or sets name property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dsl")]
        public Dsl Dsl { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dataSource")]
        public DataSource DataSource { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lastRegisteredBy")]
        public LastRegisteredBy LastRegisteredBy { get; set; }

        /// <summary>
        /// Gets or sets fromSourceSystem property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.fromSourceSystem")]
        public bool FromSourceSystem { get; set; }

        /// <summary>
        /// Gets or sets containerId property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.containerId")]
        public double? ContainerId { get; set; }

        /// <summary>
        /// Gets or sets goalExpression property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.goalExpression")]
        public string GoalExpression { get; set; }

        /// <summary>
        /// Gets or sets valueExpression property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.valueExpression")]
        public string ValueExpression { get; set; }

        /// <summary>
        /// Gets or sets statusExpression property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.statusExpression")]
        public string StatusExpression { get; set; }

        /// <summary>
        /// Gets or sets trendExpression property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.trendExpression")]
        public string TrendExpression { get; set; }

        /// <summary>
        /// Gets or sets measureGroup property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.measureGroup")]
        public string MeasureGroup { get; set; }

        /// <summary>
        /// Gets or sets description property, used to describe assets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.descriptions")]
        public System.Collections.Generic.IList<Description> Descriptions { get; set; }

        /// <summary>
        /// Gets or sets the data steward of the asset
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.experts")]
        public System.Collections.Generic.IList<Expert> Experts { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.accessInstructions")]
        public AccessInstruction AccessInstructions { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.documentation")]
        public Documentation Documentation { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.friendlyName")]
        public FriendlyName FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets taging the asset
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.tags")]
        public System.Collections.Generic.IList<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or sets taging the asset using glossary terms, this is a
        /// feature only for standard SKU
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.termTags")]
        public System.Collections.Generic.IList<TermTag> TermTags { get; set; }

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
            if (Dsl == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Dsl");
            }
            if (DataSource == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DataSource");
            }
            if (LastRegisteredBy == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "LastRegisteredBy");
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
            if (this.Dsl != null)
            {
                this.Dsl.Validate();
            }
            if (this.DataSource != null)
            {
                this.DataSource.Validate();
            }
            if (this.LastRegisteredBy != null)
            {
                this.LastRegisteredBy.Validate();
            }
            if (this.Descriptions != null)
            {
                foreach (var element1 in this.Descriptions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.Experts != null)
            {
                foreach (var element2 in this.Experts)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (this.AccessInstructions != null)
            {
                this.AccessInstructions.Validate();
            }
            if (this.Documentation != null)
            {
                this.Documentation.Validate();
            }
            if (this.FriendlyName != null)
            {
                this.FriendlyName.Validate();
            }
            if (this.Tags != null)
            {
                foreach (var element3 in this.Tags)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (this.TermTags != null)
            {
                foreach (var element4 in this.TermTags)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
        }
    }
}
