using FacebookWrapper;

namespace WindowsFacebookLogic
{
    internal static class FacebookLoginLogic
    {
        private static string[] s_AppPremissions =
            {
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown"
        };

        internal static LoginResult LoginAndInit(string i_AppID)
        {
            LoginResult loginResult = null;

            loginResult = FacebookService.Login(i_AppID, s_AppPremissions);
            if (loginResult.FacebookOAuthResult.IsSuccess)
            {
                AppManagerFacade appManagerFacade = AppManagerFacade.AppManagerFacadeInstance();
                registerLoginResultOnAppManager(appManagerFacade, loginResult);
            }

            return loginResult;
        }

        internal static LoginResult CheckForQuickLogin()
        {
            LoginResult loginResult = null;

            AppSettings m_AppSettings = AppSettings.LoadFromFile();

            if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                loginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                AppManagerFacade appManagerFacade = AppManagerFacade.AppManagerFacadeInstance();
                registerLoginResultOnAppManager(appManagerFacade, loginResult);
            }

            return loginResult;
        }

        private static void registerLoginResultOnAppManager(AppManagerFacade io_AppManagerFacade, LoginResult i_LoginResult)
        {
            io_AppManagerFacade.LoginResult = i_LoginResult;
            io_AppManagerFacade.SetDefaultCollectionLimits();
            io_AppManagerFacade.LoadUserData();
        }
    }
}
