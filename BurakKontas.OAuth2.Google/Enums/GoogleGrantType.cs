namespace BurakKontas.OAuth2.Google.Enums
{
    /// <summary>
    /// Specifies the different OAuth 2.0 grant types.
    /// </summary>
    public enum GoogleGrantType
    {
        /// <summary>
        /// Authorization Code grant type.
        /// Used to obtain an authorization code which can be exchanged for an access token.
        /// </summary>
        AuthorizationCode,

        /// <summary>
        /// Implicit grant type.
        /// Used to obtain an access token directly without an authorization code.
        /// </summary>
        Implicit,

        /// <summary>
        /// Resource Owner Password Credentials grant type.
        /// Used to exchange user credentials directly for an access token.
        /// </summary>
        Password,

        /// <summary>
        /// Client Credentials grant type.
        /// Used to obtain an access token using the client's credentials.
        /// </summary>
        ClientCredentials,

        /// <summary>
        /// Refresh Token grant type.
        /// Used to obtain a new access token using a refresh token.
        /// </summary>
        RefreshToken
    }
}