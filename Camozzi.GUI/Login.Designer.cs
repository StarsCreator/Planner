namespace Camozzi.GUI
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
            this.Psw = new MetroFramework.Controls.MetroTextBox();
            this.UsR = new MetroFramework.Controls.MetroComboBox();
            this.LogBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Psw
            // 
            this.Psw.Lines = new string[0];
            this.Psw.Location = new System.Drawing.Point(33, 98);
            this.Psw.MaxLength = 32767;
            this.Psw.Name = "Psw";
            this.Psw.PasswordChar = '*';
            this.Psw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Psw.SelectedText = "";
            this.Psw.Size = new System.Drawing.Size(311, 23);
            this.Psw.TabIndex = 0;
            this.Psw.UseSelectable = true;
            this.Psw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Psw_KeyDown);
            // 
            // UsR
            // 
            this.UsR.FormattingEnabled = true;
            this.UsR.ItemHeight = 23;
            this.UsR.Location = new System.Drawing.Point(33, 63);
            this.UsR.Name = "UsR";
            this.UsR.Size = new System.Drawing.Size(311, 29);
            this.UsR.Style = MetroFramework.MetroColorStyle.Red;
            this.UsR.TabIndex = 2;
            this.UsR.UseSelectable = true;
            // 
            // LogBtn
            // 
            this.LogBtn.Location = new System.Drawing.Point(33, 127);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(311, 23);
            this.LogBtn.TabIndex = 3;
            this.LogBtn.Text = "Вход";
            this.LogBtn.UseSelectable = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Camozzi.GUI.Properties.Resources.allChart;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.ClientSize = new System.Drawing.Size(367, 163);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.UsR);
            this.Controls.Add(this.Psw);
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "CamozziClient";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Psw;
        private MetroFramework.Controls.MetroComboBox UsR;
        private MetroFramework.Controls.MetroButton LogBtn;

    }
}