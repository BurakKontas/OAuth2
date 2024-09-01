namespace BurakKontas.OAuth2.Google.Enums
{
    /// <summary>
    /// Specifies the type of access your application needs when interacting with Google's OAuth2 API.
    /// </summary>
    public enum GoogleAccessType
    {
        /// <summary>
        /// Online access type. Suitable for short-lived sessions.
        /// No refresh token is issued.
        /// </summary>
        Online,

        /// <summary>
        /// Offline access type. Suitable for long-lived sessions.
        /// A refresh token is issued to maintain access even when the user is not actively using the application.
        /// </summary>
        Offline
    }
}