namespace 你画我猜
{
    partial class allroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allroom));
            this.room1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.room1)).BeginInit();
            this.SuspendLayout();
            // 
            // room1
            // 
            this.room1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("room1.BackgroundImage")));
            this.room1.Location = new System.Drawing.Point(83, 62);
            this.room1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(157, 128);
            this.room1.TabIndex = 0;
            this.room1.TabStop = false;
            this.room1.Click += new System.EventHandler(this.room1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // allroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.room1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "allroom";
            this.Text = "allroom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.allroom_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.allroom_FormClosed);
            this.Load += new System.EventHandler(this.allroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.room1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox room1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}