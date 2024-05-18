namespace MobileMusic.usercontrols
{
    partial class FavoriteItemUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteItemUC));
            this.pb_download = new System.Windows.Forms.PictureBox();
            this.pb_play = new System.Windows.Forms.PictureBox();
            this.lb_author = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_download
            // 
            this.pb_download.Image = ((System.Drawing.Image)(resources.GetObject("pb_download.Image")));
            this.pb_download.Location = new System.Drawing.Point(347, 43);
            this.pb_download.Name = "pb_download";
            this.pb_download.Size = new System.Drawing.Size(32, 32);
            this.pb_download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_download.TabIndex = 11;
            this.pb_download.TabStop = false;
            this.pb_download.Click += new System.EventHandler(this.pb_download_Click);
            // 
            // pb_play
            // 
            this.pb_play.Image = ((System.Drawing.Image)(resources.GetObject("pb_play.Image")));
            this.pb_play.Location = new System.Drawing.Point(309, 43);
            this.pb_play.Name = "pb_play";
            this.pb_play.Size = new System.Drawing.Size(32, 32);
            this.pb_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_play.TabIndex = 10;
            this.pb_play.TabStop = false;
            this.pb_play.Click += new System.EventHandler(this.pb_play_Click);
            // 
            // lb_author
            // 
            this.lb_author.AutoEllipsis = true;
            this.lb_author.ForeColor = System.Drawing.Color.Gray;
            this.lb_author.Location = new System.Drawing.Point(91, 55);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(125, 20);
            this.lb_author.TabIndex = 9;
            this.lb_author.Text = "Zyzz";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(90, 15);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(110, 25);
            this.lb_title.TabIndex = 8;
            this.lb_title.Text = "Shameless";
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(14, 15);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(60, 60);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 7;
            this.pb_logo.TabStop = false;
            this.pb_logo.Click += new System.EventHandler(this.pb_logo_Click);
            // 
            // FavoriteItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pb_download);
            this.Controls.Add(this.pb_play);
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pb_logo);
            this.Name = "FavoriteItemUC";
            this.Size = new System.Drawing.Size(392, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pb_download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_download;
        private System.Windows.Forms.PictureBox pb_play;
        private System.Windows.Forms.Label lb_author;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}
