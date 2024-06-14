using ListToTreeJsonConverter.Objects;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ListToTreeJsonConverter.Utils
{
    public class PolymorphicJsonConverter<TBase> : JsonConverter<TBase> where TBase : TreeBuilder
    {
        public override TBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException("This converter does not support deserialization.");
        }

        public override void Write(Utf8JsonWriter writer, TBase value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }

}
