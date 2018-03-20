using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Gaming
    {
        public string word;
        public string userpackage;
        public string flag;
        public string username;
        public string roomnumber;
        public Gaming(String package)
        {
            this.userpackage = package;
            Analysics();
        }
        public void Analysics()
        {
            flag = userpackage.Substring(0, 1);
            roomnumber = userpackage.Substring(1, 1);
            username = userpackage.Substring(2, 4);
            if (flag == "3")
                Judge();
        }
        public void Judge()
        {
            PackData newpackage;
            string Judging = userpackage.Substring(6);
            if (Judging == word)
            {
                newpackage = new PackData("6");
                newpackage.Roomnumber = roomnumber;
                newpackage.Name = username;
                newpackage.PackData6();
                Send sender = new Send();
                sender.Package = newpackage.result;
                sender.SendDataToServer();
            }
        }
        
    }
}
