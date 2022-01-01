using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
   public interface IMyMatchInfoStrategy
    {
         List<string> CreateListOfMatchInfo(User i_Friend);
    }
}
