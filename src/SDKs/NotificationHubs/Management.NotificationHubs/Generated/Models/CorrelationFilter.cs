// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the correlation filter expression.
    /// </summary>
    public partial class CorrelationFilter
    {
        /// <summary>
        /// Initializes a new instance of the CorrelationFilter class.
        /// </summary>
        public CorrelationFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CorrelationFilter class.
        /// </summary>
        /// <param name="properties">dictionary object for custom
        /// filters</param>
        /// <param name="correlationId">Identifier of the correlation.</param>
        /// <param name="messageId">Identifier of the message.</param>
        /// <param name="to">Address to send to.</param>
        /// <param name="replyTo">Address of the notificationhub to reply
        /// to.</param>
        /// <param name="label">Application specific label.</param>
        /// <param name="sessionId">Session identifier.</param>
        /// <param name="replyToSessionId">Session identifier to reply
        /// to.</param>
        /// <param name="contentType">Content type of the message.</param>
        /// <param name="requiresPreprocessing">Value that indicates whether
        /// the rule action requires preprocessing.</param>
        public CorrelationFilter(IDictionary<string, string> properties = default(IDictionary<string, string>), string correlationId = default(string), string messageId = default(string), string to = default(string), string replyTo = default(string), string label = default(string), string sessionId = default(string), string replyToSessionId = default(string), string contentType = default(string), bool? requiresPreprocessing = default(bool?))
        {
            Properties = properties;
            CorrelationId = correlationId;
            MessageId = messageId;
            To = to;
            ReplyTo = replyTo;
            Label = label;
            SessionId = sessionId;
            ReplyToSessionId = replyToSessionId;
            ContentType = contentType;
            RequiresPreprocessing = requiresPreprocessing;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets dictionary object for custom filters
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets identifier of the correlation.
        /// </summary>
        [JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets identifier of the message.
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets address to send to.
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }

        /// <summary>
        /// Gets or sets address of the notificationhub to reply to.
        /// </summary>
        [JsonProperty(PropertyName = "replyTo")]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Gets or sets application specific label.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets session identifier.
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or sets session identifier to reply to.
        /// </summary>
        [JsonProperty(PropertyName = "replyToSessionId")]
        public string ReplyToSessionId { get; set; }

        /// <summary>
        /// Gets or sets content type of the message.
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets value that indicates whether the rule action requires
        /// preprocessing.
        /// </summary>
        [JsonProperty(PropertyName = "requiresPreprocessing")]
        public bool? RequiresPreprocessing { get; set; }

    }
}
