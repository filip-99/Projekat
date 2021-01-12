namespace Classroom_schedule
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowSchedule = new System.Windows.Forms.Button();
            this.buttonScheduling = new System.Windows.Forms.Button();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFreePeriods = new System.Windows.Forms.TextBox();
            this.textBoxCSchedule = new System.Windows.Forms.TextBox();
            this.listBoxHelp = new System.Windows.Forms.ListBox();
            this.buttonFromTo = new System.Windows.Forms.Button();
            this.buttonOnlyFree = new System.Windows.Forms.Button();
            this.buttonShowFreeClassrooms = new System.Windows.Forms.Button();
            this.buttonShowCSchedule = new System.Windows.Forms.Button();
            this.buttonShowS = new System.Windows.Forms.Button();
            this.listBoxSchedule = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.buttonShowSchedule);
            this.panel1.Controls.Add(this.buttonScheduling);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 45);
            this.panel1.TabIndex = 2;
            // 
            // buttonShowSchedule
            // 
            this.buttonShowSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowSchedule.ForeColor = System.Drawing.Color.White;
            this.buttonShowSchedule.Location = new System.Drawing.Point(143, 3);
            this.buttonShowSchedule.Name = "buttonShowSchedule";
            this.buttonShowSchedule.Size = new System.Drawing.Size(134, 38);
            this.buttonShowSchedule.TabIndex = 1;
            this.buttonShowSchedule.Text = "Show schedule";
            this.buttonShowSchedule.UseVisualStyleBackColor = false;
            this.buttonShowSchedule.Click += new System.EventHandler(this.buttonShowSchedule_Click);
            // 
            // buttonScheduling
            // 
            this.buttonScheduling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonScheduling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScheduling.ForeColor = System.Drawing.Color.White;
            this.buttonScheduling.Location = new System.Drawing.Point(3, 3);
            this.buttonScheduling.Name = "buttonScheduling";
            this.buttonScheduling.Size = new System.Drawing.Size(134, 38);
            this.buttonScheduling.TabIndex = 0;
            this.buttonScheduling.Text = "Scheduling";
            this.buttonScheduling.UseVisualStyleBackColor = false;
            this.buttonScheduling.Click += new System.EventHandler(this.buttonScheduling_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(966, 113);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(61, 20);
            this.textBoxFrom.TabIndex = 32;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(1045, 113);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(61, 20);
            this.textBoxTo.TabIndex = 31;
            // 
            // textBoxFreePeriods
            // 
            this.textBoxFreePeriods.Location = new System.Drawing.Point(788, 113);
            this.textBoxFreePeriods.Name = "textBoxFreePeriods";
            this.textBoxFreePeriods.Size = new System.Drawing.Size(140, 20);
            this.textBoxFreePeriods.TabIndex = 30;
            // 
            // textBoxCSchedule
            // 
            this.textBoxCSchedule.Location = new System.Drawing.Point(607, 113);
            this.textBoxCSchedule.Name = "textBoxCSchedule";
            this.textBoxCSchedule.Size = new System.Drawing.Size(140, 20);
            this.textBoxCSchedule.TabIndex = 29;
            // 
            // listBoxHelp
            // 
            this.listBoxHelp.FormattingEnabled = true;
            this.listBoxHelp.Location = new System.Drawing.Point(607, 157);
            this.listBoxHelp.Name = "listBoxHelp";
            this.listBoxHelp.Size = new System.Drawing.Size(499, 381);
            this.listBoxHelp.TabIndex = 28;
            // 
            // buttonFromTo
            // 
            this.buttonFromTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFromTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFromTo.ForeColor = System.Drawing.Color.White;
            this.buttonFromTo.Location = new System.Drawing.Point(966, 70);
            this.buttonFromTo.Name = "buttonFromTo";
            this.buttonFromTo.Size = new System.Drawing.Size(140, 37);
            this.buttonFromTo.TabIndex = 27;
            this.buttonFromTo.Text = "Show periods in range";
            this.buttonFromTo.UseVisualStyleBackColor = false;
            // 
            // buttonOnlyFree
            // 
            this.buttonOnlyFree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOnlyFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOnlyFree.ForeColor = System.Drawing.Color.White;
            this.buttonOnlyFree.Location = new System.Drawing.Point(267, 84);
            this.buttonOnlyFree.Name = "buttonOnlyFree";
            this.buttonOnlyFree.Size = new System.Drawing.Size(140, 37);
            this.buttonOnlyFree.TabIndex = 26;
            this.buttonOnlyFree.Text = "Show only free periods";
            this.buttonOnlyFree.UseVisualStyleBackColor = false;
            // 
            // buttonShowFreeClassrooms
            // 
            this.buttonShowFreeClassrooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowFreeClassrooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowFreeClassrooms.ForeColor = System.Drawing.Color.White;
            this.buttonShowFreeClassrooms.Location = new System.Drawing.Point(788, 70);
            this.buttonShowFreeClassrooms.Name = "buttonShowFreeClassrooms";
            this.buttonShowFreeClassrooms.Size = new System.Drawing.Size(140, 37);
            this.buttonShowFreeClassrooms.TabIndex = 25;
            this.buttonShowFreeClassrooms.Text = "Show free classroom periods";
            this.buttonShowFreeClassrooms.UseVisualStyleBackColor = false;
            // 
            // buttonShowCSchedule
            // 
            this.buttonShowCSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowCSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowCSchedule.ForeColor = System.Drawing.Color.White;
            this.buttonShowCSchedule.Location = new System.Drawing.Point(607, 70);
            this.buttonShowCSchedule.Name = "buttonShowCSchedule";
            this.buttonShowCSchedule.Size = new System.Drawing.Size(140, 37);
            this.buttonShowCSchedule.TabIndex = 24;
            this.buttonShowCSchedule.Text = "Show classroom schedule";
            this.buttonShowCSchedule.UseVisualStyleBackColor = false;
            // 
            // buttonShowS
            // 
            this.buttonShowS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowS.ForeColor = System.Drawing.Color.White;
            this.buttonShowS.Location = new System.Drawing.Point(121, 84);
            this.buttonShowS.Name = "buttonShowS";
            this.buttonShowS.Size = new System.Drawing.Size(140, 37);
            this.buttonShowS.TabIndex = 23;
            this.buttonShowS.Text = "Show schedule";
            this.buttonShowS.UseVisualStyleBackColor = false;
            this.buttonShowS.Click += new System.EventHandler(this.buttonShowS_Click);
            // 
            // listBoxSchedule
            // 
            this.listBoxSchedule.FormattingEnabled = true;
            this.listBoxSchedule.Location = new System.Drawing.Point(28, 144);
            this.listBoxSchedule.Name = "listBoxSchedule";
            this.listBoxSchedule.Size = new System.Drawing.Size(488, 394);
            this.listBoxSchedule.TabIndex = 22;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 608);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFreePeriods);
            this.Controls.Add(this.textBoxCSchedule);
            this.Controls.Add(this.listBoxHelp);
            this.Controls.Add(this.buttonFromTo);
            this.Controls.Add(this.buttonOnlyFree);
            this.Controls.Add(this.buttonShowFreeClassrooms);
            this.Controls.Add(this.buttonShowCSchedule);
            this.Controls.Add(this.buttonShowS);
            this.Controls.Add(this.listBoxSchedule);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowSchedule;
        private System.Windows.Forms.Button buttonScheduling;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFreePeriods;
        private System.Windows.Forms.TextBox textBoxCSchedule;
        private System.Windows.Forms.ListBox listBoxHelp;
        private System.Windows.Forms.Button buttonFromTo;
        private System.Windows.Forms.Button buttonOnlyFree;
        private System.Windows.Forms.Button buttonShowFreeClassrooms;
        private System.Windows.Forms.Button buttonShowCSchedule;
        private System.Windows.Forms.Button buttonShowS;
        private System.Windows.Forms.ListBox listBoxSchedule;
    }
}