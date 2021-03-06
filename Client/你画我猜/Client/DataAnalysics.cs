﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 你画我猜
{
    public class DataAnalysics
    {

        public string PendData;
        public string AnalysicsFlag;
        public string AnalysicsRoomnumber;
        public String AnalysicsName;
        public String AnalysicsMessage;
        public int[,] Location = new int[10, 2];
        public string[] PlayerRoom = new string[6];
        public string[] PlayerName = new string[6];
        public string[] PlayerScore = new string[6];
        public string word;
        public int[] RoomNumber = new int[9];
        public int[] RoomPlayerNum = new int[9];
        public int[] Roomstate = new int[9];//游戏状态
        bool Isdraw = false;
        public DataAnalysics()
        {

        }
        public void AddData(string Data)
        {
            this.PendData = Data;
        }
        public void Analysics()
        {
            AnalysicsFlag = PendData.Substring(0,1);
            AnalysicsRoomnumber = PendData.Substring(1, 1);
            switch (AnalysicsFlag)
            {
                case "1":
                    AnalysicsData1();
                    break;
                case "2":
                    AnalysicsData2();
                    break;
                case "3":
                    AnalysicsData3();
                    break;
                case "4":
                    AnalysicsData4();
                    break;
                case "5":
                    AnalysicsData5();
                    break;
                case "6":
                    AnalysicsData6();
                    break;
                case "7":
                    AnalysicsData7();
                    break;
                default:
                    AnalysicError();
                    break;
            }
        }
        public void AnalysicsData1()
        {
            return;
        }
        public void AnalysicsData2()
        {
            return;
        }
        public void AnalysicsData3()
        {
            pbdata.messageFlag = true;
            AnalysicsName = PendData.Substring(2, 4);
            pbdata.messagename = AnalysicsName; 
            AnalysicsMessage = PendData.Substring(6);
            pbdata.message = AnalysicsMessage;
        }
        public void AnalysicsData4()
        {
            pbdata.drawFlag = true;
            AnalysicsName = PendData.Substring(2, 4);
            pbdata.AnalysicsName = AnalysicsName;
            int i = 0, j = 0;
            for (int k = 6; k < 85; k += 4)
            {
                string lo1, lo2, lo3, lo4;
                lo1 = PendData.Substring(k,1);
                lo2 = PendData.Substring(k + 1, 1);
                lo3 = PendData.Substring(k + 2, 1);
                lo4 = PendData.Substring(k + 3, 1);
                int lo11, lo22, lo33, lo44;
                lo11 = Convert.ToInt32(lo1);
                lo22 = Convert.ToInt32(lo2);
                lo33 = Convert.ToInt32(lo3);
                lo44 = Convert.ToInt32(lo4);
                Location[i, j] = lo11 * 1000 + lo22 * 100 + lo33*10 + lo44;
                j++;
                if (j == 2)
                {
                    j -= 2;
                    i++;
                }
            }
            Location = pbdata.Analysicslocation;
        }
        public void AnalysicsData5()
        {

            //AnalysicsName = Encoding.UTF8.GetString(PendData, 2, 4);
            int n = 0;
            for (int i = 2; i < 38; i = i + 6)
            {
                PlayerRoom[n] = PendData.Substring(i, 1);
                PlayerName[n] = PendData.Substring(i+1, 4);
                pbdata.playerName[n] = PlayerName[n];
                PlayerScore[n] = PendData.Substring(i + 5, 1);
                pbdata.playerScore[n] = PlayerScore[n];
                n++;
            }
        }
        public void AnalysicsData6()//大厅房间信息
        {
            AnalysicsName = PendData.Substring(2, 4);
            int j = 0;
            for(int i = 6;i<33;i+=3)
            {
                RoomNumber[j] = Convert.ToInt32(PendData.Substring(i, 1));
                RoomPlayerNum[j] = Convert.ToInt32(PendData.Substring(i+1, 1));
                pbdata.roomPlayerNum[j] = RoomPlayerNum[j];
                Roomstate[j] = Convert.ToInt32(PendData.Substring(i + 2, 1));
                pbdata.roomstate[j] = Roomstate[j];
                j++;
            }
        }
        public void AnalysicsData7()
        {
            AnalysicsName = PendData.Substring(2, 4);
            pbdata.gameName = AnalysicsName;
            word = PendData.Substring(6, 10);
            pbdata.word = word;
            pbdata.gameFlag = true;
        }
        public void AnalysicsData8()
        {
            Isdraw = true;
        }
        public void AnalysicError()
        {
            Console.WriteLine("ERROR");
            return;
        }
    }
}
