#nullable enable

namespace NightfallAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfidenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::NightfallAI.Confidence>
    {
        /// <inheritdoc />
        public override global::NightfallAI.Confidence Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::NightfallAI.ConfidenceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::NightfallAI.Confidence)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::NightfallAI.Confidence);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::NightfallAI.Confidence value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::NightfallAI.ConfidenceExtensions.ToValueString(value));
        }
    }
}
