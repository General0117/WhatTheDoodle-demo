using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace Client
{
    class Monitor
    {
        public int port;
        public Monitor(int port)
        {
            this.port = port;
        }
        public void receive()
        {
            UdpClient udpclient = new UdpClient(port);
            DataAnalysics Analyzer = new DataAnalysics();
            while (true)
            {
                IPEndPoint iPEndPoint = null;
                byte[] bytes = udpclient.Receive(ref iPEndPoint);
                string data = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                Analyzer.AddData(data);
                Analyzer.Analysics();
                string name = Analyzer.AnalysicsName;
                string roomnumber = Analyzer.AnalysicsRoomnumber;
                string message = Analyzer.AnalysicsMessage;
                Console.WriteLine("name:" + name);
                Console.WriteLine("roomnumber:"+roomnumber);
                Console.WriteLine("message:" + message); 
                //string data = Encoding.UTF8.GetString(bytes, 0, bytes.Length);//解码接收到的字节流
                //Console.WriteLine("{0:HH:mm:ss}->接收数据(from {1}:{2})：{3}", DateTime.Now, iPEndPoint.Address, iPEndPoint.Port, data);
            }
            //udpclient.Close();
        }

    }
}