namespace WindowsFormsApp1
{
    partial class PTmethod_de
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PTmethod_de));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.writeoption = new System.Windows.Forms.PictureBox();
            this.fileoption = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.decode1 = new WindowsFormsApp1.decode();
            this.file_de1 = new WindowsFormsApp1.file_de();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeoption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileoption)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(13, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // writeoption
            // 
            this.writeoption.BackColor = System.Drawing.Color.Transparent;
            this.writeoption.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("writeoption.BackgroundImage")));
            this.writeoption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.writeoption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.writeoption.Location = new System.Drawing.Point(625, 256);
            this.writeoption.Name = "writeoption";
            this.writeoption.Size = new System.Drawing.Size(151, 141);
            this.writeoption.TabIndex = 8;
            this.writeoption.TabStop = false;
            this.writeoption.Click += new System.EventHandler(this.writeoption_Click);
            // 
            // fileoption
            // 
            this.fileoption.BackColor = System.Drawing.Color.Transparent;
            this.fileoption.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileoption.BackgroundImage")));
            this.fileoption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fileoption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileoption.Location = new System.Drawing.Point(136, 256);
            this.fileoption.Name = "fileoption";
            this.fileoption.Size = new System.Drawing.Size(151, 141);
            this.fileoption.TabIndex = 7;
            this.fileoption.TabStop = false;
            this.fileoption.Click += new System.EventHandler(this.fileoption_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("BigNoodleTitling", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "choose a method for text retrieval";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel1.Location = new System.Drawing.Point(136, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 21);
            this.panel1.TabIndex = 5;
            // 
            // decode1
            // 
            this.decode1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decode1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decode1.Location = new System.Drawing.Point(3, 3);
            this.decode1.Name = "decode1";
            this.decode1.Size = new System.Drawing.Size(941, 642);
            this.decode1.TabIndex = 10;
            this.decode1.Visible = false;
            // 
            // file_de1
            // 
            this.file_de1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.file_de1.Location = new System.Drawing.Point(0, 3);
            this.file_de1.Name = "file_de1";
            this.file_de1.Size = new System.Drawing.Size(938, 636);
            this.file_de1.TabIndex = 11;
            this.file_de1.Visible = false;
            // 
            // PTmethod_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.file_de1);
            this.Controls.Add(this.decode1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.writeoption);
            this.Controls.Add(this.fileoption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "PTmethod_de";
            this.Size = new System.Drawing.Size(938, 636);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeoption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileoption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox writeoption;
        private System.Windows.Forms.PictureBox fileoption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private decode decode1;
        private file_de file_de1;
    }
}
