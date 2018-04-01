namespace 你画我猜
{
    partial class room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pen = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.startgame = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.messagebox = new System.Windows.Forms.TextBox();
            this.roomuser1 = new System.Windows.Forms.Label();
            this.scor1 = new System.Windows.Forms.Label();
            this.roomuser2 = new System.Windows.Forms.Label();
            this.scor2 = new System.Windows.Forms.Label();
            this.roomuser3 = new System.Windows.Forms.Label();
            this.scor3 = new System.Windows.Forms.Label();
            this.roomuser4 = new System.Windows.Forms.Label();
            this.scor4 = new System.Windows.Forms.Label();
            this.roomuser5 = new System.Windows.Forms.Label();
            this.scor5 = new System.Windows.Forms.Label();
            this.roomuser6 = new System.Windows.Forms.Label();
            this.scor6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.word = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.White;
            this.pbImg.Enabled = false;
            this.pbImg.Location = new System.Drawing.Point(0, 0);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(998, 640);
            this.pbImg.TabIndex = 1;
            this.pbImg.TabStop = false;
            this.pbImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImg_MouseDown);
            this.pbImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImg_MouseMove);
            this.pbImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImg_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbImg);
            this.panel2.Location = new System.Drawing.Point(142, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 640);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // pen
            // 
            this.pen.Location = new System.Drawing.Point(12, 154);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(96, 50);
            this.pen.TabIndex = 6;
            this.pen.Text = "铅笔";
            this.pen.UseVisualStyleBackColor = true;
            this.pen.Click += new System.EventHandler(this.pen_Click);
            // 
            // eraser
            // 
            this.eraser.Location = new System.Drawing.Point(12, 227);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(96, 50);
            this.eraser.TabIndex = 10;
            this.eraser.Text = "橡皮";
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // startgame
            // 
            this.startgame.Enabled = false;
            this.startgame.Location = new System.Drawing.Point(12, 304);
            this.startgame.Name = "startgame";
            this.startgame.Size = new System.Drawing.Size(96, 50);
            this.startgame.TabIndex = 19;
            this.startgame.Text = "开始游戏";
            this.startgame.UseVisualStyleBackColor = true;
            this.startgame.Click += new System.EventHandler(this.startgame_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(1373, 749);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 20;
            this.send.Text = "发送";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // messagebox
            // 
            this.messagebox.Location = new System.Drawing.Point(1146, 751);
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(221, 21);
            this.messagebox.TabIndex = 21;
            // 
            // roomuser1
            // 
            this.roomuser1.AutoSize = true;
            this.roomuser1.Location = new System.Drawing.Point(142, 50);
            this.roomuser1.Name = "roomuser1";
            this.roomuser1.Size = new System.Drawing.Size(17, 12);
            this.roomuser1.TabIndex = 22;
            this.roomuser1.Text = "无";
            // 
            // scor1
            // 
            this.scor1.AutoSize = true;
            this.scor1.Location = new System.Drawing.Point(142, 100);
            this.scor1.Name = "scor1";
            this.scor1.Size = new System.Drawing.Size(17, 12);
            this.scor1.TabIndex = 23;
            this.scor1.Text = "无";
            // 
            // roomuser2
            // 
            this.roomuser2.AutoSize = true;
            this.roomuser2.Location = new System.Drawing.Point(277, 50);
            this.roomuser2.Name = "roomuser2";
            this.roomuser2.Size = new System.Drawing.Size(17, 12);
            this.roomuser2.TabIndex = 24;
            this.roomuser2.Text = "无";
            // 
            // scor2
            // 
            this.scor2.AutoSize = true;
            this.scor2.Location = new System.Drawing.Point(277, 100);
            this.scor2.Name = "scor2";
            this.scor2.Size = new System.Drawing.Size(17, 12);
            this.scor2.TabIndex = 25;
            this.scor2.Text = "无";
            // 
            // roomuser3
            // 
            this.roomuser3.AutoSize = true;
            this.roomuser3.Location = new System.Drawing.Point(421, 50);
            this.roomuser3.Name = "roomuser3";
            this.roomuser3.Size = new System.Drawing.Size(17, 12);
            this.roomuser3.TabIndex = 26;
            this.roomuser3.Text = "无";
            // 
            // scor3
            // 
            this.scor3.AutoSize = true;
            this.scor3.Location = new System.Drawing.Point(421, 100);
            this.scor3.Name = "scor3";
            this.scor3.Size = new System.Drawing.Size(17, 12);
            this.scor3.TabIndex = 27;
            this.scor3.Text = "无";
            // 
            // roomuser4
            // 
            this.roomuser4.AutoSize = true;
            this.roomuser4.Location = new System.Drawing.Point(556, 50);
            this.roomuser4.Name = "roomuser4";
            this.roomuser4.Size = new System.Drawing.Size(17, 12);
            this.roomuser4.TabIndex = 28;
            this.roomuser4.Text = "无";
            // 
            // scor4
            // 
            this.scor4.AutoSize = true;
            this.scor4.Location = new System.Drawing.Point(556, 100);
            this.scor4.Name = "scor4";
            this.scor4.Size = new System.Drawing.Size(17, 12);
            this.scor4.TabIndex = 23;
            this.scor4.Text = "无";
            // 
            // roomuser5
            // 
            this.roomuser5.AutoSize = true;
            this.roomuser5.Location = new System.Drawing.Point(697, 50);
            this.roomuser5.Name = "roomuser5";
            this.roomuser5.Size = new System.Drawing.Size(17, 12);
            this.roomuser5.TabIndex = 29;
            this.roomuser5.Text = "无";
            // 
            // scor5
            // 
            this.scor5.AutoSize = true;
            this.scor5.Location = new System.Drawing.Point(697, 100);
            this.scor5.Name = "scor5";
            this.scor5.Size = new System.Drawing.Size(17, 12);
            this.scor5.TabIndex = 30;
            this.scor5.Text = "无";
            // 
            // roomuser6
            // 
            this.roomuser6.AutoSize = true;
            this.roomuser6.Location = new System.Drawing.Point(834, 50);
            this.roomuser6.Name = "roomuser6";
            this.roomuser6.Size = new System.Drawing.Size(17, 12);
            this.roomuser6.TabIndex = 31;
            this.roomuser6.Text = "无";
            // 
            // scor6
            // 
            this.scor6.AutoSize = true;
            this.scor6.Location = new System.Drawing.Point(834, 100);
            this.scor6.Name = "scor6";
            this.scor6.Size = new System.Drawing.Size(17, 12);
            this.scor6.TabIndex = 32;
            this.scor6.Text = "无";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Location = new System.Drawing.Point(1159, 66);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(65, 12);
            this.word.TabIndex = 33;
            this.word.Text = "请开始游戏";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(1146, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 613);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 804);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.word);
            this.Controls.Add(this.scor6);
            this.Controls.Add(this.roomuser6);
            this.Controls.Add(this.scor5);
            this.Controls.Add(this.roomuser5);
            this.Controls.Add(this.scor4);
            this.Controls.Add(this.roomuser4);
            this.Controls.Add(this.scor3);
            this.Controls.Add(this.roomuser3);
            this.Controls.Add(this.scor2);
            this.Controls.Add(this.roomuser2);
            this.Controls.Add(this.scor1);
            this.Controls.Add(this.roomuser1);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.send);
            this.Controls.Add(this.startgame);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.pen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "room";
            this.Text = "room";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.room_FormClosed);
            this.Load += new System.EventHandler(this.room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pen;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button startgame;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox messagebox;
        private System.Windows.Forms.Label roomuser1;
        private System.Windows.Forms.Label scor1;
        private System.Windows.Forms.Label roomuser2;
        private System.Windows.Forms.Label scor2;
        private System.Windows.Forms.Label roomuser3;
        private System.Windows.Forms.Label scor3;
        private System.Windows.Forms.Label roomuser4;
        private System.Windows.Forms.Label scor4;
        private System.Windows.Forms.Label roomuser5;
        private System.Windows.Forms.Label scor5;
        private System.Windows.Forms.Label roomuser6;
        private System.Windows.Forms.Label scor6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer4;
    }
}