namespace EmediaQuest1
{
    partial class MainForm
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
            this.gbChoose = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJpeg = new System.Windows.Forms.Button();
            this.btnWave = new System.Windows.Forms.Button();
            this.gbChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChoose
            // 
            this.gbChoose.Controls.Add(this.label2);
            this.gbChoose.Controls.Add(this.label1);
            this.gbChoose.Controls.Add(this.btnJpeg);
            this.gbChoose.Controls.Add(this.btnWave);
            this.gbChoose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbChoose.Location = new System.Drawing.Point(12, 12);
            this.gbChoose.Name = "gbChoose";
            this.gbChoose.Size = new System.Drawing.Size(604, 337);
            this.gbChoose.TabIndex = 0;
            this.gbChoose.TabStop = false;
            this.gbChoose.Text = "Choose your destiny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "JPEG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "WAVE";
            // 
            // btnJpeg
            // 
            this.btnJpeg.BackgroundImage = global::EmediaQuest1.Properties.Resources.dzejpeg;
            this.btnJpeg.Location = new System.Drawing.Point(301, 19);
            this.btnJpeg.Name = "btnJpeg";
            this.btnJpeg.Size = new System.Drawing.Size(296, 288);
            this.btnJpeg.TabIndex = 1;
            this.btnJpeg.UseVisualStyleBackColor = true;
            this.btnJpeg.Click += new System.EventHandler(this.btnJpeg_Click);
            // 
            // btnWave
            // 
            this.btnWave.BackgroundImage = global::EmediaQuest1.Properties.Resources.wave;
            this.btnWave.Location = new System.Drawing.Point(6, 19);
            this.btnWave.Name = "btnWave";
            this.btnWave.Size = new System.Drawing.Size(289, 288);
            this.btnWave.TabIndex = 0;
            this.btnWave.UseVisualStyleBackColor = true;
            this.btnWave.Click += new System.EventHandler(this.btnWave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(624, 362);
            this.Controls.Add(this.gbChoose);
            this.Name = "MainForm";
            this.Text = "Decoding";
            this.gbChoose.ResumeLayout(false);
            this.gbChoose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChoose;
        private System.Windows.Forms.Button btnJpeg;
        private System.Windows.Forms.Button btnWave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

