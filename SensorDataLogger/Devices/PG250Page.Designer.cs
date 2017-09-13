namespace SensorDataLogger.Devices
{
    partial class PG250Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PG250Page));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.recordStart = new System.Windows.Forms.Button();
            this.SendEmailBt = new System.Windows.Forms.Button();
            this.recordStop = new System.Windows.Forms.Button();
            this.C01CmdBt = new System.Windows.Forms.Button();
            this.setReadPeriod = new System.Windows.Forms.Button();
            this.lastSaveDate = new System.Windows.Forms.Label();
            this.C23CmdBt = new System.Windows.Forms.Button();
            this.lastReadDate = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pg250TimerIntervalTb = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pg250Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ndirTempText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sampleFlowRateTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.measuredValuesBox = new System.Windows.Forms.GroupBox();
            this.MeasuredValuesPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.measuredValuesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.recordStart);
            this.groupBox1.Controls.Add(this.SendEmailBt);
            this.groupBox1.Controls.Add(this.recordStop);
            this.groupBox1.Controls.Add(this.C01CmdBt);
            this.groupBox1.Controls.Add(this.setReadPeriod);
            this.groupBox1.Controls.Add(this.lastSaveDate);
            this.groupBox1.Controls.Add(this.C23CmdBt);
            this.groupBox1.Controls.Add(this.lastReadDate);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.pg250TimerIntervalTb);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haberleşme Ayarları";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "COM Port : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // recordStart
            // 
            this.recordStart.Location = new System.Drawing.Point(776, 17);
            this.recordStart.Name = "recordStart";
            this.recordStart.Size = new System.Drawing.Size(132, 35);
            this.recordStart.TabIndex = 21;
            this.recordStart.Text = "Kayıt Başlat";
            this.recordStart.UseVisualStyleBackColor = true;
            this.recordStart.Click += new System.EventHandler(this.recordStart_Click);
            // 
            // SendEmailBt
            // 
            this.SendEmailBt.Location = new System.Drawing.Point(1129, 30);
            this.SendEmailBt.Name = "SendEmailBt";
            this.SendEmailBt.Size = new System.Drawing.Size(106, 47);
            this.SendEmailBt.TabIndex = 3;
            this.SendEmailBt.Text = "Mail Gönder";
            this.SendEmailBt.UseVisualStyleBackColor = true;
            this.SendEmailBt.Click += new System.EventHandler(this.SendEmailBt_Click);
            // 
            // recordStop
            // 
            this.recordStop.Location = new System.Drawing.Point(776, 55);
            this.recordStop.Name = "recordStop";
            this.recordStop.Size = new System.Drawing.Size(132, 34);
            this.recordStop.TabIndex = 22;
            this.recordStop.Text = "Kayıt Durdur";
            this.recordStop.UseVisualStyleBackColor = true;
            this.recordStop.Click += new System.EventHandler(this.recordStop_Click);
            // 
            // C01CmdBt
            // 
            this.C01CmdBt.Location = new System.Drawing.Point(952, 22);
            this.C01CmdBt.Name = "C01CmdBt";
            this.C01CmdBt.Size = new System.Drawing.Size(145, 33);
            this.C01CmdBt.TabIndex = 0;
            this.C01CmdBt.Text = "C01";
            this.C01CmdBt.UseVisualStyleBackColor = true;
            this.C01CmdBt.Visible = false;
            this.C01CmdBt.Click += new System.EventHandler(this.C01CmdBt_Click);
            // 
            // setReadPeriod
            // 
            this.setReadPeriod.Location = new System.Drawing.Point(309, 14);
            this.setReadPeriod.Name = "setReadPeriod";
            this.setReadPeriod.Size = new System.Drawing.Size(85, 73);
            this.setReadPeriod.TabIndex = 20;
            this.setReadPeriod.Text = "Güncelle";
            this.setReadPeriod.UseVisualStyleBackColor = true;
            this.setReadPeriod.Click += new System.EventHandler(this.setReadPeriod_Click);
            // 
            // lastSaveDate
            // 
            this.lastSaveDate.AutoSize = true;
            this.lastSaveDate.Location = new System.Drawing.Point(606, 34);
            this.lastSaveDate.Name = "lastSaveDate";
            this.lastSaveDate.Size = new System.Drawing.Size(13, 17);
            this.lastSaveDate.TabIndex = 19;
            this.lastSaveDate.Text = "-";
            // 
            // C23CmdBt
            // 
            this.C23CmdBt.Location = new System.Drawing.Point(952, 60);
            this.C23CmdBt.Name = "C23CmdBt";
            this.C23CmdBt.Size = new System.Drawing.Size(146, 29);
            this.C23CmdBt.TabIndex = 1;
            this.C23CmdBt.Text = "C23";
            this.C23CmdBt.UseVisualStyleBackColor = true;
            this.C23CmdBt.Visible = false;
            this.C23CmdBt.Click += new System.EventHandler(this.C23CmdBt_Click);
            // 
            // lastReadDate
            // 
            this.lastReadDate.AutoSize = true;
            this.lastReadDate.Location = new System.Drawing.Point(606, 72);
            this.lastReadDate.Name = "lastReadDate";
            this.lastReadDate.Size = new System.Drawing.Size(13, 17);
            this.lastReadDate.TabIndex = 18;
            this.lastReadDate.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(219, 17);
            this.label21.TabIndex = 14;
            this.label21.Text = "Cihaz Okuma Periyodu ( saniye ) ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(441, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(151, 17);
            this.label24.TabIndex = 17;
            this.label24.Text = "Son Kaydetme Zamanı";
            // 
            // pg250TimerIntervalTb
            // 
            this.pg250TimerIntervalTb.Location = new System.Drawing.Point(235, 27);
            this.pg250TimerIntervalTb.Name = "pg250TimerIntervalTb";
            this.pg250TimerIntervalTb.Size = new System.Drawing.Size(59, 22);
            this.pg250TimerIntervalTb.TabIndex = 15;
            this.pg250TimerIntervalTb.Text = "20";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(451, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 17);
            this.label22.TabIndex = 16;
            this.label22.Text = "Son Okunma Zamanı";
            // 
            // pg250Timer
            // 
            this.pg250Timer.Tick += new System.EventHandler(this.pg250Timer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ndirTempText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.sampleFlowRateTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(10, 804);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1240, 114);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cihaz Değerleri";
            // 
            // ndirTempText
            // 
            this.ndirTempText.AutoSize = true;
            this.ndirTempText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndirTempText.Location = new System.Drawing.Point(629, 66);
            this.ndirTempText.Name = "ndirTempText";
            this.ndirTempText.Size = new System.Drawing.Size(15, 20);
            this.ndirTempText.TabIndex = 5;
            this.ndirTempText.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "NDIR Temperature ";
            // 
            // sampleFlowRateTxt
            // 
            this.sampleFlowRateTxt.AutoSize = true;
            this.sampleFlowRateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleFlowRateTxt.Location = new System.Drawing.Point(628, 39);
            this.sampleFlowRateTxt.Name = "sampleFlowRateTxt";
            this.sampleFlowRateTxt.Size = new System.Drawing.Size(15, 20);
            this.sampleFlowRateTxt.TabIndex = 3;
            this.sampleFlowRateTxt.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sample Flow Rate ";
            // 
            // measuredValuesBox
            // 
            this.measuredValuesBox.Controls.Add(this.MeasuredValuesPanel);
            this.measuredValuesBox.Location = new System.Drawing.Point(10, 118);
            this.measuredValuesBox.Name = "measuredValuesBox";
            this.measuredValuesBox.Size = new System.Drawing.Size(1240, 680);
            this.measuredValuesBox.TabIndex = 26;
            this.measuredValuesBox.TabStop = false;
            this.measuredValuesBox.Text = "Ölçüm Değerleri";
            // 
            // MeasuredValuesPanel
            // 
            this.MeasuredValuesPanel.AutoScroll = true;
            this.MeasuredValuesPanel.Location = new System.Drawing.Point(7, 22);
            this.MeasuredValuesPanel.Name = "MeasuredValuesPanel";
            this.MeasuredValuesPanel.Size = new System.Drawing.Size(1225, 652);
            this.MeasuredValuesPanel.TabIndex = 0;
            // 
            // PG250Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 1178);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.measuredValuesBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PG250Page";
            this.Text = "Horiba PG250 Kayıt Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PG250Page_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.measuredValuesBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button recordStart;
        private System.Windows.Forms.Button SendEmailBt;
        private System.Windows.Forms.Button recordStop;
        private System.Windows.Forms.Button C01CmdBt;
        private System.Windows.Forms.Button setReadPeriod;
        private System.Windows.Forms.Label lastSaveDate;
        private System.Windows.Forms.Button C23CmdBt;
        private System.Windows.Forms.Label lastReadDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox pg250TimerIntervalTb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Timer pg250Timer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ndirTempText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sampleFlowRateTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox measuredValuesBox;
        private System.Windows.Forms.Panel MeasuredValuesPanel;
    }
}