
#nullable enable

namespace NightfallAI
{
    /// <summary>
    /// Inline scan policy with detection rules and alert settings
    /// </summary>
    public sealed partial class ScanPolicy
    {
        /// <summary>
        /// Inline detection rule definitions (up to 10)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectionRules")]
        public global::System.Collections.Generic.IList<global::NightfallAI.DetectionRule>? DetectionRules { get; set; }

        /// <summary>
        /// UUIDs of pre-configured detection rules
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectionRuleUUIDs")]
        public global::System.Collections.Generic.IList<string>? DetectionRuleUUIDs { get; set; }

        /// <summary>
        /// Number of bytes of context to return around each finding<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextBytes")]
        public long? ContextBytes { get; set; }

        /// <summary>
        /// How findings should be redacted (specify exactly one type)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRedactionConfig")]
        public global::NightfallAI.RedactionConfig? DefaultRedactionConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alertConfig")]
        public global::NightfallAI.AlertConfig? AlertConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanPolicy" /> class.
        /// </summary>
        /// <param name="detectionRules">
        /// Inline detection rule definitions (up to 10)
        /// </param>
        /// <param name="detectionRuleUUIDs">
        /// UUIDs of pre-configured detection rules
        /// </param>
        /// <param name="contextBytes">
        /// Number of bytes of context to return around each finding<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="defaultRedactionConfig">
        /// How findings should be redacted (specify exactly one type)
        /// </param>
        /// <param name="alertConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScanPolicy(
            global::System.Collections.Generic.IList<global::NightfallAI.DetectionRule>? detectionRules,
            global::System.Collections.Generic.IList<string>? detectionRuleUUIDs,
            long? contextBytes,
            global::NightfallAI.RedactionConfig? defaultRedactionConfig,
            global::NightfallAI.AlertConfig? alertConfig)
        {
            this.DetectionRules = detectionRules;
            this.DetectionRuleUUIDs = detectionRuleUUIDs;
            this.ContextBytes = contextBytes;
            this.DefaultRedactionConfig = defaultRedactionConfig;
            this.AlertConfig = alertConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanPolicy" /> class.
        /// </summary>
        public ScanPolicy()
        {
        }
    }
}