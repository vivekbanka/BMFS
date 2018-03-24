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
    public partial class Addfiles : Form
    {
        private List<primaryinvestigatoryear> PIdatabseList = new List<primaryinvestigatoryear>();
        public Addfiles()
        {
            InitializeComponent();
        }

        private void Addfiles_Load(object sender, EventArgs e)
        {
            // getting the PI name fro database 
            var source = new AutoCompleteStringCollection();
            using (var DBContext = new bmfsEntities())
            {
                PIdatabseList = DBContext.primaryinvestigatoryears.ToList();
            };
            // Create the list to use as the custom source. 

            source.AddRange(GettheNameOfPI(PIdatabseList));

            PIName.AutoCompleteCustomSource = source;
            PIName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PIName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string[] GettheNameOfPI(List<primaryinvestigatoryear> list)
        {
            String[] NameList = new string[list.Count];
            for(int i =0; i<list.Count;i++)
            {
                NameList[i] = list[i].FirstName + ',' + list[i].LastName;
            }
            return NameList;
        }
        private void UploadFileToDatabase(string description, byte[] barray,string FileName)
        {
            //adding file to database 
            BMFS.file addFiles = new BMFS.file();
            string[] PiFirstname = PIName.Text.Split(',');
            int PrimryID = PIdatabseList.Where(s => s.FirstName == PiFirstname[0] && s.LastName == PiFirstname[1]).Select(s => s.PrimaryInvestigatorID).First();
            addFiles.PrimaryInvestigatorID = PrimryID;
            addFiles.FileShortDescription = description;
            addFiles.FileDescription = description;
            addFiles.CreatedAt = DateTime.Now;
            addFiles.CreatedBy = LoggedInUser.UserName;
            addFiles.FileData = barray;
            addFiles.UpdatedBy = LoggedInUser.UserName;
            addFiles.LastUpdated = DateTime.Now;
            addFiles.FileName = FileName;
            using (var DBContext = new bmfsEntities())
            {
                DBContext.files.Add(addFiles);
                DBContext.SaveChanges();
            }

         }

        private void File1Btn_Click(object sender, EventArgs e)
        {
            
            if(FileoneDis.Text == "")
            {
                ShowErrMessageBox("please add Description");
            }
            else
            {
                openFileDialog1.ShowDialog();
                try
                {
                    //read file
                    byte[] barray = System.IO.File.ReadAllBytes(openFileDialog1.FileName);

                    //extract the filename only from the selected path
                    string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    //upload the files
                    if(filename !="")
                    {
                        UploadFileToDatabase(FileoneDis.Text, barray, filename);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        private void ShowErrMessageBox(String error)
        {
            string message = error;
            string caption = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }

        private void FIleTwoBtn_Click(object sender, EventArgs e)
        {
            if (FileTwoDis.Text == "")
            {
                ShowErrMessageBox("please add Description");
            }
            else
            {
                openFileDialog1.ShowDialog();
                try
                {
                    //read file
                    byte[] barray = System.IO.File.ReadAllBytes(openFileDialog1.FileName);

                    //extract the filename only from the selected path
                    string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    //upload the files
                    if (filename != "")
                    {
                        UploadFileToDatabase(FileTwoDis.Text, barray, filename);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void FileThreeBtn_Click(object sender, EventArgs e)
        {
            if (FileThreeDis.Text == "")
            {
                ShowErrMessageBox("please add Description");
            }
            else
            {
                openFileDialog1.ShowDialog();
                try
                {
                    //read file
                    byte[] barray = System.IO.File.ReadAllBytes(openFileDialog1.FileName);

                    //extract the filename only from the selected path
                    string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    //upload the files
                    if (filename != "")
                    {
                        UploadFileToDatabase(FileThreeDis.Text, barray, filename);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
