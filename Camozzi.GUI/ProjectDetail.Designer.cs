namespace Camozzi.GUI
{
    partial class ProjectDetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectDetail));
            this.IdTB = new MetroFramework.Controls.MetroTextBox();
            this.NameTb = new MetroFramework.Controls.MetroTextBox();
            this.StartMdt = new MetroFramework.Controls.MetroDateTime();
            this.butOk = new MetroFramework.Controls.MetroButton();
            this.userCb = new MetroFramework.Controls.MetroComboBox();
            this.FinishMdt = new MetroFramework.Controls.MetroDateTime();
            this.StateCb = new MetroFramework.Controls.MetroComboBox();
            this.PriorityCb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.CommentTb = new MetroFramework.Controls.MetroTextBox();
            this.butCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.managerCb = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btnUsr = new MetroFramework.Controls.MetroTile();
            this.btnMng = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // IdTB
            // 
            this.IdTB.Enabled = false;
            this.IdTB.Lines = new string[0];
            this.IdTB.Location = new System.Drawing.Point(145, 56);
            this.IdTB.MaxLength = 32767;
            this.IdTB.Name = "IdTB";
            this.IdTB.PasswordChar = '\0';
            this.IdTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IdTB.SelectedText = "";
            this.IdTB.Size = new System.Drawing.Size(235, 30);
            this.IdTB.Style = MetroFramework.MetroColorStyle.Red;
            this.IdTB.TabIndex = 0;
            this.IdTB.UseSelectable = true;
            // 
            // NameTb
            // 
            this.NameTb.Lines = new string[0];
            this.NameTb.Location = new System.Drawing.Point(145, 92);
            this.NameTb.MaxLength = 32767;
            this.NameTb.Name = "NameTb";
            this.NameTb.PasswordChar = '\0';
            this.NameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTb.SelectedText = "";
            this.NameTb.Size = new System.Drawing.Size(235, 30);
            this.NameTb.Style = MetroFramework.MetroColorStyle.Red;
            this.NameTb.TabIndex = 1;
            this.NameTb.UseSelectable = true;
            // 
            // StartMdt
            // 
            this.StartMdt.Location = new System.Drawing.Point(145, 128);
            this.StartMdt.MinimumSize = new System.Drawing.Size(0, 29);
            this.StartMdt.Name = "StartMdt";
            this.StartMdt.Size = new System.Drawing.Size(235, 29);
            this.StartMdt.Style = MetroFramework.MetroColorStyle.Red;
            this.StartMdt.TabIndex = 2;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(224, 470);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 3;
            this.butOk.Text = "Oк";
            this.butOk.UseSelectable = true;
            // 
            // userCb
            // 
            this.userCb.FormattingEnabled = true;
            this.userCb.ItemHeight = 23;
            this.userCb.Location = new System.Drawing.Point(145, 233);
            this.userCb.Name = "userCb";
            this.userCb.Size = new System.Drawing.Size(198, 29);
            this.userCb.Style = MetroFramework.MetroColorStyle.Red;
            this.userCb.TabIndex = 4;
            this.userCb.UseSelectable = true;
            // 
            // FinishMdt
            // 
            this.FinishMdt.Location = new System.Drawing.Point(145, 163);
            this.FinishMdt.MinimumSize = new System.Drawing.Size(0, 29);
            this.FinishMdt.Name = "FinishMdt";
            this.FinishMdt.Size = new System.Drawing.Size(235, 29);
            this.FinishMdt.Style = MetroFramework.MetroColorStyle.Red;
            this.FinishMdt.TabIndex = 5;
            // 
            // StateCb
            // 
            this.StateCb.FormattingEnabled = true;
            this.StateCb.ItemHeight = 23;
            this.StateCb.Items.AddRange(new object[] {
            "В очереди",
            "В работе",
            "Закончен",
            "Отпуск",
            "На производстве",
            "Приостановлен",
            "Командировка"});
            this.StateCb.Location = new System.Drawing.Point(143, 269);
            this.StateCb.Name = "StateCb";
            this.StateCb.Size = new System.Drawing.Size(237, 29);
            this.StateCb.Style = MetroFramework.MetroColorStyle.Red;
            this.StateCb.TabIndex = 6;
            this.StateCb.UseSelectable = true;
            // 
            // PriorityCb
            // 
            this.PriorityCb.FormattingEnabled = true;
            this.PriorityCb.ItemHeight = 23;
            this.PriorityCb.Items.AddRange(new object[] {
            "Обычный",
            "Высокий"});
            this.PriorityCb.Location = new System.Drawing.Point(143, 304);
            this.PriorityCb.Name = "PriorityCb";
            this.PriorityCb.Size = new System.Drawing.Size(237, 29);
            this.PriorityCb.Style = MetroFramework.MetroColorStyle.Red;
            this.PriorityCb.TabIndex = 7;
            this.PriorityCb.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Номер";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Название";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(48, 243);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Исполнитель";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(48, 173);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Окончание";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(48, 138);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Начало";
            // 
            // CommentTb
            // 
            this.CommentTb.Lines = new string[0];
            this.CommentTb.Location = new System.Drawing.Point(143, 344);
            this.CommentTb.MaxLength = 32767;
            this.CommentTb.Multiline = true;
            this.CommentTb.Name = "CommentTb";
            this.CommentTb.PasswordChar = '\0';
            this.CommentTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CommentTb.SelectedText = "";
            this.CommentTb.Size = new System.Drawing.Size(237, 120);
            this.CommentTb.Style = MetroFramework.MetroColorStyle.Red;
            this.CommentTb.TabIndex = 13;
            this.CommentTb.UseSelectable = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(305, 470);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 14;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(48, 279);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Состояние";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(48, 314);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Приоритет";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(48, 344);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(93, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Комментарии";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // managerCb
            // 
            this.managerCb.FormattingEnabled = true;
            this.managerCb.ItemHeight = 23;
            this.managerCb.Location = new System.Drawing.Point(145, 198);
            this.managerCb.Name = "managerCb";
            this.managerCb.Size = new System.Drawing.Size(198, 29);
            this.managerCb.Style = MetroFramework.MetroColorStyle.Red;
            this.managerCb.TabIndex = 18;
            this.managerCb.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(0, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(100, 23);
            this.metroLabel9.TabIndex = 0;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(0, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(100, 23);
            this.metroLabel10.TabIndex = 0;
            this.metroLabel10.Text = "Менеджер";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(48, 208);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(74, 19);
            this.metroLabel11.TabIndex = 19;
            this.metroLabel11.Text = "Менеджер";
            // 
            // btnUsr
            // 
            this.btnUsr.ActiveControl = null;
            this.btnUsr.Location = new System.Drawing.Point(349, 233);
            this.btnUsr.Name = "btnUsr";
            this.btnUsr.Size = new System.Drawing.Size(30, 30);
            this.btnUsr.Style = MetroFramework.MetroColorStyle.Red;
            this.btnUsr.TabIndex = 20;
            this.btnUsr.TileImage = ((System.Drawing.Image)(resources.GetObject("btnUsr.TileImage")));
            this.btnUsr.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsr.UseSelectable = true;
            this.btnUsr.UseTileImage = true;
            // 
            // btnMng
            // 
            this.btnMng.ActiveControl = null;
            this.btnMng.Location = new System.Drawing.Point(350, 198);
            this.btnMng.Name = "btnMng";
            this.btnMng.Size = new System.Drawing.Size(30, 30);
            this.btnMng.Style = MetroFramework.MetroColorStyle.Red;
            this.btnMng.TabIndex = 21;
            this.btnMng.TileImage = ((System.Drawing.Image)(resources.GetObject("btnMng.TileImage")));
            this.btnMng.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMng.UseSelectable = true;
            this.btnMng.UseTileImage = true;
            // 
            // ProjectDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 504);
            this.Controls.Add(this.btnMng);
            this.Controls.Add(this.btnUsr);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.managerCb);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.CommentTb);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PriorityCb);
            this.Controls.Add(this.StateCb);
            this.Controls.Add(this.FinishMdt);
            this.Controls.Add(this.userCb);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.StartMdt);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.IdTB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectDetail";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "ProjectDetail";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox IdTB;
        private MetroFramework.Controls.MetroTextBox NameTb;
        private MetroFramework.Controls.MetroDateTime StartMdt;
        private MetroFramework.Controls.MetroButton butOk;
        private MetroFramework.Controls.MetroComboBox userCb;
        private MetroFramework.Controls.MetroDateTime FinishMdt;
        private MetroFramework.Controls.MetroComboBox StateCb;
        private MetroFramework.Controls.MetroComboBox PriorityCb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox CommentTb;
        private MetroFramework.Controls.MetroButton butCancel;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroComboBox managerCb;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTile btnMng;
        private MetroFramework.Controls.MetroTile btnUsr;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}