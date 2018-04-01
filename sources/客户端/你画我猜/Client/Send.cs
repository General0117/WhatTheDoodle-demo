using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace 你画我猜
{
    public class Send
    {
        public string Package;
        public string ip;
        public int port;
        public Send()
        {
        }
        public void SendDataToServer()
        {
            UdpClient udpclient = new UdpClient();
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Parse(ip), port);

            byte[] data= Encoding.UTF8.GetBytes(Package);
            udpclient.Send(data, data.Length, ipendpoint);
            //udpclient.Close();//关闭UDP连接
            //Console.WriteLine("{0:HH:mm:ss}->发送数据(to {1})：{2}", DateTime.Now, ip, data[0]);
        }
    }
}
