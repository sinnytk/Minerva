﻿namespace WindowsFormsApp1
{
    partial class caesarkeydialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.keyreturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter any number from 1-25 for Caesar shifting";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 25);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // keyreturn
            // 
            this.keyreturn.Location = new System.Drawing.Point(13, 52);
            this.keyreturn.Name = "keyreturn";
            this.keyreturn.Size = new System.Drawing.Size(75, 23);
            this.keyreturn.TabIndex = 2;
            this.keyreturn.Text = "Enter";
            this.keyreturn.UseVisualStyleBackColor = true;
            this.keyreturn.Click += new System.EventHandler(this.keyreturn_Click);
            // 
            // caesarkeydialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 82);
            this.Controls.Add(this.keyreturn);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "caesarkeydialog";
            this.Text = "caesarkeydialog";
            this.Load += new System.EventHandler(this.caesarkeydialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button keyreturn;
    }
}