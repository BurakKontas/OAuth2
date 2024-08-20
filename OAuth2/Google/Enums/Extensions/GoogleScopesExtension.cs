namespace OAuth2.Google.Enums.Extensions
{
    /// <summary>
    /// Provides extension methods for the <see cref="GoogleScopes"/> enum.
    /// </summary>
    public static class GoogleScopesExtension
    {
        /// <summary>
        /// Converts the <see cref="GoogleScopes"/> enum value to its corresponding string representation.
        /// </summary>
        /// <param name="scope">The <see cref="GoogleScopes"/> enum value.</param>
        /// <returns>A string representation of the <see cref="GoogleScopes"/> enum value.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when an unknown <see cref="GoogleScopes"/> value is provided.</exception>
        public static string Value(this GoogleScopes scope)
        {
            return scope switch
            {
                GoogleScopes.Profile => "profile",
                GoogleScopes.Email => "email",
                GoogleScopes.OpenId => "openid",
                GoogleScopes.DriveReadonly => "drive.readonly",
                GoogleScopes.Drive => "drive",
                GoogleScopes.Calendar => "calendar",
                GoogleScopes.ContactsReadonly => "contacts.readonly",
                GoogleScopes.Photos => "photoslibrary",
                GoogleScopes.YoutubeReadonly => "youtube.readonly",
                GoogleScopes.Youtube => "youtube",
                GoogleScopes.Analytics => "analytics",
                GoogleScopes.Ads => "ads",
                GoogleScopes.CloudPlatform => "cloud-platform",
                GoogleScopes.PlusLogin => "plus.login",
                GoogleScopes.Maps => "maps",
                GoogleScopes.Groups => "groups",
                GoogleScopes.Hangouts => "hangouts",
                GoogleScopes.Sheets => "sheets",
                GoogleScopes.Slides => "slides",
                GoogleScopes.Tasks => "tasks",
                GoogleScopes.Fitness => "fitness",
                _ => throw new ArgumentOutOfRangeException(nameof(scope), scope, null)
            };
        }

        /// <summary>
        /// Converts a list of <see cref="GoogleScopes"/> enum values to a space-separated string of scope values.
        /// </summary>
        /// <param name="scopes">The list of <see cref="GoogleScopes"/> enum values to convert.</param>
        /// <returns>A space-separated string representing the combined values of the provided scopes.</returns>
        public static string FromList(this IEnumerable<GoogleScopes> scopes)
        {
            return string.Join(" ", scopes.Select(scope => scope.Value()));
        }
    }
}
