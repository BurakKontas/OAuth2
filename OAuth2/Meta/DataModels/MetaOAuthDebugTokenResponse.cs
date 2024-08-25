using System.Text.Json.Serialization;

namespace OAuth2.Meta.DataModels;

public class MetaOAuthDebugTokenResponse
{
    [JsonPropertyName("data")]
    public required MetaOAuthDebugTokenData Data { get; set; }   
}

public class MetaOAuthDebugTokenData
{
    [JsonPropertyName("app_id")]
    public required string AppId { get; set; }

    public required string Type { get; set; }

    public required string Application { get; set; }

    [JsonPropertyName("data_access_expires_at")]
    public required int DataAccessExpiresAt { get; set; }

    [JsonPropertyName("expires_at")]
    public required int ExpiresAt { get; set; }

    [JsonPropertyName("is_valid")]
    public required bool IsValid { get; set; }

    [JsonPropertyName("issued_at")]
    public required int IssuedAt { get; set; }

    public required IEnumerable<string> Scopes { get; set; }

    [JsonPropertyName("user_id")]
    public required string UserId { get; set; }
}