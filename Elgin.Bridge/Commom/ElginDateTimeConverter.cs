using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elgin.Bridge.Commom
{
    internal class ElginDateTimeConverter : JsonConverter<DateTime>
    {
        private readonly string format;

        public ElginDateTimeConverter()
        {
            format = "dd/MM/yyyy HH:mm:ss";
        }

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.ParseExact(
                reader.GetString(),
                format,
                CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(format, CultureInfo.InvariantCulture));
        }
    }
}