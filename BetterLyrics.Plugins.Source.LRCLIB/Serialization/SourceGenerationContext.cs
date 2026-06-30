using System.Text.Json;
using System.Text.Json.Serialization;

namespace BetterLyrics.Plugins.Source.LRCLIB.Serialization
{
    [JsonSerializable(typeof(JsonElement))]
    [JsonSourceGenerationOptions(WriteIndented = true)]
    public partial class SourceGenerationContext : JsonSerializerContext { }
}
