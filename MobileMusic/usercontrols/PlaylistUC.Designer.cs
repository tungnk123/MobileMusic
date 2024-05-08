namespace MobileMusic.usercontrols
{
    partial class PlaylistUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistUC));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addPlaylist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playlist";
            // 
            // btn_addPlaylist
            // 
            this.btn_addPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btn_addPlaylist.Image")));
            this.btn_addPlaylist.Location = new System.Drawing.Point(31, 69);
            this.btn_addPlaylist.Name = "btn_addPlaylist";
            this.btn_addPlaylist.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btn_addPlaylist.Size = new System.Drawing.Size(394, 59);
            this.btn_addPlaylist.TabIndex = 2;
            this.btn_addPlaylist.Text = "Thêm playlist";
            this.btn_addPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addPlaylist.UseVisualStyleBackColor = true;
            // 
            // PlaylistUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btn_addPlaylist);
            this.Controls.Add(this.label1);
            this.Name = "PlaylistUC";
            this.Size = new System.Drawing.Size(452, 599);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addPlaylist;
    }
}
