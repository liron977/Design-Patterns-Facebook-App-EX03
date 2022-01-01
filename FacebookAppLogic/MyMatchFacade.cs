using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class MyMatchFacade
    {
        private readonly FindMyMatchLogic r_FindMyMatchLogic = new FindMyMatchLogic();

        public void FilterMyMatch(int i_FromAge, int i_ToAge, User.eGender i_Gender)
        {
            r_FindMyMatchLogic.FilterMyMatch(i_FromAge, i_ToAge, i_Gender);
        }

        public List<FriendLogic> GetMyMatches()
        {
            return r_FindMyMatchLogic.r_FriendsList;
        }

        public List<string> GetMyMatchesInfo(int i_type)
        {
            List<string> matchesByFormat = new List<string>();

            foreach(FriendLogic friend in r_FindMyMatchLogic.r_FriendsList)
            {
                IMyMatchFormat iMatchesFormat = new MyMatchFormatAdapter(friend.Friend, i_type);
                matchesByFormat.AddRange(iMatchesFormat.CreateFormattedMatchesList());
            }

            return matchesByFormat;
        }

        public User GetMyFan()
        {
            return r_FindMyMatchLogic.FindMyFan();
        }

        public void UpdateMatchesList(List<FriendLogic> i_FriendsList)
        {
            r_FindMyMatchLogic.UpdateFriendList(i_FriendsList);
        }

        public int GetSelectedMatchIndex(string i_SelectedItem, int i_SelectedIndex, int i_type)
        {
            return r_FindMyMatchLogic.GetNameIndex(i_SelectedItem, i_SelectedIndex, i_type);
        }

        public User GetSelectedMatch(string i_SelectedMatch)
        {
            return r_FindMyMatchLogic.FindSelectedFriend(i_SelectedMatch);
        }
    }
}