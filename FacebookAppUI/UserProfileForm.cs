﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace BasicFacebookFeatures
{
    internal partial class UserProfileForm : Form
    {
        private readonly UserProfileFacade r_ProfileFacade = new UserProfileFacade();

        private const string k_MessageSomethingWrong = "Something wrong. Try later";
        private const string k_MessageNoData = "No data to show";
        private const string k_MessageStatusPosted = "Status Posted! ID";
        private const string k_MessageErrorBirthday = @"None of your friends has birthday in the next 3 days";
        private IEnumerator<User> m_BirthYearFriends;
        private int m_UpcomungDays=3;


        public UserProfileForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs i_E)
        {
            r_ProfileFacade.initFriendList();
            new Thread(fetchInfo).Start();
           
        }

        private void fetchInfo()
        {
            ProfilePicture.Load(r_ProfileFacade.GetPicture());
            new Thread(fetchNewsFeed).Start();
            new Thread(fetchFriends).Start();
           // new Thread(fetchUpcomingBirthdays).Start();
            new Thread(fetchAlbums).Start();
        }

        private void fetchUpcomingBirthdays()
        {
           
                        upcomingBirthdaysListBox.Items.Clear();
            
                        m_BirthYearFriends = r_ProfileFacade.FetchUpcomingBirthdays(m_UpcomungDays);

                        using (IEnumerator<User> iterator = m_BirthYearFriends)
                        {
                            while (iterator.MoveNext())
                            {
                        upcomingBirthdaysListBox.Items.Add(iterator.Current);
                            }
                        }

                        if (upcomingBirthdaysListBox.Items.Count == 0)
                        {
                            MessageBox.Show(
                                (string.Format($@"No friend in birth year: {m_UpcomungDays} using this app. 
This is the time to enlarge the friends in this age")));
                        }
                    
              /*      else
                    {
                        MessageBox.Show(k_MessageErrorBirthday);
                    }*/
              
            



            /* try
             {
                 if(upcomingBirthdaysListBox.Items.Count != 0)
                 {
                     upcomingBirthdaysListBox.Invoke(new Action(() => upcomingBirthdaysListBox.Items.Clear()));
                 }
                 else
                 {
                     List<string> friendList = r_ProfileFacade.GetUpcomingBirthdays();

                     foreach(string friendUser in friendList)
                     {
                         upcomingBirthdaysListBox.Invoke(
                             new Action(() => upcomingBirthdaysListBox.Items.Add(friendUser)));
                     }

                     if(friendsListBox.Items.Count == 0)
                     {
                         MessageBox.Show(k_MessageErrorBirthday);
                     }
                 }
             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        }

        private void fetchFriends()
        {
            try
            {
                if(friendsListBox.Items.Count != 0)
                {
                    friendsListBox.Items.Clear();
                }
                else
                {
                    List<User> friendList = r_ProfileFacade.GetFriends();

                    foreach(User friendUser in friendList)
                    {
                        friendsListBox.Invoke(new Action(() => friendsListBox.Items.Add(friendUser)));
                    }

                    if(friendsListBox.Items.Count == 0)
                    {
                        MessageBox.Show(k_MessageNoData);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void fetchNewsFeed()
        {
            try
            {
                List<string> userPosts = r_ProfileFacade.GetNewsFeed();

                foreach(string post in userPosts)
                {
                    posts.Invoke(new Action(() => posts.Items.Add(post)));
                }

                if(posts.Items.Count == 0)
                {
                    posts.Invoke(new Action(() => posts.Items.Add(k_MessageNoData)));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void friendsListBox_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            showSelectedFriendDetails();
        }

        private void showSelectedFriendDetails()
        {
            if(friendsListBox.SelectedItems.Count == 1)
            {
                User userFriend = friendsListBox.SelectedItem as User;
                FriendProfileForm friendProfile = new FriendProfileForm();
                friendProfile.r_ProfileFacade.FriendLogic.Friend = userFriend;

                friendProfile.Show();
            }
        }

        private void fetchAlbums()
        {
            try
            {
                List<Album> userAlbums = r_ProfileFacade.GetAlbums();
                albumBindingSource.DataSource = userAlbums;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void postStatusButton_Click_1(object i_Sender, EventArgs i_E)
        {
            try
            {
                if(!(string.IsNullOrEmpty(PostStatusTextBox.Text)))
                {
                    r_ProfileFacade.PostStatus(PostStatusTextBox.Text);
                    MessageBox.Show(k_MessageStatusPosted);
                }
                else
                {
                    MessageBox.Show(k_MessageSomethingWrong);
                }
            }
            catch
            {
                MessageBox.Show(k_MessageSomethingWrong);
            }
        }

  /*      private void radioButton7DaysFilter_CheckedChanged(object sender, EventArgs e)
        {
            m_UpcomungDays = 7;
            fetchUpcomingBirthdays();
     
        }*/

       /* private void radioButton3DaysFilter_CheckedChanged(object sender, EventArgs e)
        {
            m_UpcomungDays = 3;
            fetchUpcomingBirthdays();
        }*/

   /*     private void radioButtonIn30days_CheckedChanged(object sender, EventArgs e)
        {
            m_UpcomungDays = 30;
            fetchUpcomingBirthdays();
        }
*/
        private void radioButtonIn30days_Click(object sender, EventArgs e)
        {
            m_UpcomungDays = 30;
            fetchUpcomingBirthdays();
        }

        private void radioButton7DaysFilter_Click(object sender, EventArgs e)
        {
            m_UpcomungDays = 7;
            fetchUpcomingBirthdays();

        }

        private void radioButton3DaysFilter_Click(object sender, EventArgs e)
        {
            m_UpcomungDays = 187;
            fetchUpcomingBirthdays();

        }
    }
}