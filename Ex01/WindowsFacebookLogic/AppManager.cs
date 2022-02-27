using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebookLogic
{
    public class AppManager
    {
        private static readonly object sr_CreationLockContext = new object();
        private static AppManager s_AppManager = null;
        private LoginResult m_LoginResult;

        public AppManager()
        {
        }

        public static AppManager AppManagerInstance()
        {
            if (s_AppManager == null)
            {
                lock (sr_CreationLockContext)
                {
                    if (s_AppManager == null)
                    {
                        s_AppManager = new AppManager();
                    }
                }
            }

            return s_AppManager;
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
                        friendStatusString = "Active";
                        break;
                    case User.eOnlineStatus.offline:
                        friendStatusString = "Offline";
                        break;
                    case User.eOnlineStatus.idle:
                        friendStatusString = "Idle";
                        break;
                    case User.eOnlineStatus.unknown:
                        friendStatusString = "Unknown";
                        break;
                    default:
                        friendStatusString = "Had issues get friend status";
                        break;
                }
            }

            return friendStatusString;
        }

        public FacebookObjectCollection<Photo> GetAlbumCopy(FacebookObjectCollection<Photo> i_Album)
        {
            FacebookObjectCollection<Photo> albumPhotosCopy = new FacebookObjectCollection<Photo>();

            foreach (Photo currentPhoto in i_Album)
            {
                albumPhotosCopy.Add(currentPhoto);
            }

            return albumPhotosCopy;
        }

        public int GetNextPictureIndex(Album i_Album, int i_CurrentIndex)
        {
            return (i_CurrentIndex + 1) % i_Album.Photos.Count;
        }

        public int GetPreviousPictureIndex(Album i_Album, int i_CurrentIndex)
        {
            int index = i_CurrentIndex - 1;

            if (index < 0)
            {
                index = i_Album.Photos.Count - 1;
            }

            return index;
        }
    }
}
