namespace MobileMusic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_favorite = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_playlist = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_musicMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_homeMenu = new System.Windows.Forms.PictureBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pn_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_favorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_musicMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pb_favorite);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pb_playlist);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pb_musicMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_homeMenu);
            this.panel1.Location = new System.Drawing.Point(0, 641);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 102);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Favorite";
            // 
            // pb_favorite
            // 
            this.pb_favorite.Image = ((System.Drawing.Image)(resources.GetObject("pb_favorite.Image")));
            this.pb_favorite.Location = new System.Drawing.Point(360, 12);
            this.pb_favorite.Name = "pb_favorite";
            this.pb_favorite.Size = new System.Drawing.Size(50, 50);
            this.pb_favorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_favorite.TabIndex = 7;
            this.pb_favorite.TabStop = false;
            this.pb_favorite.Click += new System.EventHandler(this.pb_favorite_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Playlist";
            // 
            // pb_playlist
            // 
            this.pb_playlist.Image = ((System.Drawing.Image)(resources.GetObject("pb_playlist.Image")));
            this.pb_playlist.Location = new System.Drawing.Point(249, 12);
            this.pb_playlist.Name = "pb_playlist";
            this.pb_playlist.Size = new System.Drawing.Size(50, 50);
            this.pb_playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_playlist.TabIndex = 5;
            this.pb_playlist.TabStop = false;
            this.pb_playlist.Click += new System.EventHandler(this.pb_playlist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Music";
            // 
            // pb_musicMenu
            // 
            this.pb_musicMenu.Image = ((System.Drawing.Image)(resources.GetObject("pb_musicMenu.Image")));
            this.pb_musicMenu.Location = new System.Drawing.Point(139, 12);
            this.pb_musicMenu.Name = "pb_musicMenu";
            this.pb_musicMenu.Size = new System.Drawing.Size(50, 50);
            this.pb_musicMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_musicMenu.TabIndex = 3;
            this.pb_musicMenu.TabStop = false;
            this.pb_musicMenu.Click += new System.EventHandler(this.pb_musicMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home";
            // 
            // pb_homeMenu
            // 
            this.pb_homeMenu.Image = ((System.Drawing.Image)(resources.GetObject("pb_homeMenu.Image")));
            this.pb_homeMenu.Location = new System.Drawing.Point(36, 12);
            this.pb_homeMenu.Name = "pb_homeMenu";
            this.pb_homeMenu.Size = new System.Drawing.Size(50, 50);
            this.pb_homeMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_homeMenu.TabIndex = 1;
            this.pb_homeMenu.TabStop = false;
            this.pb_homeMenu.Click += new System.EventHandler(this.pb_homeMenu_Click);
            // 
            // pb_exit
            // 
            this.pb_exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_exit.Image")));
            this.pb_exit.Location = new System.Drawing.Point(404, 0);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(48, 48);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_exit.TabIndex = 1;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // pn_main
            // 
            this.pn_main.Location = new System.Drawing.Point(0, 48);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(452, 593);
            this.pn_main.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 743);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.pb_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_favorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_musicMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_homeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_favorite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_playlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_musicMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_homeMenu;
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Panel pn_main;
    }
}

