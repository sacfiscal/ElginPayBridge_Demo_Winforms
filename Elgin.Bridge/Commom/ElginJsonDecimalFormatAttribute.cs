using System;
using System.Text.Json.Serialization;

namespace Elgin.Bridge.Commom
{
    internal sealed class ElginJsonDecimalFormatAttribute : JsonConverterAttribute
    {
        public override JsonConverter CreateConverter(Type typeToConvert)
        {
            return new ElginDecimalConverter();
        }
    }
}