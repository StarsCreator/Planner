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
            WeekPlanner.DataColumns dataColumns2 = new WeekPlanner.DataColumns();
            WeekPlanner.DataColumns dataColumns3 = new WeekPlanner.DataColumns();
            WeekPlanner.DataColumns dataColumns4 = new WeekPlanner.DataColumns();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.themeBox = new MetroFramework.Controls.MetroComboBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neoTabWindow1 = new NeoTabControlLibrary.NeoTabWindow();
            this.FirstTab = new NeoTabControlLibrary.NeoTabPage();
            this.PlanTab = new NeoTabControlLibrary.NeoTabPage();
            this.neoTabWindow2 = new NeoTabControlLibrary.NeoTabWindow();
            this.AllProjectTab = new NeoTabControlLibrary.NeoTabPage();
            this.AllReclamationTab = new NeoTabControlLibrary.NeoTabPage();
            this.SelfTaskTab = new NeoTabControlLibrary.NeoTabPage();
            this.neoTabWindow3 = new NeoTabControlLibrary.NeoTabWindow();
            this.SelfProjectTab = new NeoTabControlLibrary.NeoTabPage();
            this.SelfReclamationTab = new NeoTabControlLibrary.NeoTabPage();
            this.ReportTab = new NeoTabControlLibrary.NeoTabPage();
            this.reclamationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AllProjectPlan = new WeekPlanner.CalendarPlanner();
            this.AllReclamationPlan = new WeekPlanner.CalendarPlanner();
            this.SelfProjectPlan = new WeekPlanner.CalendarPlanner();
            this.SelfReclamationPlan = new WeekPlanner.CalendarPlanner();
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow1)).BeginInit();
            this.neoTabWindow1.SuspendLayout();
            this.PlanTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow2)).BeginInit();
            this.neoTabWindow2.SuspendLayout();
            this.AllProjectTab.SuspendLayout();
            this.AllReclamationTab.SuspendLayout();
            this.SelfTaskTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow3)).BeginInit();
            this.neoTabWindow3.SuspendLayout();
            this.SelfProjectTab.SuspendLayout();
            this.SelfReclamationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reclamationsBindingSource)).BeginInit();
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
            this.neoTabWindow1.SelectedIndex = 2;
            this.neoTabWindow1.Size = new System.Drawing.Size(1036, 647);
            this.neoTabWindow1.TabIndex = 0;
            // 
            // FirstTab
            // 
            this.FirstTab.BackColor = System.Drawing.Color.Transparent;
            this.FirstTab.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FirstTab.Name = "FirstTab";
            this.FirstTab.Text = "Главная";
            this.FirstTab.ToolTipText = "neoTabPage4";
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
            this.neoTabWindow2.Size = new System.Drawing.Size(943, 641);
            this.neoTabWindow2.TabIndex = 0;
            // 
            // AllProjectTab
            // 
            this.AllProjectTab.Controls.Add(this.AllProjectPlan);
            this.AllProjectTab.Name = "AllProjectTab";
            this.AllProjectTab.Text = "Проекты";
            this.AllProjectTab.ToolTipText = "neoTabPage1";
            // 
            // AllReclamationTab
            // 
            this.AllReclamationTab.Controls.Add(this.AllReclamationPlan);
            this.AllReclamationTab.Name = "AllReclamationTab";
            this.AllReclamationTab.Text = "Рекламации";
            this.AllReclamationTab.ToolTipText = "neoTabPage2";
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
            this.neoTabWindow3.SelectedIndex = 1;
            this.neoTabWindow3.Size = new System.Drawing.Size(943, 641);
            this.neoTabWindow3.TabIndex = 0;
            // 
            // SelfProjectTab
            // 
            this.SelfProjectTab.BackColor = System.Drawing.Color.Transparent;
            this.SelfProjectTab.Controls.Add(this.SelfProjectPlan);
            this.SelfProjectTab.Name = "SelfProjectTab";
            this.SelfProjectTab.Text = "Проекты";
            this.SelfProjectTab.ToolTipText = "neoTabPage1";
            // 
            // SelfReclamationTab
            // 
            this.SelfReclamationTab.Controls.Add(this.SelfReclamationPlan);
            this.SelfReclamationTab.Name = "SelfReclamationTab";
            this.SelfReclamationTab.Text = "Рекламации";
            this.SelfReclamationTab.ToolTipText = "neoTabPage1";
            // 
            // ReportTab
            // 
            this.ReportTab.BackColor = System.Drawing.Color.Transparent;
            this.ReportTab.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.Text = "Отчеты";
            this.ReportTab.ToolTipText = "neoTabPage1";
            // 
            // AllProjectPlan
            // 
            this.AllProjectPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.AllProjectPlan.Columns = dataColumns1;
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
            this.AllProjectPlan.IsAllowedDraggingBetweenRows = true;
            this.AllProjectPlan.IsAllowedStretchAndDrag = true;
            this.AllProjectPlan.IsAllowedTreeViewDrawing = true;
            this.AllProjectPlan.ItemHeight = 30;
            this.AllProjectPlan.ItemTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllProjectPlan.LeftMargin = 250;
            this.AllProjectPlan.LeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.AllProjectPlan.Location = new System.Drawing.Point(0, 0);
            this.AllProjectPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllProjectPlan.Name = "AllProjectPlan";
            this.AllProjectPlan.Size = new System.Drawing.Size(857, 635);
            this.AllProjectPlan.TabIndex = 0;
            // 
            // AllReclamationPlan
            // 
            this.AllReclamationPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.AllReclamationPlan.Columns = dataColumns2;
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
            this.AllReclamationPlan.IsAllowedDraggingBetweenRows = true;
            this.AllReclamationPlan.IsAllowedStretchAndDrag = true;
            this.AllReclamationPlan.IsAllowedTreeViewDrawing = true;
            this.AllReclamationPlan.ItemHeight = 30;
            this.AllReclamationPlan.ItemTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AllReclamationPlan.LeftMargin = 250;
            this.AllReclamationPlan.LeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.AllReclamationPlan.Location = new System.Drawing.Point(0, 0);
            this.AllReclamationPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllReclamationPlan.Name = "AllReclamationPlan";
            this.AllReclamationPlan.Size = new System.Drawing.Size(857, 635);
            this.AllReclamationPlan.TabIndex = 0;
            // 
            // SelfProjectPlan
            // 
            this.SelfProjectPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.SelfProjectPlan.Columns = dataColumns3;
            this.SelfProjectPlan.CurrentDate = new System.DateTime(2015, 2, 11, 12, 4, 32, 321);
            this.SelfProjectPlan.DatesIntervalMode = WeekPlanner.WeekPlannerMode.Daily;
            this.SelfProjectPlan.DayCount = 7;
            this.SelfProjectPlan.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.SelfProjectPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelfProjectPlan.Name = "SelfProjectPlan";
            this.SelfProjectPlan.Size = new System.Drawing.Size(857, 300);
            this.SelfProjectPlan.TabIndex = 0;
            // 
            // SelfReclamationPlan
            // 
            this.SelfReclamationPlan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.SelfReclamationPlan.Columns = dataColumns4;
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
            this.SelfReclamationPlan.Size = new System.Drawing.Size(857, 300);
            this.SelfReclamationPlan.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 647);
            this.Controls.Add(this.neoTabWindow1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CamozziClient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow1)).EndInit();
            this.neoTabWindow1.ResumeLayout(false);
            this.PlanTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow2)).EndInit();
            this.neoTabWindow2.ResumeLayout(false);
            this.AllProjectTab.ResumeLayout(false);
            this.AllReclamationTab.ResumeLayout(false);
            this.SelfTaskTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow3)).EndInit();
            this.neoTabWindow3.ResumeLayout(false);
            this.SelfProjectTab.ResumeLayout(false);
            this.SelfReclamationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reclamationsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource reclamationsBindingSource;
        private NeoTabControlLibrary.NeoTabPage ReportTab;
        private NeoTabControlLibrary.NeoTabWindow neoTabWindow2;
        private NeoTabControlLibrary.NeoTabPage AllProjectTab;
        private NeoTabControlLibrary.NeoTabPage AllReclamationTab;
        private NeoTabControlLibrary.NeoTabWindow neoTabWindow3;
        private NeoTabControlLibrary.NeoTabPage SelfProjectTab;
        private NeoTabControlLibrary.NeoTabPage SelfReclamationTab;
        private WeekPlanner.CalendarPlanner AllProjectPlan;
        private WeekPlanner.CalendarPlanner AllReclamationPlan;
        private WeekPlanner.CalendarPlanner SelfProjectPlan;
        private WeekPlanner.CalendarPlanner SelfReclamationPlan;

    }
}

