using System;
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
            using (var DBContext = new bmfsEntities())
            {
                if (DBContext.users.Where(u => u.UserName == LoginTxtBox.Text && u.Password == PwdTxtBox.Text).Count() > 0)
                {
                    LoggedInUser.UserName = LoginTxtBox.Text;
                    this.Hide();
                    FileTable fileTable = new FileTable();
                    fileTable.Show();
                } else
                {
                    string message = "Please Check the Username/Password";
                    string caption = "Login Error";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.

                    result = MessageBox.Show(message, caption, buttons);
                }
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
