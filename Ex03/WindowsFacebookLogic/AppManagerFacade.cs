using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebookLogic
{
    public class AppManagerFacade
    {
        public event FacebookThemeChanged.FacebookThemeChangedEventHandler ThemeChanged = null;

        private readonly Sorter<Event> r_EventSorter = new Sorter<Event>();
        private LoginResult m_LoginResult;
        private FacebookObjectCollection<Post> m_Posts;
        private FacebookObjectCollection<Event> m_Events;
        private FacebookObjectCollection<User> m_Friends;
        private FacebookObjectCollection<Page> m_LikedPages;
        private FacebookObjectCollection<Album> m_Albums;
        private FacebookObjectCollection<Group> m_Groups;
        private LogicEnums.eThemeColor m_ThemeColor = LogicEnums.eThemeColor.Blue;
        
        private AppManagerFacade()
        {
        }

        public static AppManagerFacade AppManagerFacadeInstance()
        {
            return Singleton<AppManagerFacade>.Instance;
        }

        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }

            set
            {
                m_LoginResult = value;
            }
        }

        public User LoginUser()
        {
            User user = null;

            if (m_LoginResult != null)
            {
                user = m_LoginResult.LoggedInUser;
            }

            return user;
        }

        public void LoadUserData()
        {
            User user = m_LoginResult.LoggedInUser;
            Albums = user.Albums;
            Friends = user.Friends;
            Posts = user.Posts;
            Events = user.Events;
        }   

        public LogicEnums.eThemeColor ThemeColor
        {
            get
            {
                return m_ThemeColor;
            }

            set
            {
                m_ThemeColor = value;
                OnThemeChanged(m_ThemeColor);
            }
        }

        protected virtual void OnThemeChanged(LogicEnums.eThemeColor i_ThemeColor)
        {
            if (ThemeChanged != null)
            {
                ThemeChanged.Invoke(i_ThemeColor);
            }
        }

        public void SetCollectionLimits(int i_CollectionLimit)
        {
            FacebookService.s_CollectionLimit = i_CollectionLimit;
        }

        public void SetDefaultCollectionLimits()
        {
            FacebookService.s_CollectionLimit = 100;
        }

        public User GetUserByName(User i_LoginUser, string i_Name)
        {
            User user = null;

            foreach (User currentUser in i_LoginUser.Friends)
            {
                if (currentUser.Name == i_Name)
                {
                    user = currentUser;
                }
            }

            return user;
        }

        public string GetFriendStatus(User i_LoginUser, string i_Name)
        {
            string friendStatusString = null;
            User friendUser = GetUserByName(i_LoginUser, i_Name);
            if (friendUser != null)
            {
                switch (friendUser.OnlineStatus)
                {
                    case User.eOnlineStatus.active:
                        friendStatusString = LogicMessages.k_ActiveString;
                        break;
                    case User.eOnlineStatus.offline:
                        friendStatusString = LogicMessages.k_OfflineString;
                        break;
                    case User.eOnlineStatus.idle:
                        friendStatusString = LogicMessages.k_IdleString;
                        break;
                    case User.eOnlineStatus.unknown:
                        friendStatusString = LogicMessages.k_UnknownString;
                        break;
                    default:
                        friendStatusString = LogicMessages.k_IssueRetriveFriendString;
                        break;
                }
            }

            return friendStatusString;
        }

        public List<Photo> GetMostLikedPhotosFromAlbum(Album i_AlbumPhotos, int i_AmountOfPhotos)
        {
            return CollageLogic.GetMostLikedPhotosFromAlbum(i_AlbumPhotos, i_AmountOfPhotos);
        }

        public List<Photo> GetRandomPhotosFromAlbum(Album i_AlbumPhotos, int i_AmountOfPhotos)
        {
            return CollageLogic.GetRandomPhotosFromAlbum(i_AlbumPhotos, i_AmountOfPhotos);
        }

        public List<Event> SortEvent(LogicEnums.eSortType i_SortType, FacebookObjectCollection<Event> i_EventsForSort)
        {
            r_EventSorter.Comparer = FactorySortEvents.GetSorterObject(i_SortType);
            return r_EventSorter.Sort(i_EventsForSort);
        }

        public int GetUserScore(User i_LoginUser, User i_FriendUser)
        {
            return SoulMateLogic.GetUserScore(i_LoginUser, i_FriendUser);
        }

        public LoginResult CheckForQuickLogin()
        {
            return FacebookLoginLogic.CheckForQuickLogin();
        }

        public LoginResult LoginAndInit(string i_AppID)
        {
            return FacebookLoginLogic.LoginAndInit(i_AppID);
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return m_Albums;
            }

            set
            {
                m_Albums = value;
            }
        }

        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                return m_Posts;
            }

            set
            {
                m_Posts = value;
            }
        }

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                return m_Events;
            }

            set
            {
                m_Events = value;
            }
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get
            {
                return m_LikedPages;
            }

            set
            {
                m_LikedPages = value;
            }
        }

        public FacebookObjectCollection<User> Friends
        {
            get
            {
                return m_Friends;
            }

            set
            {
                m_Friends = value;
            }
        }

        public FacebookObjectCollection<Group> Groups
        {
            get
            {
                return m_Groups;
            }

            set
            {
                m_Groups = value;
            }
        }
    }
}