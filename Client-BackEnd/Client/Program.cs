using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace Client
{

    class Program
    {
        static void Main()
        {
            Monitor ClientMonitor = new Monitor(613);
            Thread MonitorThread = new Thread(new ThreadStart(ClientMonitor.receive));
            MonitorThread.Start();
            while (true)
            {
                Send send = new Send();
                String IP = "192.168.1.100";
                int port = 6666;
                String Message = Console.ReadLine();//手动测试时直接输入包信息
                send.Package = Message;
                send.SendDataToServer(IP, port);
            }
        }
    }
}
