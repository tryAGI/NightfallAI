
#nullable enable

namespace NightfallAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExclusionRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NightfallAI.JsonConverters.MatchTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NightfallAI.MatchType MatchType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::NightfallAI.JsonConverters.ExclusionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::NightfallAI.ExclusionType ExclusionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex")]
        public global::NightfallAI.Regex? Regex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordList")]
        public global::NightfallAI.WordList? WordList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionRule" /> class.
        /// </summary>
        /// <param name="matchType"></param>
        /// <param name="exclusionType"></param>
        /// <param name="regex"></param>
        /// <param name="wordList"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExclusionRule(
            global::NightfallAI.MatchType matchType,
            global::NightfallAI.ExclusionType exclusionType,
            global::NightfallAI.Regex? regex,
            global::NightfallAI.WordList? wordList)
        {
            this.MatchType = matchType;
            this.ExclusionType = exclusionType;
            this.Regex = regex;
            this.WordList = wordList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionRule" /> class.
        /// </summary>
        public ExclusionRule()
        {
        }
    }
}