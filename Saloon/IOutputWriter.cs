using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saloon
{
    public interface IOutputWriter
    {
        public void SaveSaloonFileinfo(ref SaloonFileInfo saloonFileInfo);
        public void SaveFriendsList(ref SaloonFileInfo saloonFileInfo);
    }
}