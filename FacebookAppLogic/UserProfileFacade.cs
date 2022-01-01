using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public class UserProfileFacade
    {
        private readonly FacebookAppManager r_AppManager;

        public UserProfileFacade()
        {
            r_AppManager = FacebookAppManager.Instance;
        }
        public void initFriendList()
        {
            r_AppManager.initFriendList();
        }

        public string GetPicture()
        {
            return r_AppManager.FetchPicture();
        }

        public List<string> GetNewsFeed()
        {
            return r_AppManager.FetchNewsFeed();
        }

        public List<User> GetFriends()
        {
            return r_AppManager.FetchFriendsList();
        }

    /*    public List<string> GetUpcomingBirthdays()
        {
           // return r_AppManager.();
        }
*/
        public List<Album> GetAlbums()
        {
            return r_AppManager.FetchAlbums();
        }

        public Status PostStatus(string i_UserStatusText)
        {
            return r_AppManager.PostStatus(i_UserStatusText);
        }

        public void PostAndTag(User i_User, string i_Message)
        {
            r_AppManager.PostAndTag(i_User, i_Message);
        }

        public string GetUserName()
        {
            return r_AppManager.FetchUserName();
        }
        public IEnumerator<User> FetchUpcomingBirthdays(int i_UpcomingDays)
        {
            string nextDays;
           
            r_AppManager.FilterUpcomingBirthdays = i_Friend =>
            {
                for (int i = 0; i <= i_UpcomingDays; i++) { nextDays = DateTime.Now.Date.AddDays(i).ToString("dd/MM"); if (string.Compare(nextDays, i_Friend.Birthday.Substring(0, 5)) == 0) return true; }
                return false;
            };
            return GetEnumerator();
        }
        public IEnumerator<User> GetEnumerator()
        {
            return r_AppManager.GetEnumerator();
        }
    }
}