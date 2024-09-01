using BurakKontas.OAuth2.Google.DataModels;
using FluentValidation;

namespace BurakKontas.OAuth2.Google.Validators;

/// <summary>
/// Validator class for <see cref="GoogleOAuthData"/> to ensure the validity of the OAuth 2.0 configuration data.
/// </summary>
public class GoogleOAuthDataValidator : AbstractValidator<GoogleOAuthData>
{
    public GoogleOAuthDataValidator()
    {
        RuleFor(x => x.LoginUrl)
            .NotEmpty().WithMessage("Google URL cannot be empty.")
            .Must(uri => Uri.TryCreate(uri.ToString(), UriKind.Absolute, out _)).WithMessage("Invalid Google URL format.");

        RuleFor(x => x.ClientId)
            .NotEmpty().WithMessage("Client ID cannot be empty.");

        RuleFor(x => x.ClientSecret)
            .NotEmpty().WithMessage("Client Secret cannot be empty.");

        RuleFor(x => x.RedirectUri)
            .NotNull().WithMessage("Redirect URI cannot be null.")
            .Must(uri => Uri.IsWellFormedUriString(uri.ToString(), UriKind.Absolute)).WithMessage("Invalid Redirect URI format.");

        RuleFor(x => x.AccessType)
            .IsInEnum().WithMessage("Invalid Access Type. Must be 'Online' or 'Offline'.");

        RuleFor(x => x.Prompt)
            .IsInEnum().WithMessage("Invalid Prompt. Must be one of 'None', 'Consent', 'SelectAccount', or 'Login'.");

        RuleFor(x => x.Scope)
            .NotEmpty().WithMessage("Scopes cannot be empty.")
            .Must(scopes => scopes.Any()).WithMessage("At least one scope must be provided.");

        RuleFor(x => x.ResponseType)
            .IsInEnum().WithMessage("Invalid Response Type. Must be one of 'Code', 'Token', or 'Code id_token token'.");

        RuleFor(x => x.GrantType)
            .IsInEnum().WithMessage("Invalid Grant Type. Must be one of 'AuthorizationCode', 'Implicit', 'Password', 'ClientCredentials', or 'RefreshToken'.");

        RuleFor(x => x.State)
            .NotEmpty().WithMessage("State cannot be empty.");
    }
}