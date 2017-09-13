namespace SensorDataLogger.Dialogs
{
    partial class AddShaftDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bacaName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBt = new System.Windows.Forms.Button();
            this.saveBt = new System.Windows.Forms.Button();
            this.bacaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bacaID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bacaName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 155);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baca Bilgileri";
            // 
            // bacaName
            // 
            this.bacaName.Location = new System.Drawing.Point(154, 49);
            this.bacaName.Name = "bacaName";
            this.bacaName.Size = new System.Drawing.Size(150, 22);
            this.bacaName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ölçüm Noktası İsmi";
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(195, 199);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(106, 42);
            this.cancelBt.TabIndex = 10;
            this.cancelBt.Text = "İptal";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // saveBt
            // 
            this.saveBt.Location = new System.Drawing.Point(83, 199);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(106, 42);
            this.saveBt.TabIndex = 9;
            this.saveBt.Text = "Kaydet";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // bacaID
            // 
            this.bacaID.Location = new System.Drawing.Point(154, 86);
            this.bacaID.Name = "bacaID";
            this.bacaID.Size = new System.Drawing.Size(150, 22);
            this.bacaID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ölçüm Noktası ID ";
            // 
            // AddShaftDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.saveBt);
            this.Name = "AddShaftDialog";
            this.Text = "Yeni Ölçüm Noktası Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bacaName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.TextBox bacaID;
        private System.Windows.Forms.Label label2;
    }
}