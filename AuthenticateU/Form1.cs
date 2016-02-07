using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tvl.Java.BuildTasks;

namespace AuthenticateU
{
    public partial class MainPage : Form
    {
        private string userName;
        private string userPassword;
        private Image userImage;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            userName = tb_userName.Text;
            userPassword = tb_password.Text;
            
        }
    }
}
