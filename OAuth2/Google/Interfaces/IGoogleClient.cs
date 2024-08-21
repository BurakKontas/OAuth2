using OAuth2.Common.Interfaces;
using OAuth2.Google.DataModels;

namespace OAuth2.Google.Interfaces
{
    /// <summary>
    /// Defines the methods for interacting with Google OAuth 2.0 authentication services.
    /// </summary>
    public interface IGoogleClient: IClient<GoogleOAuthLoginResponse>
    {
        /// <summary>
        /// Retrieves an access token and other OAuth login response data using an authorization code.
        /// </summary>
        /// <param name="code">The authorization code received from Google's OAuth 2.0 authorization server.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a <see cref="GoogleOAuthLoginResponse"/> containing the login response data, or <c>null</c> if the request fails.</returns>
        new Task<GoogleOAuthLoginResponse?> LoginAsync(string code);

        /// <summary>
        /// Retrieves a new access token using a refresh token.
        /// </summary>
        /// <param name="refreshToken">The refresh token issued by Google's OAuth 2.0 authorization server.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a <see cref="GoogleOAuthLoginResponse"/> containing the new login response data, or <c>null</c> if the request fails.</returns>
        Task<GoogleOAuthLoginResponse?> RefreshTokenAsync(string refreshToken);
    }
}