namespace Camozzi.GUI
{
    partial class ReclamationDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReclamationDetail));
            this.l14 = new MetroFramework.Controls.MetroLabel();
            this.l10 = new MetroFramework.Controls.MetroLabel();
            this.CancelBtn = new MetroFramework.Controls.MetroButton();
            this.CommentTb = new MetroFramework.Controls.MetroTextBox();
            this.l4 = new MetroFramework.Controls.MetroLabel();
            this.l11 = new MetroFramework.Controls.MetroLabel();
            this.l9 = new MetroFramework.Controls.MetroLabel();
            this.l2 = new MetroFramework.Controls.MetroLabel();
            this.l1 = new MetroFramework.Controls.MetroLabel();
            this.StatusCb = new MetroFramework.Controls.MetroComboBox();
            this.CheckedMdt = new MetroFramework.Controls.MetroDateTime();
            this.ManagerCb = new MetroFramework.Controls.MetroComboBox();
            this.OkBtn = new MetroFramework.Controls.MetroButton();
            this.StartMdt = new MetroFramework.Controls.MetroDateTime();
            this.ProductionTb = new MetroFramework.Controls.MetroTextBox();
            this.NomenclatureTb = new MetroFramework.Controls.MetroTextBox();
            this.l5 = new MetroFramework.Controls.MetroLabel();
            this.UserCb = new MetroFramework.Controls.MetroComboBox();
            this.l12 = new MetroFramework.Controls.MetroLabel();
            this.SendMDt = new MetroFramework.Controls.MetroDateTime();
            this.l6 = new MetroFramework.Controls.MetroLabel();
            this.ReclamationTb = new MetroFramework.Controls.MetroTextBox();
            this.l3 = new MetroFramework.Controls.MetroLabel();
            this.CountTb = new MetroFramework.Controls.MetroTextBox();
            this.l8 = new MetroFramework.Controls.MetroLabel();
            this.ActTb = new MetroFramework.Controls.MetroTextBox();
            this.l7 = new MetroFramework.Controls.MetroLabel();
            this.ClientTb = new MetroFramework.Controls.MetroTextBox();
            this.SolutionCb = new MetroFramework.Controls.MetroCheckBox();
            this.l13 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMng = new MetroFramework.Controls.MetroTile();
            this.btnUsr = new MetroFramework.Controls.MetroTile();
            this.addMng = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // l14
            // 
            this.l14.AutoSize = true;
            this.l14.Location = new System.Drawing.Point(427, 246);
            this.l14.Name = "l14";
            this.l14.Size = new System.Drawing.Size(93, 19);
            this.l14.TabIndex = 35;
            this.l14.Text = "Комментарии";
            // 
            // l10
            // 
            this.l10.AutoSize = true;
            this.l10.Location = new System.Drawing.Point(429, 130);
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(47, 19);
            this.l10.TabIndex = 33;
            this.l10.Text = "Статус";
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(701, 513);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 32;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseSelectable = true;
            // 
            // CommentTb
            // 
            this.CommentTb.Lines = new string[0];
            this.CommentTb.Location = new System.Drawing.Point(526, 246);
            this.CommentTb.MaxLength = 32767;
            this.CommentTb.Multiline = true;
            this.CommentTb.Name = "CommentTb";
            this.CommentTb.PasswordChar = '\0';
            this.CommentTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CommentTb.SelectedText = "";
            this.CommentTb.Size = new System.Drawing.Size(250, 261);
            this.CommentTb.Style = MetroFramework.MetroColorStyle.Red;
            this.CommentTb.TabIndex = 31;
            this.CommentTb.UseSelectable = true;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(23, 200);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(66, 19);
            this.l4.TabIndex = 30;
            this.l4.Text = "Поступил";
            // 
            // l11
            // 
            this.l11.AutoSize = true;
            this.l11.Location = new System.Drawing.Point(429, 165);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(71, 19);
            this.l11.TabIndex = 29;
            this.l11.Text = "Проверен";
            // 
            // l9
            // 
            this.l9.AutoSize = true;
            this.l9.Location = new System.Drawing.Point(429, 95);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(89, 19);
            this.l9.TabIndex = 28;
            this.l9.Text = "Исполнитель";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(23, 89);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(76, 19);
            this.l2.TabIndex = 27;
            this.l2.Text = "Продукция";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(23, 60);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(96, 19);
            this.l1.TabIndex = 26;
            this.l1.Text = "Номенклатура";
            // 
            // StatusCb
            // 
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.ItemHeight = 23;
            this.StatusCb.Items.AddRange(new object[] {
            "Заявлено",
            "В Работе",
            "Выполнено"});
            this.StatusCb.Location = new System.Drawing.Point(526, 120);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(250, 29);
            this.StatusCb.Style = MetroFramework.MetroColorStyle.Red;
            this.StatusCb.TabIndex = 24;
            this.StatusCb.UseSelectable = true;
            // 
            // CheckedMdt
            // 
            this.CheckedMdt.Location = new System.Drawing.Point(526, 155);
            this.CheckedMdt.MinimumSize = new System.Drawing.Size(0, 29);
            this.CheckedMdt.Name = "CheckedMdt";
            this.CheckedMdt.Size = new System.Drawing.Size(250, 29);
            this.CheckedMdt.Style = MetroFramework.MetroColorStyle.Red;
            this.CheckedMdt.TabIndex = 23;
            // 
            // ManagerCb
            // 
            this.ManagerCb.Enabled = false;
            this.ManagerCb.FormattingEnabled = true;
            this.ManagerCb.ItemHeight = 23;
            this.ManagerCb.Location = new System.Drawing.Point(123, 225);
            this.ManagerCb.Name = "ManagerCb";
            this.ManagerCb.Size = new System.Drawing.Size(178, 29);
            this.ManagerCb.Style = MetroFramework.MetroColorStyle.Red;
            this.ManagerCb.TabIndex = 22;
            this.ManagerCb.UseSelectable = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(620, 513);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 21;
            this.OkBtn.Text = "Ок";
            this.OkBtn.UseSelectable = true;
            // 
            // StartMdt
            // 
            this.StartMdt.Location = new System.Drawing.Point(123, 190);
            this.StartMdt.MinimumSize = new System.Drawing.Size(0, 29);
            this.StartMdt.Name = "StartMdt";
            this.StartMdt.Size = new System.Drawing.Size(250, 29);
            this.StartMdt.Style = MetroFramework.MetroColorStyle.Red;
            this.StartMdt.TabIndex = 20;
            // 
            // ProductionTb
            // 
            this.ProductionTb.Lines = new string[0];
            this.ProductionTb.Location = new System.Drawing.Point(123, 85);
            this.ProductionTb.MaxLength = 1000;
            this.ProductionTb.Multiline = true;
            this.ProductionTb.Name = "ProductionTb";
            this.ProductionTb.PasswordChar = '\0';
            this.ProductionTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductionTb.SelectedText = "";
            this.ProductionTb.Size = new System.Drawing.Size(250, 70);
            this.ProductionTb.Style = MetroFramework.MetroColorStyle.Red;
            this.ProductionTb.TabIndex = 19;
            this.ProductionTb.UseSelectable = true;
            // 
            // NomenclatureTb
            // 
            this.NomenclatureTb.Lines = new string[0];
            this.NomenclatureTb.Location = new System.Drawing.Point(123, 56);
            this.NomenclatureTb.MaxLength = 32767;
            this.NomenclatureTb.Name = "NomenclatureTb";
            this.NomenclatureTb.PasswordChar = '\0';
            this.NomenclatureTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NomenclatureTb.SelectedText = "";
            this.NomenclatureTb.Size = new System.Drawing.Size(250, 23);
            this.NomenclatureTb.Style = MetroFramework.MetroColorStyle.Red;
            this.NomenclatureTb.TabIndex = 18;
            this.NomenclatureTb.UseSelectable = true;
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Enabled = false;
            this.l5.Location = new System.Drawing.Point(23, 235);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(74, 19);
            this.l5.TabIndex = 37;
            this.l5.Text = "Менеджер";
            // 
            // UserCb
            // 
            this.UserCb.Enabled = false;
            this.UserCb.FormattingEnabled = true;
            this.UserCb.ItemHeight = 23;
            this.UserCb.Location = new System.Drawing.Point(526, 85);
            this.UserCb.Name = "UserCb";
            this.UserCb.Size = new System.Drawing.Size(214, 29);
            this.UserCb.Style = MetroFramework.MetroColorStyle.Red;
            this.UserCb.TabIndex = 36;
            this.UserCb.UseSelectable = true;
            // 
            // l12
            // 
            this.l12.AutoSize = true;
            this.l12.Location = new System.Drawing.Point(429, 200);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(77, 19);
            this.l12.TabIndex = 39;
            this.l12.Text = "Отправлен";
            // 
            // SendMDt
            // 
            this.SendMDt.Location = new System.Drawing.Point(526, 190);
            this.SendMDt.MinimumSize = new System.Drawing.Size(0, 29);
            this.SendMDt.Name = "SendMDt";
            this.SendMDt.Size = new System.Drawing.Size(250, 29);
            this.SendMDt.Style = MetroFramework.MetroColorStyle.Red;
            this.SendMDt.TabIndex = 38;
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(23, 261);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(83, 19);
            this.l6.TabIndex = 41;
            this.l6.Text = "Рекламация";
            // 
            // ReclamationTb
            // 
            this.ReclamationTb.Lines = new string[0];
            this.ReclamationTb.Location = new System.Drawing.Point(123, 261);
            this.ReclamationTb.MaxLength = 32767;
            this.ReclamationTb.Multiline = true;
            this.ReclamationTb.Name = "ReclamationTb";
            this.ReclamationTb.PasswordChar = '\0';
            this.ReclamationTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ReclamationTb.SelectedText = "";
            this.ReclamationTb.Size = new System.Drawing.Size(250, 120);
            this.ReclamationTb.Style = MetroFramework.MetroColorStyle.Red;
            this.ReclamationTb.TabIndex = 40;
            this.ReclamationTb.UseSelectable = true;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(23, 165);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(79, 19);
            this.l3.TabIndex = 43;
            this.l3.Text = "Количество";
            // 
            // CountTb
            // 
            this.CountTb.Lines = new string[0];
            this.CountTb.Location = new System.Drawing.Point(123, 161);
            this.CountTb.MaxLength = 32767;
            this.CountTb.Name = "CountTb";
            this.CountTb.PasswordChar = '\0';
            this.CountTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CountTb.SelectedText = "";
            this.CountTb.Size = new System.Drawing.Size(250, 23);
            this.CountTb.Style = MetroFramework.MetroColorStyle.Red;
            this.CountTb.TabIndex = 42;
            this.CountTb.UseSelectable = true;
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Location = new System.Drawing.Point(429, 60);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(29, 19);
            this.l8.TabIndex = 45;
            this.l8.Text = "Акт";
            // 
            // ActTb
            // 
            this.ActTb.Lines = new string[0];
            this.ActTb.Location = new System.Drawing.Point(526, 56);
            this.ActTb.MaxLength = 32767;
            this.ActTb.Name = "ActTb";
            this.ActTb.PasswordChar = '\0';
            this.ActTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ActTb.SelectedText = "";
            this.ActTb.Size = new System.Drawing.Size(250, 23);
            this.ActTb.Style = MetroFramework.MetroColorStyle.Red;
            this.ActTb.TabIndex = 44;
            this.ActTb.UseSelectable = true;
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Location = new System.Drawing.Point(23, 387);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(51, 19);
            this.l7.TabIndex = 47;
            this.l7.Text = "Клиент";
            // 
            // ClientTb
            // 
            this.ClientTb.Lines = new string[0];
            this.ClientTb.Location = new System.Drawing.Point(123, 387);
            this.ClientTb.MaxLength = 32767;
            this.ClientTb.Multiline = true;
            this.ClientTb.Name = "ClientTb";
            this.ClientTb.PasswordChar = '\0';
            this.ClientTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ClientTb.SelectedText = "";
            this.ClientTb.Size = new System.Drawing.Size(250, 120);
            this.ClientTb.Style = MetroFramework.MetroColorStyle.Red;
            this.ClientTb.TabIndex = 46;
            this.ClientTb.UseSelectable = true;
            // 
            // SolutionCb
            // 
            this.SolutionCb.AutoSize = true;
            this.SolutionCb.Location = new System.Drawing.Point(526, 225);
            this.SolutionCb.Name = "SolutionCb";
            this.SolutionCb.Size = new System.Drawing.Size(70, 15);
            this.SolutionCb.Style = MetroFramework.MetroColorStyle.Red;
            this.SolutionCb.TabIndex = 49;
            this.SolutionCb.Text = "Принята";
            this.SolutionCb.UseSelectable = true;
            // 
            // l13
            // 
            this.l13.AutoSize = true;
            this.l13.Location = new System.Drawing.Point(429, 221);
            this.l13.Name = "l13";
            this.l13.Size = new System.Drawing.Size(65, 19);
            this.l13.TabIndex = 50;
            this.l13.Text = "Решение";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMng
            // 
            this.btnMng.ActiveControl = null;
            this.btnMng.Location = new System.Drawing.Point(307, 224);
            this.btnMng.Name = "btnMng";
            this.btnMng.Size = new System.Drawing.Size(30, 30);
            this.btnMng.Style = MetroFramework.MetroColorStyle.Red;
            this.btnMng.TabIndex = 54;
            this.btnMng.TileImage = ((System.Drawing.Image)(resources.GetObject("btnMng.TileImage")));
            this.btnMng.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMng.UseSelectable = true;
            this.btnMng.UseTileImage = true;
            // 
            // btnUsr
            // 
            this.btnUsr.ActiveControl = null;
            this.btnUsr.Location = new System.Drawing.Point(746, 85);
            this.btnUsr.Name = "btnUsr";
            this.btnUsr.Size = new System.Drawing.Size(30, 30);
            this.btnUsr.Style = MetroFramework.MetroColorStyle.Red;
            this.btnUsr.TabIndex = 53;
            this.btnUsr.TileImage = ((System.Drawing.Image)(resources.GetObject("btnUsr.TileImage")));
            this.btnUsr.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsr.UseSelectable = true;
            this.btnUsr.UseTileImage = true;
            // 
            // addMng
            // 
            this.addMng.ActiveControl = null;
            this.addMng.Location = new System.Drawing.Point(343, 225);
            this.addMng.Name = "addMng";
            this.addMng.Size = new System.Drawing.Size(30, 30);
            this.addMng.Style = MetroFramework.MetroColorStyle.Red;
            this.addMng.TabIndex = 55;
            this.addMng.TileImage = ((System.Drawing.Image)(resources.GetObject("addMng.TileImage")));
            this.addMng.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addMng.UseSelectable = true;
            this.addMng.UseTileImage = true;
            // 
            // ReclamationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(805, 566);
            this.Controls.Add(this.addMng);
            this.Controls.Add(this.btnMng);
            this.Controls.Add(this.btnUsr);
            this.Controls.Add(this.l13);
            this.Controls.Add(this.SolutionCb);
            this.Controls.Add(this.l7);
            this.Controls.Add(this.ClientTb);
            this.Controls.Add(this.l8);
            this.Controls.Add(this.ActTb);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.CountTb);
            this.Controls.Add(this.l6);
            this.Controls.Add(this.ReclamationTb);
            this.Controls.Add(this.l12);
            this.Controls.Add(this.SendMDt);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.UserCb);
            this.Controls.Add(this.l14);
            this.Controls.Add(this.l10);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CommentTb);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l11);
            this.Controls.Add(this.l9);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.StatusCb);
            this.Controls.Add(this.CheckedMdt);
            this.Controls.Add(this.ManagerCb);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.StartMdt);
            this.Controls.Add(this.ProductionTb);
            this.Controls.Add(this.NomenclatureTb);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReclamationDetail";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel l14;
        private MetroFramework.Controls.MetroLabel l10;
        private MetroFramework.Controls.MetroButton CancelBtn;
        private MetroFramework.Controls.MetroTextBox CommentTb;
        private MetroFramework.Controls.MetroLabel l4;
        private MetroFramework.Controls.MetroLabel l11;
        private MetroFramework.Controls.MetroLabel l9;
        private MetroFramework.Controls.MetroLabel l2;
        private MetroFramework.Controls.MetroLabel l1;
        private MetroFramework.Controls.MetroComboBox StatusCb;
        private MetroFramework.Controls.MetroDateTime CheckedMdt;
        private MetroFramework.Controls.MetroComboBox ManagerCb;
        private MetroFramework.Controls.MetroButton OkBtn;
        private MetroFramework.Controls.MetroDateTime StartMdt;
        private MetroFramework.Controls.MetroTextBox ProductionTb;
        private MetroFramework.Controls.MetroTextBox NomenclatureTb;
        private MetroFramework.Controls.MetroLabel l5;
        private MetroFramework.Controls.MetroComboBox UserCb;
        private MetroFramework.Controls.MetroLabel l12;
        private MetroFramework.Controls.MetroDateTime SendMDt;
        private MetroFramework.Controls.MetroLabel l6;
        private MetroFramework.Controls.MetroTextBox ReclamationTb;
        private MetroFramework.Controls.MetroLabel l3;
        private MetroFramework.Controls.MetroTextBox CountTb;
        private MetroFramework.Controls.MetroLabel l8;
        private MetroFramework.Controls.MetroTextBox ActTb;
        private MetroFramework.Controls.MetroLabel l7;
        private MetroFramework.Controls.MetroTextBox ClientTb;
        private MetroFramework.Controls.MetroCheckBox SolutionCb;
        private MetroFramework.Controls.MetroLabel l13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroTile btnMng;
        private MetroFramework.Controls.MetroTile btnUsr;
        private MetroFramework.Controls.MetroTile addMng;
    }
}