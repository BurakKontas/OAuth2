using System.Text.Json.Serialization;

namespace BurakKontas.OAuth2.Meta.DataModels;

public class MetaOAuthCheckPermissionsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<MetaOAuthCheckPermissionsData> Data { get; set; } = default!;
}

public class MetaOAuthCheckPermissionsData
{
    [JsonPropertyName("permission")]
    public required string Permission { get; set; }

    [JsonPropertyName("status")]
    public required string Status { get; set; }
}