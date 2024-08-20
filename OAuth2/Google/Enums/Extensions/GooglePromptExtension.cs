namespace OAuth2.Google.Enums.Extensions
{
    public static class GooglePromptExtensions
    {
        /// <summary>
        /// Converts the <see cref="GooglePrompt"/> enum value to its corresponding string value.
        /// </summary>
        /// <param name="prompt">The <see cref="GooglePrompt"/> enum value.</param>
        /// <returns>A string representation of the <see cref="GooglePrompt"/> enum value.</returns>
        public static string Value(this GooglePrompt prompt)
        {
            return prompt switch
            {
                GooglePrompt.None => "none",
                GooglePrompt.Consent => "consent",
                GooglePrompt.SelectAccount => "select_account",
                GooglePrompt.Login => "login",
                _ => throw new ArgumentOutOfRangeException(nameof(prompt), prompt, null)
            };
        }
    }
}