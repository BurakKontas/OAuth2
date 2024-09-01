using BurakKontas.OAuth2.Meta.Enums;

namespace BurakKontas.OAuth2.Meta.DataModels;

public class MetaOAuthData
{
    /// <summary>
    /// The URL endpoint used for Meta OAuth 2.0 authorization requests.
    /// </summary>
    /// <value>
    /// Default value is "https://graph.facebook.com/".
    /// </value>
    /// <remarks>
    /// This URL is used to start the OAuth 2.0 authorization process with Meta.
    /// Ensure that any custom URL you provide is correctly formatted for Meta OAuth 2.0.
    /// </remarks>
    public Uri LoginUrl { get; set; } = new("https://graph.facebook.com/");

    /// <summary>
    /// The version used for Meta OAuth 2.0 authorization requests.
    /// </summary>
    /// <value>
    /// Default value is "v20.0".
    /// </value>
    /// <remarks>
    /// This version is used to start the OAuth 2.0 authorization process with Meta.
    /// Ensure that any custom Version you provide is correctly formatted for Meta OAuth 2.0.
    /// </remarks>
    public string Version { get; set; } = "v20.0";

    /// <summary>
    /// The client ID obtained from Meta Developer Console.
    /// </summary>
    public required string ClientId { get; set; }

    /// <summary>
    /// The client secret obtained from Meta Developer Console.
    /// </summary>
    public required string ClientSecret { get; set; }

    /// <summary>
    /// The URI to which Meta will redirect after successful authorization.
    /// </summary>
    /// <remarks>
    /// Must be a valid URI.
    /// </remarks>
    public required Uri RedirectUri { get; set; }

    /// <summary>
    /// The scopes requested during the authorization process.
    /// Defines the level of access requested from Meta services.
    /// </summary>
    /// <remarks>
    /// Check the Meta API documentation for a list of available scopes and further information. https://developers.facebook.com/docs/permissions
    /// </remarks>
    public required IEnumerable<MetaFields> Permissions { get; set; }

    /// <summary>
    /// A unique state parameter to maintain state between the request and callback.
    /// Used to prevent CSRF attacks and maintain the state of the user's request.
    /// </summary>
    /// <value>
    /// Default value is a new GUID.
    /// </value>
    /// <remarks>
    /// Ensure that the state parameter is unique for each request to prevent CSRF attacks.
    /// </remarks>
    public string State { get; set; } = Guid.NewGuid().ToString();
}