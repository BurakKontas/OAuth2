// ReSharper disable InvalidXmlDocComment
namespace BurakKontas.OAuth2.Meta.Enums;

public enum MetaFields
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
    GamingUserLocale,
    /// <summary>
    /// The <typeparamref name="InstagramBasic"/> permission allows your app to read an Instagram account profile's info and media.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Get basic metadata of an Instagram Business account profile, for example username and ID.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramBasic,
    /// <summary>
    /// The <typeparamref name="InstagramBrandedContentAdsBrand"/> permission allows an app to read Instagram posts where the app user's Instagram account is tagged as a paid partner, and an app user to read, request, and revoke permissions to run Partnership Ads.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Read Instagram posts where the account is tagged as a paid partner.</description>
    ///     </item>
    ///     <item>
    ///         <description>Manage permissions to run Partnership Ads without needing a pre-existing post.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramBrandedContentAdsBrand,
    /// <summary>
    /// The <typeparamref name="InstagramBrandedContentBrand"/> permission allows your app to add, remove and view creators from a specific brand’s approved creators list. The allowed usage for this permission is to manage a specific brand’s Instagram creator content settings. You may also use this permission to request analytics insights to improve your app and for marketing or advertising purposes, through the use of aggregated and de-identified or anonymized information (provided such data cannot be re-identified).
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Manage branded creator content settings on a business’ Instagram account.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramBrandedContentBrand,
    /// <summary>
    /// The <typeparamref name="InstagramBrandedContentCreator"/> permission allows your app to read and change the boost status of a creator’s specific piece of content. The allowed usage for this permission is to manage Instagram creator content settings. You may also use this permission to request analytics insights to improve your app and for marketing or advertising purposes, through the use of aggregated and de-identified or anonymized information (provided such data cannot be re-identified).
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Read and change an Instagram creator’s content settings.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramBrandedContentCreator,
    /// <summary>
    /// The <typeparamref name="InstagramBusinessBasic"/> allows your app to read an Instagram Business account profile's info and media. The allowed usage for this permission is to get basic metadata of an Instagram Business account profile, for example username and ID.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Get basic metadata of an Instagram Business account profile.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramBusinessBasic,
    /// <summary>
    /// The <typeparamref name="InstagramBusinessContentPublish"/> permission allows an app to create organic feed photo and video posts on behalf of a business user. The allowed usage of this permission is to allow an app to manage the organic content creation process for Instagram (for example, post photos and videos) on behalf of an Instagram business account. You may also use this permission to request analytics insights to improve your app and for marketing or advertising purposes, through the use of aggregated and de-identified or anonymized information (provided such data cannot be re-identified).
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Manage the organic content creation process for Instagram (for example, post photos and videos) on behalf of an Instagram business account.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramBusinessContentPublish,
    /// <summary>
    /// The <typeparamref name="InstagramBusinessManageComments"/> permission allows an app to access comments on an Instagram professional account, as well as public posts and Instagram Stories where that account is tagged or mentioned in comments. The allowed usage for this permission is to create, update and delete comments for an Instagram professional account.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Create, update, and delete comments for an Instagram professional account.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramBusinessManageComments,
    /// <summary>
    /// The <typeparamref name="InstagramBusinessManageMessages"/> permission allows an app to access messages on an Instagram professional account. The allowed usage for this permission is to view, manage and respond to messages, and to use third-party customer relationship management (CRM) tools to manage messages.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>View, manage, and respond to messages.</description>
    ///     </item>
    ///     <item>
    ///         <description>Use third-party customer relationship management (CRM) tools to manage messages.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramBusinessManageMessages,
    /// <summary>
    /// The <typeparamref name="InstagramContentPublish"/> permission allows your app to create organic feed photo and video posts on behalf of a business user.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Managing organic content creation process for Instagram (for example, post photos and videos to main feed) on behalf of a business.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramContentPublish,
    /// <summary>
    /// The <typeparamref name="InstagramGraphUserMedia"/> permission allows your app to read the Media node, which represents an image, video, or album and the node’s edges.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Creating physical or digital books from the app user's photos, including exporting photos for printing.</description>
    ///     </item>
    ///     <item>
    ///         <description>Displaying the app users photos to other app users within the app, for example with social or dating apps.</description>
    ///     </item>
    ///     <item>
    ///         <description>Editing or creating new photos or videos based on the app user's existing photos and videos, (e.g. for photo or video Editing Apps).</description>
    ///     </item>
    ///     <item>
    ///         <description>Displaying the app user's photos and videos in an external device such as a TV or digital photo frame.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramGraphUserMedia,
    /// <summary>
    /// The <typeparamref name="InstagramGraphUserProfile"/> permission allows your app to read the app user's profile.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Read fields in an Instagram <see href="https://developers.facebook.com/docs/instagram-basic-display-api/reference/user">user profile</see>, for example user ID and account type.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramGraphUserProfile,
    /// <summary>
    /// The <typeparamref name="InstagramManageComments"/> permission allows your app to create, delete and hide comments on behalf of the Instagram account linked to a Page. Your app can also read and respond to public media and comments that a business has been photo tagged or @mentioned in.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Read, update and delete comments of Instagram Business accounts.</description>
    ///     </item>
    ///     <item>
    ///         <description>Read media objects, such as stories, of Instagram Business accounts.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramManageComments,
    /// <summary>
    /// The <typeparamref name="InstagramManageEvents"/> permission allows an app permission to log events (e.g., purchase, add-to-cart, leads) on behalf of Instagram accounts administered by the app’s users. The allowed usage for this permission is to log events on Instagram accounts and send this activity data to Meta for ads targeting, optimization and reporting; and to provide marketing and advertising analytics insights. You may also use this permission to request analytics insights to improve your app and for marketing or advertising purposes, through the use of aggregated and de-identified or anonymized information (provided such data cannot be re-identified).
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Log events on Instagram accounts and send this activity data to Meta for ads targeting, optimization and reporting.</description>
    ///     </item>
    ///     <item>
    ///         <description>Provide marketing and advertising analytics insights.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramManageEvents,
    /// <summary>
    /// The <typeparamref name="InstagramManageInsights"/> permission allows your app to get access to insights for the Instagram account linked to a Facebook Page. Your app can also discover and read the profile info and media of other business profiles.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Get metadata of an Instagram Business account.</description>
    ///     </item>
    ///     <item>
    ///         <description>Get data insights of an Instagram Business account.</description>
    ///     </item>
    ///     <item>
    ///         <description>Get story insights of an Instagram Business account.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramManageInsights,
    /// <summary>
    /// The <typeparamref name="InstagramManageMessages"/> permission allows business users to read and respond to Instagram Direct messages.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Business that want to retrieve threads and messages from its Direct inbox.</description>
    ///     </item>
    ///     <item>
    ///         <description>Business that want to manage messages with their customer.</description>
    ///     </item>
    ///     <item>
    ///         <description>Business that want to use third-party customer relationship management (CRM) tools to manage its IG Direct inbox.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramManageMessages,
    /// <summary>
    /// The <typeparamref name="InstagramShoppingTagProducts"/> permission allows an app to tag Instagram media with product tags and appeal product rejections.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Check eligibility for product tagging.</description>
    ///     </item>
    ///     <item>
    ///         <description>Get catalogs and products.</description>
    ///     </item>
    ///     <item>
    ///         <description>Tag media with product tags.</description>
    ///     </item>
    ///     <item>
    ///         <description>Manage existing product tags.</description>
    ///     </item>
    ///     <item>
    ///         <description>Appeal product rejections.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramShoppingTagProducts,
    /// <summary>
    /// The <typeparamref name="InstagramManageUpcomingEvents"/> permission allows an app to read, create, and update upcoming events on behalf of Instagram accounts administered by people using the app. The allowed usage for this permission is to manage upcoming events on Instagram accounts administered by the people using the app. You may also use this permission to request analytics insights to improve your app and for marketing or advertising purposes, through the use of aggregated and de-identified or anonymized information (provided such data cannot be re-identified).
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Manage upcoming events on Instagram accounts administered by the people using the app.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    InstagramManageUpcomingEvents,
    /// <summary>
    /// The <typeparamref name="LeadsRetrieval"/> permission allows your app to retrieve and read all information captured by a lead ads form associated with an ad created in Ads Manager or the Marketing API.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Reach out to the people who followed up your lead ad form requesting more information. For example, an auto dealer reaching out to a potential customer (lead) that responded to their ad with quotes for a car.</description>
    ///     </item>
    ///     <item>
    ///         <description>For advertiser authorized CRM platforms to pull the lead data on behalf of the advertisers. These advertisers can then use the lead information to reach out to the user.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    LeadsRetrieval,
    /// <summary>
    /// The <typeparamref name="ManageFundraisers"/> permission allows an app to create, update, and read a fundraiser and its donations on behalf of a user.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Help fundraiser creators to expand their reach on Facebook.</description>
    ///     </item>
    ///     <item>
    ///         <description>Sync the amount raised displayed on the fundraiser's website and the linked Facebook fundraiser.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    ManageFundraisers,
    /// <summary>
    /// The <typeparamref name="PagesEvents"/> permissions allows your app permission to log events on behalf of Facebook Pages administered by people using your app and to send those events to Facebook for ads targeting, optimization and reporting.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type = "bullet">
    ///     <item>
    ///         <description>Send businesses related activities (for example purchase, add-to-cart, lead) on behalf of Pages owned by the people who use your app.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesEvents,
    /// <summary>
    /// The <typeparamref name="PagesManageAds"/> permission allows your app to manage ads associated with the Page.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Create ads for your Page.</description>
    ///     </item>
    ///     <item>
    ///         <description>Manage ads for your Page.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesManageAds,
    /// <summary>
    /// The <typeparamref name="PagesManageCta"/> permission allows your app to carry out POST and DELETE functions on endpoints used to manage call-to-action buttons on a Facebook Page.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Provide API access to manage call-to-action buttons on Pages that you manage.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesManageCta,
    /// <summary>
    /// The <typeparamref name="PagesManageInstantArticles"/> permission allows your app to manage Instant Articles on behalf of Facebook Pages administered by people using your app.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Create and update Instant Articles for Pages owned by the people who use your app.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesManageInstantArticles,
    /// <summary>
    /// The <typeparamref name="PagesManageEngagement"/> permission allows your app to create, edit, and delete comments posted on the Page.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Publish a comment on a Page post.</description>
    ///     </item>
    ///     <item>
    ///         <description>Update your comment on a Page post.</description>
    ///     </item>
    ///     <item>
    ///         <description>Delete a comment on a Page post.</description>
    ///     </item>
    ///     <item>
    ///         <description>Like a Page post or remove your Like from a Page post.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesManageEngagement,
    /// <summary>
    /// The <typeparamref name="PagesManageMetadata"/> permission allows your app to subscribe and receive webhooks about activity on the Page, and to update settings on the Page.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Subscribe to receive webhooks of your Page.</description>
    ///     </item>
    ///     <item>
    ///         <description>Update settings of your Page.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesManageMetadata,
    /// <summary>
    /// The <typeparamref name="PagesManagePosts"/> permission allows your app to create, edit, and delete your Page posts.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Publish a post, photo, or video to your Page.</description>
    ///     </item>
    ///     <item>
    ///         <description>Update a post, photo, or video on your Page.</description>
    ///     </item>
    ///     <item>
    ///         <description>Delete a post, photo, or video on your Page.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesManagePosts,
    /// <summary>
    /// The <typeparamref name="PagesMessaging"/> permission allows your app to manage and access Page conversations in Messenger.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Create interactive experiences initiated by a user.</description>
    ///     </item>
    ///     <item>
    ///         <description>Confirm customer interactions such as purchases, orders, and bookings.</description>
    ///     </item>
    ///     <item>
    ///         <description>Send customer support messages.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesMessaging,
    /// <summary>
    /// The <typeparamref name="PagesReadEngagement"/> permission allows your app to read content (posts, photos, videos, events) posted by the Page, read followers' data (including name, PSID), and profile picture, and read metadata and other insights about the Page.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Get content posted by your Page.</description>
    ///     </item>
    ///     <item>
    ///         <description>Get names, PSIDs, and profile pictures of your Page followers.</description>
    ///     </item>
    ///     <item>
    ///         <description>Get metadata about your Page.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesReadEngagement,
    /// <summary>
    /// The <typeparamref name="PagesReadUserContent"/> permission allows your app to read user-generated content on the Page, such as posts, comments, and ratings by users or other Pages, and to delete user comments on Page posts.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Get user-generated content on your Page.</description>
    ///     </item>
    ///     <item>
    ///         <description>Get posts that your Page is tagged in.</description>
    ///     </item>
    ///     <item>
    ///         <description>Delete comments posted by users on your Page.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesReadUserContent,
    /// <summary>
    /// The <typeparamref name="PagesShowList"/> permission allows your app to access the list of Pages a person manages.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Show a person the list of Pages they manage.</description>
    ///     </item>
    ///     <item>
    ///         <description>Verify that a person manages a Page.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesShowList,
    /// <summary>
    /// The <typeparamref name="PagesUserGender"/> permission allows your app to access a user's gender through the Page your app is connected to.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Personalize experiences or recommendations based on gender.</description>
    ///     </item>
    ///     <item>
    ///         <description>Use gendered language such as correct pronouns and titles.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesUserGender,
    /// <summary>
    /// The <typeparamref name="PagesUserLocale"/> permission allows your app to access a user's locale through the Page your app is connected to.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Personalize experiences based on the locale of a person by surfacing locale-specific content.</description>
    ///     </item>
    ///     <item>
    ///         <description>Send responses in the preferred language of the person.</description>
    ///     </item>
    ///     <item>
    ///         <description>Display numbers, times, and dates correctly for the locale of the person.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesUserLocale,
    /// <summary>
    /// The <typeparamref name="PagesUserTimezone"/> permission allows your app to access a user's time zone through the Page your app is connected to.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Personalize experiences or schedule content based on the user's time zone.</description>
    ///     </item>
    ///     <item>
    ///         <description>Send notifications or reminders at appropriate times based on the user's time zone.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PagesUserTimezone,
    /// <summary>
    /// The <typeparamref name="PrivateComputationAccess"/> permission allows your app to access Meta's Private Computation products.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Access and utilize Meta's Private Computation products for data processing.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PrivateComputationAccess,
    /// <summary>
    /// The <typeparamref name="PublicProfile"/> permission allows your app to read the user's basic public profile information.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Access basic profile information such as name, profile picture, and user ID.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PublicProfile,
    /// <summary>
    /// The <typeparamref name="PublishVideo"/> permission allows your app to publish live videos on behalf of the user.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Stream live video on behalf of the user.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    PublishVideo,
    /// <summary>
    /// The <typeparamref name="ReadInsights"/> permission allows your app to read Insights data for the user's Pages, apps, and web domains.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Access and analyze Insights data related to user engagement and content performance.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    ReadInsights,
    /// <summary>
    /// The <typeparamref name="ThreadsBasic"/> permission allows your app to read basic profile information and content published by the user on Threads.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Access the user's profile information and the content they have published on Threads.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    ThreadsBasic,
    /// <summary>
    /// The <typeparamref name="ThreadsContentPublish"/> permission allows your app to create and publish content on behalf of the user's Threads profile.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Publish content to the user's Threads profile.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    ThreadsContentPublish,
    /// <summary>
    /// The <typeparamref name="ThreadsManageInsights"/> permission allows your app to access and manage insights for the user's Threads profile.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Access and analyze insights for the user's Threads profile.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    ThreadsManageInsights,
    /// <summary>
    /// The <typeparamref name="ThreadsShowList"/> permission allows your app to view the list of people who the user follows on Threads.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Access the list of people followed by the user on Threads.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    ThreadsShowList,
    /// <summary>
    /// The <typeparamref name="UserGender"/> permission allows your app to access the user's gender information.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Personalize experiences based on the user's gender.</description>
    ///     </item>
    ///     <item>
    ///         <description>Use gender-specific language, pronouns, and titles.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    UserGender,
    /// <summary>
    /// The <typeparamref name="UserAgeRange"/> permission allows your app to access the user's age range.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Personalize experiences and content based on the user's age range.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    UserAgeRange,
    /// <summary>
    /// The <typeparamref name="UserFriends"/> permission allows your app to access the user's friends list.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Display the user's friends list to connect them with others.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    UserFriends,
    /// <summary>
    /// The <typeparamref name="UserHometown"/> permission allows your app to read a person's hometown location from their Facebook profile.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Provide a personalized experience based on where a person lived or grew up.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    UserHometown,
    /// <summary>
    /// The <typeparamref name="UserLikes"/> permission allows your app to read a list of all Facebook Pages that a user has liked.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Provide a personalized experience by correlating or surfacing content related to the person’s likes.</description>
    ///     </item>
    ///     <item>
    ///         <description>Curate content at scale to customize apps with large amounts of content.</description>
    ///     </item>
    ///     <item>
    ///         <description>Enable people to share their likes with others, such as in dating and music apps.</description>
    ///     </item>
    ///     <item>
    ///         <description>Allow parental access controls and monitoring apps to analyze user likes for potential safety and wellbeing issues for people under 18 years old.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    UserLikes,
    /// <summary>
    /// The <typeparamref name="UserLink"/> permission allows your app to access the Facebook profile URL of the person using your app.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Provide a way for someone who uses your app to visit another person's Facebook profile.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    UserLink,
    /// <summary>
    /// The <typeparamref name="UserLocation"/> permission allows your app to read the city name as listed in the location field of a person's Facebook profile.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Provide a personalized experience based on the city name as listed in the location field of a person's Facebook profile.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    UserLocation,
    /// <summary>
    /// The <typeparamref name="UserMessengerContact"/> permission allows a business to contact a person via Messenger upon their approval or initiation of a chat thread with the business's Page.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>For a Page to send a person an initial message, post-purchase updates, and account updates.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    UserMessengerContact,
    /// <summary>
    /// The <typeparamref name="UserPhotos"/> permission allows your app to read the photos a person has uploaded to Facebook.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Create physical or digital books or albums of a person's photos, which includes permitting people to export photos for printing.</description>
    ///     </item>
    ///     <item>
    ///         <description>Provide people with the ability to display their photos with other app users, for example in dating or social apps.</description>
    ///     </item>
    ///     <item>
    ///         <description>Provide people with the ability to edit or create new photo content based on existing photos.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    UserPhotos,
    /// <summary>
    /// The <typeparamref name="UserPosts"/> permission allows your app to access the posts that a user has made on their timeline.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Enable people to create physical or digital books or albums of their timelines.</description>
    ///     </item>
    ///     <item>
    ///         <description>Allow people to share memories from their timeline on Facebook or on other social apps.</description>
    ///     </item>
    ///     <item>
    ///         <description>Allow parental access controls and monitoring apps to analyze a post's content to detect potential risk to safety or wellbeing for people under 18 years old.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    UserPosts,
    /// <summary>
    /// The <typeparamref name="UserVideos"/> permission allows your app to read a list of videos uploaded by a person.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Display a person's videos on a TV via a set-top box or in a digital photo frame.</description>
    ///     </item>
    ///     <item>
    ///         <description>Provide people with the ability to edit or create new video content using existing videos.</description>
    ///     </item>
    ///     <item>
    ///         <description>Provide people with the ability to display their video with others within their app, for example in dating or social apps.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    UserVideos,
    /// <summary>
    /// The <typeparamref name="WhatsappBusinessManagement"/> permission allows your app to read and/or manage WhatsApp business assets you own or have been granted access to by other businesses through this permission.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Manage WhatsApp business assets.</description>
    ///     </item>
    ///     <item>
    ///         <description>Display WhatsApp Business Account analytics in your customer portal.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    WhatsappBusinessManagement,
    /// <summary>
    /// The <typeparamref name="WhatsappBusinessMessaging"/> permission allows an app to send WhatsApp messages to a specific phone number, upload and retrieve media from messages, manage and get WhatsApp business profile information, and to register those phone numbers with Meta.
    /// </summary>
    /// <remarks>
    /// Allowed Usages:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Send WhatsApp messages to a specific phone number.</description>
    ///     </item>
    ///     <item>
    ///         <description>Upload and retrieve media from messages.</description>
    ///     </item>
    ///     <item>
    ///         <description>Manage and get WhatsApp business profile information.</description>
    ///     </item>
    ///     <item>
    ///         <description>Register a phone number with Meta.</description>
    ///     </item>
    /// </list>
    /// </remarks>
    WhatsappBusinessMessaging
}