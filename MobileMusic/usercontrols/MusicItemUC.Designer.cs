namespace MobileMusic.usercontrols
{
    partial class MusicItemUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicItemUC));
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pb_add = new System.Windows.Forms.PictureBox();
            this.pb_favorite = new System.Windows.Forms.PictureBox();
            this.pb_play = new System.Windows.Forms.PictureBox();
            this.pb_download = new System.Windows.Forms.PictureBox();
            this.lb_title = new System.Windows.Forms.RichTextBox();
            this.lb_author = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_favorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_download)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(12, 16);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(60, 60);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // pb_add
            // 
            this.pb_add.Image = ((System.Drawing.Image)(resources.GetObject("pb_add.Image")));
            this.pb_add.Location = new System.Drawing.Point(231, 55);
            this.pb_add.Name = "pb_add";
            this.pb_add.Size = new System.Drawing.Size(32, 32);
            this.pb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_add.TabIndex = 3;
            this.pb_add.TabStop = false;
            this.pb_add.Click += new System.EventHandler(this.pb_add_Click);
            // 
            // pb_favorite
            // 
            this.pb_favorite.Image = ((System.Drawing.Image)(resources.GetObject("pb_favorite.Image")));
            this.pb_favorite.Location = new System.Drawing.Point(269, 55);
            this.pb_favorite.Name = "pb_favorite";
            this.pb_favorite.Size = new System.Drawing.Size(32, 32);
            this.pb_favorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_favorite.TabIndex = 4;
            this.pb_favorite.TabStop = false;
            this.pb_favorite.Click += new System.EventHandler(this.pb_favorite_Click);
            // 
            // pb_play
            // 
            this.pb_play.Image = ((System.Drawing.Image)(resources.GetObject("pb_play.Image")));
            this.pb_play.Location = new System.Drawing.Point(307, 55);
            this.pb_play.Name = "pb_play";
            this.pb_play.Size = new System.Drawing.Size(32, 32);
            this.pb_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_play.TabIndex = 5;
            this.pb_play.TabStop = false;
            this.pb_play.Click += new System.EventHandler(this.pb_play_Click);
            // 
            // pb_download
            // 
            this.pb_download.Image = ((System.Drawing.Image)(resources.GetObject("pb_download.Image")));
            this.pb_download.Location = new System.Drawing.Point(345, 55);
            this.pb_download.Name = "pb_download";
            this.pb_download.Size = new System.Drawing.Size(32, 32);
            this.pb_download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_download.TabIndex = 6;
            this.pb_download.TabStop = false;
            this.pb_download.Click += new System.EventHandler(this.pb_download_Click);
            // 
            // lb_title
            // 
            this.lb_title.BackColor = System.Drawing.Color.White;
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_title.Location = new System.Drawing.Point(78, 16);
            this.lb_title.Name = "lb_title";
            this.lb_title.ReadOnly = true;
            this.lb_title.Size = new System.Drawing.Size(299, 37);
            this.lb_title.TabIndex = 7;
            this.lb_title.Text = "";
            // 
            // lb_author
            // 
            this.lb_author.AutoWordSelection = true;
            this.lb_author.BackColor = System.Drawing.Color.White;
            this.lb_author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_author.ForeColor = System.Drawing.Color.Gray;
            this.lb_author.Location = new System.Drawing.Point(78, 55);
            this.lb_author.Name = "lb_author";
            this.lb_author.ReadOnly = true;
            this.lb_author.Size = new System.Drawing.Size(125, 32);
            this.lb_author.TabIndex = 8;
            this.lb_author.Text = "";
            // 
            // MusicItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pb_download);
            this.Controls.Add(this.pb_play);
            this.Controls.Add(this.pb_favorite);
            this.Controls.Add(this.pb_add);
            this.Controls.Add(this.pb_logo);
            this.Name = "MusicItemUC";
            this.Size = new System.Drawing.Size(392, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_favorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_download)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.PictureBox pb_add;
        private System.Windows.Forms.PictureBox pb_favorite;
        private System.Windows.Forms.PictureBox pb_play;
        private System.Windows.Forms.PictureBox pb_download;
        public System.Windows.Forms.RichTextBox lb_title;
        public System.Windows.Forms.RichTextBox lb_author;
    }
}
