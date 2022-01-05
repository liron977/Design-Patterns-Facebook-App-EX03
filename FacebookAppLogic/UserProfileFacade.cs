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
            int monthBirth = DateTime.Now.Date.AddDays(i_UpcomingDays).Month;
            int daybirth = DateTime.Now.Date.AddDays(i_UpcomingDays).Day;
            r_AppManager.FilterUpcomingBirthdays = i_Friend => ( int.Parse(i_Friend.Birthday.Substring(0, 2)) <= daybirth && int.Parse(i_Friend.Birthday.Substring(3, 2)) == monthBirth);
                
            return GetEnumerator();
        }
        public IEnumerator<User> GetEnumerator()
        {
            return r_AppManager.GetEnumerator();
        }
    }
}