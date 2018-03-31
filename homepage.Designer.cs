namespace WindowsFormsApp1
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Welcome = new System.Windows.Forms.Button();
            this.navbar_home = new System.Windows.Forms.Panel();
            this.nav_about = new System.Windows.Forms.Button();
            this.nav_works = new System.Windows.Forms.Button();
            this.nav_use = new System.Windows.Forms.Button();
            this.nav_home = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.Panel();
            this.aboutcontrol1 = new WindowsFormsApp1.aboutcontrol();
            this.homecontrol1 = new WindowsFormsApp1.homecontrol();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navbar_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.home.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Welcome
            // 
            this.btn_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.btn_Welcome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_Welcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Welcome.Font = new System.Drawing.Font("BigNoodleTitling", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Welcome.ForeColor = System.Drawing.Color.White;
            this.btn_Welcome.Location = new System.Drawing.Point(355, 501);
            this.btn_Welcome.Name = "btn_Welcome";
            this.btn_Welcome.Size = new System.Drawing.Size(500, 110);
            this.btn_Welcome.TabIndex = 1;
            this.btn_Welcome.Text = "Welcome";
            this.btn_Welcome.UseVisualStyleBackColor = false;
            this.btn_Welcome.Click += new System.EventHandler(this.button1_Click);
            // 
            // navbar_home
            // 
            this.navbar_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.navbar_home.Controls.Add(this.nav_about);
            this.navbar_home.Controls.Add(this.nav_works);
            this.navbar_home.Controls.Add(this.nav_use);
            this.navbar_home.Controls.Add(this.nav_home);
            this.navbar_home.Controls.Add(this.pictureBox2);
            this.navbar_home.Location = new System.Drawing.Point(0, 0);
            this.navbar_home.Name = "navbar_home";
            this.navbar_home.Size = new System.Drawing.Size(251, 642);
            this.navbar_home.TabIndex = 0;
            this.navbar_home.Visible = false;
            // 
            // nav_about
            // 
            this.nav_about.BackColor = System.Drawing.Color.Transparent;
            this.nav_about.FlatAppearance.BorderSize = 0;
            this.nav_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.nav_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nav_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_about.Font = new System.Drawing.Font("Highway Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_about.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nav_about.Location = new System.Drawing.Point(0, 214);
            this.nav_about.Name = "nav_about";
            this.nav_about.Size = new System.Drawing.Size(82, 27);
            this.nav_about.TabIndex = 7;
            this.nav_about.Text = "about";
            this.nav_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_about.UseVisualStyleBackColor = false;
            this.nav_about.Click += new System.EventHandler(this.nav_about_Click);
            // 
            // nav_works
            // 
            this.nav_works.BackColor = System.Drawing.Color.Transparent;
            this.nav_works.FlatAppearance.BorderSize = 0;
            this.nav_works.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.nav_works.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nav_works.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_works.Font = new System.Drawing.Font("Highway Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_works.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nav_works.Location = new System.Drawing.Point(1, 280);
            this.nav_works.Name = "nav_works";
            this.nav_works.Size = new System.Drawing.Size(127, 27);
            this.nav_works.TabIndex = 6;
            this.nav_works.Text = "how it works";
            this.nav_works.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_works.UseVisualStyleBackColor = false;
            this.nav_works.Click += new System.EventHandler(this.nav_works_Click);
            // 
            // nav_use
            // 
            this.nav_use.BackColor = System.Drawing.Color.Transparent;
            this.nav_use.FlatAppearance.BorderSize = 0;
            this.nav_use.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.nav_use.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nav_use.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_use.Font = new System.Drawing.Font("Highway Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_use.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nav_use.Location = new System.Drawing.Point(0, 247);
            this.nav_use.Name = "nav_use";
            this.nav_use.Size = new System.Drawing.Size(111, 27);
            this.nav_use.TabIndex = 5;
            this.nav_use.Text = "how to use";
            this.nav_use.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_use.UseVisualStyleBackColor = false;
            this.nav_use.Click += new System.EventHandler(this.nav_use_Click);
            // 
            // nav_home
            // 
            this.nav_home.BackColor = System.Drawing.Color.Transparent;
            this.nav_home.FlatAppearance.BorderSize = 0;
            this.nav_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.nav_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nav_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_home.Font = new System.Drawing.Font("Highway Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nav_home.Location = new System.Drawing.Point(0, 181);
            this.nav_home.Name = "nav_home";
            this.nav_home.Size = new System.Drawing.Size(70, 27);
            this.nav_home.TabIndex = 3;
            this.nav_home.Text = "home";
            this.nav_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_home.UseVisualStyleBackColor = false;
            this.nav_home.Click += new System.EventHandler(this.nav_home_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 86);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // home
            // 
            this.home.Controls.Add(this.aboutcontrol1);
            this.home.Controls.Add(this.homecontrol1);
            this.home.Controls.Add(this.navbar_home);
            this.home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home.Location = new System.Drawing.Point(0, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(1201, 642);
            this.home.TabIndex = 2;
            this.home.Visible = false;
            // 
            // aboutcontrol1
            // 
            this.aboutcontrol1.BackColor = System.Drawing.Color.Black;
            this.aboutcontrol1.Location = new System.Drawing.Point(248, 0);
            this.aboutcontrol1.Name = "aboutcontrol1";
            this.aboutcontrol1.Size = new System.Drawing.Size(941, 642);
            this.aboutcontrol1.TabIndex = 2;
            // 
            // homecontrol1
            // 
            this.homecontrol1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homecontrol1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homecontrol1.Location = new System.Drawing.Point(257, 0);
            this.homecontrol1.Name = "homecontrol1";
            this.homecontrol1.Size = new System.Drawing.Size(941, 642);
            this.homecontrol1.TabIndex = 1;
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1201, 642);
            this.Controls.Add(this.home);
            this.Controls.Add(this.btn_Welcome);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Roboto Lt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "homepage";
            this.Text = "Minvera by Tarun";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navbar_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Welcome;
        private System.Windows.Forms.Panel navbar_home;
        private System.Windows.Forms.Button nav_about;
        private System.Windows.Forms.Button nav_works;
        private System.Windows.Forms.Button nav_use;
        private System.Windows.Forms.Button nav_home;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel home;
        private homecontrol homecontrol1;
        private aboutcontrol aboutcontrol1;
    }
}

