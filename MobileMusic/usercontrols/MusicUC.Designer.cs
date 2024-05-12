namespace MobileMusic.usercontrols
{
    partial class MusicUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicUC));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_vietNam = new System.Windows.Forms.Button();
            this.btn_international = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.pb_search = new System.Windows.Forms.PictureBox();
            this.fpn_musicList = new System.Windows.Forms.FlowLayoutPanel();
            this.choosePlaylistUC1 = new MobileMusic.usercontrols.ChoosePlaylistUC();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(22, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_vietNam
            // 
            this.btn_vietNam.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_vietNam.Location = new System.Drawing.Point(125, 19);
            this.btn_vietNam.Name = "btn_vietNam";
            this.btn_vietNam.Size = new System.Drawing.Size(97, 40);
            this.btn_vietNam.TabIndex = 1;
            this.btn_vietNam.Text = "VietNam";
            this.btn_vietNam.UseVisualStyleBackColor = false;
            this.btn_vietNam.Click += new System.EventHandler(this.btn_vietNam_Click);
            // 
            // btn_international
            // 
            this.btn_international.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_international.Location = new System.Drawing.Point(228, 19);
            this.btn_international.Name = "btn_international";
            this.btn_international.Size = new System.Drawing.Size(126, 40);
            this.btn_international.TabIndex = 2;
            this.btn_international.Text = "International";
            this.btn_international.UseVisualStyleBackColor = false;
            this.btn_international.Click += new System.EventHandler(this.International_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.tb_search);
            this.panel5.Controls.Add(this.pb_search);
            this.panel5.Location = new System.Drawing.Point(22, 78);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(412, 50);
            this.panel5.TabIndex = 4;
            // 
            // tb_search
            // 
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(3, 5);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(364, 37);
            this.tb_search.TabIndex = 1;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // pb_search
            // 
            this.pb_search.Image = ((System.Drawing.Image)(resources.GetObject("pb_search.Image")));
            this.pb_search.Location = new System.Drawing.Point(373, 5);
            this.pb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_search.Name = "pb_search";
            this.pb_search.Size = new System.Drawing.Size(36, 40);
            this.pb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_search.TabIndex = 2;
            this.pb_search.TabStop = false;
            // 
            // fpn_musicList
            // 
            this.fpn_musicList.AutoScroll = true;
            this.fpn_musicList.Location = new System.Drawing.Point(22, 147);
            this.fpn_musicList.Name = "fpn_musicList";
            this.fpn_musicList.Size = new System.Drawing.Size(427, 452);
            this.fpn_musicList.TabIndex = 5;
            // 
            // choosePlaylistUC1
            // 
            this.choosePlaylistUC1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.choosePlaylistUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.choosePlaylistUC1.Location = new System.Drawing.Point(65, 174);
            this.choosePlaylistUC1.Name = "choosePlaylistUC1";
            this.choosePlaylistUC1.Size = new System.Drawing.Size(333, 307);
            this.choosePlaylistUC1.TabIndex = 0;
            this.choosePlaylistUC1.Visible = false;
            // 
            // MusicUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.choosePlaylistUC1);
            this.Controls.Add(this.fpn_musicList);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btn_international);
            this.Controls.Add(this.btn_vietNam);
            this.Controls.Add(this.button1);
            this.Name = "MusicUC";
            this.Size = new System.Drawing.Size(452, 599);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_vietNam;
        private System.Windows.Forms.Button btn_international;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox tb_search;
        public System.Windows.Forms.PictureBox pb_search;
        private System.Windows.Forms.FlowLayoutPanel fpn_musicList;
        public ChoosePlaylistUC choosePlaylistUC1;
    }
}
