using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 你画我猜
{
    public partial class allroom : Form
    {
        public void sendpack(string result,string ip,int port)
        {
            Send send = new Send();
            send.Package = result;
            send.ip = ip;
            send.port = port;
            send.SendDataToServer();
        }
        public allroom()
        {
            InitializeComponent();
        }
        private void allroom_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }
        private void room1_Click(object sender, EventArgs e)
        {
            PackData pack = new PackData("1");
            pack.Roomnumber = "1";
            pack.Name = pbdata.Name;
            pack.Start();
            sendpack(pack.result, pbdata.ip, pbdata.port);

            pbdata.Roomnumber = "1";
            this.timer1.Stop();
            room room = new room();
            this.Hide();
            if(room.ShowDialog()==DialogResult.OK)
            {
                this.Show();
                this.timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PackData pack = new PackData("8");
            pack.Start();
            sendpack(pack.result, pbdata.ip, pbdata.port);
            DataAnalysics dataAnalysics = new DataAnalysics();
            if (pbdata.roomPlayerNum[0] == 6 || pbdata.roomstate[0] == 1)
                room1.Enabled = false;
            /*if (pbdata.roomPlayerNum[1] == 6 || pbdata.roomstate[1] == 1)
                pictureBox1.Enabled = false;
            if (pbdata.roomPlayerNum[2] == 6 || pbdata.roomstate[2] == 1)
                pictureBox1.Enabled = false;
            if (pbdata.roomPlayerNum[3] == 6 || pbdata.roomstate[3] == 1)
                pictureBox1.Enabled = false;
            if (pbdata.roomPlayerNum[4] == 6 || pbdata.roomstate[4] == 1)
                pictureBox1.Enabled = false;
            if (pbdata.roomPlayerNum[5] == 6 || pbdata.roomstate[5] == 1)
                pictureBox1.Enabled = false;
            if (pbdata.roomPlayerNum[6] == 6 || pbdata.roomstate[6] == 1)
                pictureBox1.Enabled = false;
            if (pbdata.roomPlayerNum[7] == 6 || pbdata.roomstate[7] == 1)
                pictureBox1.Enabled = false;
            if (pbdata.roomPlayerNum[8] == 6 || pbdata.roomstate[8] == 1)
                pictureBox1.Enabled = false;*/
            //Application.DoEvents();

        }

        private void allroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            pbdata.IsClose = true;
            pbdata.ThreadRunning = false;
            //pbdata.MonitorThread.Abort();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void allroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            pbdata.IsClose = true;
            pbdata.ThreadRunning = false;
            pbdata.MonitorThread.Abort();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            //Application.Exit();
        }
    }
}
