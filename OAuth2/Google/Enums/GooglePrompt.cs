namespace OAuth2.Google.Enums
{
    /// <summary>
    /// Specifies the prompt behavior for Google's OAuth2 authorization.
    /// </summary>
    public enum GooglePrompt
    {
        /// <summary>
        /// No prompt. The user is not prompted to grant access or select an account.
        /// If consent or account selection is required, an error will be returned.
        /// </summary>
        None,

        /// <summary>
        /// Consent prompt. The user is always prompted to grant consent to the application.
        /// </summary>
        Consent,

        /// <summary>
        /// Select account prompt. The user is prompted to select an account if multiple accounts are available.
        /// </summary>
        SelectAccount,

        /// <summary>
        /// Login prompt. The user is always prompted to log in, even if they are already authenticated.
        /// </summary>
        Login
    }
}