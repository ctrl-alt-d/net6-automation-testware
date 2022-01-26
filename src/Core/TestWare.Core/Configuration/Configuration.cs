

using System.Text.Json.Nodes;

namespace TestWare.Core.Configuration
{
    public class Configuration
    {
        public string Tag { get; set; } =string.Empty;
        public IEnumerable<JsonObject> Capabilities { get; set; } = Array.Empty<JsonObject>();
    }
}
