namespace MobileMusic.usercontrols
{
    partial class PlaylistItemUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistItemUC));
            this.lb_title = new System.Windows.Forms.Label();
            this.pb_deleteFolder = new System.Windows.Forms.PictureBox();
            this.pb_deleteMusic = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deleteFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deleteMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(89, 15);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(155, 32);
            this.lb_title.TabIndex = 8;
            this.lb_title.Text = "Shameless";
            // 
            // pb_deleteFolder
            // 
            this.pb_deleteFolder.Image = ((System.Drawing.Image)(resources.GetObject("pb_deleteFolder.Image")));
            this.pb_deleteFolder.Location = new System.Drawing.Point(347, 31);
            this.pb_deleteFolder.Name = "pb_deleteFolder";
            this.pb_deleteFolder.Size = new System.Drawing.Size(32, 32);
            this.pb_deleteFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_deleteFolder.TabIndex = 10;
            this.pb_deleteFolder.TabStop = false;
            this.pb_deleteFolder.Click += new System.EventHandler(this.pb_deleteFolder_Click);
            // 
            // pb_deleteMusic
            // 
            this.pb_deleteMusic.Image = ((System.Drawing.Image)(resources.GetObject("pb_deleteMusic.Image")));
            this.pb_deleteMusic.Location = new System.Drawing.Point(309, 31);
            this.pb_deleteMusic.Name = "pb_deleteMusic";
            this.pb_deleteMusic.Size = new System.Drawing.Size(32, 32);
            this.pb_deleteMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_deleteMusic.TabIndex = 9;
            this.pb_deleteMusic.TabStop = false;
            this.pb_deleteMusic.Click += new System.EventHandler(this.pb_deleteMusic_Click);
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
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_count.Location = new System.Drawing.Point(90, 50);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(23, 25);
            this.lb_count.TabIndex = 11;
            this.lb_count.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bài hát";
            // 
            // PlaylistItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.pb_deleteFolder);
            this.Controls.Add(this.pb_deleteMusic);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pb_logo);
            this.Name = "PlaylistItemUC";
            this.Size = new System.Drawing.Size(392, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pb_deleteFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deleteMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_deleteFolder;
        private System.Windows.Forms.PictureBox pb_deleteMusic;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label label1;
    }
}
