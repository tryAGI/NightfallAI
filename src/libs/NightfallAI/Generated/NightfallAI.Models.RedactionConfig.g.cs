
#nullable enable

namespace NightfallAI
{
    /// <summary>
    /// How findings should be redacted (specify exactly one type)
    /// </summary>
    public sealed partial class RedactionConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskConfig")]
        public global::NightfallAI.MaskConfig? MaskConfig { get; set; }

        /// <summary>
        /// Replace finding with the matched detector name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infoTypeSubstitutionConfig")]
        public global::NightfallAI.InfoTypeSubstitutionConfig? InfoTypeSubstitutionConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("substitutionConfig")]
        public global::NightfallAI.SubstitutionConfig? SubstitutionConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cryptoConfig")]
        public global::NightfallAI.CryptoConfig? CryptoConfig { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeFinding")]
        public bool? RemoveFinding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactionConfig" /> class.
        /// </summary>
        /// <param name="maskConfig"></param>
        /// <param name="infoTypeSubstitutionConfig">
        /// Replace finding with the matched detector name
        /// </param>
        /// <param name="substitutionConfig"></param>
        /// <param name="cryptoConfig"></param>
        /// <param name="removeFinding">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedactionConfig(
            global::NightfallAI.MaskConfig? maskConfig,
            global::NightfallAI.InfoTypeSubstitutionConfig? infoTypeSubstitutionConfig,
            global::NightfallAI.SubstitutionConfig? substitutionConfig,
            global::NightfallAI.CryptoConfig? cryptoConfig,
            bool? removeFinding)
        {
            this.MaskConfig = maskConfig;
            this.InfoTypeSubstitutionConfig = infoTypeSubstitutionConfig;
            this.SubstitutionConfig = substitutionConfig;
            this.CryptoConfig = cryptoConfig;
            this.RemoveFinding = removeFinding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactionConfig" /> class.
        /// </summary>
        public RedactionConfig()
        {
        }
    }
}