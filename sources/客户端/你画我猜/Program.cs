using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 你画我猜
{
    public class pbdata
    {
        public static bool ThreadRunning = true;
        public static bool IsClose = false;
        public static string Flag;  //package 标志
        public static string Name;  //用户名
        public static string Roomnumber; //房间号
        public static string ip = "192.168.1.106";  // 服务器ip
        public static int port = 6666;  //端口


        public static string[] playerName = new string[6];  //房间信息
        public static string[] playerScore = new string[6];  //房间积分


        public static int[] roomNumber = new int[9];//游戏房间号
        public static int[] roomPlayerNum = new int[9]; // 游戏房间人数
        public static int[] roomstate = new int[9];//游戏状态

        public static string gameName;
        public static string word;
        public static bool gameFlag = false;

        public static int[,] location = new int[10, 2];
        public static string message;
        public static string messagename;
        public static bool messageFlag = false;

        public static bool drawFlag = false;
        public static int[,] Analysicslocation = new int[10, 2];
        public static string AnalysicsName;
        public static Monitor ClientMonitor;
        public static Thread MonitorThread;
    }
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataAnalysics dataAnalysics = new DataAnalysics();
            pbdata.ClientMonitor = new Monitor(613);
            pbdata.MonitorThread = new Thread(new ThreadStart(pbdata.ClientMonitor.receive));
            pbdata.MonitorThread.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login login = new login();
            if (login.ShowDialog() == DialogResult.OK)
                Application.Run(new allroom());
        }
    }
}
