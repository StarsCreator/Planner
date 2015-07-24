namespace Camozzi.GUI
{
    partial class UserDetail
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
            this.fieldPhone = new MetroFramework.Controls.MetroTextBox();
            this.fieldMail = new MetroFramework.Controls.MetroTextBox();
            this.fieldDept = new MetroFramework.Controls.MetroTextBox();
            this.fieldComment = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.OkBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // fieldPhone
            // 
            this.fieldPhone.Lines = new string[0];
            this.fieldPhone.Location = new System.Drawing.Point(91, 56);
            this.fieldPhone.MaxLength = 32767;
            this.fieldPhone.Name = "fieldPhone";
            this.fieldPhone.PasswordChar = '\0';
            this.fieldPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fieldPhone.SelectedText = "";
            this.fieldPhone.Size = new System.Drawing.Size(233, 30);
            this.fieldPhone.TabIndex = 0;
            this.fieldPhone.UseSelectable = true;
            // 
            // fieldMail
            // 
            this.fieldMail.Lines = new string[] {
        "metroTextBox2"};
            this.fieldMail.Location = new System.Drawing.Point(91, 92);
            this.fieldMail.MaxLength = 32767;
            this.fieldMail.Name = "fieldMail";
            this.fieldMail.PasswordChar = '\0';
            this.fieldMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fieldMail.SelectedText = "";
            this.fieldMail.Size = new System.Drawing.Size(233, 30);
            this.fieldMail.TabIndex = 1;
            this.fieldMail.Text = "metroTextBox2";
            this.fieldMail.UseSelectable = true;
            // 
            // fieldDept
            // 
            this.fieldDept.Lines = new string[] {
        "metroTextBox3"};
            this.fieldDept.Location = new System.Drawing.Point(91, 128);
            this.fieldDept.MaxLength = 32767;
            this.fieldDept.Name = "fieldDept";
            this.fieldDept.PasswordChar = '\0';
            this.fieldDept.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fieldDept.SelectedText = "";
            this.fieldDept.Size = new System.Drawing.Size(233, 30);
            this.fieldDept.TabIndex = 2;
            this.fieldDept.Text = "metroTextBox3";
            this.fieldDept.UseSelectable = true;
            // 
            // fieldComment
            // 
            this.fieldComment.Lines = new string[] {
        "metroTextBox4"};
            this.fieldComment.Location = new System.Drawing.Point(91, 164);
            this.fieldComment.MaxLength = 32767;
            this.fieldComment.Multiline = true;
            this.fieldComment.Name = "fieldComment";
            this.fieldComment.PasswordChar = '\0';
            this.fieldComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fieldComment.SelectedText = "";
            this.fieldComment.Size = new System.Drawing.Size(233, 120);
            this.fieldComment.TabIndex = 3;
            this.fieldComment.Text = "metroTextBox4";
            this.fieldComment.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Телефон";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Mail";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Отдел";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 164);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Прочее";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(249, 290);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 8;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseSelectable = true;
            // 
            // UserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 334);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.fieldComment);
            this.Controls.Add(this.fieldDept);
            this.Controls.Add(this.fieldMail);
            this.Controls.Add(this.fieldPhone);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDetail";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "UserDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox fieldPhone;
        private MetroFramework.Controls.MetroTextBox fieldMail;
        private MetroFramework.Controls.MetroTextBox fieldDept;
        private MetroFramework.Controls.MetroTextBox fieldComment;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton OkBtn;
    }
}