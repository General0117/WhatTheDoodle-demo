﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 你画我猜
{
    class PackData
    {
        public string result;
        byte[] data = new byte[1024];
        public string Flag;
        public string Roomnumber;
        public String Name;
        public String Message;
        public int[,] Location = new int[10, 2];
        public int[] PlayerRoom = new int[6];
        public string[] PlayerName = new string[6];
        public int[] PlayerScore = new int[6];
        public PackData(string Flag)
        {
            this.Flag = Flag;
        }
        public void Start()
        {
            switch (Flag)
            {
                case "1":
                    PackData1();
                    break;
                case "2":
                    PackData2();
                    break;
                case "3":
                    PackData3();
                    break;
                case "4":
                    PackData4();
                    break;
                //case 5:
                //    PackData5();
                //    break;
                case "6":
                    PackData6();
                    break;
                case "7":
                    PackData7();
                    break;
                case "8":
                    PackData8();
                    break;
                default:
                    PackdataError();
                    break;
            }
        }
        public void PackData1()
        {
            result = Flag + Roomnumber + Name;
        }
        public void PackData2()
        {
            result = Flag + Roomnumber + Name;
        }
        public void PackData3()
        {
            result = Flag +Roomnumber+Name + Message;
        }
        public void PackData4()
        {
            result = Flag + Roomnumber + Name;
            for (int i = 0; i <= 9; i++)
                for (int j = 0; j <= 1; j++)
                {
                    string lo1, lo2, lo3, lo4;
                    int temp = Location[i, j];
                    lo1 = Convert.ToString(temp / 1000);
                    lo2 = Convert.ToString(temp % 1000 / 100);
                    lo3 = Convert.ToString(temp % 100 / 10);
                    lo4 = Convert.ToString(temp % 10);
                    result = result + lo1 + lo2 + lo3 + lo4;
                }
        }
        //public void PackData5()
        //{

        //}
        public void PackData6()
        {
            result = Flag + Roomnumber + Name;
        }
        public void PackData7()
        {
            result = Flag + Roomnumber + Name;
        }
        public void PackData8()
        {
            result = Flag;
        }
        public void PackData9()
        {
            result = Flag + Roomnumber;
        }
        public void PackdataError()
        {
            Console.WriteLine("ERROR");
            return;
        }
    }
}
