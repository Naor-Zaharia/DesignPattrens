using System.Threading;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebookLogic
{
    internal static class SoulMateLogic
    {
        private static int getScoreLanguages(User i_LoginUser, User i_FriendUser)
        {
            int LanguageScore = 0;

            if (i_LoginUser.Languages != null)
            {
                foreach (Page currentLanguage in i_LoginUser.Languages)
                {
                    foreach (Page currentFriendLanguage in i_FriendUser.Languages)
                    {
                        if (currentFriendLanguage.Name == currentLanguage.Name)
                        {
                            LanguageScore++;
                        }
                    }
                }
            }

            return LanguageScore;
        }

        private static int getScoreLocation(User i_LoginUser, User i_FriendUser)
        {
            int locationScore = 0;

            if (i_FriendUser.Location.Name == i_LoginUser.Location.Name)
            {
                locationScore++;
            }

            return locationScore;
        }

        private static int getScoreCheckIns(User i_LoginUser, User i_FriendUser)
        {
            int checkInsScore = 0;

            foreach (Checkin currentCheckIn in i_LoginUser.Checkins)
            {
                foreach (Checkin currentFriendCheckIn in i_FriendUser.Checkins)
                {
                    if (currentCheckIn.Name == currentCheckIn.Name)
                    {
                        checkInsScore++;
                    }
                }
            }

            return checkInsScore;
        }

        private static int getScoreEvents(User i_LoginUser, User i_FriendUser)
        {
            int eventsScore = 0;

            foreach (Event currentEvents in i_LoginUser.Events)
            {
                foreach (Event currentFriendEvents in i_FriendUser.Events)
                {
                    if (currentEvents.Name == currentFriendEvents.Name)
                    {
                        eventsScore++;
                    }
                }
            }

            return eventsScore;
        }

        private static int getScoreLikedPages(User i_LoginUser, User i_FriendUser)
        {
            int likedPagesScore = 0;

            foreach (Page currentLikedPages in i_LoginUser.LikedPages)
            {
                foreach (Page currentFriendLikesPage in i_FriendUser.LikedPages)
                {
                    if (currentFriendLikesPage.Name == currentLikedPages.Name)
                    {
                        likedPagesScore++;
                    }
                }
            }

            return likedPagesScore;
        }

        internal static int GetUserScore(User i_LoginUser, User i_FriendUser)
        {
            int scoreLanguages = 0;
            int scoreLocation = 0;
            int scoreCheckIns = 0;
            int scoreEvents = 0;
            int scoreLikedPages = 0;         

            Thread getScoreLanguagesThread = new Thread(() => { scoreLanguages = getScoreLanguages(i_LoginUser, i_FriendUser); });
            getScoreLanguagesThread.Start();
            Thread getScoreLocationThread = new Thread(() => { scoreLocation = getScoreLocation(i_LoginUser, i_FriendUser); });
            getScoreLocationThread.Start();
            Thread getScoreCheckInsThread = new Thread(() => { scoreCheckIns = getScoreCheckIns(i_LoginUser, i_FriendUser); });
            getScoreCheckInsThread.Start();
            Thread getScoreEventsThread = new Thread(() => { scoreEvents = getScoreEvents(i_LoginUser, i_FriendUser); });
            getScoreEventsThread.Start();
            Thread getScoreLikedPagesThread = new Thread(() => { scoreLikedPages = getScoreLanguages(i_LoginUser, i_FriendUser); });
            getScoreLikedPagesThread.Start();

            getScoreLanguagesThread.Join();
            getScoreLocationThread.Join();
            getScoreCheckInsThread.Join();
            getScoreEventsThread.Join();
            getScoreLikedPagesThread.Join();

            return scoreLanguages + scoreLikedPages + scoreLocation + scoreCheckIns + scoreEvents;
        }
    }
}
