namespace SensorDataLogger.Screens
{
    partial class ProgramParameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramParameters));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteUserBt = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.ListBox();
            this.addUserBt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteFactoryBt = new System.Windows.Forms.Button();
            this.factoryList = new System.Windows.Forms.ListBox();
            this.addFactoryBt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBacaBt = new System.Windows.Forms.Button();
            this.addBacaBt = new System.Windows.Forms.Button();
            this.bacaList = new System.Windows.Forms.ListBox();
            this.loadXmlButton = new System.Windows.Forms.Button();
            this.saveXmlButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mailListRemoveBt = new System.Windows.Forms.Button();
            this.mailListAddBt = new System.Windows.Forms.Button();
            this.mailList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteUserBt);
            this.groupBox1.Controls.Add(this.userList);
            this.groupBox1.Controls.Add(this.addUserBt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı İsimleri";
            // 
            // deleteUserBt
            // 
            this.deleteUserBt.Location = new System.Drawing.Point(141, 363);
            this.deleteUserBt.Name = "deleteUserBt";
            this.deleteUserBt.Size = new System.Drawing.Size(75, 39);
            this.deleteUserBt.TabIndex = 18;
            this.deleteUserBt.Text = "Sil";
            this.deleteUserBt.UseVisualStyleBackColor = true;
            this.deleteUserBt.Click += new System.EventHandler(this.deleteUserBt_Click);
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 16;
            this.userList.Location = new System.Drawing.Point(16, 21);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(240, 324);
            this.userList.TabIndex = 0;
            // 
            // addUserBt
            // 
            this.addUserBt.Location = new System.Drawing.Point(60, 363);
            this.addUserBt.Name = "addUserBt";
            this.addUserBt.Size = new System.Drawing.Size(75, 39);
            this.addUserBt.TabIndex = 17;
            this.addUserBt.Text = "Ekle";
            this.addUserBt.UseVisualStyleBackColor = true;
            this.addUserBt.Click += new System.EventHandler(this.addUserBt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteFactoryBt);
            this.groupBox2.Controls.Add(this.factoryList);
            this.groupBox2.Controls.Add(this.addFactoryBt);
            this.groupBox2.Location = new System.Drawing.Point(289, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 430);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tesisler";
            // 
            // deleteFactoryBt
            // 
            this.deleteFactoryBt.Location = new System.Drawing.Point(144, 363);
            this.deleteFactoryBt.Name = "deleteFactoryBt";
            this.deleteFactoryBt.Size = new System.Drawing.Size(75, 39);
            this.deleteFactoryBt.TabIndex = 15;
            this.deleteFactoryBt.Text = "Sil";
            this.deleteFactoryBt.UseVisualStyleBackColor = true;
            this.deleteFactoryBt.Click += new System.EventHandler(this.deleteFactoryBt_Click);
            // 
            // factoryList
            // 
            this.factoryList.FormattingEnabled = true;
            this.factoryList.ItemHeight = 16;
            this.factoryList.Location = new System.Drawing.Point(15, 21);
            this.factoryList.Name = "factoryList";
            this.factoryList.Size = new System.Drawing.Size(228, 324);
            this.factoryList.TabIndex = 1;
            this.factoryList.SelectedIndexChanged += new System.EventHandler(this.newFactorySelected);
            // 
            // addFactoryBt
            // 
            this.addFactoryBt.Location = new System.Drawing.Point(63, 363);
            this.addFactoryBt.Name = "addFactoryBt";
            this.addFactoryBt.Size = new System.Drawing.Size(75, 39);
            this.addFactoryBt.TabIndex = 14;
            this.addFactoryBt.Text = "Ekle";
            this.addFactoryBt.UseVisualStyleBackColor = true;
            this.addFactoryBt.Click += new System.EventHandler(this.addFactoryBt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.deleteBacaBt);
            this.groupBox3.Controls.Add(this.addBacaBt);
            this.groupBox3.Controls.Add(this.bacaList);
            this.groupBox3.Location = new System.Drawing.Point(556, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 429);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ölçüm Noktaları";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-326, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-464, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Parametre Değeri : ";
            // 
            // deleteBacaBt
            // 
            this.deleteBacaBt.Location = new System.Drawing.Point(144, 362);
            this.deleteBacaBt.Name = "deleteBacaBt";
            this.deleteBacaBt.Size = new System.Drawing.Size(75, 39);
            this.deleteBacaBt.TabIndex = 9;
            this.deleteBacaBt.Text = "Sil";
            this.deleteBacaBt.UseVisualStyleBackColor = true;
            this.deleteBacaBt.Click += new System.EventHandler(this.deleteBacaBt_Click);
            // 
            // addBacaBt
            // 
            this.addBacaBt.Location = new System.Drawing.Point(63, 362);
            this.addBacaBt.Name = "addBacaBt";
            this.addBacaBt.Size = new System.Drawing.Size(75, 39);
            this.addBacaBt.TabIndex = 8;
            this.addBacaBt.Text = "Ekle";
            this.addBacaBt.UseVisualStyleBackColor = true;
            this.addBacaBt.Click += new System.EventHandler(this.addBacaBt_Click);
            // 
            // bacaList
            // 
            this.bacaList.FormattingEnabled = true;
            this.bacaList.ItemHeight = 16;
            this.bacaList.Location = new System.Drawing.Point(14, 21);
            this.bacaList.Name = "bacaList";
            this.bacaList.Size = new System.Drawing.Size(240, 324);
            this.bacaList.TabIndex = 1;
            // 
            // loadXmlButton
            // 
            this.loadXmlButton.Location = new System.Drawing.Point(445, 458);
            this.loadXmlButton.Name = "loadXmlButton";
            this.loadXmlButton.Size = new System.Drawing.Size(119, 32);
            this.loadXmlButton.TabIndex = 3;
            this.loadXmlButton.Text = "Getir";
            this.loadXmlButton.UseVisualStyleBackColor = true;
            this.loadXmlButton.Click += new System.EventHandler(this.loadXmlButton_Click);
            // 
            // saveXmlButton
            // 
            this.saveXmlButton.Location = new System.Drawing.Point(570, 458);
            this.saveXmlButton.Name = "saveXmlButton";
            this.saveXmlButton.Size = new System.Drawing.Size(135, 32);
            this.saveXmlButton.TabIndex = 4;
            this.saveXmlButton.Text = "Kaydet";
            this.saveXmlButton.UseVisualStyleBackColor = true;
            this.saveXmlButton.Click += new System.EventHandler(this.saveXmlButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mailListRemoveBt);
            this.groupBox4.Controls.Add(this.mailListAddBt);
            this.groupBox4.Controls.Add(this.mailList);
            this.groupBox4.Location = new System.Drawing.Point(822, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 430);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mail Listesi";
            // 
            // mailListRemoveBt
            // 
            this.mailListRemoveBt.Location = new System.Drawing.Point(137, 363);
            this.mailListRemoveBt.Name = "mailListRemoveBt";
            this.mailListRemoveBt.Size = new System.Drawing.Size(75, 39);
            this.mailListRemoveBt.TabIndex = 14;
            this.mailListRemoveBt.Text = "Sil";
            this.mailListRemoveBt.UseVisualStyleBackColor = true;
            this.mailListRemoveBt.Click += new System.EventHandler(this.mailListRemoveBt_Click);
            // 
            // mailListAddBt
            // 
            this.mailListAddBt.Location = new System.Drawing.Point(56, 363);
            this.mailListAddBt.Name = "mailListAddBt";
            this.mailListAddBt.Size = new System.Drawing.Size(75, 39);
            this.mailListAddBt.TabIndex = 13;
            this.mailListAddBt.Text = "Ekle";
            this.mailListAddBt.UseVisualStyleBackColor = true;
            this.mailListAddBt.Click += new System.EventHandler(this.mailListAddBt_Click);
            // 
            // mailList
            // 
            this.mailList.FormattingEnabled = true;
            this.mailList.ItemHeight = 16;
            this.mailList.Location = new System.Drawing.Point(6, 22);
            this.mailList.Name = "mailList";
            this.mailList.Size = new System.Drawing.Size(240, 324);
            this.mailList.TabIndex = 13;
            // 
            // ProgramParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 502);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.saveXmlButton);
            this.Controls.Add(this.loadXmlButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProgramParameters";
            this.Text = "Program Parametreleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.ListBox factoryList;
        private System.Windows.Forms.ListBox bacaList;
        private System.Windows.Forms.Button deleteUserBt;
        private System.Windows.Forms.Button addUserBt;
        private System.Windows.Forms.Button deleteFactoryBt;
        private System.Windows.Forms.Button addFactoryBt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBacaBt;
        private System.Windows.Forms.Button addBacaBt;
        private System.Windows.Forms.Button loadXmlButton;
        private System.Windows.Forms.Button saveXmlButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button mailListRemoveBt;
        private System.Windows.Forms.Button mailListAddBt;
        private System.Windows.Forms.ListBox mailList;
    }
}