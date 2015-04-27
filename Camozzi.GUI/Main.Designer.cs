using System.Security.AccessControl;

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
            WeekPlanner.DataColumns dataColumns5 = new WeekPlanner.DataColumns();
            WeekPlanner.DataColumns dataColumns6 = new WeekPlanner.DataColumns();
            WeekPlanner.DataColumns dataColumns7 = new WeekPlanner.DataColumns();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            WeekPlanner.DataColumns dataColumns8 = new WeekPlanner.DataColumns();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.themeBox = new MetroFramework.Controls.MetroComboBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllProjectPlan = new WeekPlanner.CalendarPlanner();
            this.AllReclamationPlan = new WeekPlanner.CalendarPlanner();
            this.proj = new System.Windows.Forms.SplitContainer();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.SelfProjectLeft = new MetroFramework.Controls.MetroTile();
            this.SelfProjectRight = new MetroFramework.Controls.MetroTile();
            this.SelfProjectStartSet = new MetroFramework.Controls.MetroDateTime();
            this.SelfProjectSetDate = new MetroFramework.Controls.MetroTile();
            this.SelfProjectEndSet = new MetroFramework.Controls.MetroDateTime();
            this.SelfProjectPlan = new WeekPlanner.CalendarPlanner();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.MetroTableProject = new MetroFramework.Controls.MetroGrid();
            this.ContextNewProj = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addNewProj = new System.Windows.Forms.ToolStripMenuItem();
            this.MetroChartProject = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reclams = new System.Windows.Forms.SplitContainer();
            this.SelfReclamationPlan = new WeekPlanner.CalendarPlanner();
            this.MetroTableReclamation = new MetroFramework.Controls.MetroGrid();
            this.ContextNewRec = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addNewRec = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextProj = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.AddProj = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProj = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteProj = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextRec = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addRec = new System.Windows.Forms.ToolStripMenuItem();
            this.editRec = new System.Windows.Forms.ToolStripMenuItem();
            this.delRec = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AllRecAndProj = new System.Windows.Forms.TabControl();
            this.AllProjectTab = new System.Windows.Forms.TabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.AllProjectLeft = new MetroFramework.Controls.MetroTile();
            this.AllProjectRight = new MetroFramework.Controls.MetroTile();
            this.AllProjectStartTimeSet = new MetroFramework.Controls.MetroDateTime();
            this.AllProjectSetDate = new MetroFramework.Controls.MetroTile();
            this.AllProjectsEndTimeSet = new MetroFramework.Controls.MetroDateTime();
            this.AllReclamationTab = new System.Windows.Forms.TabPage();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.AllReclamationLeft = new MetroFramework.Controls.MetroTile();
            this.AllReclamationRight = new MetroFramework.Controls.MetroTile();
            this.AllReclamationStartSet = new MetroFramework.Controls.MetroDateTime();
            this.AllReclamationDateSet = new MetroFramework.Controls.MetroTile();
            this.AllReclamationEndSet = new MetroFramework.Controls.MetroDateTime();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.SelfProjectTab = new System.Windows.Forms.TabPage();
            this.SelfReclamationTab = new System.Windows.Forms.TabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SelfReclamationLeft = new MetroFramework.Controls.MetroTile();
            this.SelfReclamationRight = new MetroFramework.Controls.MetroTile();
            this.SelfReclamationStartSet = new MetroFramework.Controls.MetroDateTime();
            this.SelfReclamationDateSet = new MetroFramework.Controls.MetroTile();
            this.SelfReclamationEndSet = new MetroFramework.Controls.MetroDateTime();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.mainProjChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.mainRecChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAllProj = new System.Windows.Forms.Label();
            this.lblStopProj = new System.Windows.Forms.Label();
            this.lblWorkProj = new System.Windows.Forms.Label();
            this.lblCompProj = new System.Windows.Forms.Label();
            this.lblWaitProj = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proj)).BeginInit();
            this.proj.Panel1.SuspendLayout();
            this.proj.Panel2.SuspendLayout();
            this.proj.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroTableProject)).BeginInit();
            this.ContextNewProj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroChartProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclams)).BeginInit();
            this.reclams.Panel1.SuspendLayout();
            this.reclams.Panel2.SuspendLayout();
            this.reclams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroTableReclamation)).BeginInit();
            this.ContextNewRec.SuspendLayout();
            this.ContextProj.SuspendLayout();
            this.ContextRec.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.AllRecAndProj.SuspendLayout();
            this.AllProjectTab.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.AllReclamationTab.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.SelfProjectTab.SuspendLayout();
            this.SelfReclamationTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainProjChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainRecChart)).BeginInit();
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
            // AllProjectPlan
            // 
            this.AllProjectPlan.AutoScroll = true;
            this.AllProjectPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.AllProjectPlan.Columns = dataColumns5;
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
            this.AllProjectPlan.IsAllowedStretchAndDrag = false;
            this.AllProjectPlan.IsAllowedTreeViewDrawing = false;
            this.AllProjectPlan.ItemHeight = 30;
            this.AllProjectPlan.ItemTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllProjectPlan.LeftMargin = 250;
            this.AllProjectPlan.LeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.AllProjectPlan.Location = new System.Drawing.Point(3, 3);
            this.AllProjectPlan.Name = "AllProjectPlan";
            this.AllProjectPlan.Size = new System.Drawing.Size(1164, 599);
            this.AllProjectPlan.TabIndex = 0;
            // 
            // AllReclamationPlan
            // 
            this.AllReclamationPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.AllReclamationPlan.Columns = dataColumns6;
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
            this.AllReclamationPlan.Location = new System.Drawing.Point(3, 3);
            this.AllReclamationPlan.Name = "AllReclamationPlan";
            this.AllReclamationPlan.Size = new System.Drawing.Size(1164, 599);
            this.AllReclamationPlan.TabIndex = 0;
            // 
            // proj
            // 
            this.proj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proj.Location = new System.Drawing.Point(3, 3);
            this.proj.Name = "proj";
            this.proj.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // proj.Panel1
            // 
            this.proj.Panel1.Controls.Add(this.metroPanel3);
            this.proj.Panel1.Controls.Add(this.SelfProjectPlan);
            this.proj.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.proj.Panel1MinSize = 300;
            // 
            // proj.Panel2
            // 
            this.proj.Panel2.Controls.Add(this.splitContainer2);
            this.proj.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.proj.Size = new System.Drawing.Size(1164, 599);
            this.proj.SplitterDistance = 300;
            this.proj.TabIndex = 0;
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
            this.metroPanel3.Location = new System.Drawing.Point(956, 90);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(176, 148);
            this.metroPanel3.Style = MetroFramework.MetroColorStyle.Black;
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
            this.SelfProjectLeft.Style = MetroFramework.MetroColorStyle.Silver;
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
            this.SelfProjectRight.Style = MetroFramework.MetroColorStyle.Silver;
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
            this.SelfProjectSetDate.Style = MetroFramework.MetroColorStyle.Silver;
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
            this.SelfProjectPlan.Columns = dataColumns7;
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
            this.SelfProjectPlan.Size = new System.Drawing.Size(1164, 300);
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
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.MetroChartProject);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(1164, 295);
            this.splitContainer2.SplitterDistance = 595;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroTableProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.MetroTableProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MetroTableProject.ContextMenuStrip = this.ContextNewProj;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MetroTableProject.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroTableProject.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.MetroTableProject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MetroTableProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MetroTableProject.Size = new System.Drawing.Size(595, 295);
            this.MetroTableProject.Style = MetroFramework.MetroColorStyle.Silver;
            this.MetroTableProject.TabIndex = 18;
            // 
            // ContextNewProj
            // 
            this.ContextNewProj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProj});
            this.ContextNewProj.Name = "metroContextMenu1";
            this.ContextNewProj.Size = new System.Drawing.Size(125, 26);
            // 
            // addNewProj
            // 
            this.addNewProj.Image = ((System.Drawing.Image)(resources.GetObject("addNewProj.Image")));
            this.addNewProj.Name = "addNewProj";
            this.addNewProj.Size = new System.Drawing.Size(124, 22);
            this.addNewProj.Text = "Добавить";
            // 
            // MetroChartProject
            // 
            chartArea4.Name = "ChartArea1";
            this.MetroChartProject.ChartAreas.Add(chartArea4);
            this.MetroChartProject.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.MetroChartProject.Legends.Add(legend4);
            this.MetroChartProject.Location = new System.Drawing.Point(0, 0);
            this.MetroChartProject.Name = "MetroChartProject";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.YValuesPerPoint = 4;
            this.MetroChartProject.Series.Add(series6);
            this.MetroChartProject.Size = new System.Drawing.Size(565, 295);
            this.MetroChartProject.TabIndex = 19;
            this.MetroChartProject.Text = "chart1";
            // 
            // reclams
            // 
            this.reclams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reclams.Location = new System.Drawing.Point(3, 3);
            this.reclams.Name = "reclams";
            this.reclams.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // reclams.Panel1
            // 
            this.reclams.Panel1.Controls.Add(this.SelfReclamationPlan);
            this.reclams.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // reclams.Panel2
            // 
            this.reclams.Panel2.Controls.Add(this.MetroTableReclamation);
            this.reclams.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reclams.Size = new System.Drawing.Size(1164, 599);
            this.reclams.SplitterDistance = 288;
            this.reclams.TabIndex = 13;
            // 
            // SelfReclamationPlan
            // 
            this.SelfReclamationPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.SelfReclamationPlan.Columns = dataColumns8;
            this.SelfReclamationPlan.CurrentDate = new System.DateTime(2015, 2, 11, 12, 4, 48, 804);
            this.SelfReclamationPlan.DatesIntervalMode = WeekPlanner.WeekPlannerMode.Daily;
            this.SelfReclamationPlan.DayCount = 7;
            this.SelfReclamationPlan.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.SelfReclamationPlan.Name = "SelfReclamationPlan";
            this.SelfReclamationPlan.Size = new System.Drawing.Size(1164, 288);
            this.SelfReclamationPlan.TabIndex = 0;
            // 
            // MetroTableReclamation
            // 
            this.MetroTableReclamation.AllowUserToAddRows = false;
            this.MetroTableReclamation.AllowUserToDeleteRows = false;
            this.MetroTableReclamation.AllowUserToResizeRows = false;
            this.MetroTableReclamation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MetroTableReclamation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroTableReclamation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MetroTableReclamation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MetroTableReclamation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroTableReclamation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MetroTableReclamation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MetroTableReclamation.ContextMenuStrip = this.ContextNewRec;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MetroTableReclamation.DefaultCellStyle = dataGridViewCellStyle2;
            this.MetroTableReclamation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetroTableReclamation.EnableHeadersVisualStyles = false;
            this.MetroTableReclamation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MetroTableReclamation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroTableReclamation.Location = new System.Drawing.Point(0, 0);
            this.MetroTableReclamation.MultiSelect = false;
            this.MetroTableReclamation.Name = "MetroTableReclamation";
            this.MetroTableReclamation.ReadOnly = true;
            this.MetroTableReclamation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroTableReclamation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MetroTableReclamation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MetroTableReclamation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MetroTableReclamation.Size = new System.Drawing.Size(1164, 307);
            this.MetroTableReclamation.Style = MetroFramework.MetroColorStyle.Silver;
            this.MetroTableReclamation.TabIndex = 12;
            // 
            // ContextNewRec
            // 
            this.ContextNewRec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRec});
            this.ContextNewRec.Name = "metroContextMenu1";
            this.ContextNewRec.Size = new System.Drawing.Size(125, 26);
            // 
            // addNewRec
            // 
            this.addNewRec.Image = ((System.Drawing.Image)(resources.GetObject("addNewRec.Image")));
            this.addNewRec.Name = "addNewRec";
            this.addNewRec.Size = new System.Drawing.Size(124, 22);
            this.addNewRec.Text = "Добавить";
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
            // ContextRec
            // 
            this.ContextRec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRec,
            this.editRec,
            this.delRec});
            this.ContextRec.Name = "metroContextMenu1";
            this.ContextRec.Size = new System.Drawing.Size(154, 70);
            // 
            // addRec
            // 
            this.addRec.Image = ((System.Drawing.Image)(resources.GetObject("addRec.Image")));
            this.addRec.Name = "addRec";
            this.addRec.Size = new System.Drawing.Size(153, 22);
            this.addRec.Text = "Добавить";
            // 
            // editRec
            // 
            this.editRec.Image = ((System.Drawing.Image)(resources.GetObject("editRec.Image")));
            this.editRec.Name = "editRec";
            this.editRec.Size = new System.Drawing.Size(153, 22);
            this.editRec.Text = "Редактировать";
            // 
            // delRec
            // 
            this.delRec.Image = ((System.Drawing.Image)(resources.GetObject("delRec.Image")));
            this.delRec.Name = "delRec";
            this.delRec.Size = new System.Drawing.Size(153, 22);
            this.delRec.Text = "Удалить";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 64);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1256, 645);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(68, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1184, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AllRecAndProj);
            this.tabPage2.Location = new System.Drawing.Point(68, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(1184, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "План";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AllRecAndProj
            // 
            this.AllRecAndProj.Controls.Add(this.AllProjectTab);
            this.AllRecAndProj.Controls.Add(this.AllReclamationTab);
            this.AllRecAndProj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllRecAndProj.Location = new System.Drawing.Point(3, 3);
            this.AllRecAndProj.Name = "AllRecAndProj";
            this.AllRecAndProj.SelectedIndex = 0;
            this.AllRecAndProj.Size = new System.Drawing.Size(1178, 631);
            this.AllRecAndProj.TabIndex = 0;
            // 
            // AllProjectTab
            // 
            this.AllProjectTab.Controls.Add(this.metroPanel2);
            this.AllProjectTab.Controls.Add(this.AllProjectPlan);
            this.AllProjectTab.Location = new System.Drawing.Point(4, 22);
            this.AllProjectTab.Name = "AllProjectTab";
            this.AllProjectTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllProjectTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllProjectTab.Size = new System.Drawing.Size(1170, 605);
            this.AllProjectTab.TabIndex = 0;
            this.AllProjectTab.Text = "Проекты";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.AllProjectLeft);
            this.metroPanel2.Controls.Add(this.AllProjectRight);
            this.metroPanel2.Controls.Add(this.AllProjectStartTimeSet);
            this.metroPanel2.Controls.Add(this.AllProjectSetDate);
            this.metroPanel2.Controls.Add(this.AllProjectsEndTimeSet);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(956, 90);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(176, 148);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel2.TabIndex = 20;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
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
            this.AllProjectStartTimeSet.MinimumSize = new System.Drawing.Size(4, 29);
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
            this.AllProjectsEndTimeSet.MinimumSize = new System.Drawing.Size(4, 29);
            this.AllProjectsEndTimeSet.Name = "AllProjectsEndTimeSet";
            this.AllProjectsEndTimeSet.Size = new System.Drawing.Size(155, 29);
            this.AllProjectsEndTimeSet.TabIndex = 3;
            // 
            // AllReclamationTab
            // 
            this.AllReclamationTab.Controls.Add(this.metroPanel4);
            this.AllReclamationTab.Controls.Add(this.AllReclamationPlan);
            this.AllReclamationTab.Location = new System.Drawing.Point(4, 22);
            this.AllReclamationTab.Name = "AllReclamationTab";
            this.AllReclamationTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllReclamationTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllReclamationTab.Size = new System.Drawing.Size(1170, 605);
            this.AllReclamationTab.TabIndex = 1;
            this.AllReclamationTab.Text = "Рекламации";
            this.AllReclamationTab.UseVisualStyleBackColor = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel4.Controls.Add(this.AllReclamationLeft);
            this.metroPanel4.Controls.Add(this.AllReclamationRight);
            this.metroPanel4.Controls.Add(this.AllReclamationStartSet);
            this.metroPanel4.Controls.Add(this.AllReclamationDateSet);
            this.metroPanel4.Controls.Add(this.AllReclamationEndSet);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(956, 90);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(176, 148);
            this.metroPanel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel4.TabIndex = 20;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // AllReclamationLeft
            // 
            this.AllReclamationLeft.ActiveControl = null;
            this.AllReclamationLeft.Location = new System.Drawing.Point(10, 111);
            this.AllReclamationLeft.Margin = new System.Windows.Forms.Padding(10);
            this.AllReclamationLeft.Name = "AllReclamationLeft";
            this.AllReclamationLeft.Size = new System.Drawing.Size(74, 25);
            this.AllReclamationLeft.Style = MetroFramework.MetroColorStyle.Silver;
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
            this.AllReclamationRight.Style = MetroFramework.MetroColorStyle.Silver;
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
            this.AllReclamationDateSet.Style = MetroFramework.MetroColorStyle.Silver;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl3);
            this.tabPage3.Location = new System.Drawing.Point(68, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage3.Size = new System.Drawing.Size(1184, 637);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Задачи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.SelfProjectTab);
            this.tabControl3.Controls.Add(this.SelfReclamationTab);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1178, 631);
            this.tabControl3.TabIndex = 0;
            // 
            // SelfProjectTab
            // 
            this.SelfProjectTab.Controls.Add(this.proj);
            this.SelfProjectTab.Location = new System.Drawing.Point(4, 22);
            this.SelfProjectTab.Name = "SelfProjectTab";
            this.SelfProjectTab.Padding = new System.Windows.Forms.Padding(3);
            this.SelfProjectTab.Size = new System.Drawing.Size(1170, 605);
            this.SelfProjectTab.TabIndex = 0;
            this.SelfProjectTab.Text = "Проекты";
            this.SelfProjectTab.UseVisualStyleBackColor = true;
            // 
            // SelfReclamationTab
            // 
            this.SelfReclamationTab.Controls.Add(this.metroPanel1);
            this.SelfReclamationTab.Controls.Add(this.reclams);
            this.SelfReclamationTab.Location = new System.Drawing.Point(4, 22);
            this.SelfReclamationTab.Name = "SelfReclamationTab";
            this.SelfReclamationTab.Padding = new System.Windows.Forms.Padding(3);
            this.SelfReclamationTab.Size = new System.Drawing.Size(1170, 605);
            this.SelfReclamationTab.TabIndex = 1;
            this.SelfReclamationTab.Text = "Рекламации";
            this.SelfReclamationTab.UseVisualStyleBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.SelfReclamationLeft);
            this.metroPanel1.Controls.Add(this.SelfReclamationRight);
            this.metroPanel1.Controls.Add(this.SelfReclamationStartSet);
            this.metroPanel1.Controls.Add(this.SelfReclamationDateSet);
            this.metroPanel1.Controls.Add(this.SelfReclamationEndSet);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(956, 90);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(176, 148);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel1.TabIndex = 19;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // SelfReclamationLeft
            // 
            this.SelfReclamationLeft.ActiveControl = null;
            this.SelfReclamationLeft.Location = new System.Drawing.Point(10, 111);
            this.SelfReclamationLeft.Margin = new System.Windows.Forms.Padding(10);
            this.SelfReclamationLeft.Name = "SelfReclamationLeft";
            this.SelfReclamationLeft.Size = new System.Drawing.Size(74, 25);
            this.SelfReclamationLeft.Style = MetroFramework.MetroColorStyle.Silver;
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
            this.SelfReclamationRight.Style = MetroFramework.MetroColorStyle.Silver;
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
            this.SelfReclamationDateSet.Style = MetroFramework.MetroColorStyle.Silver;
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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(68, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1184, 637);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Отчеты";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // mainProjChart
            // 
            chartArea5.Name = "ChartArea1";
            this.mainProjChart.ChartAreas.Add(chartArea5);
            this.mainProjChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.mainProjChart.Legends.Add(legend5);
            this.mainProjChart.Location = new System.Drawing.Point(0, 0);
            this.mainProjChart.Name = "mainProjChart";
            series7.BorderWidth = 5;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.LabelBorderWidth = 3;
            series7.Legend = "Legend1";
            series7.MarkerBorderWidth = 3;
            series7.Name = "Series1";
            series8.BorderWidth = 5;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.mainProjChart.Series.Add(series7);
            this.mainProjChart.Series.Add(series8);
            this.mainProjChart.Size = new System.Drawing.Size(782, 315);
            this.mainProjChart.TabIndex = 0;
            this.mainProjChart.Text = "chart1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(1178, 631);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lblWaitProj);
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            this.splitContainer3.Panel1.Controls.Add(this.lblCompProj);
            this.splitContainer3.Panel1.Controls.Add(this.lblWorkProj);
            this.splitContainer3.Panel1.Controls.Add(this.lblStopProj);
            this.splitContainer3.Panel1.Controls.Add(this.lblAllProj);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.mainProjChart);
            this.splitContainer3.Size = new System.Drawing.Size(1178, 315);
            this.splitContainer3.SplitterDistance = 392;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.mainRecChart);
            this.splitContainer4.Size = new System.Drawing.Size(1178, 312);
            this.splitContainer4.SplitterDistance = 392;
            this.splitContainer4.TabIndex = 0;
            // 
            // mainRecChart
            // 
            chartArea6.Name = "ChartArea1";
            this.mainRecChart.ChartAreas.Add(chartArea6);
            this.mainRecChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.mainRecChart.Legends.Add(legend6);
            this.mainRecChart.Location = new System.Drawing.Point(0, 0);
            this.mainRecChart.Name = "mainRecChart";
            series9.BorderWidth = 5;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.LabelBorderWidth = 3;
            series9.Legend = "Legend1";
            series9.MarkerBorderWidth = 3;
            series9.Name = "Series1";
            series10.BorderWidth = 5;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Series2";
            this.mainRecChart.Series.Add(series9);
            this.mainRecChart.Series.Add(series10);
            this.mainRecChart.Size = new System.Drawing.Size(782, 312);
            this.mainRecChart.TabIndex = 1;
            this.mainRecChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общее количество проектов в базе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "из них закончены";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "в работе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(68, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "приостановлены";
            // 
            // lblAllProj
            // 
            this.lblAllProj.AutoSize = true;
            this.lblAllProj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllProj.Location = new System.Drawing.Point(267, 20);
            this.lblAllProj.Name = "lblAllProj";
            this.lblAllProj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAllProj.Size = new System.Drawing.Size(29, 17);
            this.lblAllProj.TabIndex = 4;
            this.lblAllProj.Text = "123";
            // 
            // lblStopProj
            // 
            this.lblStopProj.AutoSize = true;
            this.lblStopProj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStopProj.Location = new System.Drawing.Point(267, 88);
            this.lblStopProj.Name = "lblStopProj";
            this.lblStopProj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStopProj.Size = new System.Drawing.Size(29, 17);
            this.lblStopProj.TabIndex = 5;
            this.lblStopProj.Text = "123";
            // 
            // lblWorkProj
            // 
            this.lblWorkProj.AutoSize = true;
            this.lblWorkProj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkProj.Location = new System.Drawing.Point(267, 54);
            this.lblWorkProj.Name = "lblWorkProj";
            this.lblWorkProj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWorkProj.Size = new System.Drawing.Size(29, 17);
            this.lblWorkProj.TabIndex = 6;
            this.lblWorkProj.Text = "123";
            // 
            // lblCompProj
            // 
            this.lblCompProj.AutoSize = true;
            this.lblCompProj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompProj.Location = new System.Drawing.Point(267, 37);
            this.lblCompProj.Name = "lblCompProj";
            this.lblCompProj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCompProj.Size = new System.Drawing.Size(29, 17);
            this.lblCompProj.TabIndex = 7;
            this.lblCompProj.Text = "123";
            // 
            // lblWaitProj
            // 
            this.lblWaitProj.AutoSize = true;
            this.lblWaitProj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWaitProj.Location = new System.Drawing.Point(267, 71);
            this.lblWaitProj.Name = "lblWaitProj";
            this.lblWaitProj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWaitProj.Size = new System.Drawing.Size(29, 17);
            this.lblWaitProj.TabIndex = 9;
            this.lblWaitProj.Text = "123";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(68, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "в ожидании";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 645);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CamozziClient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.proj.Panel1.ResumeLayout(false);
            this.proj.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proj)).EndInit();
            this.proj.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MetroTableProject)).EndInit();
            this.ContextNewProj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MetroChartProject)).EndInit();
            this.reclams.Panel1.ResumeLayout(false);
            this.reclams.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reclams)).EndInit();
            this.reclams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MetroTableReclamation)).EndInit();
            this.ContextNewRec.ResumeLayout(false);
            this.ContextProj.ResumeLayout(false);
            this.ContextRec.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.AllRecAndProj.ResumeLayout(false);
            this.AllProjectTab.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.AllReclamationTab.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.SelfProjectTab.ResumeLayout(false);
            this.SelfReclamationTab.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainProjChart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainRecChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroComboBox themeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private WeekPlanner.CalendarPlanner AllProjectPlan;
        private WeekPlanner.CalendarPlanner AllReclamationPlan;
        private WeekPlanner.CalendarPlanner SelfReclamationPlan;
        private MetroFramework.Controls.MetroGrid MetroTableReclamation;
        private MetroFramework.Controls.MetroContextMenu ContextProj;
        private System.Windows.Forms.ToolStripMenuItem AddProj;
        private System.Windows.Forms.ToolStripMenuItem EditProj;
        private System.Windows.Forms.ToolStripMenuItem DeleteProj;
        private MetroFramework.Controls.MetroContextMenu ContextNewProj;
        private System.Windows.Forms.ToolStripMenuItem addNewProj;
        private MetroFramework.Controls.MetroContextMenu ContextRec;
        private System.Windows.Forms.ToolStripMenuItem addRec;
        private System.Windows.Forms.ToolStripMenuItem editRec;
        private System.Windows.Forms.ToolStripMenuItem delRec;
        private MetroFramework.Controls.MetroContextMenu ContextNewRec;
        private System.Windows.Forms.ToolStripMenuItem addNewRec;
        private System.Windows.Forms.SplitContainer reclams;
        private System.Windows.Forms.SplitContainer proj;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl AllRecAndProj;
        private System.Windows.Forms.TabPage AllProjectTab;
        private System.Windows.Forms.TabPage AllReclamationTab;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage SelfProjectTab;
        private System.Windows.Forms.TabPage SelfReclamationTab;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile SelfReclamationLeft;
        private MetroFramework.Controls.MetroTile SelfReclamationRight;
        private MetroFramework.Controls.MetroDateTime SelfReclamationStartSet;
        private MetroFramework.Controls.MetroTile SelfReclamationDateSet;
        private MetroFramework.Controls.MetroDateTime SelfReclamationEndSet;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile AllProjectLeft;
        private MetroFramework.Controls.MetroTile AllProjectRight;
        private MetroFramework.Controls.MetroDateTime AllProjectStartTimeSet;
        private MetroFramework.Controls.MetroTile AllProjectSetDate;
        private MetroFramework.Controls.MetroDateTime AllProjectsEndTimeSet;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTile AllReclamationLeft;
        private MetroFramework.Controls.MetroTile AllReclamationRight;
        private MetroFramework.Controls.MetroDateTime AllReclamationStartSet;
        private MetroFramework.Controls.MetroTile AllReclamationDateSet;
        private MetroFramework.Controls.MetroDateTime AllReclamationEndSet;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainProjChart;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainRecChart;
        private System.Windows.Forms.Label lblCompProj;
        private System.Windows.Forms.Label lblWorkProj;
        private System.Windows.Forms.Label lblStopProj;
        private System.Windows.Forms.Label lblAllProj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWaitProj;
        private System.Windows.Forms.Label label6;

    }
}

