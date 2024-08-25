﻿using OAuth2.Common.Interfaces;
using OAuth2.Meta.DataModels;
using OAuth2.Meta.Enums;

namespace OAuth2.Meta.Interfaces;

public interface IMetaClient: IClient<MetaOAuthLoginResponse>
{
    // https://www.facebook.com/v20.0/dialog/oauth?client_id=867503841911923&redirect_uri=http://localhost:3030/oauth/callback&state=random-state&scope=public_profile,email,user_age_range
    Task<MetaOAuthAppTokenResponse> GetAppTokenAsync(); // https://graph.facebook.com/oauth/access_token?client_id=867503841911923&client_secret=904827f79e417d88cc1e389c00e5b647&grant_type=client_credentials
    new Task<MetaOAuthLoginResponse> LoginAsync(string code); // https://graph.facebook.com/v20.0/oauth/access_token?client_id=867503841911923&redirect_uri=http://localhost:3030/oauth/callback&client_secret=904827f79e417d88cc1e389c00e5b647&code=code
    new Task<MetaOAuthLoginResponse> RefreshTokenAsync(string refreshToken); // https://graph.facebook.com/oauth/access_token?client_id=867503841911923&client_secret=904827f79e417d88cc1e389c00e5b647&grant_type=fb_exchange_token&fb_exchange_token=token
    Task<MetaOAuthDebugTokenResponse> DebugTokenAsync(string token, string appToken); // graph.facebook.com/debug_token?input_token=token&access_token=appToken
    Task<MetaOAuthCheckPermissionsResponse> CheckPermissionsAsync(string token, string userId); // https://graph.facebook.com/v20.0/{userid}/permissions // header authorization bearer: token
    Task<MetaOAuthGetUserDataResponse>GetUserAsync(string token, string userId, IEnumerable<MetaFields> fields); // https://graph.facebook.com/v20.0/{userid}?fields=id,name,picture,email // header authorization bearer: token
}