using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 你画我猜
{
    class DrawTools:Form
    {
        public Graphics DrawTools_Graphics;//目标绘图板
        private Pen p;
        private Image orginalImg;//原始画布，用来保存已完成的绘图过程
        private Color drawColor = Color.Black;//绘图颜色
        private Graphics newgraphics;//中间画板
        private Image finishingImg;//中间画布，用来保存绘图过程中的痕迹
        private float size = 1;

        public int i = 0;
        /// <summary>
        /// 绘图颜色
        /// </summary>
        public Color DrawColor
        {
            get { return drawColor; }
            set
            {
                drawColor = value;
                p.Color = value;
            }
        }
        public void sendpack(string result, string ip, int port)
        {
            Send send = new Send();
            send.Package = result;
            send.ip = ip;
            send.port = port;
            send.SendDataToServer();
        }
        /// <summary>
        /// 绘图颜色
        /// </summary>
        public float Size
        {
            get { return size; }
            set
            {
                size = value;
                p.Width = value;
            }
        }
        /// <summary>
        /// 原始画布
        /// </summary>
        public Image OrginalImg
        {
            get { return orginalImg; }
            set
            {
                finishingImg = (Image)value.Clone();
                orginalImg = (Image)value.Clone();
            }
        }
        /// <summary>
        /// 表示是否开始绘图
        /// </summary>
        public bool startDraw = false;
        /// <summary>
        /// 绘图起点
        /// </summary>
        public PointF startPointF;

        /// <summary>
        /// 初始化绘图工具
        /// </summary>
        /// <param name="g">绘图板</param>
        /// <param name="c">绘图颜色</param>
        /// <param name="img">初始画布</param>
        public DrawTools(Graphics g, Color c, Image img)
        {
            DrawTools_Graphics = g;
            drawColor = c;
            p = new Pen(c, 1);
            finishingImg = (Image)img.Clone();
            orginalImg = (Image)img.Clone();
        }
        /// <summary>
        /// 橡皮方法
        /// </summary>
        /// <param name="e">鼠标参数</param>
        public void Eraser(MouseEventArgs e)
        {
            if (startDraw)
            {
                newgraphics = Graphics.FromImage(finishingImg);
                newgraphics.FillRectangle(new SolidBrush(Color.White), e.X, e.Y, 20, 20);
                newgraphics.Dispose();
                DrawTools_Graphics.DrawImage(finishingImg, 0, 0);
            }
        }

        /// <summary>
        /// 铅笔方法
        /// </summary>
        /// <param name="e">鼠标参数</param>
        public void DrawDot(MouseEventArgs e)
        {

           // int i = 0;
            //pbdata.location[i, 0] = startPointF.X;
            if (startDraw)
            {
                pbdata.location[i, 0] = (int)startPointF.X;
                pbdata.location[i, 1] = (int)startPointF.Y;
                newgraphics = Graphics.FromImage(finishingImg);
                PointF currentPointF = new PointF(e.X, e.Y);
                newgraphics.DrawLine(p, startPointF, currentPointF);
                startPointF = currentPointF;
                newgraphics.Dispose();
                DrawTools_Graphics.DrawImage(finishingImg, 0, 0);
                i++;
                while(i==10)
                {
                    PackData pack = new PackData("4");
                    pack.Roomnumber = pbdata.Roomnumber;
                    pack.Name = pbdata.Name;
                    pack.Location = pbdata.location;
                    pack.Start();
                    sendpack(pack.result, pbdata.ip, pbdata.port);
                    //pbdata.location[9, 0] = (int)startPointF.X;
                    //pbdata.location[9, 1] = (int)startPointF.Y;
                   // startPointF.X = pbdata.location[9, 0];
                    //startPointF.Y = pbdata.location[9, 1];
                    pbdata.location = new int[10, 2];
                    i = 0;
                }
            }
        }

        public void Drawline()
        {

            startPointF.X = pbdata.Analysicslocation[0, 0];
            startPointF.Y = pbdata.Analysicslocation[0, 1];
            if (startPointF.X == 9999) return;
            for (int i = 1; i < 10; i++)
            {
                newgraphics = Graphics.FromImage(finishingImg);
                PointF currentPointF = new PointF();
                currentPointF.X = pbdata.Analysicslocation[i, 0];
                currentPointF.Y = pbdata.Analysicslocation[i, 1];
                if (currentPointF.X == 0 || startPointF.X == 0) break;
                if (currentPointF.X != 9999 && currentPointF.Y != 9999)
                {
                    newgraphics.DrawLine(p, startPointF, currentPointF);
                    startPointF = currentPointF;
                    newgraphics.Dispose();
                    DrawTools_Graphics.DrawImage(finishingImg, 0, 0);
                }
                else
                    break;
                
            }
        }
        /// <summary>
        /// 清除变量，释放内存
        /// </summary>
        public void ClearVar()
        {
            DrawTools_Graphics.Dispose();
            finishingImg.Dispose();
            orginalImg.Dispose();
            p.Dispose();
        }
        public void EndDraw()
        {
            startDraw = false;
            //为了让完成后的绘图过程保留下来，要将中间图片绘制到原始画布上
            newgraphics = Graphics.FromImage(orginalImg);
            newgraphics.DrawImage(finishingImg, 0, 0);
            newgraphics.Dispose();
        }
    }
}

