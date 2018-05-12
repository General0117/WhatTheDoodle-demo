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
    public partial class room : Form
    {
        public room()
        {
            InitializeComponent();
        }
        public void sendpack(string result, string ip, int port)
        {
            Send send = new Send();
            send.Package = result;
            send.ip = ip;
            send.port = port;
            send.SendDataToServer();
        }

        private DrawTools dt;
        private string sType = "Dot";
        private bool bReSize = false;
        private Size DefaultPicSize;
        private void room_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 100;
            this.timer1.Start();

            this.timer2.Interval = 60000;

            this.timer3.Interval = 1000;
            this.timer3.Start();

            this.timer4.Interval = 10;
            //this.timer4.Start();

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
            Bitmap bmp = new Bitmap(pbImg.Width, pbImg.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(pbImg.BackColor), new Rectangle(0, 0, pbImg.Width, pbImg.Height));
            g.Dispose();
            dt = new DrawTools(this.pbImg.CreateGraphics(), Color.Black, bmp);//实例化工具类,默认是黑色
            DefaultPicSize = pbImg.Size;
        }

        private void pen_Click(object sender, EventArgs e)
        {
            sType = "Dot";
            if (sType == "Eraser")
            {
                //可以选则鼠标形状
                pbImg.Cursor = new Cursor(Application.StartupPath + @"\img\pb.cur");
            }
            else
            {
                pbImg.Cursor = Cursors.Cross;
            }
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            label1.Text = "橡皮";
            sType = "Eraser";
            if (sType == "Eraser")
            {
                pbImg.Cursor = new Cursor(Application.StartupPath + @"\img\pb.cur");
            }
            else
            {
                pbImg.Cursor = Cursors.Cross;
            }
        }

        private void room_FormClosed(object sender, FormClosedEventArgs e)
        {
            PackData pack = new PackData("2");
            pack.Name = pbdata.Name;
            pack.Roomnumber = pbdata.Roomnumber;
            pack.Start();
            sendpack(pack.result, pbdata.ip, pbdata.port);

            this.Close();
            this.DialogResult = DialogResult.OK;
            /*allroom allroom = new allroom();
            allroom.Show();*/
        }
        //pbimg＂鼠标按下＂事件处理方法
        private void pbImg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dt != null)
                {
                    label1.Text = "按下鼠标";
                    dt.startDraw = true; //相当于所选工具被激活，可开始画图
                    dt.startPointF = new PointF(e.X, e.Y);
                    //pbdata.location[0, 0] = e.X;
                    //pbdata.location[0, 1] = e.Y;
                }
            }
        }
        //pbimg＂鼠标移动＂事件处理方法
        private void pbImg_MouseMove(object sender, MouseEventArgs e)
        {
            // Thread.Sleep(6);

            if (dt.startDraw)
            {
                label1.Text = "正在绘图";
                pbdata.location[0, 0] = (int)dt.startPointF.X;
                pbdata.location[0, 1] = (int)dt.startPointF.Y;
                //label3.Text = e.X.ToString();
                //label4.Text = e.Y.ToString();
                switch (sType)//！！！！！！！！！！！！！有一个bug
                {
                    case "Dot": dt.DrawDot(e); break;
                    case "Eraser": dt.Eraser(e); break;
                    default: dt.DrawDot(e); break;
                }
            }
        }

        //pbimg＂鼠标松开＂事件处理方法
        private void pbImg_MouseUp(object sender, MouseEventArgs e)
        {
            if (dt != null)
            {
                if (dt.i == 10)
                {
                    pbdata.location[0, 0] = 9999;
                    pbdata.location[0, 1] = 9999;
                }
                else
                {
                    pbdata.location[dt.i, 0] = 9999;
                    pbdata.location[dt.i, 1] = 9999;
                }
                dt.i = 0;
                PackData pack = new PackData("4");
                pack.Roomnumber = pbdata.Roomnumber;
                pack.Name = pbdata.Name;
                pack.Location = pbdata.location;
                pack.Start();
                sendpack(pack.result, pbdata.ip, pbdata.port);

                label1.Text = "松开鼠标";
                dt.EndDraw();
            }
        }
        //窗体移动最小化等造成的pbimg＂重画＂事件处理方法
        private void pbImg_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(dt.OrginalImg, 0, 0);
            //g.Dispose();切不可使用,这个Graphics是系统传入的变量，不是我们自己创建的，如果dispose就会出错
        }

        private void reSize_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void reSize_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void reSize_MouseUp(object sender, MouseEventArgs e)
        {
            bReSize = false;//大小改变结束
            //调节大小可能造成画板大小超过屏幕区域，所以事先要设置autoScroll为true.
            //但是滚动条的出现反而增加了我们的难度，因为滚动条上下移动并不会自动帮我们调整图片的坐标。
            //这是因为GDI绘图的坐标系不只一个，好像有三个，没有仔细了解，一个是屏幕坐标，一个是客户区坐标，还个是文档坐标。
            //滚动条的上下移动改变的是文档的坐标，但是客户区坐标不变，而location属性就属于客户区坐标，所以我们直接计算会出现错误
            //这时我们就需要知道文档坐标与客户区坐标的偏移量，这就是AutoScrollPostion可以提供的
            //pbImg.Size = new Size(reSize.Location.X - (this.panel2.AutoScrollPosition.X), reSize.Location.Y - (this.panel2.AutoScrollPosition.Y));
            dt.DrawTools_Graphics = pbImg.CreateGraphics();//因为画板的大小被改变所以必须重新赋值

            //另外画布也被改变所以也要重新赋值
            Bitmap bmp = new Bitmap(pbImg.Width, pbImg.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pbImg.Width, pbImg.Height);
            g.DrawImage(dt.OrginalImg, 0, 0);
            g.Dispose();
            g = pbImg.CreateGraphics();
            g.DrawImage(bmp, 0, 0);
            g.Dispose();
            dt.OrginalImg = bmp;

            bmp.Dispose();
        }

        private void startgame_Click(object sender, EventArgs e)
        {
            PackData pack = new PackData("7");
            pack.Roomnumber = pbdata.Roomnumber;
            pack.Name = pbdata.Name;
            pack.Start();
            sendpack(pack.result, pbdata.ip, pbdata.port);
        }

        private void send_Click(object sender, EventArgs e)
        {
            PackData pack = new PackData("3");
            pack.Message = messagebox.Text;
            pack.Name = pbdata.Name;
            pack.Roomnumber = pbdata.Roomnumber;
            pack.Start();
            sendpack(pack.result, pbdata.ip, pbdata.port);
            messagebox.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataAnalysics dataAnalysics = new DataAnalysics();
            if (pbdata.playerName[0] == pbdata.Name)
                startgame.Enabled = true;
            roomuser1.Text = pbdata.playerName[0];
            roomuser2.Text = pbdata.playerName[1];
            roomuser3.Text = pbdata.playerName[2];
            roomuser4.Text = pbdata.playerName[3];
            roomuser5.Text = pbdata.playerName[4];
            roomuser6.Text = pbdata.playerName[5];
            scor1.Text = pbdata.playerScore[0];
            scor2.Text = pbdata.playerScore[1];
            scor3.Text = pbdata.playerScore[2];
            scor4.Text = pbdata.playerScore[3];
            scor5.Text = pbdata.playerScore[4];
            scor6.Text = pbdata.playerScore[5];
            //Application.DoEvents();
            if (pbdata.gameFlag == true)
            {
                if (pbdata.gameName == pbdata.Name)
                {
                    this.timer1.Stop();
                    pbImg.Enabled = true;
                    startgame.Enabled = false;
                    word.Text = pbdata.word;
                    this.timer2.Start();
                }
                else
                {
                    this.timer1.Stop();
                    word.Text = "游戏开始";
                    this.timer4.Start();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pbImg.Enabled = false;
            pbdata.gameFlag = false;
            startgame.Enabled = true;
            this.timer2.Stop();
            this.timer4.Stop();
            this.timer1.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pbdata.messageFlag == true)
            {
                richTextBox1.Text += pbdata.messagename + "：" + pbdata.message + '\n';
                pbdata.messageFlag = false;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pbdata.drawFlag == true&&pbdata.Name != pbdata.AnalysicsName)
            {
                dt.Drawline();
                pbdata.drawFlag = false;
            }
        }
    }
}
