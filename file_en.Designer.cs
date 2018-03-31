namespace WindowsFormsApp1
{
    partial class file_en
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(file_en));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputtext = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputtext = new System.Windows.Forms.RichTextBox();
            this.vigenerebtn = new System.Windows.Forms.Button();
            this.caesarbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Instruction = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ciphered text:";
            // 
            // outputtext
            // 
            this.outputtext.BackColor = System.Drawing.Color.Black;
            this.outputtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputtext.Font = new System.Drawing.Font("Roboto Lt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputtext.ForeColor = System.Drawing.SystemColors.Window;
            this.outputtext.HideSelection = false;
            this.outputtext.Location = new System.Drawing.Point(188, 309);
            this.outputtext.Name = "outputtext";
            this.outputtext.ReadOnly = true;
            this.outputtext.Size = new System.Drawing.Size(575, 118);
            this.outputtext.TabIndex = 13;
            this.outputtext.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Input from file:";
            // 
            // inputtext
            // 
            this.inputtext.BackColor = System.Drawing.Color.Black;
            this.inputtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputtext.Font = new System.Drawing.Font("Roboto Lt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputtext.ForeColor = System.Drawing.SystemColors.Window;
            this.inputtext.Location = new System.Drawing.Point(188, 244);
            this.inputtext.Name = "inputtext";
            this.inputtext.ReadOnly = true;
            this.inputtext.Size = new System.Drawing.Size(575, 59);
            this.inputtext.TabIndex = 11;
            this.inputtext.Text = "";
            // 
            // vigenerebtn
            // 
            this.vigenerebtn.BackColor = System.Drawing.Color.IndianRed;
            this.vigenerebtn.FlatAppearance.BorderSize = 0;
            this.vigenerebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vigenerebtn.Font = new System.Drawing.Font("Kingsbridge El", 23F);
            this.vigenerebtn.Location = new System.Drawing.Point(617, 537);
            this.vigenerebtn.Name = "vigenerebtn";
            this.vigenerebtn.Size = new System.Drawing.Size(257, 90);
            this.vigenerebtn.TabIndex = 10;
            this.vigenerebtn.Text = "Vigenère cipher";
            this.vigenerebtn.UseVisualStyleBackColor = false;
            this.vigenerebtn.Click += new System.EventHandler(this.vigenerebtn_Click);
            // 
            // caesarbtn
            // 
            this.caesarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(199)))), ((int)(((byte)(241)))));
            this.caesarbtn.FlatAppearance.BorderSize = 0;
            this.caesarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caesarbtn.Font = new System.Drawing.Font("Kingsbridge El", 23F);
            this.caesarbtn.Location = new System.Drawing.Point(71, 537);
            this.caesarbtn.Name = "caesarbtn";
            this.caesarbtn.Size = new System.Drawing.Size(257, 90);
            this.caesarbtn.TabIndex = 9;
            this.caesarbtn.Text = "Caesar cipher";
            this.caesarbtn.UseVisualStyleBackColor = false;
            this.caesarbtn.Click += new System.EventHandler(this.caesarbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(188, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 133);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Instruction
            // 
            this.Instruction.AutoSize = true;
            this.Instruction.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Instruction.Location = new System.Drawing.Point(320, 95);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(384, 22);
            this.Instruction.TabIndex = 16;
            this.Instruction.Text = "Click on the file icon on left to browse the file";
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.filename.ForeColor = System.Drawing.Color.Salmon;
            this.filename.Location = new System.Drawing.Point(320, 213);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(84, 15);
            this.filename.TabIndex = 17;
            this.filename.Text = "selectedfile.txt";
            // 
            // file_en
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.filename);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputtext);
            this.Controls.Add(this.vigenerebtn);
            this.Controls.Add(this.caesarbtn);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "file_en";
            this.Size = new System.Drawing.Size(938, 636);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox outputtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox inputtext;
        private System.Windows.Forms.Button vigenerebtn;
        private System.Windows.Forms.Button caesarbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Instruction;
        private System.Windows.Forms.Label filename;
    }
}
