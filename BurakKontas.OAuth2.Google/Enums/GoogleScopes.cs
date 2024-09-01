namespace BurakKontas.OAuth2.Google.Enums
{
    /// <summary>
    /// Specifies the scopes of access requested for Google's OAuth2 authorization.
    /// </summary>
    public enum GoogleScopes
    {
        // General Scopes
        /// <summary>
        /// Allows access to basic profile information.
        /// </summary>
        Profile,

        /// <summary>
        /// Allows access to the user's email address.
        /// </summary>
        Email,

        /// <summary>
        /// Allows access to the OpenID Connect user profile.
        /// </summary>
        OpenId,

        // Google Drive Scopes
        /// <summary>
        /// Allows read-only access to Google Drive files.
        /// </summary>
        DriveReadonly,

        /// <summary>
        /// Allows full access to Google Drive files.
        /// </summary>
        Drive,

        // Google Calendar Scopes
        /// <summary>
        /// Allows access to Google Calendar events.
        /// </summary>
        Calendar,

        // Google Contacts Scopes
        /// <summary>
        /// Allows read-only access to the user's contacts.
        /// </summary>
        ContactsReadonly,

        // Google Photos Scopes
        /// <summary>
        /// Allows access to the user's Google Photos library.
        /// </summary>
        Photos,

        // YouTube Scopes
        /// <summary>
        /// Allows read-only access to the user's YouTube data.
        /// </summary>
        YoutubeReadonly,

        /// <summary>
        /// Allows full access to the user's YouTube data.
        /// </summary>
        Youtube,

        // Google Analytics Scopes
        /// <summary>
        /// Allows access to Google Analytics data.
        /// </summary>
        Analytics,

        // Google Ads Scopes
        /// <summary>
        /// Allows access to Google Ads data.
        /// </summary>
        Ads,

        // Google Cloud Scopes
        /// <summary>
        /// Allows access to Google Cloud Platform resources.
        /// </summary>
        CloudPlatform,

        // Google+ Scopes
        /// <summary>
        /// Allows access to Google+ profile and activities.
        /// </summary>
        PlusLogin,

        // Google Maps Scopes
        /// <summary>
        /// Allows access to Google Maps data and services.
        /// </summary>
        Maps,

        // Google Groups Scopes
        /// <summary>
        /// Allows access to Google Groups data.
        /// </summary>
        Groups,

        // Google Hangouts Scopes
        /// <summary>
        /// Allows access to Google Hangouts data.
        /// </summary>
        Hangouts,

        // Google Sheets Scopes
        /// <summary>
        /// Allows access to Google Sheets data.
        /// </summary>
        Sheets,

        // Google Slides Scopes
        /// <summary>
        /// Allows access to Google Slides data.
        /// </summary>
        Slides,

        // Google Tasks Scopes
        /// <summary>
        /// Allows access to Google Tasks data.
        /// </summary>
        Tasks,

        // Google Fit Scopes
        /// <summary>
        /// Allows access to Google Fit data.
        /// </summary>
        Fitness
    }
}
