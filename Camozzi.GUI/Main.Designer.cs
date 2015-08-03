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
            WeekPlanner.DataColumns dataColumns1 = new WeekPlanner.DataColumns();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            WeekPlanner.DataColumns dataColumns2 = new WeekPlanner.DataColumns();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.themeBox = new MetroFramework.Controls.MetroComboBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ContextProj = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.AddProj = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProj = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteProj = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lblWaitProj = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCompProj = new System.Windows.Forms.Label();
            this.lblWorkProj = new System.Windows.Forms.Label();
            this.lblStopProj = new System.Windows.Forms.Label();
            this.lblAllProj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.allTab = new System.Windows.Forms.TabPage();
            this.selfTab = new System.Windows.Forms.TabPage();
            this.SelfRecAndProj = new System.Windows.Forms.TabControl();
            this.SelfProjectTab = new System.Windows.Forms.TabPage();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.AddManagerNameCh = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HideAllEndProjectCh = new System.Windows.Forms.CheckBox();
            this.AddManagerNameChx = new System.Windows.Forms.CheckBox();
            this.AllProjectTab = new System.Windows.Forms.TabPage();
            this.AllProjectPlan = new WeekPlanner.CalendarPlanner();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.AllProjectsEndTimeSet = new MetroFramework.Controls.MetroDateTime();
            this.AllProjectSetDate = new MetroFramework.Controls.MetroTile();
            this.AllProjectStartTimeSet = new MetroFramework.Controls.MetroDateTime();
            this.AllProjectRight = new MetroFramework.Controls.MetroTile();
            this.AllProjectLeft = new MetroFramework.Controls.MetroTile();
            this.AllRecAndProj = new System.Windows.Forms.TabControl();
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
            this.ContextProj.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.SuspendLayout();
            this.allTab.SuspendLayout();
            this.selfTab.SuspendLayout();
            this.SelfRecAndProj.SuspendLayout();
            this.SelfProjectTab.SuspendLayout();
            this.AddManagerNameCh.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AllProjectTab.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.AllRecAndProj.SuspendLayout();
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
            this.SelfProjectStartSet.MinimumSize = new System.Drawing.Size(0, 29);
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
            this.SelfProjectEndSet.MinimumSize = new System.Drawing.Size(0, 29);
            this.SelfProjectEndSet.Name = "SelfProjectEndSet";
            this.SelfProjectEndSet.Size = new System.Drawing.Size(155, 29);
            this.SelfProjectEndSet.TabIndex = 3;
            // 
            // SelfProjectPlan
            // 
            this.SelfProjectPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.SelfProjectPlan.Columns = dataColumns1;
            this.SelfProjectPlan.ContextMenuStrip = this.ContextNewProj;
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
            this.SelfProjectPlan.IsAllowedDraggingBetweenRows = false;
            this.SelfProjectPlan.IsAllowedStretchAndDrag = false;
            this.SelfProjectPlan.IsAllowedTreeViewDrawing = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroTableProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MetroTableProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MetroTableProject.ContextMenuStrip = this.ContextNewProj;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MetroTableProject.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroTableProject.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            chartArea1.Name = "ChartArea1";
            this.MetroChartProject.ChartAreas.Add(chartArea1);
            this.MetroChartProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetroChartProject.Location = new System.Drawing.Point(0, 0);
            this.MetroChartProject.Name = "MetroChartProject";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.MetroChartProject.Series.Add(series1);
            this.MetroChartProject.Size = new System.Drawing.Size(565, 295);
            this.MetroChartProject.TabIndex = 19;
            this.MetroChartProject.Text = "chart1";
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
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.allTab);
            this.tabControl1.Controls.Add(this.selfTab);
            this.tabControl1.Controls.Add(this.reportTab);
            this.tabControl1.Controls.Add(this.AddManagerNameCh);
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
            // mainTab
            // 
            this.mainTab.Controls.Add(this.splitContainer1);
            this.mainTab.Location = new System.Drawing.Point(68, 4);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTab.Size = new System.Drawing.Size(1184, 637);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Главная";
            this.mainTab.UseVisualStyleBackColor = true;
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
            this.splitContainer3.Size = new System.Drawing.Size(1178, 315);
            this.splitContainer3.SplitterDistance = 392;
            this.splitContainer3.TabIndex = 0;
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
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Size = new System.Drawing.Size(1178, 312);
            this.splitContainer4.SplitterDistance = 392;
            this.splitContainer4.TabIndex = 0;
            // 
            // allTab
            // 
            this.allTab.Controls.Add(this.AllRecAndProj);
            this.allTab.Location = new System.Drawing.Point(68, 4);
            this.allTab.Name = "allTab";
            this.allTab.Padding = new System.Windows.Forms.Padding(3);
            this.allTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.allTab.Size = new System.Drawing.Size(1184, 637);
            this.allTab.TabIndex = 1;
            this.allTab.Text = "План";
            this.allTab.UseVisualStyleBackColor = true;
            // 
            // selfTab
            // 
            this.selfTab.Controls.Add(this.SelfRecAndProj);
            this.selfTab.Location = new System.Drawing.Point(68, 4);
            this.selfTab.Name = "selfTab";
            this.selfTab.Padding = new System.Windows.Forms.Padding(3);
            this.selfTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selfTab.Size = new System.Drawing.Size(1184, 637);
            this.selfTab.TabIndex = 2;
            this.selfTab.Text = "Задачи";
            this.selfTab.UseVisualStyleBackColor = true;
            // 
            // SelfRecAndProj
            // 
            this.SelfRecAndProj.Controls.Add(this.SelfProjectTab);
            this.SelfRecAndProj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelfRecAndProj.Location = new System.Drawing.Point(3, 3);
            this.SelfRecAndProj.Name = "SelfRecAndProj";
            this.SelfRecAndProj.SelectedIndex = 0;
            this.SelfRecAndProj.Size = new System.Drawing.Size(1178, 631);
            this.SelfRecAndProj.TabIndex = 0;
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
            // reportTab
            // 
            this.reportTab.Location = new System.Drawing.Point(68, 4);
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Windows.Forms.Padding(3);
            this.reportTab.Size = new System.Drawing.Size(1184, 637);
            this.reportTab.TabIndex = 3;
            this.reportTab.Text = "Отчеты";
            this.reportTab.UseVisualStyleBackColor = true;
            // 
            // AddManagerNameCh
            // 
            this.AddManagerNameCh.Controls.Add(this.groupBox1);
            this.AddManagerNameCh.Location = new System.Drawing.Point(68, 4);
            this.AddManagerNameCh.Name = "AddManagerNameCh";
            this.AddManagerNameCh.Size = new System.Drawing.Size(1184, 637);
            this.AddManagerNameCh.TabIndex = 4;
            this.AddManagerNameCh.Text = "Опции";
            this.AddManagerNameCh.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddManagerNameChx);
            this.groupBox1.Controls.Add(this.HideAllEndProjectCh);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отображение";
            // 
            // HideAllEndProjectCh
            // 
            this.HideAllEndProjectCh.AutoSize = true;
            this.HideAllEndProjectCh.Location = new System.Drawing.Point(7, 20);
            this.HideAllEndProjectCh.Name = "HideAllEndProjectCh";
            this.HideAllEndProjectCh.Size = new System.Drawing.Size(189, 17);
            this.HideAllEndProjectCh.TabIndex = 0;
            this.HideAllEndProjectCh.Text = "Скрывать выолненные проекты";
            this.HideAllEndProjectCh.UseVisualStyleBackColor = true;
            // 
            // AddManagerNameChx
            // 
            this.AddManagerNameChx.AutoSize = true;
            this.AddManagerNameChx.Location = new System.Drawing.Point(7, 43);
            this.AddManagerNameChx.Name = "AddManagerNameChx";
            this.AddManagerNameChx.Size = new System.Drawing.Size(272, 17);
            this.AddManagerNameChx.TabIndex = 1;
            this.AddManagerNameChx.Text = "Добавлять имя менеджера к названию проекта";
            this.AddManagerNameChx.UseVisualStyleBackColor = true;
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
            // AllProjectPlan
            // 
            this.AllProjectPlan.AutoScroll = true;
            this.AllProjectPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.AllProjectPlan.Columns = dataColumns2;
            this.AllProjectPlan.ContextMenuStrip = this.ContextNewProj;
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
            // AllProjectsEndTimeSet
            // 
            this.AllProjectsEndTimeSet.Location = new System.Drawing.Point(10, 45);
            this.AllProjectsEndTimeSet.Margin = new System.Windows.Forms.Padding(10);
            this.AllProjectsEndTimeSet.MinimumSize = new System.Drawing.Size(0, 29);
            this.AllProjectsEndTimeSet.Name = "AllProjectsEndTimeSet";
            this.AllProjectsEndTimeSet.Size = new System.Drawing.Size(155, 29);
            this.AllProjectsEndTimeSet.TabIndex = 3;
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
            // AllProjectStartTimeSet
            // 
            this.AllProjectStartTimeSet.Location = new System.Drawing.Point(10, 10);
            this.AllProjectStartTimeSet.Margin = new System.Windows.Forms.Padding(10);
            this.AllProjectStartTimeSet.MinimumSize = new System.Drawing.Size(0, 29);
            this.AllProjectStartTimeSet.Name = "AllProjectStartTimeSet";
            this.AllProjectStartTimeSet.Size = new System.Drawing.Size(155, 29);
            this.AllProjectStartTimeSet.TabIndex = 4;
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
            // AllRecAndProj
            // 
            this.AllRecAndProj.Controls.Add(this.AllProjectTab);
            this.AllRecAndProj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllRecAndProj.Location = new System.Drawing.Point(3, 3);
            this.AllRecAndProj.Name = "AllRecAndProj";
            this.AllRecAndProj.SelectedIndex = 0;
            this.AllRecAndProj.Size = new System.Drawing.Size(1178, 631);
            this.AllRecAndProj.TabIndex = 0;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
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
            this.ContextProj.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.allTab.ResumeLayout(false);
            this.selfTab.ResumeLayout(false);
            this.SelfRecAndProj.ResumeLayout(false);
            this.SelfProjectTab.ResumeLayout(false);
            this.AddManagerNameCh.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AllProjectTab.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.AllRecAndProj.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroComboBox themeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MetroFramework.Controls.MetroContextMenu ContextProj;
        private System.Windows.Forms.ToolStripMenuItem AddProj;
        private System.Windows.Forms.ToolStripMenuItem EditProj;
        private System.Windows.Forms.ToolStripMenuItem DeleteProj;
        private MetroFramework.Controls.MetroContextMenu ContextNewProj;
        private System.Windows.Forms.ToolStripMenuItem addNewProj;
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
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage allTab;
        private System.Windows.Forms.TabPage selfTab;
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.TabControl SelfRecAndProj;
        private System.Windows.Forms.TabPage SelfProjectTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
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
        private System.Windows.Forms.TabPage AddManagerNameCh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox AddManagerNameChx;
        private System.Windows.Forms.CheckBox HideAllEndProjectCh;
        private System.Windows.Forms.TabControl AllRecAndProj;
        private System.Windows.Forms.TabPage AllProjectTab;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile AllProjectLeft;
        private MetroFramework.Controls.MetroTile AllProjectRight;
        private MetroFramework.Controls.MetroDateTime AllProjectStartTimeSet;
        private MetroFramework.Controls.MetroTile AllProjectSetDate;
        private MetroFramework.Controls.MetroDateTime AllProjectsEndTimeSet;
        private WeekPlanner.CalendarPlanner AllProjectPlan;

    }
}

