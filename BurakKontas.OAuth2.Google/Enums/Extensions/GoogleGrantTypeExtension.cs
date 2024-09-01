using BurakKontas.OAuth2.Google.Enums;

namespace BurakKontas.OAuth2.Google.Enums.Extensions
{
    /// <summary>
    /// Provides extension methods for the <see cref="GoogleGrantType"/> enum.
    /// </summary>
    public static class GoogleGrantTypeExtensions
    {
        /// <summary>
        /// Converts the <see cref="GoogleGrantType"/> to its corresponding string representation.
        /// </summary>
        /// <param name="grantType">The OAuth 2.0 grant type.</param>
        /// <returns>The string representation of the grant type.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when an unknown grant type is provided.</exception>
        public static string Value(this GoogleGrantType grantType)
        {
            return grantType switch
            {
                GoogleGrantType.AuthorizationCode => "authorization_code",
                GoogleGrantType.Implicit => "implicit",
                GoogleGrantType.Password => "password",
                GoogleGrantType.ClientCredentials => "client_credentials",
                GoogleGrantType.RefreshToken => "refresh_token",
                _ => throw new ArgumentOutOfRangeException(nameof(grantType), grantType, null)
            };
        }
    }
}