namespace BurakKontas.OAuth2.Common.Interfaces;

public interface IClient<TLoginResponse> where TLoginResponse : class
{
    /// <summary>
    /// Retrieves an access token and other OAuth login response data using an authorization code.
    /// </summary>
    /// <param name="code">The authorization code received from OAuth 2.0 authorization server.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a <see cref="ILoginResponse"/> containing the login response data, or <c>null</c> if the request fails.</returns>
    Task<TLoginResponse?> LoginAsync(string code);

    Task<TLoginResponse?> RefreshTokenAsync(string refreshToken);

    /// <summary>
    /// Constructs and returns the URL for initiating the OAuth 2.0 login process.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a string containing the login URL.</returns>
    Task<string> GetLoginUrl();
}