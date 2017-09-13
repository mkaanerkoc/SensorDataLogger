namespace SensorDataLogger.Screens
{
    partial class OpeningScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpeningScreen));
            this.oldRecordBt = new System.Windows.Forms.Button();
            this.newRecordBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtParametreleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oldRecordBt
            // 
            this.oldRecordBt.Location = new System.Drawing.Point(190, 200);
            this.oldRecordBt.Name = "oldRecordBt";
            this.oldRecordBt.Size = new System.Drawing.Size(237, 68);
            this.oldRecordBt.TabIndex = 2;
            this.oldRecordBt.TabStop = false;
            this.oldRecordBt.Text = "Eski Kayıda Devam Et";
            this.oldRecordBt.UseVisualStyleBackColor = true;
            this.oldRecordBt.Click += new System.EventHandler(this.oldRecordBt_Click);
            // 
            // newRecordBt
            // 
            this.newRecordBt.Location = new System.Drawing.Point(190, 111);
            this.newRecordBt.Name = "newRecordBt";
            this.newRecordBt.Size = new System.Drawing.Size(237, 70);
            this.newRecordBt.TabIndex = 1;
            this.newRecordBt.TabStop = false;
            this.newRecordBt.Text = "Yeni Kayıt Başlat";
            this.newRecordBt.UseVisualStyleBackColor = true;
            this.newRecordBt.Click += new System.EventHandler(this.newRecordBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Argate Yazılım ® 2017";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtParametreleriToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // kayıtParametreleriToolStripMenuItem
            // 
            this.kayıtParametreleriToolStripMenuItem.Name = "kayıtParametreleriToolStripMenuItem";
            this.kayıtParametreleriToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.kayıtParametreleriToolStripMenuItem.Text = "Kayıt Parametreleri";
            this.kayıtParametreleriToolStripMenuItem.Click += new System.EventHandler(this.recordParameterSettingsClick);
            // 
            // OpeningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(634, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newRecordBt);
            this.Controls.Add(this.oldRecordBt);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "OpeningScreen";
            this.Text = "Horiba Kayıt Programı V.1.0.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oldRecordBt;
        private System.Windows.Forms.Button newRecordBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtParametreleriToolStripMenuItem;
    }
}