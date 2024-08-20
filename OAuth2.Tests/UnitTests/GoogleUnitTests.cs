using FluentAssertions;
using Moq;
using Moq.Protected;
using OAuth2.Google.DataModels;
using OAuth2.Google.Enums;
using OAuth2.Google.Clients;

namespace OAuth2.Tests.UnitTests;

public class GoogleUnitTests
{
    private readonly GoogleOAuthData _validGoogleOAuthData;
    private readonly HttpClient _httpClient;

    public GoogleUnitTests()
    {
        _validGoogleOAuthData = new GoogleOAuthData
        {
            GoogleUrl = new Uri("https://accounts.google.com/o/oauth2/v2/auth?"),
            GoogleTokenUrl = new Uri("https://oauth2.googleapis.com/token"),
            ClientId = "test-client-id",
            ClientSecret = "test-client-secret",
            RedirectUri = new Uri("https://example.com/callback"),
            AccessType = GoogleAccessType.Online,
            Prompt = GooglePrompt.Consent,
            Scope =
            [
                GoogleScopes.OpenId,
                GoogleScopes.Email
            ],
            ResponseType = GoogleResponseType.Code,
            State = Guid.NewGuid()
                .ToString(),
            GrantType = GoogleGrantType.AuthorizationCode
        };


        // Setup HttpClient mock for login
        var mockHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
        mockHandler
            .Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Content = new StringContent("{\"id_token\":\"test-id-token\",\"access_token\":\"test-token\",\"expires_in\":3600,\"refresh_token\":\"test-refresh-token\",\"scope\":\"openid email\",\"token_type\":\"Bearer\"}")
            });

        _httpClient = new HttpClient(mockHandler.Object);

    }

    [Fact]
    public void Constructor_ValidData_ShouldNotThrowException()
    {
        // Arrange
        _ = new GoogleClient(_validGoogleOAuthData, _httpClient);

        // Act & Assert
        // No exception should be thrown
    }

    [Fact]
    public async Task LoginAsync_ValidCode_ShouldReturnExpectedResponse()
    {
        // Arrange
        var googleClient = new GoogleClient(_validGoogleOAuthData, _httpClient);
        const string code = "test-auth-code";

        // Act
        var response = await googleClient.LoginAsync(code);

        // Assert
        response.Should().NotBeNull();
        response!.AccessToken.Should().Be("test-token");
    }

    [Fact]
    public async Task RefreshTokenAsync_ValidRefreshToken_ShouldReturnExpectedResponse()
    {
        // Arrange
        var googleClient = new GoogleClient(_validGoogleOAuthData, _httpClient);
        const string refreshToken = "test-refresh-token";

        // Act
        var response = await googleClient.RefreshTokenAsync(refreshToken);

        // Assert
        response.Should().NotBeNull();
        response!.AccessToken.Should().Be("test-token");
    }

    [Fact]
    public async Task GetLoginUrl_ShouldReturnExpectedUrl()
    {
        // Arrange
        var googleClient = new GoogleClient(_validGoogleOAuthData, _httpClient);

        // Act
        var url = await googleClient.GetLoginUrl();

        // Assert
        url.Should().Contain("response_type=code");
        url.Should().Contain("client_id=test-client-id");
        url.Should().Contain("redirect_uri=https://example.com/callback");
        url.Should().Contain("scope=openid email");
        url.Should().Contain("access_type=online");
        url.Should().Contain("prompt=consent");
        url.Should().Contain("state=");
    }
}