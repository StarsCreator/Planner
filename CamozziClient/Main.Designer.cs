namespace CamozziClient
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mChart = new Braincase.GanttChart.Chart();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mChart2 = new Braincase.GanttChart.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint200 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint150 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint100 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint80 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint50 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint25 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint10 = new System.Windows.Forms.ToolStripMenuItem();
            this.printImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileImgPrint100 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileImgPrint50 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileImgPrint10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewDayOfWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewDayOfMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewWeekOfYear = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1027, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общая";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mChart);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 428);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // mChart
            // 
            this.mChart.AllowTaskDragDrop = false;
            this.mChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mChart.ContextMenuStrip = this.contextMenuStrip2;
            this.mChart.FullDateStringFormat = null;
            this.mChart.Location = new System.Drawing.Point(4, 3);
            this.mChart.Margin = new System.Windows.Forms.Padding(0);
            this.mChart.Name = "mChart";
            this.mChart.Size = new System.Drawing.Size(679, 422);
            this.mChart.TabIndex = 0;
            this.mChart.Load += new System.EventHandler(this.mChart_Load);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(127, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem2.Text = "Добавить";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1027, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Личная";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.mChart2);
            this.splitContainer2.Size = new System.Drawing.Size(1027, 443);
            this.splitContainer2.SplitterDistance = 341;
            this.splitContainer2.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(335, 422);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // mChart2
            // 
            this.mChart2.AllowTaskDragDrop = false;
            this.mChart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mChart2.ContextMenuStrip = this.contextMenuStrip1;
            this.mChart2.FullDateStringFormat = null;
            this.mChart2.Location = new System.Drawing.Point(2, 3);
            this.mChart2.Margin = new System.Windows.Forms.Padding(0);
            this.mChart2.Name = "mChart2";
            this.mChart2.Size = new System.Drawing.Size(677, 422);
            this.mChart2.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 26);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.toolStripMenuItem3,
            this.mnuFileSave,
            this.mnuFileOpen,
            this.toolStripMenuItem4,
            this.mnuFilePrint,
            this.printImageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(365, 22);
            this.mnuFileNew.Text = "New";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(362, 6);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(365, 22);
            this.mnuFileSave.Text = "Save...";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(365, 22);
            this.mnuFileOpen.Text = "Open...";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(362, 6);
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilePrint200,
            this.mnuFilePrint150,
            this.mnuFilePrint100,
            this.mnuFilePrint80,
            this.mnuFilePrint50,
            this.mnuFilePrint25,
            this.mnuFilePrint10});
            this.mnuFilePrint.Name = "mnuFilePrint";
            this.mnuFilePrint.Size = new System.Drawing.Size(365, 22);
            this.mnuFilePrint.Text = "Print Document (Printing to PDF is advised for this test)";
            // 
            // mnuFilePrint200
            // 
            this.mnuFilePrint200.Name = "mnuFilePrint200";
            this.mnuFilePrint200.Size = new System.Drawing.Size(102, 22);
            this.mnuFilePrint200.Text = "200%";
            // 
            // mnuFilePrint150
            // 
            this.mnuFilePrint150.Name = "mnuFilePrint150";
            this.mnuFilePrint150.Size = new System.Drawing.Size(102, 22);
            this.mnuFilePrint150.Text = "150%";
            // 
            // mnuFilePrint100
            // 
            this.mnuFilePrint100.Name = "mnuFilePrint100";
            this.mnuFilePrint100.Size = new System.Drawing.Size(102, 22);
            this.mnuFilePrint100.Text = "100%";
            // 
            // mnuFilePrint80
            // 
            this.mnuFilePrint80.Name = "mnuFilePrint80";
            this.mnuFilePrint80.Size = new System.Drawing.Size(102, 22);
            this.mnuFilePrint80.Text = "80%";
            // 
            // mnuFilePrint50
            // 
            this.mnuFilePrint50.Name = "mnuFilePrint50";
            this.mnuFilePrint50.Size = new System.Drawing.Size(102, 22);
            this.mnuFilePrint50.Text = "50%";
            // 
            // mnuFilePrint25
            // 
            this.mnuFilePrint25.Name = "mnuFilePrint25";
            this.mnuFilePrint25.Size = new System.Drawing.Size(102, 22);
            this.mnuFilePrint25.Text = "25%";
            // 
            // mnuFilePrint10
            // 
            this.mnuFilePrint10.Name = "mnuFilePrint10";
            this.mnuFilePrint10.Size = new System.Drawing.Size(102, 22);
            this.mnuFilePrint10.Text = "10%";
            // 
            // printImageToolStripMenuItem
            // 
            this.printImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileImgPrint100,
            this.mnuFileImgPrint50,
            this.mnuFileImgPrint10});
            this.printImageToolStripMenuItem.Name = "printImageToolStripMenuItem";
            this.printImageToolStripMenuItem.Size = new System.Drawing.Size(365, 22);
            this.printImageToolStripMenuItem.Text = "Print Image (Warning: Large file sizes)";
            // 
            // mnuFileImgPrint100
            // 
            this.mnuFileImgPrint100.Name = "mnuFileImgPrint100";
            this.mnuFileImgPrint100.Size = new System.Drawing.Size(152, 22);
            this.mnuFileImgPrint100.Text = "100%";
            // 
            // mnuFileImgPrint50
            // 
            this.mnuFileImgPrint50.Name = "mnuFileImgPrint50";
            this.mnuFileImgPrint50.Size = new System.Drawing.Size(152, 22);
            this.mnuFileImgPrint50.Text = "50%";
            // 
            // mnuFileImgPrint10
            // 
            this.mnuFileImgPrint10.Name = "mnuFileImgPrint10";
            this.mnuFileImgPrint10.Size = new System.Drawing.Size(152, 22);
            this.mnuFileImgPrint10.Text = "10%";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(362, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(365, 22);
            this.mnuFileExit.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewDayOfWeek,
            this.mnuViewDayOfMonth,
            this.mnuViewWeekOfYear});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mnuViewDayOfWeek
            // 
            this.mnuViewDayOfWeek.Checked = true;
            this.mnuViewDayOfWeek.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewDayOfWeek.Name = "mnuViewDayOfWeek";
            this.mnuViewDayOfWeek.Size = new System.Drawing.Size(149, 22);
            this.mnuViewDayOfWeek.Text = "Day Of Week";
            this.mnuViewDayOfWeek.Click += new System.EventHandler(this.mnuViewDayOfWeek_Click);
            // 
            // mnuViewDayOfMonth
            // 
            this.mnuViewDayOfMonth.Name = "mnuViewDayOfMonth";
            this.mnuViewDayOfMonth.Size = new System.Drawing.Size(149, 22);
            this.mnuViewDayOfMonth.Text = "Day Of Month";
            this.mnuViewDayOfMonth.Click += new System.EventHandler(this.mnuViewDayOfMonth_Click);
            // 
            // mnuViewWeekOfYear
            // 
            this.mnuViewWeekOfYear.Name = "mnuViewWeekOfYear";
            this.mnuViewWeekOfYear.Size = new System.Drawing.Size(149, 22);
            this.mnuViewWeekOfYear.Text = "Week Of Year";
            this.mnuViewWeekOfYear.Click += new System.EventHandler(this.mnuViewWeekOfYear_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 493);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "CamozziClient";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Braincase.GanttChart.Chart mChart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Braincase.GanttChart.Chart mChart2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint200;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint150;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint100;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint80;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint50;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint25;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint10;
        private System.Windows.Forms.ToolStripMenuItem printImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileImgPrint100;
        private System.Windows.Forms.ToolStripMenuItem mnuFileImgPrint50;
        private System.Windows.Forms.ToolStripMenuItem mnuFileImgPrint10;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuViewDayOfWeek;
        private System.Windows.Forms.ToolStripMenuItem mnuViewDayOfMonth;
        private System.Windows.Forms.ToolStripMenuItem mnuViewWeekOfYear;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    }
}

