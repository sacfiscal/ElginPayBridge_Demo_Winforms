using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elgin.Bridge.Commom
{
    internal class ElginDecimalConverter : JsonConverter<decimal>
    {
        public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var valor = Convert.ToInt64(reader.GetString());
            return valor / 100;
        }

        public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(Convert.ToInt64(value * 100).ToString());
        }
    }
}