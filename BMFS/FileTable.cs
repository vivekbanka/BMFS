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
            YearListBox.Items.Add(2018);
            YearListBox.Items.Add(2017);
            YearListBox.Items.Add(2016);
            YearListBox.Items.Add(2015);
            YearListBox.Items.Add(2014);
            YearListBox.Items.Add(2013);
            YearListBox.Items.Add(2012);
            YearListBox.Items.Add(2011);
        }
        private void YearListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PIListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
