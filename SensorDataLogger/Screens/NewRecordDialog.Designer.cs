namespace SensorDataLogger.Screens
{
    partial class NewRecordDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRecordDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startRecordBt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browseNewFile = new System.Windows.Forms.Button();
            this.shaftSelectionCb = new System.Windows.Forms.ComboBox();
            this.factorySelectionCb = new System.Windows.Forms.ComboBox();
            this.operatorSelectionCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tarihSaatGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operatör İsim/Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tesis İsmi ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PG250",
            "PG350"});
            this.comboBox1.Location = new System.Drawing.Point(224, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cihaz Türü";
            // 
            // startRecordBt
            // 
            this.startRecordBt.Location = new System.Drawing.Point(187, 423);
            this.startRecordBt.Name = "startRecordBt";
            this.startRecordBt.Size = new System.Drawing.Size(168, 60);
            this.startRecordBt.TabIndex = 8;
            this.startRecordBt.Text = "Kayıt Başlat";
            this.startRecordBt.UseVisualStyleBackColor = true;
            this.startRecordBt.Click += new System.EventHandler(this.startRecordBt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ölçüm Tarih / Saat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dosya İsmi";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameTextBox.Location = new System.Drawing.Point(220, 271);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(278, 27);
            this.fileNameTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browseNewFile);
            this.groupBox1.Controls.Add(this.shaftSelectionCb);
            this.groupBox1.Controls.Add(this.factorySelectionCb);
            this.groupBox1.Controls.Add(this.operatorSelectionCb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.filePathTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tarihSaatGuncelle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fileNameTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 381);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Ayarları";
            // 
            // browseNewFile
            // 
            this.browseNewFile.Location = new System.Drawing.Point(423, 319);
            this.browseNewFile.Name = "browseNewFile";
            this.browseNewFile.Size = new System.Drawing.Size(75, 27);
            this.browseNewFile.TabIndex = 23;
            this.browseNewFile.Text = "Gözat";
            this.browseNewFile.UseVisualStyleBackColor = true;
            this.browseNewFile.Click += new System.EventHandler(this.browseNewFile_Click);
            // 
            // shaftSelectionCb
            // 
            this.shaftSelectionCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shaftSelectionCb.FormattingEnabled = true;
            this.shaftSelectionCb.Location = new System.Drawing.Point(224, 185);
            this.shaftSelectionCb.Name = "shaftSelectionCb";
            this.shaftSelectionCb.Size = new System.Drawing.Size(274, 28);
            this.shaftSelectionCb.TabIndex = 22;
            // 
            // factorySelectionCb
            // 
            this.factorySelectionCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorySelectionCb.FormattingEnabled = true;
            this.factorySelectionCb.Location = new System.Drawing.Point(224, 137);
            this.factorySelectionCb.Name = "factorySelectionCb";
            this.factorySelectionCb.Size = new System.Drawing.Size(274, 28);
            this.factorySelectionCb.TabIndex = 21;
            this.factorySelectionCb.SelectedIndexChanged += new System.EventHandler(this.factorySelectionCb_SelectedIndexChanged);
            // 
            // operatorSelectionCb
            // 
            this.operatorSelectionCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorSelectionCb.FormattingEnabled = true;
            this.operatorSelectionCb.Location = new System.Drawing.Point(224, 89);
            this.operatorSelectionCb.Name = "operatorSelectionCb";
            this.operatorSelectionCb.Size = new System.Drawing.Size(274, 28);
            this.operatorSelectionCb.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Dosya Konumu";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextBox.Location = new System.Drawing.Point(220, 319);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(192, 27);
            this.filePathTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "-";
            // 
            // tarihSaatGuncelle
            // 
            this.tarihSaatGuncelle.Location = new System.Drawing.Point(423, 230);
            this.tarihSaatGuncelle.Name = "tarihSaatGuncelle";
            this.tarihSaatGuncelle.Size = new System.Drawing.Size(75, 23);
            this.tarihSaatGuncelle.TabIndex = 15;
            this.tarihSaatGuncelle.Text = "Yenile";
            this.tarihSaatGuncelle.UseVisualStyleBackColor = true;
            this.tarihSaatGuncelle.Click += new System.EventHandler(this.tarihSaatGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ölçüm Noktası";
            // 
            // NewRecordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startRecordBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewRecordDialog";
            this.Text = "Yeni Kayıt Ekranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startRecordBt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tarihSaatGuncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.ComboBox shaftSelectionCb;
        private System.Windows.Forms.ComboBox factorySelectionCb;
        private System.Windows.Forms.ComboBox operatorSelectionCb;
        private System.Windows.Forms.Button browseNewFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}