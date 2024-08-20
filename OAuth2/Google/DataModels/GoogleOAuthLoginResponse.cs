using System.Text.Json.Serialization;

namespace OAuth2.Google.DataModels
{
    /// <summary>
    /// Represents the response received from Google OAuth 2.0 authentication service upon successful login.
    /// </summary>
    public class GoogleOAuthLoginResponse
    {
        /// <summary>
        /// The ID token issued by Google. This token contains information about the authenticated user.
        /// </summary>
        [JsonPropertyName("id_token")]
        public required string IdToken { get; set; }

        /// <summary>
        /// The access token issued by Google. This token is used to authenticate API requests.
        /// </summary>
        [JsonPropertyName("access_token")]
        public required string AccessToken { get; set; }

        /// <summary>
        /// The number of seconds until the access token expires. Indicates the token's validity period.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public required int ExpiresIn { get; set; }

        /// <summary>
        /// The refresh token issued by Google. This token can be used to obtain a new access token after the current token expires.
        /// It is optional and may be null if not provided by the authentication service.
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// The scope of access granted by the user. This represents the permissions granted to the application.
        /// </summary>
        [JsonPropertyName("scope")]
        public required string Scope { get; set; }

        /// <summary>
        /// The type of token issued by Google. Typically, this is "Bearer".
        /// </summary>
        [JsonPropertyName("token_type")]
        public required string TokenType { get; set; }

        /// <summary>
        /// An exception thrown when the authentication response is empty or invalid.
        /// Indicates a failure to receive a valid response from the Google authentication service.
        /// </summary>
        public static ArgumentNullException Blank => new($"Authentication failed: Received empty or invalid response from the Google authentication service. Please check your input and try again.");
    }
}
