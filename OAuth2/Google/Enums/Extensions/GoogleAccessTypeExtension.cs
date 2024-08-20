namespace OAuth2.Google.Enums.Extensions
{
    /// <summary>
    /// Provides extension methods for the <see cref="GoogleAccessType"/> enum.
    /// </summary>
    public static class GoogleAccessTypeExtension
    {
        /// <summary>
        /// Converts the <see cref="GoogleAccessType"/> enum value to its corresponding string representation.
        /// </summary>
        /// <param name="accessType">The <see cref="GoogleAccessType"/> enum value.</param>
        /// <returns>A string representation of the <see cref="GoogleAccessType"/> enum value.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when an unknown <see cref="GoogleAccessType"/> value is provided.</exception>
        public static string Value(this GoogleAccessType accessType)
        {
            return accessType switch
            {
                GoogleAccessType.Online => "online",
                GoogleAccessType.Offline => "offline",
                _ => throw new ArgumentOutOfRangeException(nameof(accessType), accessType, null)
            };
        }
    }
}