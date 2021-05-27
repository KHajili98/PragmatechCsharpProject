
namespace Charging_Of_Pool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxVolume = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.btnCalculateVolume = new System.Windows.Forms.Button();
            this.numericForWidth = new System.Windows.Forms.NumericUpDown();
            this.numericForHeight = new System.Windows.Forms.NumericUpDown();
            this.numericForLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.calculateTime = new System.Windows.Forms.Button();
            this.numericPipe1 = new System.Windows.Forms.NumericUpDown();
            this.numericPipe2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericForWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericForHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericForLength)).BeginInit();
            this.groupBoxTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPipe2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVolume
            // 
            this.groupBoxVolume.Controls.Add(this.label6);
            this.groupBoxVolume.Controls.Add(this.label5);
            this.groupBoxVolume.Controls.Add(this.VolumeLabel);
            this.groupBoxVolume.Controls.Add(this.btnCalculateVolume);
            this.groupBoxVolume.Controls.Add(this.numericForWidth);
            this.groupBoxVolume.Controls.Add(this.numericForHeight);
            this.groupBoxVolume.Controls.Add(this.numericForLength);
            this.groupBoxVolume.Controls.Add(this.label1);
            this.groupBoxVolume.Controls.Add(this.Length);
            this.groupBoxVolume.Location = new System.Drawing.Point(34, 34);
            this.groupBoxVolume.Name = "groupBoxVolume";
            this.groupBoxVolume.Size = new System.Drawing.Size(304, 302);
            this.groupBoxVolume.TabIndex = 0;
            this.groupBoxVolume.TabStop = false;
            this.groupBoxVolume.Text = "Volume of Pool";
            this.groupBoxVolume.Enter += new System.EventHandler(this.groupBoxVolume_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Volume = Length * Width * Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Volume :";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(226, 239);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(36, 20);
            this.VolumeLabel.TabIndex = 6;
            this.VolumeLabel.Text = "0.00";
            // 
            // btnCalculateVolume
            // 
            this.btnCalculateVolume.Location = new System.Drawing.Point(20, 235);
            this.btnCalculateVolume.Name = "btnCalculateVolume";
            this.btnCalculateVolume.Size = new System.Drawing.Size(94, 29);
            this.btnCalculateVolume.TabIndex = 5;
            this.btnCalculateVolume.Text = "Calculate";
            this.btnCalculateVolume.UseVisualStyleBackColor = true;
            this.btnCalculateVolume.Click += new System.EventHandler(this.btnCalculateVolume_Click);
            // 
            // numericForWidth
            // 
            this.numericForWidth.Location = new System.Drawing.Point(126, 139);
            this.numericForWidth.Name = "numericForWidth";
            this.numericForWidth.Size = new System.Drawing.Size(150, 27);
            this.numericForWidth.TabIndex = 4;
            // 
            // numericForHeight
            // 
            this.numericForHeight.Location = new System.Drawing.Point(126, 90);
            this.numericForHeight.Name = "numericForHeight";
            this.numericForHeight.Size = new System.Drawing.Size(150, 27);
            this.numericForHeight.TabIndex = 3;
            // 
            // numericForLength
            // 
            this.numericForLength.Location = new System.Drawing.Point(126, 44);
            this.numericForLength.Name = "numericForLength";
            this.numericForLength.Size = new System.Drawing.Size(150, 27);
            this.numericForLength.TabIndex = 2;
            this.numericForLength.ValueChanged += new System.EventHandler(this.groupBoxVolume_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height";
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(18, 44);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(54, 20);
            this.Length.TabIndex = 0;
            this.Length.Text = "Length";
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.label8);
            this.groupBoxTime.Controls.Add(this.label7);
            this.groupBoxTime.Controls.Add(this.TimeLabel);
            this.groupBoxTime.Controls.Add(this.calculateTime);
            this.groupBoxTime.Controls.Add(this.numericPipe1);
            this.groupBoxTime.Controls.Add(this.numericPipe2);
            this.groupBoxTime.Controls.Add(this.label4);
            this.groupBoxTime.Controls.Add(this.label3);
            this.groupBoxTime.Location = new System.Drawing.Point(384, 34);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(363, 302);
            this.groupBoxTime.TabIndex = 1;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Charging Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Time = Volume / ( Pipe 1 + Pipe 2)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Time :";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(252, 235);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(36, 20);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "0.00";
            // 
            // calculateTime
            // 
            this.calculateTime.Location = new System.Drawing.Point(28, 230);
            this.calculateTime.Name = "calculateTime";
            this.calculateTime.Size = new System.Drawing.Size(94, 29);
            this.calculateTime.TabIndex = 9;
            this.calculateTime.Text = "Calculate";
            this.calculateTime.UseVisualStyleBackColor = true;
            // 
            // numericPipe1
            // 
            this.numericPipe1.Location = new System.Drawing.Point(177, 44);
            this.numericPipe1.Name = "numericPipe1";
            this.numericPipe1.Size = new System.Drawing.Size(150, 27);
            this.numericPipe1.TabIndex = 7;
            // 
            // numericPipe2
            // 
            this.numericPipe2.Location = new System.Drawing.Point(177, 90);
            this.numericPipe2.Name = "numericPipe2";
            this.numericPipe2.Size = new System.Drawing.Size(150, 27);
            this.numericPipe2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pipe 1 ( volume / min)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pipe 2 ( volume / min)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.groupBoxVolume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charging of Pool";
            this.groupBoxVolume.ResumeLayout(false);
            this.groupBoxVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericForWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericForHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericForLength)).EndInit();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPipe2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVolume;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Button btnCalculateVolume;
        private System.Windows.Forms.NumericUpDown numericForWidth;
        private System.Windows.Forms.NumericUpDown numericForHeight;
        private System.Windows.Forms.NumericUpDown numericForLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericPipe1;
        private System.Windows.Forms.NumericUpDown numericPipe2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button calculateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

