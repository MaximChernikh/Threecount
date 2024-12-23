using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saloon
{
    public interface IConosoleWriter
    {
        void WriteSaloonFileInfo(out SaloonFileInfo saloonFileInfo);

        void WriteFriendsList();
    }
}