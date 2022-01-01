using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class MyMatchFormatAdapter : IMyMatchFormat
    {
        private readonly User r_FriendUser;
        private readonly int r_CurrentYear;
        private IMyMatchInfoStrategy m_MatchInfoFormat;

        public MyMatchFormatAdapter(User i_FriendUser, int i_Type)
        {
            r_FriendUser = i_FriendUser;
            m_MatchInfoFormat = selectedFormat(i_Type);
        }

        private IMyMatchInfoStrategy selectedFormat(int i_Type)
        {
            IMyMatchInfoStrategy formatOfStrategy;
            if (i_Type == 1)
            {
                formatOfStrategy = new LimitedMatchInfo();

            }
            else
            {
                formatOfStrategy = new ExtendMatchInfo();
            }

            return formatOfStrategy;
        }

        public List<string> CreateFormattedMatchesList()
        {
            try
            {
                List<string> matchInfo = m_MatchInfoFormat.CreateListOfMatchInfo(r_FriendUser);
                matchInfo.Add(drawLine());

                return matchInfo;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: Couldn't fetch information");
            }
        }
        private string drawLine()
        {
            return @"-------------------------------------------------------------------------";
        }
    }
}