namespace WindowsFormsApp1
{
    partial class homecontrol
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
            this.encodebtn = new System.Windows.Forms.Button();
            this.decodebtn = new System.Windows.Forms.Button();
            this.pTmethod_de1 = new WindowsFormsApp1.PTmethod_de();
            this.pTmethod1 = new WindowsFormsApp1.PTmethod_en();
            this.SuspendLayout();
            // 
            // encodebtn
            // 
            this.encodebtn.BackColor = System.Drawing.Color.Transparent;
            this.encodebtn.FlatAppearance.BorderSize = 0;
            this.encodebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encodebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodebtn.Location = new System.Drawing.Point(0, 232);
            this.encodebtn.Name = "encodebtn";
            this.encodebtn.Size = new System.Drawing.Size(420, 129);
            this.encodebtn.TabIndex = 0;
            this.encodebtn.Text = "encode";
            this.encodebtn.UseVisualStyleBackColor = false;
            this.encodebtn.Click += new System.EventHandler(this.encodebtn_Click);
            // 
            // decodebtn
            // 
            this.decodebtn.BackColor = System.Drawing.Color.Transparent;
            this.decodebtn.FlatAppearance.BorderSize = 0;
            this.decodebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.decodebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.decodebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decodebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodebtn.Location = new System.Drawing.Point(518, 232);
            this.decodebtn.Name = "decodebtn";
            this.decodebtn.Size = new System.Drawing.Size(420, 129);
            this.decodebtn.TabIndex = 1;
            this.decodebtn.Text = "decode";
            this.decodebtn.UseVisualStyleBackColor = false;
            this.decodebtn.Click += new System.EventHandler(this.decodebtn_Click);
            // 
            // pTmethod_de1
            // 
            this.pTmethod_de1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pTmethod_de1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pTmethod_de1.Location = new System.Drawing.Point(3, 0);
            this.pTmethod_de1.Name = "pTmethod_de1";
            this.pTmethod_de1.Size = new System.Drawing.Size(938, 636);
            this.pTmethod_de1.TabIndex = 3;
            this.pTmethod_de1.Visible = false;
            // 
            // pTmethod1
            // 
            this.pTmethod1.BackColor = System.Drawing.Color.Black;
            this.pTmethod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTmethod1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pTmethod1.Location = new System.Drawing.Point(0, 0);
            this.pTmethod1.Name = "pTmethod1";
            this.pTmethod1.Size = new System.Drawing.Size(941, 642);
            this.pTmethod1.TabIndex = 2;
            this.pTmethod1.Visible = false;
            // 
            // homecontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pTmethod_de1);
            this.Controls.Add(this.pTmethod1);
            this.Controls.Add(this.decodebtn);
            this.Controls.Add(this.encodebtn);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "homecontrol";
            this.Size = new System.Drawing.Size(941, 642);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button encodebtn;
        private System.Windows.Forms.Button decodebtn;
        private PTmethod_en pTmethod1;
        private PTmethod_de pTmethod_de1;
    }
}
