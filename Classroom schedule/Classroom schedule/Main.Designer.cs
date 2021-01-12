namespace Classroom_schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowSchedule = new System.Windows.Forms.Button();
            this.buttonScheduling = new System.Windows.Forms.Button();
            this.buttonShowP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonUpdateP = new System.Windows.Forms.Button();
            this.buttonInsertP = new System.Windows.Forms.Button();
            this.listBoxPeriods = new System.Windows.Forms.ListBox();
            this.listBoxClassrooms = new System.Windows.Forms.ListBox();
            this.CLASSROOMS = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonUpdateC = new System.Windows.Forms.Button();
            this.buttonInsertC = new System.Windows.Forms.Button();
            this.SCHEDULING = new System.Windows.Forms.GroupBox();
            this.textBoxDuty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOccupied = new System.Windows.Forms.TextBox();
            this.textBoxCNumber = new System.Windows.Forms.TextBox();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.buttonDeleteS = new System.Windows.Forms.Button();
            this.buttonInsertS = new System.Windows.Forms.Button();
            this.buttonUpdateS = new System.Windows.Forms.Button();
            this.buttonShowC = new System.Windows.Forms.Button();
            this.listBoxSchedule = new System.Windows.Forms.ListBox();
            this.buttonShowS = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CLASSROOMS.SuspendLayout();
            this.SCHEDULING.SuspendLayout();
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
            this.panel1.TabIndex = 1;
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
            // buttonShowP
            // 
            this.buttonShowP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowP.ForeColor = System.Drawing.Color.White;
            this.buttonShowP.Location = new System.Drawing.Point(15, 326);
            this.buttonShowP.Name = "buttonShowP";
            this.buttonShowP.Size = new System.Drawing.Size(134, 38);
            this.buttonShowP.TabIndex = 34;
            this.buttonShowP.Text = "Show periods";
            this.buttonShowP.UseVisualStyleBackColor = false;
            this.buttonShowP.Click += new System.EventHandler(this.buttonShowP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxEnd);
            this.groupBox2.Controls.Add(this.textBoxStart);
            this.groupBox2.Controls.Add(this.textBoxID);
            this.groupBox2.Controls.Add(this.buttonUpdateP);
            this.groupBox2.Controls.Add(this.buttonInsertP);
            this.groupBox2.Location = new System.Drawing.Point(283, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 212);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERIODS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "End time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Start time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "ID";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(105, 115);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd.TabIndex = 23;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(105, 89);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart.TabIndex = 22;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(105, 63);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 21;
            // 
            // buttonUpdateP
            // 
            this.buttonUpdateP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonUpdateP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateP.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateP.Location = new System.Drawing.Point(125, 19);
            this.buttonUpdateP.Name = "buttonUpdateP";
            this.buttonUpdateP.Size = new System.Drawing.Size(80, 28);
            this.buttonUpdateP.TabIndex = 19;
            this.buttonUpdateP.Text = "Update";
            this.buttonUpdateP.UseVisualStyleBackColor = false;
            this.buttonUpdateP.Click += new System.EventHandler(this.buttonUpdateP_Click);
            // 
            // buttonInsertP
            // 
            this.buttonInsertP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonInsertP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertP.ForeColor = System.Drawing.Color.White;
            this.buttonInsertP.Location = new System.Drawing.Point(37, 19);
            this.buttonInsertP.Name = "buttonInsertP";
            this.buttonInsertP.Size = new System.Drawing.Size(80, 28);
            this.buttonInsertP.TabIndex = 18;
            this.buttonInsertP.Text = "Insert";
            this.buttonInsertP.UseVisualStyleBackColor = false;
            this.buttonInsertP.Click += new System.EventHandler(this.buttonInsertP_Click);
            // 
            // listBoxPeriods
            // 
            this.listBoxPeriods.FormattingEnabled = true;
            this.listBoxPeriods.Location = new System.Drawing.Point(15, 370);
            this.listBoxPeriods.Name = "listBoxPeriods";
            this.listBoxPeriods.Size = new System.Drawing.Size(262, 212);
            this.listBoxPeriods.TabIndex = 32;
            this.listBoxPeriods.SelectedIndexChanged += new System.EventHandler(this.listBoxPeriods_SelectedIndexChanged);
            // 
            // listBoxClassrooms
            // 
            this.listBoxClassrooms.FormattingEnabled = true;
            this.listBoxClassrooms.Location = new System.Drawing.Point(635, 95);
            this.listBoxClassrooms.Name = "listBoxClassrooms";
            this.listBoxClassrooms.Size = new System.Drawing.Size(233, 212);
            this.listBoxClassrooms.TabIndex = 31;
            this.listBoxClassrooms.SelectedIndexChanged += new System.EventHandler(this.listBoxClassrooms_SelectedIndexChanged);
            // 
            // CLASSROOMS
            // 
            this.CLASSROOMS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CLASSROOMS.Controls.Add(this.label9);
            this.CLASSROOMS.Controls.Add(this.label8);
            this.CLASSROOMS.Controls.Add(this.textBoxCapacity);
            this.CLASSROOMS.Controls.Add(this.textBoxNumber);
            this.CLASSROOMS.Controls.Add(this.buttonUpdateC);
            this.CLASSROOMS.Controls.Add(this.buttonInsertC);
            this.CLASSROOMS.Location = new System.Drawing.Point(874, 95);
            this.CLASSROOMS.Name = "CLASSROOMS";
            this.CLASSROOMS.Size = new System.Drawing.Size(249, 212);
            this.CLASSROOMS.TabIndex = 30;
            this.CLASSROOMS.TabStop = false;
            this.CLASSROOMS.Text = "CLASSROOMS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Capacity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Number";
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(105, 86);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapacity.TabIndex = 22;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(105, 60);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 21;
            // 
            // buttonUpdateC
            // 
            this.buttonUpdateC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonUpdateC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateC.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateC.Location = new System.Drawing.Point(125, 19);
            this.buttonUpdateC.Name = "buttonUpdateC";
            this.buttonUpdateC.Size = new System.Drawing.Size(80, 28);
            this.buttonUpdateC.TabIndex = 19;
            this.buttonUpdateC.Text = "Update";
            this.buttonUpdateC.UseVisualStyleBackColor = false;
            this.buttonUpdateC.Click += new System.EventHandler(this.buttonUpdateC_Click);
            // 
            // buttonInsertC
            // 
            this.buttonInsertC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonInsertC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertC.ForeColor = System.Drawing.Color.White;
            this.buttonInsertC.Location = new System.Drawing.Point(39, 19);
            this.buttonInsertC.Name = "buttonInsertC";
            this.buttonInsertC.Size = new System.Drawing.Size(80, 28);
            this.buttonInsertC.TabIndex = 18;
            this.buttonInsertC.Text = "Insert";
            this.buttonInsertC.UseVisualStyleBackColor = false;
            this.buttonInsertC.Click += new System.EventHandler(this.buttonInsertC_Click);
            // 
            // SCHEDULING
            // 
            this.SCHEDULING.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SCHEDULING.Controls.Add(this.textBoxDuty);
            this.SCHEDULING.Controls.Add(this.label10);
            this.SCHEDULING.Controls.Add(this.textBoxOccupied);
            this.SCHEDULING.Controls.Add(this.textBoxCNumber);
            this.SCHEDULING.Controls.Add(this.textBoxPeriod);
            this.SCHEDULING.Controls.Add(this.label4);
            this.SCHEDULING.Controls.Add(this.label3);
            this.SCHEDULING.Controls.Add(this.label2);
            this.SCHEDULING.Controls.Add(this.label1);
            this.SCHEDULING.Controls.Add(this.textBoxDay);
            this.SCHEDULING.Controls.Add(this.buttonDeleteS);
            this.SCHEDULING.Controls.Add(this.buttonInsertS);
            this.SCHEDULING.Controls.Add(this.buttonUpdateS);
            this.SCHEDULING.Location = new System.Drawing.Point(355, 95);
            this.SCHEDULING.Name = "SCHEDULING";
            this.SCHEDULING.Size = new System.Drawing.Size(274, 212);
            this.SCHEDULING.TabIndex = 29;
            this.SCHEDULING.TabStop = false;
            this.SCHEDULING.Text = "SCHEDULING";
            // 
            // textBoxDuty
            // 
            this.textBoxDuty.Location = new System.Drawing.Point(125, 149);
            this.textBoxDuty.Name = "textBoxDuty";
            this.textBoxDuty.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuty.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Classroom number";
            // 
            // textBoxOccupied
            // 
            this.textBoxOccupied.Location = new System.Drawing.Point(125, 126);
            this.textBoxOccupied.Name = "textBoxOccupied";
            this.textBoxOccupied.Size = new System.Drawing.Size(100, 20);
            this.textBoxOccupied.TabIndex = 27;
            // 
            // textBoxCNumber
            // 
            this.textBoxCNumber.Location = new System.Drawing.Point(125, 103);
            this.textBoxCNumber.Name = "textBoxCNumber";
            this.textBoxCNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxCNumber.TabIndex = 26;
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(125, 80);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeriod.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Person on duty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Occupied";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Period";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Day";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(125, 57);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(100, 20);
            this.textBoxDay.TabIndex = 20;
            // 
            // buttonDeleteS
            // 
            this.buttonDeleteS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeleteS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteS.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteS.Location = new System.Drawing.Point(181, 19);
            this.buttonDeleteS.Name = "buttonDeleteS";
            this.buttonDeleteS.Size = new System.Drawing.Size(80, 28);
            this.buttonDeleteS.TabIndex = 19;
            this.buttonDeleteS.Text = "Delete";
            this.buttonDeleteS.UseVisualStyleBackColor = false;
            this.buttonDeleteS.Click += new System.EventHandler(this.buttonDeleteS_Click);
            // 
            // buttonInsertS
            // 
            this.buttonInsertS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonInsertS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertS.ForeColor = System.Drawing.Color.White;
            this.buttonInsertS.Location = new System.Drawing.Point(15, 19);
            this.buttonInsertS.Name = "buttonInsertS";
            this.buttonInsertS.Size = new System.Drawing.Size(80, 28);
            this.buttonInsertS.TabIndex = 17;
            this.buttonInsertS.Text = "Insert";
            this.buttonInsertS.UseVisualStyleBackColor = false;
            this.buttonInsertS.Click += new System.EventHandler(this.buttonInsertS_Click);
            // 
            // buttonUpdateS
            // 
            this.buttonUpdateS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonUpdateS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateS.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateS.Location = new System.Drawing.Point(98, 19);
            this.buttonUpdateS.Name = "buttonUpdateS";
            this.buttonUpdateS.Size = new System.Drawing.Size(80, 28);
            this.buttonUpdateS.TabIndex = 18;
            this.buttonUpdateS.Text = "Update";
            this.buttonUpdateS.UseVisualStyleBackColor = false;
            this.buttonUpdateS.Click += new System.EventHandler(this.buttonUpdateS_Click);
            // 
            // buttonShowC
            // 
            this.buttonShowC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowC.ForeColor = System.Drawing.Color.White;
            this.buttonShowC.Location = new System.Drawing.Point(635, 51);
            this.buttonShowC.Name = "buttonShowC";
            this.buttonShowC.Size = new System.Drawing.Size(134, 38);
            this.buttonShowC.TabIndex = 28;
            this.buttonShowC.Text = "Show classrooms";
            this.buttonShowC.UseVisualStyleBackColor = false;
            this.buttonShowC.Click += new System.EventHandler(this.buttonShowC_Click);
            // 
            // listBoxSchedule
            // 
            this.listBoxSchedule.FormattingEnabled = true;
            this.listBoxSchedule.Location = new System.Drawing.Point(15, 95);
            this.listBoxSchedule.Name = "listBoxSchedule";
            this.listBoxSchedule.Size = new System.Drawing.Size(334, 212);
            this.listBoxSchedule.TabIndex = 27;
            this.listBoxSchedule.SelectedIndexChanged += new System.EventHandler(this.listBoxSchedule_SelectedIndexChanged);
            // 
            // buttonShowS
            // 
            this.buttonShowS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowS.ForeColor = System.Drawing.Color.White;
            this.buttonShowS.Location = new System.Drawing.Point(15, 51);
            this.buttonShowS.Name = "buttonShowS";
            this.buttonShowS.Size = new System.Drawing.Size(134, 38);
            this.buttonShowS.TabIndex = 26;
            this.buttonShowS.Text = "Show schedule";
            this.buttonShowS.UseVisualStyleBackColor = false;
            this.buttonShowS.Click += new System.EventHandler(this.buttonShowS_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 608);
            this.Controls.Add(this.buttonShowP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxPeriods);
            this.Controls.Add(this.listBoxClassrooms);
            this.Controls.Add(this.CLASSROOMS);
            this.Controls.Add(this.SCHEDULING);
            this.Controls.Add(this.buttonShowC);
            this.Controls.Add(this.listBoxSchedule);
            this.Controls.Add(this.buttonShowS);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom scheduling";
            
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.CLASSROOMS.ResumeLayout(false);
            this.CLASSROOMS.PerformLayout();
            this.SCHEDULING.ResumeLayout(false);
            this.SCHEDULING.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowSchedule;
        private System.Windows.Forms.Button buttonScheduling;
        private System.Windows.Forms.Button buttonShowP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonUpdateP;
        private System.Windows.Forms.Button buttonInsertP;
        private System.Windows.Forms.ListBox listBoxPeriods;
        private System.Windows.Forms.ListBox listBoxClassrooms;
        private System.Windows.Forms.GroupBox CLASSROOMS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonUpdateC;
        private System.Windows.Forms.Button buttonInsertC;
        private System.Windows.Forms.GroupBox SCHEDULING;
        private System.Windows.Forms.TextBox textBoxDuty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxOccupied;
        private System.Windows.Forms.TextBox textBoxCNumber;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Button buttonDeleteS;
        private System.Windows.Forms.Button buttonInsertS;
        private System.Windows.Forms.Button buttonUpdateS;
        private System.Windows.Forms.Button buttonShowC;
        private System.Windows.Forms.ListBox listBoxSchedule;
        private System.Windows.Forms.Button buttonShowS;
    }
}