namespace ProjectT
{
    partial class UpdateForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelErosion = new System.Windows.Forms.Label();
            this.hScrollBarErosion = new System.Windows.Forms.HScrollBar();
            this.label = new System.Windows.Forms.Label();
            this.hScrollBarDilation = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.hScrollBarThreshold = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxFinalResult = new System.Windows.Forms.PictureBox();
            this.pictureBoxDenoised = new System.Windows.Forms.PictureBox();
            this.pictureBoxBinary = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrayscale = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinalResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDenoised)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBoxFinalResult);
            this.groupBox1.Controls.Add(this.pictureBoxDenoised);
            this.groupBox1.Controls.Add(this.pictureBoxBinary);
            this.groupBox1.Controls.Add(this.pictureBoxGrayscale);
            this.groupBox1.Controls.Add(this.pictureBoxOriginal);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1019, 627);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelErosion);
            this.groupBox2.Controls.Add(this.hScrollBarErosion);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.hScrollBarDilation);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hScrollBarThreshold);
            this.groupBox2.Location = new System.Drawing.Point(288, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 240);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pre-process Controls";
            // 
            // labelErosion
            // 
            this.labelErosion.AutoSize = true;
            this.labelErosion.Location = new System.Drawing.Point(6, 37);
            this.labelErosion.Name = "labelErosion";
            this.labelErosion.Size = new System.Drawing.Size(44, 15);
            this.labelErosion.TabIndex = 8;
            this.labelErosion.Text = "Erosion";
            // 
            // hScrollBarErosion
            // 
            this.hScrollBarErosion.LargeChange = 1;
            this.hScrollBarErosion.Location = new System.Drawing.Point(73, 32);
            this.hScrollBarErosion.Maximum = 10;
            this.hScrollBarErosion.Name = "hScrollBarErosion";
            this.hScrollBarErosion.Size = new System.Drawing.Size(186, 20);
            this.hScrollBarErosion.TabIndex = 7;
            this.hScrollBarErosion.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarErosion_Scroll);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 69);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 15);
            this.label.TabIndex = 8;
            this.label.Text = "Dilation";
            // 
            // hScrollBarDilation
            // 
            this.hScrollBarDilation.LargeChange = 1;
            this.hScrollBarDilation.Location = new System.Drawing.Point(73, 64);
            this.hScrollBarDilation.Maximum = 10;
            this.hScrollBarDilation.Name = "hScrollBarDilation";
            this.hScrollBarDilation.Size = new System.Drawing.Size(186, 20);
            this.hScrollBarDilation.TabIndex = 7;
            this.hScrollBarDilation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarDilation_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Threshold";
            // 
            // hScrollBarThreshold
            // 
            this.hScrollBarThreshold.LargeChange = 1;
            this.hScrollBarThreshold.Location = new System.Drawing.Point(73, 101);
            this.hScrollBarThreshold.Maximum = 10;
            this.hScrollBarThreshold.Name = "hScrollBarThreshold";
            this.hScrollBarThreshold.Size = new System.Drawing.Size(186, 20);
            this.hScrollBarThreshold.TabIndex = 7;
            this.hScrollBarThreshold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarThreshold_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Result Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Denoised Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Binarized Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Grayscaled Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resized Image";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(586, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "SAVE SETTING";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "SELECT IMAGE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxFinalResult
            // 
            this.pictureBoxFinalResult.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxFinalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFinalResult.Location = new System.Drawing.Point(28, 366);
            this.pictureBoxFinalResult.Name = "pictureBoxFinalResult";
            this.pictureBoxFinalResult.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxFinalResult.TabIndex = 0;
            this.pictureBoxFinalResult.TabStop = false;
            // 
            // pictureBoxDenoised
            // 
            this.pictureBoxDenoised.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxDenoised.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDenoised.Location = new System.Drawing.Point(766, 93);
            this.pictureBoxDenoised.Name = "pictureBoxDenoised";
            this.pictureBoxDenoised.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxDenoised.TabIndex = 0;
            this.pictureBoxDenoised.TabStop = false;
            // 
            // pictureBoxBinary
            // 
            this.pictureBoxBinary.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBinary.Location = new System.Drawing.Point(520, 93);
            this.pictureBoxBinary.Name = "pictureBoxBinary";
            this.pictureBoxBinary.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxBinary.TabIndex = 0;
            this.pictureBoxBinary.TabStop = false;
            // 
            // pictureBoxGrayscale
            // 
            this.pictureBoxGrayscale.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxGrayscale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGrayscale.Location = new System.Drawing.Point(274, 93);
            this.pictureBoxGrayscale.Name = "pictureBoxGrayscale";
            this.pictureBoxGrayscale.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxGrayscale.TabIndex = 0;
            this.pictureBoxGrayscale.TabStop = false;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(28, 93);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 639);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateForm";
            this.Text = "Updating Training set";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinalResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDenoised)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.HScrollBar hScrollBarErosion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelErosion;
        private System.Windows.Forms.HScrollBar hScrollBarThreshold;
        private System.Windows.Forms.HScrollBar hScrollBarDilation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxDenoised;
        private System.Windows.Forms.PictureBox pictureBoxBinary;
        private System.Windows.Forms.PictureBox pictureBoxGrayscale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxFinalResult;
    }
}