using System.Linq;
using System.Text;

namespace Elgin.Bridge.Commom
{
    public sealed class ServerInfo
    {
        internal ServerInfo() { }

        public string Terminal { get; internal set; }

        public int PortaTransacao { get; internal set; }

        public int PortaStatus { get; internal set; }

        public override string ToString()
        {
            return GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
        }
    }
}