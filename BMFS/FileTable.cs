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
    public partial class FileTable : Form
    {
        public FileTable()
        {
            InitializeComponent();
        }

        private void FileTable_Load(object sender, EventArgs e)
        {
            int yearFn;
            using (var DBContext = new bmfsEntities())
            {
                var role =  DBContext.primaryinvestigatoryears.Select(s => s.Year).Distinct();
                YearListBox.DataSource = role.ToList();
                role.ToList().Sort();
                role.Reverse();
                yearFn = role.First();
            }
            try
            {
                using (var DBContext = new bmfsEntities())
                {
                    var PIname = (from u in DBContext.primaryinvestigatoryears where u.Year == yearFn select u.FirstName + " "+u.LastName).Distinct();
                    PIListBox.DataSource = PIname.ToList();
                }
                
            }
            catch
            {

            }
        }
        private void YearListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yearFn = Convert.ToInt32(YearListBox.SelectedValue.ToString());
            using (var DBContext = new bmfsEntities())
            {
                var PIname = (from u in DBContext.primaryinvestigatoryears where u.Year == yearFn select u.FirstName + " " + u.LastName).Distinct();
                PIListBox.DataSource = PIname.ToList();
            }
        }

        private void PIListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPI addPI = new AddPI();
            addPI.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addfiles addfiles = new Addfiles();
            addfiles.Show();
        }
    }
}
