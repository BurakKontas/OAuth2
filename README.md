# OAuth 2.0 Client

This project provides a C# client for interacting with OAuth 2.0 services. Below you'll find information on how to use and configure.

## Features

- Google OAuth 2.0 login and access token retrieval
- Token renewal support
- OAuth 2.0 login URL generation

## Requirements

- .NET 6.0 or newer
- FluentValidation
- Xunit
- Moq
- FluentAssertions

## Installation

### NuGet Packages

The project includes the necessary NuGet packages. Ensure the following packages are installed:

- `FluentValidation`
- `Xunit`
- `Moq`
- `FluentAssertions`

### Configuration

To use the Google OAuth 2.0 client, you need to create a `GoogleOAuthData` object containing the required configuration details. Here is an example configuration:

```csharp
var googleOAuthData = new GoogleOAuthData
{
    GoogleUrl = new Uri("https://accounts.google.com/o/oauth2/v2/auth?"),
    GoogleTokenUrl = new Uri("https://oauth2.googleapis.com/token"),
    ClientId = "test-client-id",
    ClientSecret = "test-client-secret",
    RedirectUri = new Uri("https://example.com/callback"),
    AccessType = GoogleAccessType.Online,
    Prompt = GooglePrompt.Consent,
    Scope = new List<GoogleScopes> { GoogleScopes.OpenId, GoogleScopes.Email },
    ResponseType = GoogleResponseType.Code,
    State = Guid.NewGuid().ToString(),
    GrantType = GoogleGrantType.AuthorizationCode
};
```

## Usage

### Creating the Client

You can create an instance of GoogleClient using the GoogleOAuthData object and an `HttpClient`:

```csharp
var httpClient = new HttpClient();
var googleClient = new GoogleClient(googleOAuthData, httpClient);
```

### Logging In

To log in using an authorization code, use the `LoginAsync` method of any client:

```csharp
const string code = "test-auth-code";
var loginResponse = await googleClient.LoginAsync(code);
Console.WriteLine($"Access Token: {loginResponse?.AccessToken}");
```

### Token Renewal

To get a new access token using a refresh token, use the `RefreshTokenAsync` method of any client:

```csharp
const string refreshToken = "test-refresh-token";
var response = await googleClient.RefreshTokenAsync(refreshToken);

Console.WriteLine($"Access Token: {response?.AccessToken}");
```

### Generating Login URL

To generate the URL needed to start the OAuth 2.0 login process, use the `GetLoginUrl` method of any client:

```csharp
var url = await googleClient.GetLoginUrl();

Console.WriteLine($"Login URL: {url}");
```

## Contributors

[BurakKontas](https://github.com/BurakKontas) - Project Owner and Lead Developer

## License

This project is licensed under the MIT License.

## TODO

- Implemented
  - Google OAuth2 Implementation
- Roadmap
  - Facebook OAuth2 Implementation
  - Apple OAuth2 Implementation
  - X OAuth2 Implementation
  - Github OAuth2 Implementation
  - Discord OAuth2 Implementation
  - Linkedin OAuth2 Implementation
  - Steam OAuth2 Implementation
  - Twitch OAuth2 Implementation
  - Epic Games OAuth2 Implementation
  - Sony Playstation OAuth2 Implementation
  - Xbox OAuth2 Implementation
