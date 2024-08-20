namespace OAuth2.Google.Enums
{
    /// <summary>
    /// Specifies the types of responses that can be requested from Google's OAuth2 authorization server.
    /// </summary>
    public enum GoogleResponseType
    {
        /// <summary>
        /// Authorization Code flow: Requests an authorization code.
        /// </summary>
        Code,

        /// <summary>
        /// Implicit flow: Requests an access token directly.
        /// </summary>
        Token,

        /// <summary>
        /// Hybrid flow: Requests an authorization code and access token.
        /// </summary>
        CodeIdToken,

        /// <summary>
        /// Hybrid flow: Requests an authorization code and ID token.
        /// </summary>
        CodeToken,

        /// <summary>
        /// Hybrid flow: Requests an ID token and access token directly.
        /// </summary>
        IdTokenToken
    }
}