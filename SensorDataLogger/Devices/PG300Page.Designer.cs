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
            this.deviceIPAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pg300Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.measuredValuesBox = new System.Windows.Forms.GroupBox();
            this.MeasuredValuesPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ndirCorrectionText = new System.Windows.Forms.Label();
            this.o2ControlTmp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.electronicCoolrTmp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.internalTmp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowRateTmp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.atmPrsText = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ndirControlTmp = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.claControlTmp = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.measuredValuesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // R200CmdBt
            // 
            this.R200CmdBt.Location = new System.Drawing.Point(900, 16);
            this.R200CmdBt.Name = "R200CmdBt";
            this.R200CmdBt.Size = new System.Drawing.Size(69, 36);
            this.R200CmdBt.TabIndex = 0;
            this.R200CmdBt.Text = "R200";
            this.R200CmdBt.UseVisualStyleBackColor = true;
            this.R200CmdBt.Click += new System.EventHandler(this.sendCmdBt_Click);
            // 
            // R201CmdBt
            // 
            this.R201CmdBt.Location = new System.Drawing.Point(975, 16);
            this.R201CmdBt.Name = "R201CmdBt";
            this.R201CmdBt.Size = new System.Drawing.Size(69, 36);
            this.R201CmdBt.TabIndex = 1;
            this.R201CmdBt.Text = "R201";
            this.R201CmdBt.UseVisualStyleBackColor = true;
            this.R201CmdBt.Click += new System.EventHandler(this.R201CmdBt_Click);
            // 
            // R202CmdBt
            // 
            this.R202CmdBt.Location = new System.Drawing.Point(900, 58);
            this.R202CmdBt.Name = "R202CmdBt";
            this.R202CmdBt.Size = new System.Drawing.Size(145, 36);
            this.R202CmdBt.TabIndex = 2;
            this.R202CmdBt.Text = "R202";
            this.R202CmdBt.UseVisualStyleBackColor = true;
            this.R202CmdBt.Click += new System.EventHandler(this.R202CmdBt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deviceIPAddr);
            this.groupBox1.Controls.Add(this.label1);
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
            this.groupBox1.Size = new System.Drawing.Size(1240, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haberleşme Ayarları";
            // 
            // deviceIPAddr
            // 
            this.deviceIPAddr.Location = new System.Drawing.Point(163, 66);
            this.deviceIPAddr.Name = "deviceIPAddr";
            this.deviceIPAddr.Size = new System.Drawing.Size(130, 22);
            this.deviceIPAddr.TabIndex = 24;
            this.deviceIPAddr.Text = "192.168.1.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cihaz IP Adresi";
            // 
            // recordStart
            // 
            this.recordStart.Location = new System.Drawing.Point(738, 20);
            this.recordStart.Name = "recordStart";
            this.recordStart.Size = new System.Drawing.Size(132, 35);
            this.recordStart.TabIndex = 21;
            this.recordStart.Text = "Kayıt Başlat";
            this.recordStart.UseVisualStyleBackColor = true;
            this.recordStart.Click += new System.EventHandler(this.recordStart_Click);
            // 
            // SendEmailBt
            // 
            this.SendEmailBt.Location = new System.Drawing.Point(1079, 15);
            this.SendEmailBt.Name = "SendEmailBt";
            this.SendEmailBt.Size = new System.Drawing.Size(106, 74);
            this.SendEmailBt.TabIndex = 3;
            this.SendEmailBt.Text = "Mail Gönder";
            this.SendEmailBt.UseVisualStyleBackColor = true;
            this.SendEmailBt.Click += new System.EventHandler(this.SendEmailBt_Click);
            // 
            // recordStop
            // 
            this.recordStop.Location = new System.Drawing.Point(738, 58);
            this.recordStop.Name = "recordStop";
            this.recordStop.Size = new System.Drawing.Size(132, 34);
            this.recordStop.TabIndex = 22;
            this.recordStop.Text = "Kayıt Durdur";
            this.recordStop.UseVisualStyleBackColor = true;
            this.recordStop.Click += new System.EventHandler(this.recordStop_Click);
            // 
            // setReadPeriod
            // 
            this.setReadPeriod.Location = new System.Drawing.Point(330, 22);
            this.setReadPeriod.Name = "setReadPeriod";
            this.setReadPeriod.Size = new System.Drawing.Size(85, 72);
            this.setReadPeriod.TabIndex = 20;
            this.setReadPeriod.Text = "Güncelle";
            this.setReadPeriod.UseVisualStyleBackColor = true;
            this.setReadPeriod.Click += new System.EventHandler(this.setReadPeriod_Click);
            // 
            // lastSaveDate
            // 
            this.lastSaveDate.AutoSize = true;
            this.lastSaveDate.Location = new System.Drawing.Point(596, 69);
            this.lastSaveDate.Name = "lastSaveDate";
            this.lastSaveDate.Size = new System.Drawing.Size(13, 17);
            this.lastSaveDate.TabIndex = 19;
            this.lastSaveDate.Text = "-";
            // 
            // lastReadDate
            // 
            this.lastReadDate.AutoSize = true;
            this.lastReadDate.Location = new System.Drawing.Point(587, 32);
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
            this.label24.Location = new System.Drawing.Point(445, 69);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(151, 17);
            this.label24.TabIndex = 17;
            this.label24.Text = "Son Kaydetme Zamanı";
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
            this.label22.Location = new System.Drawing.Point(445, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 17);
            this.label22.TabIndex = 16;
            this.label22.Text = "Son Okunma Zamanı";
            // 
            // pg300Timer
            // 
            this.pg300Timer.Tick += new System.EventHandler(this.pg300Timer_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.measuredValuesBox);
            this.panel1.Location = new System.Drawing.Point(2, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 1056);
            this.panel1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowRateTmp);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.atmPrsText);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.ndirControlTmp);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.claControlTmp);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.electronicCoolrTmp);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.internalTmp);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.o2ControlTmp);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ndirCorrectionText);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(10, 605);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1240, 442);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cihaz Değerleri";
            // 
            // measuredValuesBox
            // 
            this.measuredValuesBox.Controls.Add(this.MeasuredValuesPanel);
            this.measuredValuesBox.Location = new System.Drawing.Point(11, 1);
            this.measuredValuesBox.Name = "measuredValuesBox";
            this.measuredValuesBox.Size = new System.Drawing.Size(1240, 600);
            this.measuredValuesBox.TabIndex = 6;
            this.measuredValuesBox.TabStop = false;
            this.measuredValuesBox.Text = "Ölçüm Değerleri";
            // 
            // MeasuredValuesPanel
            // 
            this.MeasuredValuesPanel.AutoScroll = true;
            this.MeasuredValuesPanel.Location = new System.Drawing.Point(7, 22);
            this.MeasuredValuesPanel.Name = "MeasuredValuesPanel";
            this.MeasuredValuesPanel.Size = new System.Drawing.Size(1227, 569);
            this.MeasuredValuesPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "NDIR Correction Temperature ";
            // 
            // ndirCorrectionText
            // 
            this.ndirCorrectionText.AutoSize = true;
            this.ndirCorrectionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndirCorrectionText.Location = new System.Drawing.Point(445, 44);
            this.ndirCorrectionText.Name = "ndirCorrectionText";
            this.ndirCorrectionText.Size = new System.Drawing.Size(15, 20);
            this.ndirCorrectionText.TabIndex = 1;
            this.ndirCorrectionText.Text = "-";
            // 
            // o2ControlTmp
            // 
            this.o2ControlTmp.AutoSize = true;
            this.o2ControlTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o2ControlTmp.Location = new System.Drawing.Point(445, 78);
            this.o2ControlTmp.Name = "o2ControlTmp";
            this.o2ControlTmp.Size = new System.Drawing.Size(15, 20);
            this.o2ControlTmp.TabIndex = 3;
            this.o2ControlTmp.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "O2 Control Temperature";
            // 
            // electronicCoolrTmp
            // 
            this.electronicCoolrTmp.AutoSize = true;
            this.electronicCoolrTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electronicCoolrTmp.Location = new System.Drawing.Point(923, 78);
            this.electronicCoolrTmp.Name = "electronicCoolrTmp";
            this.electronicCoolrTmp.Size = new System.Drawing.Size(15, 20);
            this.electronicCoolrTmp.TabIndex = 7;
            this.electronicCoolrTmp.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(644, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Electronic Cooler Temperature";
            // 
            // internalTmp
            // 
            this.internalTmp.AutoSize = true;
            this.internalTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internalTmp.Location = new System.Drawing.Point(923, 44);
            this.internalTmp.Name = "internalTmp";
            this.internalTmp.Size = new System.Drawing.Size(15, 20);
            this.internalTmp.TabIndex = 5;
            this.internalTmp.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(644, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Internal Temperature";
            // 
            // flowRateTmp
            // 
            this.flowRateTmp.AutoSize = true;
            this.flowRateTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowRateTmp.Location = new System.Drawing.Point(923, 147);
            this.flowRateTmp.Name = "flowRateTmp";
            this.flowRateTmp.Size = new System.Drawing.Size(15, 20);
            this.flowRateTmp.TabIndex = 15;
            this.flowRateTmp.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(644, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Flow Rate Data ( L / min )";
            // 
            // atmPrsText
            // 
            this.atmPrsText.AutoSize = true;
            this.atmPrsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atmPrsText.Location = new System.Drawing.Point(923, 113);
            this.atmPrsText.Name = "atmPrsText";
            this.atmPrsText.Size = new System.Drawing.Size(15, 20);
            this.atmPrsText.TabIndex = 13;
            this.atmPrsText.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(644, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Atmospheric pressure ( hPa )";
            // 
            // ndirControlTmp
            // 
            this.ndirControlTmp.AutoSize = true;
            this.ndirControlTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndirControlTmp.Location = new System.Drawing.Point(445, 147);
            this.ndirControlTmp.Name = "ndirControlTmp";
            this.ndirControlTmp.Size = new System.Drawing.Size(15, 20);
            this.ndirControlTmp.TabIndex = 11;
            this.ndirControlTmp.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(194, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "NDIR Control Temperature ";
            // 
            // claControlTmp
            // 
            this.claControlTmp.AutoSize = true;
            this.claControlTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claControlTmp.Location = new System.Drawing.Point(445, 113);
            this.claControlTmp.Name = "claControlTmp";
            this.claControlTmp.Size = new System.Drawing.Size(15, 20);
            this.claControlTmp.TabIndex = 9;
            this.claControlTmp.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(203, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(201, 20);
            this.label17.TabIndex = 8;
            this.label17.Text = "CLA Control Temperature";
            // 
            // PG300Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 1178);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "PG300Page";
            this.Text = "Horiba PG300 Kayıt Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PG300Page_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.measuredValuesBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button R200CmdBt;
        private System.Windows.Forms.Button R201CmdBt;
        private System.Windows.Forms.Button R202CmdBt;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.TextBox deviceIPAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox measuredValuesBox;
        private System.Windows.Forms.Panel MeasuredValuesPanel;
        private System.Windows.Forms.Label flowRateTmp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label atmPrsText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ndirControlTmp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label claControlTmp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label electronicCoolrTmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label internalTmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label o2ControlTmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ndirCorrectionText;
        private System.Windows.Forms.Label label2;
    }
}