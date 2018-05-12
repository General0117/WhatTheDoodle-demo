using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 你画我猜
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            pbdata.Name = username_Box.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //private void login_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    pbdata.IsClose = true;
        //    pbdata.ThreadRunning = false;
        //    //pbdata.MonitorThread.Abort();
        //    System.Diagnostics.Process.GetCurrentProcess().Kill();
        //}

        //private void login_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    pbdata.IsClose = true;
        //    pbdata.ThreadRunning = false;
        //    //pbdata.MonitorThread.Abort();
        //    System.Diagnostics.Process.GetCurrentProcess().Kill();
        //}
    }
}
