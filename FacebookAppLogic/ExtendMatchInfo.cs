using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class ExtendMatchInfo : IMyMatchInfoStrategy
    {
        public List<string> CreateListOfMatchInfo(User i_Friend)
        {
            List<string> matchesInfo = new List<string>();
            int currentYear = int.Parse(DateTime.Now.Year.ToString());
            int yearOfBirth = int.Parse(i_Friend.Birthday.Substring(6, 4));
            string friendLocation = i_Friend.Location.ToString();

            matchesInfo.Add(string.Format($@"Name: {i_Friend.Name}"));
            matchesInfo.Add(string.Format($@"Age: {currentYear - yearOfBirth}"));
            friendLocation = friendLocation.Replace("(location: )", "");
            matchesInfo.Add(string.Format($@"Location: {friendLocation}"));
            matchesInfo.Add(string.Format($@"Gender: {i_Friend.Gender}"));

            return matchesInfo;
        }
    }
}