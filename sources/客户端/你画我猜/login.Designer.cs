﻿namespace 你画我猜
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.Label();
            this.username_Box = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.password_Box = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(301, 241);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(71, 15);
            this.username.TabIndex = 1;
            this.username.Text = "username";
            // 
            // username_Box
            // 
            this.username_Box.Location = new System.Drawing.Point(465, 241);
            this.username_Box.Margin = new System.Windows.Forms.Padding(4);
            this.username_Box.Name = "username_Box";
            this.username_Box.Size = new System.Drawing.Size(132, 25);
            this.username_Box.TabIndex = 2;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(301, 306);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(71, 15);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            // 
            // password_Box
            // 
            this.password_Box.Location = new System.Drawing.Point(465, 306);
            this.password_Box.Margin = new System.Windows.Forms.Padding(4);
            this.password_Box.Name = "password_Box";
            this.password_Box.Size = new System.Drawing.Size(132, 25);
            this.password_Box.TabIndex = 4;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(337, 381);
            this.login_button.Margin = new System.Windows.Forms.Padding(4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 29);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_Box);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username_Box);
            this.Controls.Add(this.username);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox username_Box;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox password_Box;
        private System.Windows.Forms.Button login_button;
    }
}

