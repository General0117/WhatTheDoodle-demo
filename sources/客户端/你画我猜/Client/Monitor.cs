using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace 你画我猜
{
    public class Monitor
    {
        public int port;
        public long num = 0;
        public long verify = 0;
        public bool Isverify = true;
        public DataAnalysics Analyzer;
        public Monitor(int port)
        {
            this.port = port;
        }
        public void receive()
        {
            UdpClient udpclient = new UdpClient(port);
            Analyzer = new DataAnalysics();
            if (pbdata.IsClose == true)
            {
                pbdata.IsClose = false;
                udpclient.Close();
            }
            if(pbdata.ThreadRunning==false)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            while (pbdata.ThreadRunning/*&&num == verify*/)
            {
                IPEndPoint iPEndPoint = null;
                byte[] bytes = udpclient.Receive(ref iPEndPoint);
                string data = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                Analyzer.AddData(data);
                Analyzer.Analysics();
                //num++;
               // Isverify = false;
                string name = Analyzer.AnalysicsName;
                string roomnumber = Analyzer.AnalysicsRoomnumber;
                string message = Analyzer.AnalysicsMessage;
                //Console.WriteLine("name:" + name);
                //Console.WriteLine("roomnumber:"+roomnumber);
                //Console.WriteLine("message:" + message); 
                //string data = Encoding.UTF8.GetString(bytes, 0, bytes.Length);//解码接收到的字节流
                //Console.WriteLine("{0:HH:mm:ss}->接收数据(from {1}:{2})：{3}", DateTime.Now, iPEndPoint.Address, iPEndPoint.Port, data);

            }
            
        }

    }
}