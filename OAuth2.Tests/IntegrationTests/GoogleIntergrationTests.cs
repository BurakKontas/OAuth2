using FluentAssertions;
using Moq;
using Moq.Protected;
using OAuth2.Google.Clients;
using Microsoft.Extensions.Configuration;
using BurakKontas.OAuth2.Google.Enums;
using BurakKontas.OAuth2.Google.DataModels;

namespace OAuth2.Tests.IntegrationTests;

public class GoogleIntegrationTests
{
    private readonly GoogleOAuthData _validGoogleOAuthData;
    private readonly HttpClient _httpClient = new();

    public GoogleIntegrationTests()
    {
        // User secrets setup to retrieve ClientId and ClientSecret
        var configuration = new ConfigurationBuilder()
            .AddUserSecrets<GoogleIntegrationTests>()
            .Build();

        var clientId = configuration["GoogleOAuth:ClientId"];
        var clientSecret = configuration["GoogleOAuth:ClientSecret"];
        var redirectUrl = configuration["GoogleOAuth:RedirectUrl"];

        _validGoogleOAuthData = new GoogleOAuthData
        {
            ClientId = clientId,
            ClientSecret = clientSecret,
            RedirectUri = new Uri(redirectUrl),
            AccessType = GoogleAccessType.Offline,
            Prompt = GooglePrompt.Consent,
            Scope =
            [
                GoogleScopes.OpenId,
                GoogleScopes.Email
            ],
            ResponseType = GoogleResponseType.Code,
            GrantType = GoogleGrantType.AuthorizationCode
        };
    }


    [Fact]
    public async Task LoginAsync_ValidCode_ShouldReturnExpectedResponse()
    {
        // Arrange
        var googleClient = new GoogleClient(_validGoogleOAuthData, _httpClient);
        const string code = "4/0AQlEd8zAe_V_0OOvMBG4Lq6GS4rhcpR1maP_-yTm1yUNowzqxBTUFMNjOO0uXQIBGpSvpQ";

        // Act
        var response = await googleClient.LoginAsync(code);

        // Assert
        response.Should().NotBeNull();
        response!.IdToken.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task RefreshTokenAsync_ValidRefreshToken_ShouldReturnExpectedResponse()
    {
        // Arrange
        var googleClient = new GoogleClient(_validGoogleOAuthData, _httpClient);
        const string refreshToken = "1//09ZZMjffEqZ7oCgYIARAAGAkSNwF-L9IrE2pvYiXirLXochaaT1Id5Wbj0Sl6YIPMfUkzbS4KnbZTseRUTJddgslA6FqXWohZet8";

        // Act
        var response = await googleClient.RefreshTokenAsync(refreshToken);

        // Assert
        response.Should().NotBeNull();
        response!.IdToken.Should().NotBeNullOrEmpty();
    }

}