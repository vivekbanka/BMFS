namespace BMFS
{
    partial class FileTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.YearListBox = new System.Windows.Forms.ListBox();
            this.PIListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.57641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.42359F));
            this.tableLayoutPanel1.Controls.Add(this.YearListBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PIListBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // YearListBox
            // 
            this.YearListBox.BackColor = System.Drawing.Color.SteelBlue;
            this.YearListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearListBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.YearListBox.FormattingEnabled = true;
            this.YearListBox.ItemHeight = 20;
            this.YearListBox.Location = new System.Drawing.Point(4, 4);
            this.YearListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YearListBox.Name = "YearListBox";
            this.YearListBox.Size = new System.Drawing.Size(168, 544);
            this.YearListBox.Sorted = true;
            this.YearListBox.TabIndex = 0;
            this.YearListBox.SelectedIndexChanged += new System.EventHandler(this.YearListBox_SelectedIndexChanged);
            // 
            // PIListBox
            // 
            this.PIListBox.BackColor = System.Drawing.Color.SteelBlue;
            this.PIListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIListBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.PIListBox.FormattingEnabled = true;
            this.PIListBox.ItemHeight = 20;
            this.PIListBox.Location = new System.Drawing.Point(184, 4);
            this.PIListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PIListBox.Name = "PIListBox";
            this.PIListBox.Size = new System.Drawing.Size(207, 544);
            this.PIListBox.TabIndex = 1;
            this.PIListBox.SelectedIndexChanged += new System.EventHandler(this.PIListBox_SelectedIndexChanged);
            // 
            // FileTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1181, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.PowderBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FileTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileTable";
            this.Load += new System.EventHandler(this.FileTable_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox YearListBox;
        private System.Windows.Forms.ListBox PIListBox;
    }
}