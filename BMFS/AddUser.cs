using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BMFS
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            using (var DBContext = new bmfsEntities())
            {
                var role = from u in DBContext.codesuserroles select u.UserRoleName;
                comboBox1.DisplayMember = "UserRoleName";
                comboBox1.ValueMember = "UserRoleCode";
                comboBox1.DataSource = role.ToList();
               
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int getRoleCode( string Rolename)
        {
            int RoleCode;
            using (var DBContext = new bmfsEntities())
            {
                RoleCode = DBContext.codesuserroles.Where(e => e.UserRoleName == Rolename).First().UserRoleCode;
            };
            return RoleCode;
         }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Email.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(Email.Text))
                {
                    string message = "Please Check the Email";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.

                    result = MessageBox.Show(message, caption, buttons);
                } else
                {
                  
                    BMFS.user users = new BMFS.user();
                    users.UserName = UserName.Text;
                    users.Password = Password.Text;
                    users.Email = Email.Text;
                    users.Role = getRoleCode(comboBox1.SelectedValue.ToString());
                    users.IsActive = Convert.ToBoolean( IsActive.Checked);
                    users.CreatedBy = LoggedInUser.UserName;
                    users.CreatedAt = DateTime.Now;
                    using (var DBContext = new bmfsEntities())
                    {
                        DBContext.users.Add(users);
                        DBContext.SaveChanges();
                        string message = "User is Added";
                        string caption = "User Info";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        // Displays the MessageBox.

                        result = MessageBox.Show(message, caption, buttons);
                        if(result == DialogResult.Yes)
                        {
                            UserName.Text = "";
                            Password.Text = "";
                            Email.Text = "";
                        }
                    }
                }
            }
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if(UserName.Text =="")
            {
                ShowErrMessageBox("User Name cannot be empty");
            }
        }
        private void ShowErrMessageBox(String error)
        {
            string message = error;
            string caption = "INformation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if(Email.Text == "")
            {
                ShowErrMessageBox("Email cannot be empty");
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if(Password.Text =="")
            {
                ShowErrMessageBox("Password can not be null");
            }
        }
    }
}
