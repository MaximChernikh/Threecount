using System;
using System.Globalization;
using System.IO;
using System.IO.Enumeration;

namespace Saloon
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Writer writer = new Writer();
            FileSaver fileSaver = new FileSaver();

            writer.WriteSaloonFileInfo(out SaloonFileInfo saloonFileInfo);
            fileSaver.SaveSaloonFileinfo(ref saloonFileInfo);
            fileSaver.SaveFriendsList(ref saloonFileInfo);
        }
    }
}
