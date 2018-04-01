using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 你画我猜
{
    public class Gaming
    {
        public string word;
        public string userpackage;
        public string flag;
        public string username;
        public string roomnumber;
        public bool correct = false;
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
        }
        public void Judge()
        {
            string Judging = userpackage.Substring(6);
            if (Judging == word)
            {
                correct = true;
            }
            else
                Rewritemessage();
        }
        public void Rewritemessage()
        {
            string newmessage = " ";

            for(int i = 0;i<word.Length;i++)
            {
                for(int j=0;j<userpackage.Length;j++)
                {
                    if (word.Substring(i, 1) == userpackage.Substring(j, 1))
                        newmessage = newmessage + "*";
                    else
                        newmessage = newmessage + userpackage.Substring(j, 1);
                }
            }

            userpackage = newmessage;
        }

        
    }
}
