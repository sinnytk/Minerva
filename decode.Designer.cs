namespace WindowsFormsApp1
{
    partial class decode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(decode));
            this.label2 = new System.Windows.Forms.Label();
            this.outputtext = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputtext = new System.Windows.Forms.RichTextBox();
            this.vigenerebtn = new System.Windows.Forms.Button();
            this.caesarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Deciphered text:";
            // 
            // outputtext
            // 
            this.outputtext.BackColor = System.Drawing.Color.Black;
            this.outputtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputtext.Font = new System.Drawing.Font("Roboto Lt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputtext.ForeColor = System.Drawing.SystemColors.Window;
            this.outputtext.HideSelection = false;
            this.outputtext.Location = new System.Drawing.Point(214, 283);
            this.outputtext.Name = "outputtext";
            this.outputtext.ReadOnly = true;
            this.outputtext.Size = new System.Drawing.Size(575, 118);
            this.outputtext.TabIndex = 14;
            this.outputtext.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(22, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Input:";
            // 
            // inputtext
            // 
            this.inputtext.BackColor = System.Drawing.Color.Black;
            this.inputtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputtext.Font = new System.Drawing.Font("Roboto Lt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputtext.ForeColor = System.Drawing.SystemColors.Window;
            this.inputtext.Location = new System.Drawing.Point(214, 159);
            this.inputtext.Name = "inputtext";
            this.inputtext.Size = new System.Drawing.Size(575, 118);
            this.inputtext.TabIndex = 11;
            this.inputtext.Text = "";
            // 
            // vigenerebtn
            // 
            this.vigenerebtn.BackColor = System.Drawing.Color.IndianRed;
            this.vigenerebtn.FlatAppearance.BorderSize = 0;
            this.vigenerebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vigenerebtn.Font = new System.Drawing.Font("Kingsbridge El", 23F);
            this.vigenerebtn.Location = new System.Drawing.Point(643, 511);
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
            this.caesarbtn.Location = new System.Drawing.Point(97, 511);
            this.caesarbtn.Name = "caesarbtn";
            this.caesarbtn.Size = new System.Drawing.Size(257, 90);
            this.caesarbtn.TabIndex = 9;
            this.caesarbtn.Text = "Caesar cipher";
            this.caesarbtn.UseVisualStyleBackColor = false;
            this.caesarbtn.Click += new System.EventHandler(this.caesarbtn_Click);
            // 
            // decode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputtext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputtext);
            this.Controls.Add(this.vigenerebtn);
            this.Controls.Add(this.caesarbtn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "decode";
            this.Size = new System.Drawing.Size(941, 642);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox outputtext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox inputtext;
        private System.Windows.Forms.Button vigenerebtn;
        private System.Windows.Forms.Button caesarbtn;
    }
}
