namespace SensorDataLogger.Devices
{
    partial class PG350Page
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
            this.R200CmdBt = new System.Windows.Forms.Button();
            this.R201CmdBt = new System.Windows.Forms.Button();
            this.R202CmdBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // R200CmdBt
            // 
            this.R200CmdBt.Location = new System.Drawing.Point(12, 12);
            this.R200CmdBt.Name = "R200CmdBt";
            this.R200CmdBt.Size = new System.Drawing.Size(145, 57);
            this.R200CmdBt.TabIndex = 0;
            this.R200CmdBt.Text = "R200";
            this.R200CmdBt.UseVisualStyleBackColor = true;
            this.R200CmdBt.Click += new System.EventHandler(this.sendCmdBt_Click);
            // 
            // R201CmdBt
            // 
            this.R201CmdBt.Location = new System.Drawing.Point(163, 12);
            this.R201CmdBt.Name = "R201CmdBt";
            this.R201CmdBt.Size = new System.Drawing.Size(146, 57);
            this.R201CmdBt.TabIndex = 1;
            this.R201CmdBt.Text = "R201";
            this.R201CmdBt.UseVisualStyleBackColor = true;
            this.R201CmdBt.Click += new System.EventHandler(this.R201CmdBt_Click);
            // 
            // R202CmdBt
            // 
            this.R202CmdBt.Location = new System.Drawing.Point(316, 13);
            this.R202CmdBt.Name = "R202CmdBt";
            this.R202CmdBt.Size = new System.Drawing.Size(145, 56);
            this.R202CmdBt.TabIndex = 2;
            this.R202CmdBt.Text = "R202";
            this.R202CmdBt.UseVisualStyleBackColor = true;
            this.R202CmdBt.Click += new System.EventHandler(this.R202CmdBt_Click);
            // 
            // PG350Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 366);
            this.Controls.Add(this.R202CmdBt);
            this.Controls.Add(this.R201CmdBt);
            this.Controls.Add(this.R200CmdBt);
            this.Name = "PG350Page";
            this.Text = "PG350Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button R200CmdBt;
        private System.Windows.Forms.Button R201CmdBt;
        private System.Windows.Forms.Button R202CmdBt;
    }
}