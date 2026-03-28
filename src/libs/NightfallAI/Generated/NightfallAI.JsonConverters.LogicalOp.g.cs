#nullable enable

namespace NightfallAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class LogicalOpJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::NightfallAI.LogicalOp>
    {
        /// <inheritdoc />
        public override global::NightfallAI.LogicalOp Read(
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
                        return global::NightfallAI.LogicalOpExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::NightfallAI.LogicalOp)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::NightfallAI.LogicalOp);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::NightfallAI.LogicalOp value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::NightfallAI.LogicalOpExtensions.ToValueString(value));
        }
    }
}
