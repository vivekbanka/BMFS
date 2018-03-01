namespace BMFS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTxtBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.PwdTxtBox = new System.Windows.Forms.TextBox();
            this.Sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(144, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // LoginTxtBox
            // 
            this.LoginTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginTxtBox.Location = new System.Drawing.Point(148, 144);
            this.LoginTxtBox.Name = "LoginTxtBox";
            this.LoginTxtBox.Size = new System.Drawing.Size(266, 20);
            this.LoginTxtBox.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password.Location = new System.Drawing.Point(144, 182);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(82, 20);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password:";
            // 
            // PwdTxtBox
            // 
            this.PwdTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PwdTxtBox.Location = new System.Drawing.Point(148, 205);
            this.PwdTxtBox.Name = "PwdTxtBox";
            this.PwdTxtBox.Size = new System.Drawing.Size(266, 20);
            this.PwdTxtBox.TabIndex = 3;
            // 
            // Sign
            // 
            this.Sign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sign.BackColor = System.Drawing.Color.AliceBlue;
            this.Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign.ForeColor = System.Drawing.Color.Black;
            this.Sign.Location = new System.Drawing.Point(319, 245);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(95, 29);
            this.Sign.TabIndex = 4;
            this.Sign.Text = "Sign In";
            this.Sign.UseVisualStyleBackColor = false;
            this.Sign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(569, 387);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.PwdTxtBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginTxtBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTxtBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PwdTxtBox;
        private System.Windows.Forms.Button Sign;
    }
}