using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
namespace FacebookAppLogic
{
    public class LimitedMatchInfo:IMyMatchInfoStrategy
    {
        public List<string> CreateListOfMatchInfo(User i_Friend)
        {
            List<string> matchesInfo = new List<string>();
            int r_CurrentYear = int.Parse(DateTime.Now.Year.ToString());
            int yearOfBirth = int.Parse(i_Friend.Birthday.Substring(6, 4));

            matchesInfo.Add(string.Format($@"Match`s name: {i_Friend.Name}"));
            matchesInfo.Add(string.Format($@"Age: {r_CurrentYear - yearOfBirth}"));
            return matchesInfo;
        }
    }
}
