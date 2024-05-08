namespace MobileMusic.usercontrols
{
    partial class HomeUC
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
            this.lb_recents = new System.Windows.Forms.Label();
            this.fpn_recent = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_download = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_recents
            // 
            this.lb_recents.AutoSize = true;
            this.lb_recents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_recents.Location = new System.Drawing.Point(20, 310);
            this.lb_recents.Name = "lb_recents";
            this.lb_recents.Size = new System.Drawing.Size(141, 25);
            this.lb_recents.TabIndex = 0;
            this.lb_recents.Text = "Recent music";
            this.lb_recents.Click += new System.EventHandler(this.lb_recents_Click);
            // 
            // fpn_recent
            // 
            this.fpn_recent.AutoScroll = true;
            this.fpn_recent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpn_recent.Location = new System.Drawing.Point(25, 353);
            this.fpn_recent.Name = "fpn_recent";
            this.fpn_recent.Size = new System.Drawing.Size(402, 224);
            this.fpn_recent.TabIndex = 1;
            // 
            // lb_download
            // 
            this.lb_download.AutoSize = true;
            this.lb_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_download.Location = new System.Drawing.Point(186, 310);
            this.lb_download.Name = "lb_download";
            this.lb_download.Size = new System.Drawing.Size(169, 25);
            this.lb_download.TabIndex = 2;
            this.lb_download.Text = "Download music";
            this.lb_download.Click += new System.EventHandler(this.lb_download_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(117, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_download);
            this.Controls.Add(this.fpn_recent);
            this.Controls.Add(this.lb_recents);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(452, 599);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_recents;
        private System.Windows.Forms.FlowLayoutPanel fpn_recent;
        private System.Windows.Forms.Label lb_download;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
