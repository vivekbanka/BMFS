﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMFS
{
    public partial class Login : Form
    {
        private Login login;
        public Login()
        {
            InitializeComponent();
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            if(LoginTxtBox.Text == "vivek" && PwdTxtBox.Text == "vivek")
            {   
                FileTable fileTable = new FileTable();
                fileTable.Show();
                this.Hide();
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
