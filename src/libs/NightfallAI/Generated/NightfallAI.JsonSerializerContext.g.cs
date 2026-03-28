
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace NightfallAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::NightfallAI.JsonConverters.DetectorTypeJsonConverter),

            typeof(global::NightfallAI.JsonConverters.DetectorTypeNullableJsonConverter),

            typeof(global::NightfallAI.JsonConverters.LogicalOpJsonConverter),

            typeof(global::NightfallAI.JsonConverters.LogicalOpNullableJsonConverter),

            typeof(global::NightfallAI.JsonConverters.ConfidenceJsonConverter),

            typeof(global::NightfallAI.JsonConverters.ConfidenceNullableJsonConverter),

            typeof(global::NightfallAI.JsonConverters.MatchTypeJsonConverter),

            typeof(global::NightfallAI.JsonConverters.MatchTypeNullableJsonConverter),

            typeof(global::NightfallAI.JsonConverters.ExclusionTypeJsonConverter),

            typeof(global::NightfallAI.JsonConverters.ExclusionTypeNullableJsonConverter),

            typeof(global::NightfallAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.ScanTextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.ScanPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::NightfallAI.DetectionRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.DetectionRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.RedactionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.AlertConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::NightfallAI.Detector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.Detector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.LogicalOp), TypeInfoPropertyName = "LogicalOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.Confidence), TypeInfoPropertyName = "Confidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.DetectorType), TypeInfoPropertyName = "DetectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.Regex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.WordList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::NightfallAI.ContextRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.ContextRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::NightfallAI.ExclusionRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.ExclusionRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.MatchType), TypeInfoPropertyName = "MatchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.ExclusionType), TypeInfoPropertyName = "ExclusionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.Proximity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.ConfidenceAdjustment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.MaskConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.InfoTypeSubstitutionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.SubstitutionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.CryptoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.SlackAlert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.EmailAlert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.WebhookAlert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.ScanTextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::NightfallAI.Finding>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::NightfallAI.Finding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.Finding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.DetectorMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.FindingLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.FindingMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.LocationRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.APIKeyMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.InitFileUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.InitFileUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.ScanFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.FileScanPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.ScanFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::NightfallAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::NightfallAI.DetectionRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::NightfallAI.Detector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::NightfallAI.ContextRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::NightfallAI.ExclusionRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::NightfallAI.Finding>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::NightfallAI.Finding>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}