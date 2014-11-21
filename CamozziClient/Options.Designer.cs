namespace CamozziClient
{
    partial class Options
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
            WeekPlanner.DataColumns dataColumns1 = new WeekPlanner.DataColumns();
            this.calendarPlanner1 = new WeekPlanner.CalendarPlanner();
            this.SuspendLayout();
            // 
            // calendarPlanner1
            // 
            this.calendarPlanner1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.calendarPlanner1.Columns = dataColumns1;
            this.calendarPlanner1.CurrentDate = new System.DateTime(2014, 11, 19, 14, 21, 11, 656);
            this.calendarPlanner1.DatesIntervalMode = WeekPlanner.WeekPlannerMode.Daily;
            this.calendarPlanner1.DayCount = 7;
            this.calendarPlanner1.GridBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.calendarPlanner1.GridCellHeight = 200;
            this.calendarPlanner1.GridTextFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.calendarPlanner1.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.calendarPlanner1.HeaderColumnsFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.calendarPlanner1.HeaderDatesFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.calendarPlanner1.HeaderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(234)))));
            this.calendarPlanner1.HeaderFillLeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.calendarPlanner1.HeaderStyleMode = WeekPlanner.HeaderStyle.Aqua;
            this.calendarPlanner1.IsAllowedDraggingBetweenRows = true;
            this.calendarPlanner1.IsAllowedStretchAndDrag = true;
            this.calendarPlanner1.IsAllowedTreeViewDrawing = true;
            this.calendarPlanner1.ItemHeight = 20;
            this.calendarPlanner1.ItemTextFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.calendarPlanner1.LeftMargin = 250;
            this.calendarPlanner1.LeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.calendarPlanner1.Location = new System.Drawing.Point(202, 12);
            this.calendarPlanner1.Name = "calendarPlanner1";
            this.calendarPlanner1.Size = new System.Drawing.Size(666, 200);
            this.calendarPlanner1.TabIndex = 0;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 421);
            this.Controls.Add(this.calendarPlanner1);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private WeekPlanner.CalendarPlanner calendarPlanner1;
    }
}