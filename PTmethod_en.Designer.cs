namespace WindowsFormsApp1
{
    partial class PTmethod_en
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PTmethod_en));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fileoption = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.writeoption = new System.Windows.Forms.PictureBox();
            this.file_en1 = new WindowsFormsApp1.file_en();
            this.process1 = new WindowsFormsApp1.encode();
            ((System.ComponentModel.ISupportInitialize)(this.fileoption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeoption)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.panel1.Location = new System.Drawing.Point(135, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 21);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("BigNoodleTitling", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "choose a method for text retrieval";
            // 
            // fileoption
            // 
            this.fileoption.BackColor = System.Drawing.Color.Transparent;
            this.fileoption.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileoption.BackgroundImage")));
            this.fileoption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fileoption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileoption.Location = new System.Drawing.Point(135, 255);
            this.fileoption.Name = "fileoption";
            this.fileoption.Size = new System.Drawing.Size(151, 141);
            this.fileoption.TabIndex = 2;
            this.fileoption.TabStop = false;
            this.fileoption.Click += new System.EventHandler(this.fileoption_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // writeoption
            // 
            this.writeoption.BackColor = System.Drawing.Color.Transparent;
            this.writeoption.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("writeoption.BackgroundImage")));
            this.writeoption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.writeoption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.writeoption.Location = new System.Drawing.Point(624, 255);
            this.writeoption.Name = "writeoption";
            this.writeoption.Size = new System.Drawing.Size(151, 141);
            this.writeoption.TabIndex = 3;
            this.writeoption.TabStop = false;
            this.writeoption.Click += new System.EventHandler(this.writeoption_Click);
            // 
            // file_en1
            // 
            this.file_en1.BackColor = System.Drawing.Color.Black;
            this.file_en1.ForeColor = System.Drawing.Color.White;
            this.file_en1.Location = new System.Drawing.Point(0, 3);
            this.file_en1.Name = "file_en1";
            this.file_en1.Size = new System.Drawing.Size(938, 636);
            this.file_en1.TabIndex = 0;
            // 
            // process1
            // 
            this.process1.BackColor = System.Drawing.Color.Black;
            this.process1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.process1.Location = new System.Drawing.Point(3, 0);
            this.process1.Name = "process1";
            this.process1.Size = new System.Drawing.Size(938, 636);
            this.process1.TabIndex = 5;
            this.process1.Visible = false;
            // 
            // PTmethod_en
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.file_en1);
            this.Controls.Add(this.process1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.writeoption);
            this.Controls.Add(this.fileoption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "PTmethod_en";
            this.Size = new System.Drawing.Size(941, 642);
            ((System.ComponentModel.ISupportInitialize)(this.fileoption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeoption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fileoption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private encode process1;
        private System.Windows.Forms.PictureBox writeoption;
        private file_en file_en1;
    }
}
