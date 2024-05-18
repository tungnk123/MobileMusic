namespace MobileMusic.usercontrols
{
    partial class SongInPlayListUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongInPlayListUC));
            this.lb_author = new System.Windows.Forms.RichTextBox();
            this.lb_title = new System.Windows.Forms.RichTextBox();
            this.pb_download = new System.Windows.Forms.PictureBox();
            this.pb_play = new System.Windows.Forms.PictureBox();
            this.pb_favorite = new System.Windows.Forms.PictureBox();
            this.pb_delete = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_favorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_author
            // 
            this.lb_author.AutoWordSelection = true;
            this.lb_author.BackColor = System.Drawing.Color.White;
            this.lb_author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_author.ForeColor = System.Drawing.Color.Gray;
            this.lb_author.Location = new System.Drawing.Point(80, 49);
            this.lb_author.Name = "lb_author";
            this.lb_author.ReadOnly = true;
            this.lb_author.Size = new System.Drawing.Size(125, 32);
            this.lb_author.TabIndex = 15;
            this.lb_author.Text = "";
            // 
            // lb_title
            // 
            this.lb_title.BackColor = System.Drawing.Color.White;
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_title.Location = new System.Drawing.Point(80, 10);
            this.lb_title.Name = "lb_title";
            this.lb_title.ReadOnly = true;
            this.lb_title.Size = new System.Drawing.Size(299, 37);
            this.lb_title.TabIndex = 14;
            this.lb_title.Text = "";
            // 
            // pb_download
            // 
            this.pb_download.Image = ((System.Drawing.Image)(resources.GetObject("pb_download.Image")));
            this.pb_download.Location = new System.Drawing.Point(347, 49);
            this.pb_download.Name = "pb_download";
            this.pb_download.Size = new System.Drawing.Size(32, 32);
            this.pb_download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_download.TabIndex = 13;
            this.pb_download.TabStop = false;
            this.pb_download.Click += new System.EventHandler(this.pb_download_Click);
            // 
            // pb_play
            // 
            this.pb_play.Image = ((System.Drawing.Image)(resources.GetObject("pb_play.Image")));
            this.pb_play.Location = new System.Drawing.Point(309, 49);
            this.pb_play.Name = "pb_play";
            this.pb_play.Size = new System.Drawing.Size(32, 32);
            this.pb_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_play.TabIndex = 12;
            this.pb_play.TabStop = false;
            this.pb_play.Click += new System.EventHandler(this.pb_play_Click);
            // 
            // pb_favorite
            // 
            this.pb_favorite.Image = ((System.Drawing.Image)(resources.GetObject("pb_favorite.Image")));
            this.pb_favorite.Location = new System.Drawing.Point(271, 49);
            this.pb_favorite.Name = "pb_favorite";
            this.pb_favorite.Size = new System.Drawing.Size(32, 32);
            this.pb_favorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_favorite.TabIndex = 11;
            this.pb_favorite.TabStop = false;
            this.pb_favorite.Click += new System.EventHandler(this.pb_favorite_Click);
            // 
            // pb_delete
            // 
            this.pb_delete.Image = ((System.Drawing.Image)(resources.GetObject("pb_delete.Image")));
            this.pb_delete.Location = new System.Drawing.Point(233, 49);
            this.pb_delete.Name = "pb_delete";
            this.pb_delete.Size = new System.Drawing.Size(32, 32);
            this.pb_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_delete.TabIndex = 10;
            this.pb_delete.TabStop = false;
            this.pb_delete.Click += new System.EventHandler(this.pb_delete_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(14, 10);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(60, 60);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 9;
            this.pb_logo.TabStop = false;
            this.pb_logo.Click += new System.EventHandler(this.pb_logo_Click);
            // 
            // SongInPlayListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pb_download);
            this.Controls.Add(this.pb_play);
            this.Controls.Add(this.pb_favorite);
            this.Controls.Add(this.pb_delete);
            this.Controls.Add(this.pb_logo);
            this.Name = "SongInPlayListUC";
            this.Size = new System.Drawing.Size(392, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pb_download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_favorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox lb_author;
        public System.Windows.Forms.RichTextBox lb_title;
        private System.Windows.Forms.PictureBox pb_download;
        private System.Windows.Forms.PictureBox pb_play;
        private System.Windows.Forms.PictureBox pb_favorite;
        private System.Windows.Forms.PictureBox pb_delete;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}
