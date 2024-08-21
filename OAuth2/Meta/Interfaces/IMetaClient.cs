using OAuth2.Common.Interfaces;

namespace OAuth2.Meta.Interfaces;

public interface IMetaClient: IClient<MetaOAuthLoginResponse>
{
    Task<MetaOAuthAppTokenResponse> GetAppTokenAsync();
    new Task<MetaOAuthLoginResponse> LoginAsync(string code);
    Task<MetaOAuthDebugTokenResponse> DebugTokenAsync(string token, string appToken);
    Task<MetaOAuthCheckPermissionsResponse> CheckPermissionsAsync(string token, string userId);
    Task<MetaOAuthGetUserDataResponse>GetUserAsync(string token, string userId, IEnumerable<MetaFields> fields);
}