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
            this.opIDTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.opSurnameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.opNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBt = new System.Windows.Forms.Button();
            this.saveBt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opIDTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.opSurnameTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.opNameTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 155);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baca Bilgileri";
            // 
            // opIDTb
            // 
            this.opIDTb.Location = new System.Drawing.Point(154, 105);
            this.opIDTb.Name = "opIDTb";
            this.opIDTb.Size = new System.Drawing.Size(150, 22);
            this.opIDTb.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Operatör ID ";
            // 
            // opSurnameTb
            // 
            this.opSurnameTb.Location = new System.Drawing.Point(154, 77);
            this.opSurnameTb.Name = "opSurnameTb";
            this.opSurnameTb.Size = new System.Drawing.Size(150, 22);
            this.opSurnameTb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Operatör Soyismi";
            // 
            // opNameTb
            // 
            this.opNameTb.Location = new System.Drawing.Point(154, 49);
            this.opNameTb.Name = "opNameTb";
            this.opNameTb.Size = new System.Drawing.Size(150, 22);
            this.opNameTb.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Operatör İsmi ";
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(195, 199);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(106, 42);
            this.cancelBt.TabIndex = 10;
            this.cancelBt.Text = "İptal";
            this.cancelBt.UseVisualStyleBackColor = true;
            // 
            // saveBt
            // 
            this.saveBt.Location = new System.Drawing.Point(83, 199);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(106, 42);
            this.saveBt.TabIndex = 9;
            this.saveBt.Text = "Kaydet";
            this.saveBt.UseVisualStyleBackColor = true;
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
            this.Text = "Yeni Baca Bilgisi Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox opIDTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox opSurnameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox opNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button saveBt;
    }
}