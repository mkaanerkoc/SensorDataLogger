namespace SensorDataLogger
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deviceBrand = new System.Windows.Forms.Label();
            this.deviceModel = new System.Windows.Forms.Label();
            this.deviceProtocol = new System.Windows.Forms.Label();
            this.devicePhysicalLayer = new System.Windows.Forms.Label();
            this.deviceCommands = new System.Windows.Forms.Label();
            this.deviceParams = new System.Windows.Forms.Label();
            this.deviceCommandsBox = new System.Windows.Forms.ComboBox();
            this.deviceParamsBox = new System.Windows.Forms.ComboBox();
            this.connectDeviceBt = new System.Windows.Forms.Button();
            this.deviceSettingsBt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deviceParamsBox);
            this.groupBox2.Controls.Add(this.deviceCommandsBox);
            this.groupBox2.Controls.Add(this.deviceParams);
            this.groupBox2.Controls.Add(this.deviceCommands);
            this.groupBox2.Controls.Add(this.devicePhysicalLayer);
            this.groupBox2.Controls.Add(this.deviceProtocol);
            this.groupBox2.Controls.Add(this.deviceModel);
            this.groupBox2.Controls.Add(this.deviceBrand);
            this.groupBox2.Location = new System.Drawing.Point(400, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Properties";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(340, 180);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // deviceBrand
            // 
            this.deviceBrand.AutoSize = true;
            this.deviceBrand.Location = new System.Drawing.Point(18, 35);
            this.deviceBrand.Name = "deviceBrand";
            this.deviceBrand.Size = new System.Drawing.Size(46, 17);
            this.deviceBrand.TabIndex = 0;
            this.deviceBrand.Text = "Brand";
            // 
            // deviceModel
            // 
            this.deviceModel.AutoSize = true;
            this.deviceModel.Location = new System.Drawing.Point(18, 64);
            this.deviceModel.Name = "deviceModel";
            this.deviceModel.Size = new System.Drawing.Size(50, 17);
            this.deviceModel.TabIndex = 1;
            this.deviceModel.Text = "Model ";
            // 
            // deviceProtocol
            // 
            this.deviceProtocol.AutoSize = true;
            this.deviceProtocol.Location = new System.Drawing.Point(18, 94);
            this.deviceProtocol.Name = "deviceProtocol";
            this.deviceProtocol.Size = new System.Drawing.Size(60, 17);
            this.deviceProtocol.TabIndex = 2;
            this.deviceProtocol.Text = "Protocol";
            // 
            // devicePhysicalLayer
            // 
            this.devicePhysicalLayer.AutoSize = true;
            this.devicePhysicalLayer.Location = new System.Drawing.Point(18, 129);
            this.devicePhysicalLayer.Name = "devicePhysicalLayer";
            this.devicePhysicalLayer.Size = new System.Drawing.Size(100, 17);
            this.devicePhysicalLayer.TabIndex = 3;
            this.devicePhysicalLayer.Text = "Physical Layer";
            // 
            // deviceCommands
            // 
            this.deviceCommands.AutoSize = true;
            this.deviceCommands.Location = new System.Drawing.Point(18, 163);
            this.deviceCommands.Name = "deviceCommands";
            this.deviceCommands.Size = new System.Drawing.Size(101, 17);
            this.deviceCommands.TabIndex = 4;
            this.deviceCommands.Text = "Command List ";
            // 
            // deviceParams
            // 
            this.deviceParams.AutoSize = true;
            this.deviceParams.Location = new System.Drawing.Point(18, 201);
            this.deviceParams.Name = "deviceParams";
            this.deviceParams.Size = new System.Drawing.Size(100, 17);
            this.deviceParams.TabIndex = 5;
            this.deviceParams.Text = "Parameter List";
            // 
            // deviceCommandsBox
            // 
            this.deviceCommandsBox.FormattingEnabled = true;
            this.deviceCommandsBox.Location = new System.Drawing.Point(182, 160);
            this.deviceCommandsBox.Name = "deviceCommandsBox";
            this.deviceCommandsBox.Size = new System.Drawing.Size(158, 24);
            this.deviceCommandsBox.TabIndex = 6;
            // 
            // deviceParamsBox
            // 
            this.deviceParamsBox.FormattingEnabled = true;
            this.deviceParamsBox.Location = new System.Drawing.Point(182, 198);
            this.deviceParamsBox.Name = "deviceParamsBox";
            this.deviceParamsBox.Size = new System.Drawing.Size(158, 24);
            this.deviceParamsBox.TabIndex = 7;
            // 
            // connectDeviceBt
            // 
            this.connectDeviceBt.Location = new System.Drawing.Point(23, 280);
            this.connectDeviceBt.Name = "connectDeviceBt";
            this.connectDeviceBt.Size = new System.Drawing.Size(170, 52);
            this.connectDeviceBt.TabIndex = 2;
            this.connectDeviceBt.Text = "Connect Device";
            this.connectDeviceBt.UseVisualStyleBackColor = true;
            this.connectDeviceBt.Click += new System.EventHandler(this.connectDeviceBt_Click);
            // 
            // deviceSettingsBt
            // 
            this.deviceSettingsBt.Location = new System.Drawing.Point(199, 280);
            this.deviceSettingsBt.Name = "deviceSettingsBt";
            this.deviceSettingsBt.Size = new System.Drawing.Size(170, 52);
            this.deviceSettingsBt.TabIndex = 3;
            this.deviceSettingsBt.Text = "Device Settings";
            this.deviceSettingsBt.UseVisualStyleBackColor = true;
            this.deviceSettingsBt.Click += new System.EventHandler(this.deviceSettingsBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 357);
            this.Controls.Add(this.deviceSettingsBt);
            this.Controls.Add(this.connectDeviceBt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label devicePhysicalLayer;
        private System.Windows.Forms.Label deviceProtocol;
        private System.Windows.Forms.Label deviceModel;
        private System.Windows.Forms.Label deviceBrand;
        private System.Windows.Forms.ComboBox deviceParamsBox;
        private System.Windows.Forms.ComboBox deviceCommandsBox;
        private System.Windows.Forms.Label deviceParams;
        private System.Windows.Forms.Label deviceCommands;
        private System.Windows.Forms.Button connectDeviceBt;
        private System.Windows.Forms.Button deviceSettingsBt;
        private System.Windows.Forms.Timer timer1;
    }
}

