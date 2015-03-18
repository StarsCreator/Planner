namespace Camozzi.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            WeekPlanner.DataColumns dataColumns13 = new WeekPlanner.DataColumns();
            WeekPlanner.DataColumns dataColumns14 = new WeekPlanner.DataColumns();
            WeekPlanner.DataColumns dataColumns15 = new WeekPlanner.DataColumns();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            WeekPlanner.DataColumns dataColumns16 = new WeekPlanner.DataColumns();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.themeBox = new MetroFramework.Controls.MetroComboBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neoTabWindow1 = new NeoTabControlLibrary.NeoTabWindow();
            this.FirstTab = new NeoTabControlLibrary.NeoTabPage();
            this.ProjectStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PlanTab = new NeoTabControlLibrary.NeoTabPage();
            this.neoTabWindow2 = new NeoTabControlLibrary.NeoTabWindow();
            this.AllProjectTab = new NeoTabControlLibrary.NeoTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.AllProjectLeft = new MetroFramework.Controls.MetroTile();
            this.AllProjectRight = new MetroFramework.Controls.MetroTile();
            this.AllProjectStartTimeSet = new MetroFramework.Controls.MetroDateTime();
            this.AllProjectSetDate = new MetroFramework.Controls.MetroTile();
            this.AllProjectsEndTimeSet = new MetroFramework.Controls.MetroDateTime();
            this.AllProjectPlan = new WeekPlanner.CalendarPlanner();
            this.AllReclamationTab = new NeoTabControlLibrary.NeoTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.AllReclamationLeft = new MetroFramework.Controls.MetroTile();
            this.AllReclamationRight = new MetroFramework.Controls.MetroTile();
            this.AllReclamationStartSet = new MetroFramework.Controls.MetroDateTime();
            this.AllReclamationDateSet = new MetroFramework.Controls.MetroTile();
            this.AllReclamationEndSet = new MetroFramework.Controls.MetroDateTime();
            this.AllReclamationPlan = new WeekPlanner.CalendarPlanner();
            this.SelfTaskTab = new NeoTabControlLibrary.NeoTabPage();
            this.neoTabWindow3 = new NeoTabControlLibrary.NeoTabWindow();
            this.SelfProjectTab = new NeoTabControlLibrary.NeoTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.SelfProjectLeft = new MetroFramework.Controls.MetroTile();
            this.SelfProjectRight = new MetroFramework.Controls.MetroTile();
            this.SelfProjectStartSet = new MetroFramework.Controls.MetroDateTime();
            this.SelfProjectSetDate = new MetroFramework.Controls.MetroTile();
            this.SelfProjectEndSet = new MetroFramework.Controls.MetroDateTime();
            this.SelfProjectPlan = new WeekPlanner.CalendarPlanner();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.MetroTableProject = new MetroFramework.Controls.MetroGrid();
            this.MetroChartProject = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SelfReclamationTab = new NeoTabControlLibrary.NeoTabPage();
            this.MetroTableReclamation = new MetroFramework.Controls.MetroGrid();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.SelfReclamationLeft = new MetroFramework.Controls.MetroTile();
            this.SelfReclamationRight = new MetroFramework.Controls.MetroTile();
            this.SelfReclamationStartSet = new MetroFramework.Controls.MetroDateTime();
            this.SelfReclamationDateSet = new MetroFramework.Controls.MetroTile();
            this.SelfReclamationEndSet = new MetroFramework.Controls.MetroDateTime();
            this.SelfReclamationPlan = new WeekPlanner.CalendarPlanner();
            this.ReportTab = new NeoTabControlLibrary.NeoTabPage();
            this.ContextProj = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.AddProj = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProj = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteProj = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow1)).BeginInit();
            this.neoTabWindow1.SuspendLayout();
            this.FirstTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectStat)).BeginInit();
            this.PlanTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow2)).BeginInit();
            this.neoTabWindow2.SuspendLayout();
            this.AllProjectTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.AllReclamationTab.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SelfTaskTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow3)).BeginInit();
            this.neoTabWindow3.SuspendLayout();
            this.SelfProjectTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroTableProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetroChartProject)).BeginInit();
            this.SelfReclamationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroTableReclamation)).BeginInit();
            this.metroPanel4.SuspendLayout();
            this.ContextProj.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CamozziClient";
            this.notifyIcon1.Visible = true;
            // 
            // themeBox
            // 
            this.themeBox.Location = new System.Drawing.Point(0, 0);
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(121, 21);
            this.themeBox.TabIndex = 0;
            this.themeBox.UseSelectable = true;
            // 
            // Column4
            // 
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // neoTabWindow1
            // 
            this.neoTabWindow1.Controls.Add(this.FirstTab);
            this.neoTabWindow1.Controls.Add(this.PlanTab);
            this.neoTabWindow1.Controls.Add(this.SelfTaskTab);
            this.neoTabWindow1.Controls.Add(this.ReportTab);
            this.neoTabWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neoTabWindow1.Location = new System.Drawing.Point(0, 0);
            this.neoTabWindow1.Margin = new System.Windows.Forms.Padding(0);
            this.neoTabWindow1.Name = "neoTabWindow1";
            this.neoTabWindow1.RendererName = "CamozziRenderer";
            this.neoTabWindow1.SelectedIndex = 0;
            this.neoTabWindow1.Size = new System.Drawing.Size(1256, 645);
            this.neoTabWindow1.TabIndex = 0;
            // 
            // FirstTab
            // 
            this.FirstTab.BackColor = System.Drawing.Color.Transparent;
            this.FirstTab.Controls.Add(this.ProjectStat);
            this.FirstTab.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FirstTab.Name = "FirstTab";
            this.FirstTab.Text = "Главная";
            this.FirstTab.ToolTipText = "neoTabPage4";
            // 
            // ProjectStat
            // 
            chartArea7.Name = "ChartArea1";
            this.ProjectStat.ChartAreas.Add(chartArea7);
            this.ProjectStat.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.ProjectStat.Legends.Add(legend7);
            this.ProjectStat.Location = new System.Drawing.Point(0, 0);
            this.ProjectStat.Name = "ProjectStat";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.ProjectStat.Series.Add(series7);
            this.ProjectStat.Size = new System.Drawing.Size(1163, 639);
            this.ProjectStat.TabIndex = 13;
            this.ProjectStat.Text = "chart1";
            // 
            // PlanTab
            // 
            this.PlanTab.BackColor = System.Drawing.Color.Transparent;
            this.PlanTab.Controls.Add(this.neoTabWindow2);
            this.PlanTab.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PlanTab.Name = "PlanTab";
            this.PlanTab.Text = "Планрование";
            this.PlanTab.ToolTipText = "neoTabPage1";
            // 
            // neoTabWindow2
            // 
            this.neoTabWindow2.Controls.Add(this.AllProjectTab);
            this.neoTabWindow2.Controls.Add(this.AllReclamationTab);
            this.neoTabWindow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neoTabWindow2.Location = new System.Drawing.Point(0, 0);
            this.neoTabWindow2.Name = "neoTabWindow2";
            this.neoTabWindow2.RendererName = "CCleanerRendererVS4";
            this.neoTabWindow2.SelectedIndex = 0;
            this.neoTabWindow2.Size = new System.Drawing.Size(1163, 639);
            this.neoTabWindow2.TabIndex = 0;
            // 
            // AllProjectTab
            // 
            this.AllProjectTab.Controls.Add(this.metroPanel1);
            this.AllProjectTab.Controls.Add(this.AllProjectPlan);
            this.AllProjectTab.Name = "AllProjectTab";
            this.AllProjectTab.Text = "Проекты";
            this.AllProjectTab.ToolTipText = "neoTabPage1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.AllProjectLeft);
            this.metroPanel1.Controls.Add(this.AllProjectRight);
            this.metroPanel1.Controls.Add(this.AllProjectStartTimeSet);
            this.metroPanel1.Controls.Add(this.AllProjectSetDate);
            this.metroPanel1.Controls.Add(this.AllProjectsEndTimeSet);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(880, 90);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(176, 148);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // AllProjectLeft
            // 
            this.AllProjectLeft.ActiveControl = null;
            this.AllProjectLeft.Location = new System.Drawing.Point(10, 111);
            this.AllProjectLeft.Margin = new System.Windows.Forms.Padding(10);
            this.AllProjectLeft.Name = "AllProjectLeft";
            this.AllProjectLeft.Size = new System.Drawing.Size(74, 25);
            this.AllProjectLeft.Style = MetroFramework.MetroColorStyle.Silver;
            this.AllProjectLeft.TabIndex = 6;
            this.AllProjectLeft.Text = "Ранее";
            this.AllProjectLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AllProjectLeft.UseSelectable = true;
            // 
            // AllProjectRight
            // 
            this.AllProjectRight.ActiveControl = null;
            this.AllProjectRight.Location = new System.Drawing.Point(91, 111);
            this.AllProjectRight.Margin = new System.Windows.Forms.Padding(10);
            this.AllProjectRight.Name = "AllProjectRight";
            this.AllProjectRight.Size = new System.Drawing.Size(74, 25);
            this.AllProjectRight.Style = MetroFramework.MetroColorStyle.Silver;
            this.AllProjectRight.TabIndex = 7;
            this.AllProjectRight.Text = "Позднее";
            this.AllProjectRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AllProjectRight.UseSelectable = true;
            // 
            // AllProjectStartTimeSet
            // 
            this.AllProjectStartTimeSet.Location = new System.Drawing.Point(10, 10);
            this.AllProjectStartTimeSet.Margin = new System.Windows.Forms.Padding(10);
            this.AllProjectStartTimeSet.MinimumSize = new System.Drawing.Size(0, 29);
            this.AllProjectStartTimeSet.Name = "AllProjectStartTimeSet";
            this.AllProjectStartTimeSet.Size = new System.Drawing.Size(155, 29);
            this.AllProjectStartTimeSet.TabIndex = 4;
            // 
            // AllProjectSetDate
            // 
            this.AllProjectSetDate.ActiveControl = null;
            this.AllProjectSetDate.Location = new System.Drawing.Point(10, 80);
            this.AllProjectSetDate.Margin = new System.Windows.Forms.Padding(10);
            this.AllProjectSetDate.Name = "AllProjectSetDate";
            this.AllProjectSetDate.Size = new System.Drawing.Size(155, 25);
            this.AllProjectSetDate.Style = MetroFramework.MetroColorStyle.Silver;
            this.AllProjectSetDate.TabIndex = 5;
            this.AllProjectSetDate.Text = "Перейти";
            this.AllProjectSetDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AllProjectSetDate.UseSelectable = true;
            // 
            // AllProjectsEndTimeSet
            // 
            this.AllProjectsEndTimeSet.Location = new System.Drawing.Point(10, 45);
            this.AllProjectsEndTimeSet.Margin = new System.Windows.Forms.Padding(10);
            this.AllProjectsEndTimeSet.MinimumSize = new System.Drawing.Size(0, 29);
            this.AllProjectsEndTimeSet.Name = "AllProjectsEndTimeSet";
            this.AllProjectsEndTimeSet.Size = new System.Drawing.Size(155, 29);
            this.AllProjectsEndTimeSet.TabIndex = 3;
            // 
            // AllProjectPlan
            // 
            this.AllProjectPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.AllProjectPlan.Columns = dataColumns13;
            this.AllProjectPlan.CurrentDate = new System.DateTime(2015, 2, 11, 12, 4, 7, 90);
            this.AllProjectPlan.DatesIntervalMode = WeekPlanner.WeekPlannerMode.Daily;
            this.AllProjectPlan.DayCount = 7;
            this.AllProjectPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllProjectPlan.GridBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.AllProjectPlan.GridCellHeight = 200;
            this.AllProjectPlan.GridTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllProjectPlan.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.AllProjectPlan.HeaderColumnsFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllProjectPlan.HeaderDatesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllProjectPlan.HeaderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(234)))));
            this.AllProjectPlan.HeaderFillLeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.AllProjectPlan.HeaderStyleMode = WeekPlanner.HeaderStyle.Aqua;
            this.AllProjectPlan.IsAllowedDraggingBetweenRows = false;
            this.AllProjectPlan.IsAllowedStretchAndDrag = true;
            this.AllProjectPlan.IsAllowedTreeViewDrawing = true;
            this.AllProjectPlan.ItemHeight = 30;
            this.AllProjectPlan.ItemTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllProjectPlan.LeftMargin = 250;
            this.AllProjectPlan.LeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.AllProjectPlan.Location = new System.Drawing.Point(0, 0);
            this.AllProjectPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllProjectPlan.Name = "AllProjectPlan";
            this.AllProjectPlan.Size = new System.Drawing.Size(1077, 633);
            this.AllProjectPlan.TabIndex = 0;
            // 
            // AllReclamationTab
            // 
            this.AllReclamationTab.Controls.Add(this.metroPanel2);
            this.AllReclamationTab.Controls.Add(this.AllReclamationPlan);
            this.AllReclamationTab.Name = "AllReclamationTab";
            this.AllReclamationTab.Text = "Рекламации";
            this.AllReclamationTab.ToolTipText = "neoTabPage2";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.AllReclamationLeft);
            this.metroPanel2.Controls.Add(this.AllReclamationRight);
            this.metroPanel2.Controls.Add(this.AllReclamationStartSet);
            this.metroPanel2.Controls.Add(this.AllReclamationDateSet);
            this.metroPanel2.Controls.Add(this.AllReclamationEndSet);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(880, 90);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(176, 148);
            this.metroPanel2.TabIndex = 9;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // AllReclamationLeft
            // 
            this.AllReclamationLeft.ActiveControl = null;
            this.AllReclamationLeft.Location = new System.Drawing.Point(10, 111);
            this.AllReclamationLeft.Margin = new System.Windows.Forms.Padding(10);
            this.AllReclamationLeft.Name = "AllReclamationLeft";
            this.AllReclamationLeft.Size = new System.Drawing.Size(74, 25);
            this.AllReclamationLeft.TabIndex = 6;
            this.AllReclamationLeft.Text = "Ранее";
            this.AllReclamationLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AllReclamationLeft.UseSelectable = true;
            // 
            // AllReclamationRight
            // 
            this.AllReclamationRight.ActiveControl = null;
            this.AllReclamationRight.Location = new System.Drawing.Point(91, 111);
            this.AllReclamationRight.Margin = new System.Windows.Forms.Padding(10);
            this.AllReclamationRight.Name = "AllReclamationRight";
            this.AllReclamationRight.Size = new System.Drawing.Size(74, 25);
            this.AllReclamationRight.TabIndex = 7;
            this.AllReclamationRight.Text = "Позднее";
            this.AllReclamationRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AllReclamationRight.UseSelectable = true;
            // 
            // AllReclamationStartSet
            // 
            this.AllReclamationStartSet.Location = new System.Drawing.Point(10, 10);
            this.AllReclamationStartSet.Margin = new System.Windows.Forms.Padding(10);
            this.AllReclamationStartSet.MinimumSize = new System.Drawing.Size(4, 29);
            this.AllReclamationStartSet.Name = "AllReclamationStartSet";
            this.AllReclamationStartSet.Size = new System.Drawing.Size(155, 29);
            this.AllReclamationStartSet.TabIndex = 4;
            // 
            // AllReclamationDateSet
            // 
            this.AllReclamationDateSet.ActiveControl = null;
            this.AllReclamationDateSet.Location = new System.Drawing.Point(10, 80);
            this.AllReclamationDateSet.Margin = new System.Windows.Forms.Padding(10);
            this.AllReclamationDateSet.Name = "AllReclamationDateSet";
            this.AllReclamationDateSet.Size = new System.Drawing.Size(155, 25);
            this.AllReclamationDateSet.TabIndex = 5;
            this.AllReclamationDateSet.Text = "Перейти";
            this.AllReclamationDateSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AllReclamationDateSet.UseSelectable = true;
            // 
            // AllReclamationEndSet
            // 
            this.AllReclamationEndSet.Location = new System.Drawing.Point(10, 45);
            this.AllReclamationEndSet.Margin = new System.Windows.Forms.Padding(10);
            this.AllReclamationEndSet.MinimumSize = new System.Drawing.Size(4, 29);
            this.AllReclamationEndSet.Name = "AllReclamationEndSet";
            this.AllReclamationEndSet.Size = new System.Drawing.Size(155, 29);
            this.AllReclamationEndSet.TabIndex = 3;
            // 
            // AllReclamationPlan
            // 
            this.AllReclamationPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.AllReclamationPlan.Columns = dataColumns14;
            this.AllReclamationPlan.CurrentDate = new System.DateTime(2015, 2, 11, 12, 4, 17, 811);
            this.AllReclamationPlan.DatesIntervalMode = WeekPlanner.WeekPlannerMode.Daily;
            this.AllReclamationPlan.DayCount = 7;
            this.AllReclamationPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllReclamationPlan.GridBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.AllReclamationPlan.GridCellHeight = 200;
            this.AllReclamationPlan.GridTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllReclamationPlan.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.AllReclamationPlan.HeaderColumnsFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllReclamationPlan.HeaderDatesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllReclamationPlan.HeaderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(234)))));
            this.AllReclamationPlan.HeaderFillLeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.AllReclamationPlan.HeaderStyleMode = WeekPlanner.HeaderStyle.Aqua;
            this.AllReclamationPlan.IsAllowedDraggingBetweenRows = false;
            this.AllReclamationPlan.IsAllowedStretchAndDrag = true;
            this.AllReclamationPlan.IsAllowedTreeViewDrawing = true;
            this.AllReclamationPlan.ItemHeight = 30;
            this.AllReclamationPlan.ItemTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllReclamationPlan.LeftMargin = 250;
            this.AllReclamationPlan.LeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.AllReclamationPlan.Location = new System.Drawing.Point(0, 0);
            this.AllReclamationPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllReclamationPlan.Name = "AllReclamationPlan";
            this.AllReclamationPlan.Size = new System.Drawing.Size(1077, 633);
            this.AllReclamationPlan.TabIndex = 0;
            // 
            // SelfTaskTab
            // 
            this.SelfTaskTab.BackColor = System.Drawing.Color.Transparent;
            this.SelfTaskTab.Controls.Add(this.neoTabWindow3);
            this.SelfTaskTab.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SelfTaskTab.Name = "SelfTaskTab";
            this.SelfTaskTab.Text = "Задачи";
            this.SelfTaskTab.ToolTipText = "neoTabPage2";
            // 
            // neoTabWindow3
            // 
            this.neoTabWindow3.Controls.Add(this.SelfProjectTab);
            this.neoTabWindow3.Controls.Add(this.SelfReclamationTab);
            this.neoTabWindow3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neoTabWindow3.Location = new System.Drawing.Point(0, 0);
            this.neoTabWindow3.Name = "neoTabWindow3";
            this.neoTabWindow3.RendererName = null;
            this.neoTabWindow3.SelectedIndex = 0;
            this.neoTabWindow3.Size = new System.Drawing.Size(1163, 639);
            this.neoTabWindow3.TabIndex = 0;
            // 
            // SelfProjectTab
            // 
            this.SelfProjectTab.BackColor = System.Drawing.Color.Transparent;
            this.SelfProjectTab.Controls.Add(this.splitContainer1);
            this.SelfProjectTab.Name = "SelfProjectTab";
            this.SelfProjectTab.Text = "Проекты";
            this.SelfProjectTab.ToolTipText = "neoTabPage1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroPanel3);
            this.splitContainer1.Panel1.Controls.Add(this.SelfProjectPlan);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1077, 633);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.TabIndex = 0;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.Controls.Add(this.SelfProjectLeft);
            this.metroPanel3.Controls.Add(this.SelfProjectRight);
            this.metroPanel3.Controls.Add(this.SelfProjectStartSet);
            this.metroPanel3.Controls.Add(this.SelfProjectSetDate);
            this.metroPanel3.Controls.Add(this.SelfProjectEndSet);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(880, 90);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(176, 148);
            this.metroPanel3.TabIndex = 18;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // SelfProjectLeft
            // 
            this.SelfProjectLeft.ActiveControl = null;
            this.SelfProjectLeft.Location = new System.Drawing.Point(10, 111);
            this.SelfProjectLeft.Margin = new System.Windows.Forms.Padding(10);
            this.SelfProjectLeft.Name = "SelfProjectLeft";
            this.SelfProjectLeft.Size = new System.Drawing.Size(74, 25);
            this.SelfProjectLeft.Style = MetroFramework.MetroColorStyle.Brown;
            this.SelfProjectLeft.TabIndex = 6;
            this.SelfProjectLeft.Text = "Ранее";
            this.SelfProjectLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelfProjectLeft.UseSelectable = true;
            // 
            // SelfProjectRight
            // 
            this.SelfProjectRight.ActiveControl = null;
            this.SelfProjectRight.Location = new System.Drawing.Point(91, 111);
            this.SelfProjectRight.Margin = new System.Windows.Forms.Padding(10);
            this.SelfProjectRight.Name = "SelfProjectRight";
            this.SelfProjectRight.Size = new System.Drawing.Size(74, 25);
            this.SelfProjectRight.Style = MetroFramework.MetroColorStyle.Brown;
            this.SelfProjectRight.TabIndex = 7;
            this.SelfProjectRight.Text = "Позднее";
            this.SelfProjectRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelfProjectRight.UseSelectable = true;
            // 
            // SelfProjectStartSet
            // 
            this.SelfProjectStartSet.Location = new System.Drawing.Point(10, 10);
            this.SelfProjectStartSet.Margin = new System.Windows.Forms.Padding(10);
            this.SelfProjectStartSet.MinimumSize = new System.Drawing.Size(4, 29);
            this.SelfProjectStartSet.Name = "SelfProjectStartSet";
            this.SelfProjectStartSet.Size = new System.Drawing.Size(155, 29);
            this.SelfProjectStartSet.TabIndex = 4;
            // 
            // SelfProjectSetDate
            // 
            this.SelfProjectSetDate.ActiveControl = null;
            this.SelfProjectSetDate.Location = new System.Drawing.Point(10, 80);
            this.SelfProjectSetDate.Margin = new System.Windows.Forms.Padding(10);
            this.SelfProjectSetDate.Name = "SelfProjectSetDate";
            this.SelfProjectSetDate.Size = new System.Drawing.Size(155, 25);
            this.SelfProjectSetDate.Style = MetroFramework.MetroColorStyle.Brown;
            this.SelfProjectSetDate.TabIndex = 5;
            this.SelfProjectSetDate.Text = "Перейти";
            this.SelfProjectSetDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelfProjectSetDate.UseSelectable = true;
            // 
            // SelfProjectEndSet
            // 
            this.SelfProjectEndSet.Location = new System.Drawing.Point(10, 45);
            this.SelfProjectEndSet.Margin = new System.Windows.Forms.Padding(10);
            this.SelfProjectEndSet.MinimumSize = new System.Drawing.Size(4, 29);
            this.SelfProjectEndSet.Name = "SelfProjectEndSet";
            this.SelfProjectEndSet.Size = new System.Drawing.Size(155, 29);
            this.SelfProjectEndSet.TabIndex = 3;
            // 
            // SelfProjectPlan
            // 
            this.SelfProjectPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.SelfProjectPlan.Columns = dataColumns15;
            this.SelfProjectPlan.CurrentDate = new System.DateTime(2015, 2, 11, 12, 4, 32, 321);
            this.SelfProjectPlan.DatesIntervalMode = WeekPlanner.WeekPlannerMode.Daily;
            this.SelfProjectPlan.DayCount = 7;
            this.SelfProjectPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelfProjectPlan.GridBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.SelfProjectPlan.GridCellHeight = 200;
            this.SelfProjectPlan.GridTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SelfProjectPlan.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.SelfProjectPlan.HeaderColumnsFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SelfProjectPlan.HeaderDatesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SelfProjectPlan.HeaderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(234)))));
            this.SelfProjectPlan.HeaderFillLeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.SelfProjectPlan.HeaderStyleMode = WeekPlanner.HeaderStyle.Aqua;
            this.SelfProjectPlan.IsAllowedDraggingBetweenRows = true;
            this.SelfProjectPlan.IsAllowedStretchAndDrag = true;
            this.SelfProjectPlan.IsAllowedTreeViewDrawing = true;
            this.SelfProjectPlan.ItemHeight = 30;
            this.SelfProjectPlan.ItemTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SelfProjectPlan.LeftMargin = 250;
            this.SelfProjectPlan.LeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.SelfProjectPlan.Location = new System.Drawing.Point(0, 0);
            this.SelfProjectPlan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SelfProjectPlan.Name = "SelfProjectPlan";
            this.SelfProjectPlan.Size = new System.Drawing.Size(1077, 313);
            this.SelfProjectPlan.TabIndex = 17;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.MetroTableProject);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.MetroChartProject);
            this.splitContainer2.Size = new System.Drawing.Size(1077, 316);
            this.splitContainer2.SplitterDistance = 553;
            this.splitContainer2.TabIndex = 0;
            // 
            // MetroTableProject
            // 
            this.MetroTableProject.AllowUserToAddRows = false;
            this.MetroTableProject.AllowUserToDeleteRows = false;
            this.MetroTableProject.AllowUserToResizeRows = false;
            this.MetroTableProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MetroTableProject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroTableProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MetroTableProject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MetroTableProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroTableProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.MetroTableProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MetroTableProject.DefaultCellStyle = dataGridViewCellStyle20;
            this.MetroTableProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetroTableProject.EnableHeadersVisualStyles = false;
            this.MetroTableProject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MetroTableProject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroTableProject.Location = new System.Drawing.Point(0, 0);
            this.MetroTableProject.Margin = new System.Windows.Forms.Padding(0);
            this.MetroTableProject.MultiSelect = false;
            this.MetroTableProject.Name = "MetroTableProject";
            this.MetroTableProject.ReadOnly = true;
            this.MetroTableProject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroTableProject.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.MetroTableProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MetroTableProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MetroTableProject.Size = new System.Drawing.Size(553, 316);
            this.MetroTableProject.TabIndex = 18;
            // 
            // MetroChartProject
            // 
            chartArea8.Name = "ChartArea1";
            this.MetroChartProject.ChartAreas.Add(chartArea8);
            this.MetroChartProject.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Legend1";
            this.MetroChartProject.Legends.Add(legend8);
            this.MetroChartProject.Location = new System.Drawing.Point(0, 0);
            this.MetroChartProject.Name = "MetroChartProject";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            series8.YValuesPerPoint = 4;
            this.MetroChartProject.Series.Add(series8);
            this.MetroChartProject.Size = new System.Drawing.Size(520, 316);
            this.MetroChartProject.TabIndex = 19;
            this.MetroChartProject.Text = "chart1";
            // 
            // SelfReclamationTab
            // 
            this.SelfReclamationTab.Controls.Add(this.MetroTableReclamation);
            this.SelfReclamationTab.Controls.Add(this.metroPanel4);
            this.SelfReclamationTab.Controls.Add(this.SelfReclamationPlan);
            this.SelfReclamationTab.Name = "SelfReclamationTab";
            this.SelfReclamationTab.Text = "Рекламации";
            this.SelfReclamationTab.ToolTipText = "neoTabPage1";
            // 
            // MetroTableReclamation
            // 
            this.MetroTableReclamation.AllowUserToResizeRows = false;
            this.MetroTableReclamation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroTableReclamation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MetroTableReclamation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MetroTableReclamation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroTableReclamation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.MetroTableReclamation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MetroTableReclamation.DefaultCellStyle = dataGridViewCellStyle23;
            this.MetroTableReclamation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetroTableReclamation.EnableHeadersVisualStyles = false;
            this.MetroTableReclamation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MetroTableReclamation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroTableReclamation.Location = new System.Drawing.Point(0, 300);
            this.MetroTableReclamation.Name = "MetroTableReclamation";
            this.MetroTableReclamation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroTableReclamation.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.MetroTableReclamation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MetroTableReclamation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MetroTableReclamation.Size = new System.Drawing.Size(1077, 333);
            this.MetroTableReclamation.TabIndex = 12;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel4.Controls.Add(this.SelfReclamationLeft);
            this.metroPanel4.Controls.Add(this.SelfReclamationRight);
            this.metroPanel4.Controls.Add(this.SelfReclamationStartSet);
            this.metroPanel4.Controls.Add(this.SelfReclamationDateSet);
            this.metroPanel4.Controls.Add(this.SelfReclamationEndSet);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(880, 90);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(176, 148);
            this.metroPanel4.TabIndex = 10;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // SelfReclamationLeft
            // 
            this.SelfReclamationLeft.ActiveControl = null;
            this.SelfReclamationLeft.Location = new System.Drawing.Point(10, 111);
            this.SelfReclamationLeft.Margin = new System.Windows.Forms.Padding(10);
            this.SelfReclamationLeft.Name = "SelfReclamationLeft";
            this.SelfReclamationLeft.Size = new System.Drawing.Size(74, 25);
            this.SelfReclamationLeft.TabIndex = 6;
            this.SelfReclamationLeft.Text = "Ранее";
            this.SelfReclamationLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelfReclamationLeft.UseSelectable = true;
            // 
            // SelfReclamationRight
            // 
            this.SelfReclamationRight.ActiveControl = null;
            this.SelfReclamationRight.Location = new System.Drawing.Point(91, 111);
            this.SelfReclamationRight.Margin = new System.Windows.Forms.Padding(10);
            this.SelfReclamationRight.Name = "SelfReclamationRight";
            this.SelfReclamationRight.Size = new System.Drawing.Size(74, 25);
            this.SelfReclamationRight.TabIndex = 7;
            this.SelfReclamationRight.Text = "Позднее";
            this.SelfReclamationRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelfReclamationRight.UseSelectable = true;
            // 
            // SelfReclamationStartSet
            // 
            this.SelfReclamationStartSet.Location = new System.Drawing.Point(10, 10);
            this.SelfReclamationStartSet.Margin = new System.Windows.Forms.Padding(10);
            this.SelfReclamationStartSet.MinimumSize = new System.Drawing.Size(4, 29);
            this.SelfReclamationStartSet.Name = "SelfReclamationStartSet";
            this.SelfReclamationStartSet.Size = new System.Drawing.Size(155, 29);
            this.SelfReclamationStartSet.TabIndex = 4;
            // 
            // SelfReclamationDateSet
            // 
            this.SelfReclamationDateSet.ActiveControl = null;
            this.SelfReclamationDateSet.Location = new System.Drawing.Point(10, 80);
            this.SelfReclamationDateSet.Margin = new System.Windows.Forms.Padding(10);
            this.SelfReclamationDateSet.Name = "SelfReclamationDateSet";
            this.SelfReclamationDateSet.Size = new System.Drawing.Size(155, 25);
            this.SelfReclamationDateSet.TabIndex = 5;
            this.SelfReclamationDateSet.Text = "Перейти";
            this.SelfReclamationDateSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelfReclamationDateSet.UseSelectable = true;
            // 
            // SelfReclamationEndSet
            // 
            this.SelfReclamationEndSet.Location = new System.Drawing.Point(10, 45);
            this.SelfReclamationEndSet.Margin = new System.Windows.Forms.Padding(10);
            this.SelfReclamationEndSet.MinimumSize = new System.Drawing.Size(4, 29);
            this.SelfReclamationEndSet.Name = "SelfReclamationEndSet";
            this.SelfReclamationEndSet.Size = new System.Drawing.Size(155, 29);
            this.SelfReclamationEndSet.TabIndex = 3;
            // 
            // SelfReclamationPlan
            // 
            this.SelfReclamationPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.SelfReclamationPlan.Columns = dataColumns16;
            this.SelfReclamationPlan.CurrentDate = new System.DateTime(2015, 2, 11, 12, 4, 48, 804);
            this.SelfReclamationPlan.DatesIntervalMode = WeekPlanner.WeekPlannerMode.Daily;
            this.SelfReclamationPlan.DayCount = 7;
            this.SelfReclamationPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelfReclamationPlan.GridBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.SelfReclamationPlan.GridCellHeight = 200;
            this.SelfReclamationPlan.GridTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SelfReclamationPlan.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.SelfReclamationPlan.HeaderColumnsFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SelfReclamationPlan.HeaderDatesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SelfReclamationPlan.HeaderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(234)))));
            this.SelfReclamationPlan.HeaderFillLeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.SelfReclamationPlan.HeaderStyleMode = WeekPlanner.HeaderStyle.Aqua;
            this.SelfReclamationPlan.IsAllowedDraggingBetweenRows = true;
            this.SelfReclamationPlan.IsAllowedStretchAndDrag = true;
            this.SelfReclamationPlan.IsAllowedTreeViewDrawing = true;
            this.SelfReclamationPlan.ItemHeight = 30;
            this.SelfReclamationPlan.ItemTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SelfReclamationPlan.LeftMargin = 250;
            this.SelfReclamationPlan.LeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.SelfReclamationPlan.Location = new System.Drawing.Point(0, 0);
            this.SelfReclamationPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelfReclamationPlan.Name = "SelfReclamationPlan";
            this.SelfReclamationPlan.Size = new System.Drawing.Size(1077, 300);
            this.SelfReclamationPlan.TabIndex = 0;
            // 
            // ReportTab
            // 
            this.ReportTab.BackColor = System.Drawing.Color.Transparent;
            this.ReportTab.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.Text = "Отчеты";
            this.ReportTab.ToolTipText = "neoTabPage1";
            // 
            // ContextProj
            // 
            this.ContextProj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProj,
            this.EditProj,
            this.DeleteProj});
            this.ContextProj.Name = "metroContextMenu1";
            this.ContextProj.Size = new System.Drawing.Size(154, 70);
            // 
            // AddProj
            // 
            this.AddProj.Image = ((System.Drawing.Image)(resources.GetObject("AddProj.Image")));
            this.AddProj.Name = "AddProj";
            this.AddProj.Size = new System.Drawing.Size(153, 22);
            this.AddProj.Text = "Добавить";
            // 
            // EditProj
            // 
            this.EditProj.Image = ((System.Drawing.Image)(resources.GetObject("EditProj.Image")));
            this.EditProj.Name = "EditProj";
            this.EditProj.Size = new System.Drawing.Size(153, 22);
            this.EditProj.Text = "Редактировать";
            // 
            // DeleteProj
            // 
            this.DeleteProj.Image = ((System.Drawing.Image)(resources.GetObject("DeleteProj.Image")));
            this.DeleteProj.Name = "DeleteProj";
            this.DeleteProj.Size = new System.Drawing.Size(153, 22);
            this.DeleteProj.Text = "Удалить";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 645);
            this.Controls.Add(this.neoTabWindow1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CamozziClient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow1)).EndInit();
            this.neoTabWindow1.ResumeLayout(false);
            this.FirstTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectStat)).EndInit();
            this.PlanTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow2)).EndInit();
            this.neoTabWindow2.ResumeLayout(false);
            this.AllProjectTab.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.AllReclamationTab.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.SelfTaskTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow3)).EndInit();
            this.neoTabWindow3.ResumeLayout(false);
            this.SelfProjectTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MetroTableProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetroChartProject)).EndInit();
            this.SelfReclamationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MetroTableReclamation)).EndInit();
            this.metroPanel4.ResumeLayout(false);
            this.ContextProj.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroComboBox themeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private NeoTabControlLibrary.NeoTabWindow neoTabWindow1;
        private NeoTabControlLibrary.NeoTabPage FirstTab;
        private NeoTabControlLibrary.NeoTabPage PlanTab;
        private NeoTabControlLibrary.NeoTabPage SelfTaskTab;
        private NeoTabControlLibrary.NeoTabPage ReportTab;
        private NeoTabControlLibrary.NeoTabWindow neoTabWindow2;
        private NeoTabControlLibrary.NeoTabPage AllProjectTab;
        private NeoTabControlLibrary.NeoTabPage AllReclamationTab;
        private NeoTabControlLibrary.NeoTabWindow neoTabWindow3;
        private NeoTabControlLibrary.NeoTabPage SelfProjectTab;
        private NeoTabControlLibrary.NeoTabPage SelfReclamationTab;
        private WeekPlanner.CalendarPlanner AllProjectPlan;
        private WeekPlanner.CalendarPlanner AllReclamationPlan;
        private WeekPlanner.CalendarPlanner SelfReclamationPlan;
        private MetroFramework.Controls.MetroTile AllProjectSetDate;
        private MetroFramework.Controls.MetroDateTime AllProjectStartTimeSet;
        private MetroFramework.Controls.MetroDateTime AllProjectsEndTimeSet;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile AllProjectLeft;
        private MetroFramework.Controls.MetroTile AllProjectRight;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile AllReclamationLeft;
        private MetroFramework.Controls.MetroTile AllReclamationRight;
        private MetroFramework.Controls.MetroDateTime AllReclamationStartSet;
        private MetroFramework.Controls.MetroTile AllReclamationDateSet;
        private MetroFramework.Controls.MetroDateTime AllReclamationEndSet;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTile SelfReclamationLeft;
        private MetroFramework.Controls.MetroTile SelfReclamationRight;
        private MetroFramework.Controls.MetroDateTime SelfReclamationStartSet;
        private MetroFramework.Controls.MetroTile SelfReclamationDateSet;
        private MetroFramework.Controls.MetroDateTime SelfReclamationEndSet;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProjectStat;
        private MetroFramework.Controls.MetroGrid MetroTableReclamation;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTile SelfProjectLeft;
        private MetroFramework.Controls.MetroTile SelfProjectRight;
        private MetroFramework.Controls.MetroDateTime SelfProjectStartSet;
        private MetroFramework.Controls.MetroTile SelfProjectSetDate;
        private MetroFramework.Controls.MetroDateTime SelfProjectEndSet;
        private WeekPlanner.CalendarPlanner SelfProjectPlan;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MetroFramework.Controls.MetroGrid MetroTableProject;
        private System.Windows.Forms.DataVisualization.Charting.Chart MetroChartProject;
        private MetroFramework.Controls.MetroContextMenu ContextProj;
        private System.Windows.Forms.ToolStripMenuItem AddProj;
        private System.Windows.Forms.ToolStripMenuItem EditProj;
        private System.Windows.Forms.ToolStripMenuItem DeleteProj;

    }
}

