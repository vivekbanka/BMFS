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
    public partial class AddPI : Form
    {
        public AddPI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowErrMessageBox(String error)
        {
            string message = error;
            string caption = "INformation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }
        private void button1_Click(object sender, EventArgs e)
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
                }
                else
                {
                    BMFS.primaryinvestigatoryear users = new BMFS.primaryinvestigatoryear();
                    users.FirstName = FstName.Text;
                    users.LastName = LstName.Text;
                    users.MiddleName = MidName.Text;
                    users.Email = Email.Text;
                    users.IsDeleted = Convert.ToBoolean(IsDeleted.Checked);
                    users.CreatedBy = LoggedInUser.UserName;
                    users.CreatedAt = DateTime.Now;
                    users.UpdatedBy = LoggedInUser.UserName;
                    users.Year = Convert.ToInt32(dateTimePicker1.Text);
                    users.LastUpdated = DateTime.Now;
                    using (var DBContext = new bmfsEntities())
                    {
                        DBContext.primaryinvestigatoryears.Add(users);
                        DBContext.SaveChanges();
                        string message = "Primary Investigator is Added";
                        string caption = "Primary Investigator";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        // Displays the MessageBox.

                        result = MessageBox.Show(message, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            FstName.Text = "";
                            LstName.Text = "";
                            MidName.Text = "";
                            Email.Text = "";
                        }
                    }
                }
            }
        }

        private void FstName_Leave(object sender, EventArgs e)
        {
            if(FstName.Text =="")
            {
                ShowErrMessageBox("First Name cannot be empty");
            }
        }

        private void LstName_Leave(object sender, EventArgs e)
        {
            if (LstName.Text == "")
            {
                ShowErrMessageBox("Last Name cannot be empty");
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if(Email.Text == "")
            {
                ShowErrMessageBox("Email cannot be empty");
            }
        }
    }
}
