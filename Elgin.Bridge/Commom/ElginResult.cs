using System.Text.Json.Serialization;

namespace Elgin.Bridge.Commom
{
    public class ElginResult
    {
        [JsonPropertyName("e1_bridge_code")]
        public int Code { get; set; }

        [JsonPropertyName("e1_bridge_msg")]
        public string Mensagem { get; set; }

        [JsonIgnore]
        public string ResultText { get; set; }
    }
}
