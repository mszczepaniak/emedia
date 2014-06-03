namespace EmediaQuest1
{
    partial class JpegForm
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
            this.InputPicture = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelRGB = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelSamplePrecision = new System.Windows.Forms.Label();
            this.labelMarkerLength = new System.Windows.Forms.Label();
            this.labelMarkerFFC0 = new System.Windows.Forms.Label();
            this.labelCommentTxt = new System.Windows.Forms.Label();
            this.labelCommentLength = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelFileFormat = new System.Windows.Forms.Label();
            this.labelThumbnailH = new System.Windows.Forms.Label();
            this.labelThumbnailW = new System.Windows.Forms.Label();
            this.labelYDensity = new System.Windows.Forms.Label();
            this.labelXDensity = new System.Windows.Forms.Label();
            this.labelDensity = new System.Windows.Forms.Label();
            this.labelMinorId = new System.Windows.Forms.Label();
            this.labelMajorId = new System.Windows.Forms.Label();
            this.labelStartLength = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FourierMag = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FourierPhase = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FourierMag)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FourierPhase)).BeginInit();
            this.SuspendLayout();
            // 
            // InputPicture
            // 
            this.InputPicture.Location = new System.Drawing.Point(6, 19);
            this.InputPicture.Name = "InputPicture";
            this.InputPicture.Size = new System.Drawing.Size(308, 256);
            this.InputPicture.TabIndex = 0;
            this.InputPicture.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputPicture);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRGB);
            this.groupBox2.Controls.Add(this.labelHeight);
            this.groupBox2.Controls.Add(this.labelWidth);
            this.groupBox2.Controls.Add(this.labelSamplePrecision);
            this.groupBox2.Controls.Add(this.labelMarkerLength);
            this.groupBox2.Controls.Add(this.labelMarkerFFC0);
            this.groupBox2.Controls.Add(this.labelCommentTxt);
            this.groupBox2.Controls.Add(this.labelCommentLength);
            this.groupBox2.Controls.Add(this.labelComment);
            this.groupBox2.Controls.Add(this.labelFileFormat);
            this.groupBox2.Controls.Add(this.labelThumbnailH);
            this.groupBox2.Controls.Add(this.labelThumbnailW);
            this.groupBox2.Controls.Add(this.labelYDensity);
            this.groupBox2.Controls.Add(this.labelXDensity);
            this.groupBox2.Controls.Add(this.labelDensity);
            this.groupBox2.Controls.Add(this.labelMinorId);
            this.groupBox2.Controls.Add(this.labelMajorId);
            this.groupBox2.Controls.Add(this.labelStartLength);
            this.groupBox2.Controls.Add(this.labelStart);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(354, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 651);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Attributes";
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.Location = new System.Drawing.Point(15, 262);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(30, 13);
            this.labelRGB.TabIndex = 18;
            this.labelRGB.Text = "RGB";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(15, 481);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 17;
            this.labelHeight.Text = "Height";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(15, 447);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 16;
            this.labelWidth.Text = "Width";
            // 
            // labelSamplePrecision
            // 
            this.labelSamplePrecision.AutoSize = true;
            this.labelSamplePrecision.Location = new System.Drawing.Point(15, 412);
            this.labelSamplePrecision.Name = "labelSamplePrecision";
            this.labelSamplePrecision.Size = new System.Drawing.Size(87, 13);
            this.labelSamplePrecision.TabIndex = 15;
            this.labelSamplePrecision.Text = "Sample precision";
            // 
            // labelMarkerLength
            // 
            this.labelMarkerLength.AutoSize = true;
            this.labelMarkerLength.Location = new System.Drawing.Point(15, 382);
            this.labelMarkerLength.Name = "labelMarkerLength";
            this.labelMarkerLength.Size = new System.Drawing.Size(76, 13);
            this.labelMarkerLength.TabIndex = 14;
            this.labelMarkerLength.Text = "Marker Length";
            // 
            // labelMarkerFFC0
            // 
            this.labelMarkerFFC0.AutoSize = true;
            this.labelMarkerFFC0.Location = new System.Drawing.Point(15, 353);
            this.labelMarkerFFC0.Name = "labelMarkerFFC0";
            this.labelMarkerFFC0.Size = new System.Drawing.Size(68, 13);
            this.labelMarkerFFC0.TabIndex = 13;
            this.labelMarkerFFC0.Text = "Marker FFC0";
            // 
            // labelCommentTxt
            // 
            this.labelCommentTxt.AutoSize = true;
            this.labelCommentTxt.Location = new System.Drawing.Point(183, 107);
            this.labelCommentTxt.Name = "labelCommentTxt";
            this.labelCommentTxt.Size = new System.Drawing.Size(0, 13);
            this.labelCommentTxt.TabIndex = 12;
            // 
            // labelCommentLength
            // 
            this.labelCommentLength.AutoSize = true;
            this.labelCommentLength.Location = new System.Drawing.Point(183, 94);
            this.labelCommentLength.Name = "labelCommentLength";
            this.labelCommentLength.Size = new System.Drawing.Size(0, 13);
            this.labelCommentLength.TabIndex = 11;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(15, 317);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(68, 13);
            this.labelComment.TabIndex = 10;
            this.labelComment.Text = "No Comment";
            // 
            // labelFileFormat
            // 
            this.labelFileFormat.AutoSize = true;
            this.labelFileFormat.Location = new System.Drawing.Point(15, 287);
            this.labelFileFormat.Name = "labelFileFormat";
            this.labelFileFormat.Size = new System.Drawing.Size(58, 13);
            this.labelFileFormat.TabIndex = 9;
            this.labelFileFormat.Text = "File Format";
            // 
            // labelThumbnailH
            // 
            this.labelThumbnailH.AutoSize = true;
            this.labelThumbnailH.Location = new System.Drawing.Point(15, 240);
            this.labelThumbnailH.Name = "labelThumbnailH";
            this.labelThumbnailH.Size = new System.Drawing.Size(90, 13);
            this.labelThumbnailH.TabIndex = 8;
            this.labelThumbnailH.Text = "Thumbnail Height";
            // 
            // labelThumbnailW
            // 
            this.labelThumbnailW.AutoSize = true;
            this.labelThumbnailW.Location = new System.Drawing.Point(15, 214);
            this.labelThumbnailW.Name = "labelThumbnailW";
            this.labelThumbnailW.Size = new System.Drawing.Size(87, 13);
            this.labelThumbnailW.TabIndex = 7;
            this.labelThumbnailW.Text = "Thumbnail Width";
            // 
            // labelYDensity
            // 
            this.labelYDensity.AutoSize = true;
            this.labelYDensity.Location = new System.Drawing.Point(15, 190);
            this.labelYDensity.Name = "labelYDensity";
            this.labelYDensity.Size = new System.Drawing.Size(52, 13);
            this.labelYDensity.TabIndex = 6;
            this.labelYDensity.Text = "Density Y";
            // 
            // labelXDensity
            // 
            this.labelXDensity.AutoSize = true;
            this.labelXDensity.Location = new System.Drawing.Point(15, 170);
            this.labelXDensity.Name = "labelXDensity";
            this.labelXDensity.Size = new System.Drawing.Size(52, 13);
            this.labelXDensity.TabIndex = 5;
            this.labelXDensity.Text = "Density X";
            // 
            // labelDensity
            // 
            this.labelDensity.AutoSize = true;
            this.labelDensity.Location = new System.Drawing.Point(15, 145);
            this.labelDensity.Name = "labelDensity";
            this.labelDensity.Size = new System.Drawing.Size(42, 13);
            this.labelDensity.TabIndex = 4;
            this.labelDensity.Text = "Density";
            // 
            // labelMinorId
            // 
            this.labelMinorId.AutoSize = true;
            this.labelMinorId.Location = new System.Drawing.Point(15, 119);
            this.labelMinorId.Name = "labelMinorId";
            this.labelMinorId.Size = new System.Drawing.Size(45, 13);
            this.labelMinorId.TabIndex = 3;
            this.labelMinorId.Text = "Minor Id";
            // 
            // labelMajorId
            // 
            this.labelMajorId.AutoSize = true;
            this.labelMajorId.Location = new System.Drawing.Point(15, 94);
            this.labelMajorId.Name = "labelMajorId";
            this.labelMajorId.Size = new System.Drawing.Size(44, 13);
            this.labelMajorId.TabIndex = 2;
            this.labelMajorId.Text = "Major id";
            // 
            // labelStartLength
            // 
            this.labelStartLength.AutoSize = true;
            this.labelStartLength.Location = new System.Drawing.Point(15, 66);
            this.labelStartLength.Name = "labelStartLength";
            this.labelStartLength.Size = new System.Drawing.Size(96, 13);
            this.labelStartLength.TabIndex = 1;
            this.labelStartLength.Text = "Start marker length";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(15, 37);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(29, 13);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Start";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FourierMag);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 179);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FFT Magnitude";
            // 
            // FourierMag
            // 
            this.FourierMag.Location = new System.Drawing.Point(21, 19);
            this.FourierMag.Name = "FourierMag";
            this.FourierMag.Size = new System.Drawing.Size(293, 154);
            this.FourierMag.TabIndex = 0;
            this.FourierMag.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FourierPhase);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(12, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 179);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FFT Phase";
            // 
            // FourierPhase
            // 
            this.FourierPhase.Location = new System.Drawing.Point(21, 19);
            this.FourierPhase.Name = "FourierPhase";
            this.FourierPhase.Size = new System.Drawing.Size(293, 154);
            this.FourierPhase.TabIndex = 0;
            this.FourierPhase.TabStop = false;
            // 
            // JpegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(711, 683);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "JpegForm";
            this.Text = "JpegForm";
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FourierMag)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FourierPhase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox InputPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox FourierMag;
        private System.Windows.Forms.PictureBox FourierPhase;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelStartLength;
        private System.Windows.Forms.Label labelMajorId;
        private System.Windows.Forms.Label labelMinorId;
        private System.Windows.Forms.Label labelDensity;
        private System.Windows.Forms.Label labelYDensity;
        private System.Windows.Forms.Label labelXDensity;
        private System.Windows.Forms.Label labelThumbnailH;
        private System.Windows.Forms.Label labelThumbnailW;
        private System.Windows.Forms.Label labelFileFormat;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelCommentLength;
        private System.Windows.Forms.Label labelCommentTxt;
        private System.Windows.Forms.Label labelMarkerFFC0;
        private System.Windows.Forms.Label labelMarkerLength;
        private System.Windows.Forms.Label labelSamplePrecision;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelRGB;
    }
}