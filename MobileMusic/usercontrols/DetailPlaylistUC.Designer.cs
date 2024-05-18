namespace MobileMusic.usercontrols
{
    partial class DetailPlaylistUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailPlaylistUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.fpn_musicList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.pb_back);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 79);
            this.panel1.TabIndex = 0;
            // 
            // pb_back
            // 
            this.pb_back.Image = ((System.Drawing.Image)(resources.GetObject("pb_back.Image")));
            this.pb_back.Location = new System.Drawing.Point(13, 15);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(50, 50);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 2;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(81, 26);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(135, 29);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Pop Music";
            // 
            // fpn_musicList
            // 
            this.fpn_musicList.AutoScroll = true;
            this.fpn_musicList.Location = new System.Drawing.Point(13, 144);
            this.fpn_musicList.Name = "fpn_musicList";
            this.fpn_musicList.Size = new System.Drawing.Size(439, 452);
            this.fpn_musicList.TabIndex = 6;
            // 
            // DetailPlaylistUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.fpn_musicList);
            this.Controls.Add(this.panel1);
            this.Name = "DetailPlaylistUC";
            this.Size = new System.Drawing.Size(452, 599);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lb_title;
        public System.Windows.Forms.FlowLayoutPanel fpn_musicList;
        private System.Windows.Forms.PictureBox pb_back;
    }
}
