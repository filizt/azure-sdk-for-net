// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description of a namespace resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NHNamespace : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the NHNamespace class.
        /// </summary>
        public NHNamespace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NHNamespace class.
        /// </summary>
        /// <param name="location">The Geo-location where the resource
        /// lives</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">Porperties of Sku</param>
        /// <param name="provisioningState">Provisioning state of the
        /// namespace.</param>
        /// <param name="createdAt">The time the namespace was created.</param>
        /// <param name="updatedAt">The time the namespace was updated.</param>
        /// <param name="notificationHubsEndpoint">Endpoint you can use to
        /// perform Notification Hubs operations.</param>
        /// <param name="metricId">Identifier for Azure Insights
        /// metrics</param>
        public NHNamespace(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), NHSku sku = default(NHSku), string provisioningState = default(string), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), string notificationHubsEndpoint = default(string), string metricId = default(string))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            ProvisioningState = provisioningState;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            NotificationHubsEndpoint = notificationHubsEndpoint;
            MetricId = metricId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets porperties of Sku
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public NHSku Sku { get; set; }

        /// <summary>
        /// Gets provisioning state of the namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the time the namespace was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets the time the namespace was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets endpoint you can use to perform Notification Hubs operations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notificationHubsEndpoint")]
        public string NotificationHubsEndpoint { get; private set; }

        /// <summary>
        /// Gets identifier for Azure Insights metrics
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricId")]
        public string MetricId { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
