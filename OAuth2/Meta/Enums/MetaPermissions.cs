// ReSharper disable InvalidXmlDocComment
namespace OAuth2.Meta.Enums;

public enum MetaPermissions
{
    /// <summary>
    /// The <typeparamref name="AdsManagement"/> permission allows your app to both read and manage the Ads account it owns, or has been granted access to, by the Ad account owner.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description> The library or executable built from a compilation.</description>
    ///     </item>
    ///     <item>
    ///         <description> Build ad management tools that provide innovative solutions and differentiated value for advertisers.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    AdsManagement,
    /// <summary>
    /// The <typeparamref name="AdsRead"/> permission allows your app to access the Ads Insights API to pull Ads report information for Ad accounts you own or have been granted access to by the owner or owners of other ad accounts through this permission. This permissions also grants your app access to the <see href="https://developers.facebook.com/docs/marketing-api/facebook-pixel/server-side-api">Server-Side API</see> to allow advertisers to send web events from their servers directly to Facebook.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Provide API access to your ad performance data for use in custom dashboards and data analytics.</description>
    ///     </item>
    ///     <item>
    ///         <description>Send web events from your server directly to Facebook.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    AdsRead,
    /// <summary>
    /// The <typeparamref name="AtibutionRead"/> permission grants your app access to the Attribution API to pull attribution report data for lines of business you own or have been granted access to by the owner or owners of other lines of business.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Provide API access to your ad performance data for use in custom dashboards and data analytics.</description>
    ///     </item>
    ///     <item>
    ///         <description>Send web events from your server directly to Facebook.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    AttributionRead,
    /// <summary>
    /// The <typeparamref name="BusinessManagement"/> permission allows your app to read and write with the Business Manager API.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Manage business assets such as an ad account.</description>
    ///     </item>
    ///     <item>
    ///         <description>Claim ad accounts.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    BusinessManagement,
    /// <summary>
    /// The <typeparamref name="CatalogManagement"/> permission allows your app to create, read, update and delete business-owned product catalogs that the user is an admin of.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Build commerce-related solutions like ecommerce platforms, travel platforms and dynamic ads.</description>
    ///     </item>
    ///     <item>
    ///         <description>Build inventory type management solutions like product inventory, hotel inventory or car inventory.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    CatalogManagement,
    /// <summary>
    /// The <typeparamref name="CommerceAccountManageOrders"/> permission allows your app to read and update commerce account orders.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Read and update orders in your commerce account.</description>
    ///     </item>
    ///     <item>
    ///         <description>Tech providers manage orders on behalf of their customers.</description>
    ///     </item>
    ///     <item>
    ///         <description>Access to Webhook notifications.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    CommerceAccountManageOrders,
    /// <summary>
    /// The <typeparamref name="CommerceAccountReadOrders"/> permission allows your app to read commerce account orders.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Read orders in your commerce account.</description>
    ///     </item>
    ///     <item>
    ///         <description>Use the buyer's email address for marketing purposes only if a buyer has opted-in at checkout.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    CommerceAccountReadOrders,
    /// <summary>
    /// The <typeparamref name="CommerceAccountReadReports"/> permission allows your app to read finance reporting data to build custom tax, cash reconciliation and reimbursement reports for a commerce account.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Read finance reporting data in your commerce account for building custom tax cash reconciliation and reimbursement reports.</description>
    ///     </item>
    ///     <item>
    ///         <description>Tech providers can run finance reports on behalf of their customers.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    CommerceAccountReadReports,
    /// <summary>
    /// The <typeparamref name="CommerceAccountReadSettings"/> permission allows your app to read commerce account settings.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Read basic commerce account information like connected channels, shipping options, fulfillment locations, connected business, etc.</description>
    ///     </item> 
    /// </list>
    /// </remarks>
    CommerceAccountReadSettings,
    /// <summary>
    /// The <typeparamref name="CommerceManageAccounts"/> permission allows your app to create and manage commerce accounts, such as an ecommerce app.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Associate your app with your commerce account.</description>
    ///     </item>
    ///     <item>
    ///         <description>Tech providers create a commerce account on behalf of their customers.</description>
    ///     </item>
    ///     <item>
    ///         <description>Tech providers enable a new sales channel within their customer’s commerce account.</description>
    ///     </item> 
    /// </list>
    /// </remarks>
    CommerceManageAccounts,
    /// <summary>
    /// The <typeparamref name="Email"/> permission allows your app to read a person's primary email address.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Communicating with people and letting them log into your app with the email address associated with their Facebook profile.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    Email,
    /// <summary>
    /// The <typeparamref name="GamingUserLocale"/> permission allows your app to get a user's preferred language while the user plays a game on Facebook (for example, Instant Games or Cloud Gaming).
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Display a game interface in the user's preferred language.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    GamingUserLocale
}