using System.Text;
using System.Text.Json;
using BurakKontas.OAuth2.Google.DataModels;
using BurakKontas.OAuth2.Google.Enums;
using BurakKontas.OAuth2.Google.Enums.Extensions;
using BurakKontas.OAuth2.Google.Interfaces;
using BurakKontas.OAuth2.Google.Validators;
using FluentValidation;
using OAuth2.Common.Interfaces;

namespace BurakKontas.OAuth2.Google.Clients;

/// <summary>
/// Implementation of the <see cref="IGoogleClient"/> interface for interacting with Google OAuth 2.0 services.
/// </summary>
public class GoogleClient : IGoogleClient
{
    private readonly GoogleOAuthData _googleOAuthData;
    private readonly HttpClient _httpClient;
    private static readonly GoogleOAuthDataValidator Validator = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="GoogleClient"/> class with the specified Google OAuth data.
    /// Validates the provided data to ensure it meets the required specifications.
    /// </summary>
    /// <param name="googleOAuthData">The configuration data required for Google OAuth 2.0 authorization.</param>
    /// <param name="httpClient">The HttpClient used to send HTTP requests.</param>
    /// <exception cref="ValidationException">Thrown when the provided OAuth data is invalid.</exception>
    public GoogleClient(GoogleOAuthData googleOAuthData, HttpClient httpClient)
    {
        var validationResult = Validator.Validate(googleOAuthData);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        _googleOAuthData = googleOAuthData;
        _httpClient = httpClient;
    }

    /// <summary>
    /// Asynchronously retrieves an access token and other OAuth login response data using an authorization code.
    /// </summary>
    /// <param name="code">The authorization code received from Google's OAuth 2.0 authorization server.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a <see cref="GoogleOAuthLoginResponse"/> containing the login response data, or <c>null</c> if the request fails.</returns>
    /// <exception cref="HttpRequestException">Thrown when the request to Google's OAuth 2.0 authorization server fails.</exception>
    public async Task<GoogleOAuthLoginResponse?> LoginAsync(string code)
    {
        var clientId = _googleOAuthData.ClientId;
        var clientSecret = _googleOAuthData.ClientSecret;
        var redirectUri = _googleOAuthData.RedirectUri;
        var grantType = _googleOAuthData.GrantType;

        var request = new HttpRequestMessage(HttpMethod.Post, _googleOAuthData.TokenUrl);

        var content = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "code", code },
            { "client_id", clientId },
            { "client_secret", clientSecret },
            { "redirect_uri", redirectUri.ToString() },
            { "grant_type", grantType.Value() }
        });

        request.Content = content;

        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<GoogleOAuthLoginResponse>(responseContent);
    }

    /// <summary>
    /// Asynchronously retrieves a new access token using a refresh token.
    /// </summary>
    /// <param name="refreshToken">The refresh token issued by Google's OAuth 2.0 authorization server.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a <see cref="GoogleOAuthLoginResponse"/> containing the new login response data, or <c>null</c> if the request fails.</returns>
    public async Task<GoogleOAuthLoginResponse?> RefreshTokenAsync(string refreshToken)
    {
        var clientId = _googleOAuthData.ClientId;
        var clientSecret = _googleOAuthData.ClientSecret;
        var grantType = GoogleGrantType.RefreshToken.Value(); // Using the correct grant type for refresh token

        var request = new HttpRequestMessage(HttpMethod.Post, _googleOAuthData.TokenUrl);

        var content = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "refresh_token", refreshToken },
            { "client_id", clientId },
            { "client_secret", clientSecret },
            { "grant_type", grantType }
        });

        request.Content = content;

        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<GoogleOAuthLoginResponse>(responseContent);
    }

    /// <summary>
    /// Constructs and returns the URL for initiating the OAuth 2.0 login process.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a string containing the login URL.</returns>
    public Task<string> GetLoginUrl()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"{_googleOAuthData.LoginUrl}");
        stringBuilder.Append($"response_type={_googleOAuthData.ResponseType.Value()}&");
        stringBuilder.Append($"client_id={_googleOAuthData.ClientId}&");
        stringBuilder.Append($"redirect_uri={_googleOAuthData.RedirectUri}&");
        stringBuilder.Append($"scope={_googleOAuthData.Scope.FromList()}&");
        stringBuilder.Append($"access_type={_googleOAuthData.AccessType.Value()}&");
        stringBuilder.Append($"prompt={_googleOAuthData.Prompt.Value()}&");
        stringBuilder.Append($"state={_googleOAuthData.State}");

        return Task.FromResult(stringBuilder.ToString());
    }
}