namespace SensorDataLogger.Devices
{
    partial class PG300Page
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
            this.R200CmdBt = new System.Windows.Forms.Button();
            this.R201CmdBt = new System.Windows.Forms.Button();
            this.R202CmdBt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.recordStart = new System.Windows.Forms.Button();
            this.SendEmailBt = new System.Windows.Forms.Button();
            this.recordStop = new System.Windows.Forms.Button();
            this.setReadPeriod = new System.Windows.Forms.Button();
            this.lastSaveDate = new System.Windows.Forms.Label();
            this.lastReadDate = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pg300TimerIntervalTb = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.measuredValuesBox = new System.Windows.Forms.GroupBox();
            this.MeasuredValuesPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pg300Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.measuredValuesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // R200CmdBt
            // 
            this.R200CmdBt.Location = new System.Drawing.Point(964, 21);
            this.R200CmdBt.Name = "R200CmdBt";
            this.R200CmdBt.Size = new System.Drawing.Size(145, 36);
            this.R200CmdBt.TabIndex = 0;
            this.R200CmdBt.Text = "R200";
            this.R200CmdBt.UseVisualStyleBackColor = true;
            this.R200CmdBt.Click += new System.EventHandler(this.sendCmdBt_Click);
            // 
            // R201CmdBt
            // 
            this.R201CmdBt.Location = new System.Drawing.Point(1115, 21);
            this.R201CmdBt.Name = "R201CmdBt";
            this.R201CmdBt.Size = new System.Drawing.Size(146, 36);
            this.R201CmdBt.TabIndex = 1;
            this.R201CmdBt.Text = "R201";
            this.R201CmdBt.UseVisualStyleBackColor = true;
            this.R201CmdBt.Click += new System.EventHandler(this.R201CmdBt_Click);
            // 
            // R202CmdBt
            // 
            this.R202CmdBt.Location = new System.Drawing.Point(1267, 21);
            this.R202CmdBt.Name = "R202CmdBt";
            this.R202CmdBt.Size = new System.Drawing.Size(145, 36);
            this.R202CmdBt.TabIndex = 2;
            this.R202CmdBt.Text = "R202";
            this.R202CmdBt.UseVisualStyleBackColor = true;
            this.R202CmdBt.Click += new System.EventHandler(this.R202CmdBt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.recordStart);
            this.groupBox1.Controls.Add(this.SendEmailBt);
            this.groupBox1.Controls.Add(this.recordStop);
            this.groupBox1.Controls.Add(this.R200CmdBt);
            this.groupBox1.Controls.Add(this.setReadPeriod);
            this.groupBox1.Controls.Add(this.R202CmdBt);
            this.groupBox1.Controls.Add(this.lastSaveDate);
            this.groupBox1.Controls.Add(this.R201CmdBt);
            this.groupBox1.Controls.Add(this.lastReadDate);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.pg300TimerIntervalTb);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1500, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haberleşme Ayarları";
            // 
            // recordStart
            // 
            this.recordStart.Location = new System.Drawing.Point(589, 13);
            this.recordStart.Name = "recordStart";
            this.recordStart.Size = new System.Drawing.Size(132, 35);
            this.recordStart.TabIndex = 21;
            this.recordStart.Text = "Kayıt Başlat";
            this.recordStart.UseVisualStyleBackColor = true;
            this.recordStart.Click += new System.EventHandler(this.recordStart_Click);
            // 
            // SendEmailBt
            // 
            this.SendEmailBt.Location = new System.Drawing.Point(827, 21);
            this.SendEmailBt.Name = "SendEmailBt";
            this.SendEmailBt.Size = new System.Drawing.Size(106, 47);
            this.SendEmailBt.TabIndex = 3;
            this.SendEmailBt.Text = "Mail Gönder";
            this.SendEmailBt.UseVisualStyleBackColor = true;
            this.SendEmailBt.Click += new System.EventHandler(this.SendEmailBt_Click);
            // 
            // recordStop
            // 
            this.recordStop.Location = new System.Drawing.Point(589, 51);
            this.recordStop.Name = "recordStop";
            this.recordStop.Size = new System.Drawing.Size(132, 34);
            this.recordStop.TabIndex = 22;
            this.recordStop.Text = "Kayıt Durdur";
            this.recordStop.UseVisualStyleBackColor = true;
            this.recordStop.Click += new System.EventHandler(this.recordStop_Click);
            // 
            // setReadPeriod
            // 
            this.setReadPeriod.Location = new System.Drawing.Point(300, 27);
            this.setReadPeriod.Name = "setReadPeriod";
            this.setReadPeriod.Size = new System.Drawing.Size(85, 30);
            this.setReadPeriod.TabIndex = 20;
            this.setReadPeriod.Text = "Güncelle";
            this.setReadPeriod.UseVisualStyleBackColor = true;
            this.setReadPeriod.Click += new System.EventHandler(this.setReadPeriod_Click);
            // 
            // lastSaveDate
            // 
            this.lastSaveDate.AutoSize = true;
            this.lastSaveDate.Location = new System.Drawing.Point(418, 60);
            this.lastSaveDate.Name = "lastSaveDate";
            this.lastSaveDate.Size = new System.Drawing.Size(13, 17);
            this.lastSaveDate.TabIndex = 19;
            this.lastSaveDate.Text = "-";
            // 
            // lastReadDate
            // 
            this.lastReadDate.AutoSize = true;
            this.lastReadDate.Location = new System.Drawing.Point(157, 60);
            this.lastReadDate.Name = "lastReadDate";
            this.lastReadDate.Size = new System.Drawing.Size(13, 17);
            this.lastReadDate.TabIndex = 18;
            this.lastReadDate.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(219, 17);
            this.label21.TabIndex = 14;
            this.label21.Text = "Cihaz Okuma Periyodu ( saniye ) ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(267, 60);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(140, 17);
            this.label24.TabIndex = 17;
            this.label24.Text = "Son Kaydetme Tarihi";
            // 
            // pg300TimerIntervalTb
            // 
            this.pg300TimerIntervalTb.Location = new System.Drawing.Point(235, 29);
            this.pg300TimerIntervalTb.Name = "pg300TimerIntervalTb";
            this.pg300TimerIntervalTb.Size = new System.Drawing.Size(59, 22);
            this.pg300TimerIntervalTb.TabIndex = 15;
            this.pg300TimerIntervalTb.Text = "20";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 17);
            this.label22.TabIndex = 16;
            this.label22.Text = "Son Okunma Tarihi";
            // 
            // measuredValuesBox
            // 
            this.measuredValuesBox.Controls.Add(this.MeasuredValuesPanel);
            this.measuredValuesBox.Location = new System.Drawing.Point(13, 109);
            this.measuredValuesBox.Name = "measuredValuesBox";
            this.measuredValuesBox.Size = new System.Drawing.Size(1500, 607);
            this.measuredValuesBox.TabIndex = 4;
            this.measuredValuesBox.TabStop = false;
            this.measuredValuesBox.Text = "Ölçüm Değerleri";
            // 
            // MeasuredValuesPanel
            // 
            this.MeasuredValuesPanel.AutoScroll = true;
            this.MeasuredValuesPanel.Location = new System.Drawing.Point(7, 22);
            this.MeasuredValuesPanel.Name = "MeasuredValuesPanel";
            this.MeasuredValuesPanel.Size = new System.Drawing.Size(1487, 579);
            this.MeasuredValuesPanel.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 722);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1500, 311);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // pg300Timer
            // 
            this.pg300Timer.Tick += new System.EventHandler(this.pg300Timer_Tick);
            // 
            // PG300Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 1045);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.measuredValuesBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "PG300Page";
            this.Text = "PG300 Page";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.measuredValuesBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button R200CmdBt;
        private System.Windows.Forms.Button R201CmdBt;
        private System.Windows.Forms.Button R202CmdBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox measuredValuesBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel MeasuredValuesPanel;
        private System.Windows.Forms.Button SendEmailBt;
        private System.Windows.Forms.Timer pg300Timer;
        private System.Windows.Forms.Button recordStart;
        private System.Windows.Forms.Button recordStop;
        private System.Windows.Forms.Button setReadPeriod;
        private System.Windows.Forms.Label lastSaveDate;
        private System.Windows.Forms.Label lastReadDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox pg300TimerIntervalTb;
        private System.Windows.Forms.Label label22;
    }
}