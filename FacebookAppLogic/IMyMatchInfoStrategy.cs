using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public interface IMyMatchInfoStrategy
    {
        List<string> CreateListOfMatchInfo(User i_Friend);
    }
}