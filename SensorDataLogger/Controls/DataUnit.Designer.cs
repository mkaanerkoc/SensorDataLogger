namespace SensorDataLogger.Controls
{
    partial class DataUnit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContainerBox = new System.Windows.Forms.GroupBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gauge = new System.Windows.Forms.AGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.ContainerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainerBox
            // 
            this.ContainerBox.Controls.Add(this.unitLabel);
            this.ContainerBox.Controls.Add(this.label1);
            this.ContainerBox.Controls.Add(this.ValueLabel);
            this.ContainerBox.Controls.Add(this.StatusLabel);
            this.ContainerBox.Controls.Add(this.label5);
            this.ContainerBox.Controls.Add(this.label4);
            this.ContainerBox.Controls.Add(this.Gauge);
            this.ContainerBox.Location = new System.Drawing.Point(3, 3);
            this.ContainerBox.Name = "ContainerBox";
            this.ContainerBox.Size = new System.Drawing.Size(284, 214);
            this.ContainerBox.TabIndex = 6;
            this.ContainerBox.TabStop = false;
            this.ContainerBox.Text = "ContainerBox";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(113, 171);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(13, 17);
            this.ValueLabel.TabIndex = 13;
            this.ValueLabel.Text = "-";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(113, 150);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(13, 17);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Statüs : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Değer : ";
            // 
            // Gauge
            // 
            this.Gauge.BaseArcColor = System.Drawing.Color.Gray;
            this.Gauge.BaseArcRadius = 80;
            this.Gauge.BaseArcStart = 200;
            this.Gauge.BaseArcSweep = 140;
            this.Gauge.BaseArcWidth = 4;
            this.Gauge.Center = new System.Drawing.Point(100, 100);
            this.Gauge.Location = new System.Drawing.Point(9, 19);
            this.Gauge.MaxValue = 4000F;
            this.Gauge.MinValue = 0F;
            this.Gauge.Name = "Gauge";
            this.Gauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Blue;
            this.Gauge.NeedleColor2 = System.Drawing.Color.Black;
            this.Gauge.NeedleRadius = 60;
            this.Gauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.Gauge.NeedleWidth = 2;
            this.Gauge.ScaleLinesInterColor = System.Drawing.Color.SaddleBrown;
            this.Gauge.ScaleLinesInterInnerRadius = 73;
            this.Gauge.ScaleLinesInterOuterRadius = 80;
            this.Gauge.ScaleLinesInterWidth = 2;
            this.Gauge.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.Gauge.ScaleLinesMajorInnerRadius = 70;
            this.Gauge.ScaleLinesMajorOuterRadius = 80;
            this.Gauge.ScaleLinesMajorStepValue = 1000F;
            this.Gauge.ScaleLinesMajorWidth = 2;
            this.Gauge.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.Gauge.ScaleLinesMinorInnerRadius = 75;
            this.Gauge.ScaleLinesMinorOuterRadius = 80;
            this.Gauge.ScaleLinesMinorTicks = 9;
            this.Gauge.ScaleLinesMinorWidth = 2;
            this.Gauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.Gauge.ScaleNumbersFormat = null;
            this.Gauge.ScaleNumbersRadius = 95;
            this.Gauge.ScaleNumbersRotation = 0;
            this.Gauge.ScaleNumbersStartScaleLine = 0;
            this.Gauge.ScaleNumbersStepScaleLines = 1;
            this.Gauge.Size = new System.Drawing.Size(269, 130);
            this.Gauge.TabIndex = 3;
            this.Gauge.Text = "Gauge";
            this.Gauge.Value = 50F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Birim : ";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(113, 188);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(13, 17);
            this.unitLabel.TabIndex = 15;
            this.unitLabel.Text = "-";
            // 
            // DataUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContainerBox);
            this.Name = "DataUnit";
            this.Size = new System.Drawing.Size(290, 220);
            this.ContainerBox.ResumeLayout(false);
            this.ContainerBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.AGauge Gauge;
        public System.Windows.Forms.GroupBox ContainerBox;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label label1;
    }
}
