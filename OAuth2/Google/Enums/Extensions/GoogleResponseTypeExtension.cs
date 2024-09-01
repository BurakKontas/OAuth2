using BurakKontas.OAuth2.Google.Enums;

namespace BurakKontas.OAuth2.Google.Enums.Extensions
{
    /// <summary>
    /// Provides extension methods for the <see cref="GoogleResponseType"/> enum.
    /// </summary>
    public static class GoogleResponseTypeExtension
    {
        /// <summary>
        /// Converts the <see cref="GoogleResponseType"/> enum value to its corresponding string representation.
        /// </summary>
        /// <param name="responseType">The <see cref="GoogleResponseType"/> enum value.</param>
        /// <returns>A string representation of the <see cref="GoogleResponseType"/> enum value.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when an unknown <see cref="GoogleResponseType"/> value is provided.</exception>
        public static string Value(this GoogleResponseType responseType)
        {
            return responseType switch
            {
                GoogleResponseType.Code => "code",
                GoogleResponseType.Token => "token",
                GoogleResponseType.CodeIdToken => "code id_token",
                GoogleResponseType.CodeToken => "code token",
                GoogleResponseType.IdTokenToken => "id_token token",
                _ => throw new ArgumentOutOfRangeException(nameof(responseType), responseType, null)
            };
        }
    }
}
