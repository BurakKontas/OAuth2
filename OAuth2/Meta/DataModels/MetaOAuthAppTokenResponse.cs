using System.Text.Json.Serialization;

namespace OAuth2.Meta.DataModels;

public class MetaOAuthAppTokenResponse
{
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; set; }

    [JsonPropertyName("token_type")]
    public required string TokenType { get; set; }
}