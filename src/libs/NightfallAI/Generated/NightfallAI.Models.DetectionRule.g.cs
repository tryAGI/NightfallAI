
#nullable enable

namespace NightfallAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectionRule
    {
        /// <summary>
        /// Human-readable name for this detection rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// List of detectors to apply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::NightfallAI.Detector> Detectors { get; set; }

        /// <summary>
        /// ANY = logical OR, ALL = logical AND
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logicalOp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NightfallAI.JsonConverters.LogicalOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NightfallAI.LogicalOp LogicalOp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionRule" /> class.
        /// </summary>
        /// <param name="detectors">
        /// List of detectors to apply
        /// </param>
        /// <param name="logicalOp">
        /// ANY = logical OR, ALL = logical AND
        /// </param>
        /// <param name="name">
        /// Human-readable name for this detection rule
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectionRule(
            global::System.Collections.Generic.IList<global::NightfallAI.Detector> detectors,
            global::NightfallAI.LogicalOp logicalOp,
            string? name)
        {
            this.Name = name;
            this.Detectors = detectors ?? throw new global::System.ArgumentNullException(nameof(detectors));
            this.LogicalOp = logicalOp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionRule" /> class.
        /// </summary>
        public DetectionRule()
        {
        }
    }
}