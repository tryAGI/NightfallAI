
#nullable enable

namespace NightfallAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack")]
        public global::NightfallAI.SlackAlert? Slack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public global::NightfallAI.EmailAlert? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public global::NightfallAI.WebhookAlert? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertConfig" /> class.
        /// </summary>
        /// <param name="slack"></param>
        /// <param name="email"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertConfig(
            global::NightfallAI.SlackAlert? slack,
            global::NightfallAI.EmailAlert? email,
            global::NightfallAI.WebhookAlert? url)
        {
            this.Slack = slack;
            this.Email = email;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertConfig" /> class.
        /// </summary>
        public AlertConfig()
        {
        }
    }
}