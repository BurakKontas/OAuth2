using OAuth2.Google.Enums;

namespace OAuth2.Google.DataModels
{
    /// <summary>
    /// Represents the configuration data required for Google OAuth 2.0 authorization.
    /// </summary>
    public class GoogleOAuthData
    {
        /// <summary>
        /// The URL endpoint used for Google OAuth 2.0 authorization requests.
        /// </summary>
        /// <value>
        /// Default value is "https://accounts.google.com/o/oauth2/v2/auth?".
        /// </value>
        /// <remarks>
        /// This URL is used to start the OAuth 2.0 authorization process with Google.
        /// Ensure that any custom URL you provide is correctly formatted for Google OAuth 2.0.
        /// </remarks>
        public Uri GoogleUrl { get; set; } = new("https://accounts.google.com/o/oauth2/v2/auth?");

        /// <summary>
        /// The URL endpoint used to exchange an authorization code or refresh token for an access token.
        /// </summary>
        /// <value>
        /// Default value is "https://oauth2.googleapis.com/token".
        /// </value>
        /// <remarks>
        /// This URL is used to obtain access tokens from Google OAuth 2.0.
        /// Only modify this if necessary for custom implementations.
        /// 
        /// Ensure that any custom URL you provide is correctly formatted for Google OAuth 2.0 token exchanges.
        /// </remarks>
        public Uri GoogleTokenUrl { get; set; } = new("https://oauth2.googleapis.com/token");

        /// <summary>
        /// The client ID obtained from Google API Console.
        /// </summary>
        public required string ClientId { get; set; }

        /// <summary>
        /// The client secret obtained from Google API Console.
        /// </summary>
        public required string ClientSecret { get; set; }

        /// <summary>
        /// The URI to which Google will redirect after successful authorization.
        /// Must be a valid URI.
        /// </summary>
        public required Uri RedirectUri { get; set; }

        /// <summary>
        /// The type of access requested from Google.
        /// Determines whether to request online or offline access.
        /// </summary>
        public required GoogleAccessType AccessType { get; set; }

        /// <summary>
        /// The prompt behavior to control the user consent screen and sign-in options.
        /// </summary>
        public required GooglePrompt Prompt { get; set; }

        /// <summary>
        /// The scopes requested during the authorization process.
        /// Defines the level of access requested from Google services.
        /// </summary>
        public required IEnumerable<GoogleScopes> Scope { get; set; }

        /// <summary>
        /// The type of response expected from Google.
        /// Determines the format of the response, such as authorization code, access token, etc.
        /// </summary>
        public required GoogleResponseType ResponseType { get; set; }

        /// <summary>
        /// The grant type used for obtaining access tokens.
        /// Specifies the type of authorization grant being used.
        /// </summary>
        public required GoogleGrantType GrantType { get; set; }

        /// <summary>
        /// A unique state parameter to maintain state between the request and callback.
        /// Used to prevent CSRF attacks and maintain the state of the user's request.
        /// </summary>
        /// <value>
        /// Default value is a new GUID.
        /// </value>
        /// <remarks>
        /// Ensure that the state parameter is unique for each request to prevent CSRF attacks.
        /// </remarks>
        public string State { get; set; } = Guid.NewGuid().ToString();
    }
}
