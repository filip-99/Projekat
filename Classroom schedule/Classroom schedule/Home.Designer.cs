
namespace Classroom_schedule
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.buttonScheduling = new System.Windows.Forms.Button();
            this.buttonShowScheduling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonScheduling
            // 
            this.buttonScheduling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonScheduling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScheduling.ForeColor = System.Drawing.Color.Transparent;
            this.buttonScheduling.Location = new System.Drawing.Point(83, 70);
            this.buttonScheduling.Margin = new System.Windows.Forms.Padding(2);
            this.buttonScheduling.Name = "buttonScheduling";
            this.buttonScheduling.Size = new System.Drawing.Size(133, 44);
            this.buttonScheduling.TabIndex = 0;
            this.buttonScheduling.Text = "Scheduling";
            this.buttonScheduling.UseVisualStyleBackColor = false;
            this.buttonScheduling.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonShowScheduling
            // 
            this.buttonShowScheduling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowScheduling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowScheduling.ForeColor = System.Drawing.Color.Transparent;
            this.buttonShowScheduling.Location = new System.Drawing.Point(260, 70);
            this.buttonShowScheduling.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowScheduling.Name = "buttonShowScheduling";
            this.buttonShowScheduling.Size = new System.Drawing.Size(133, 44);
            this.buttonShowScheduling.TabIndex = 1;
            this.buttonShowScheduling.Text = "Show Schedule";
            this.buttonShowScheduling.UseVisualStyleBackColor = false;
            this.buttonShowScheduling.Click += new System.EventHandler(this.buttonShowScheduling_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(486, 209);
            this.Controls.Add(this.buttonShowScheduling);
            this.Controls.Add(this.buttonScheduling);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonScheduling;
        private System.Windows.Forms.Button buttonShowScheduling;
    }
}

