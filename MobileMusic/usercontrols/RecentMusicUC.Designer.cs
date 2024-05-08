namespace MobileMusic.usercontrols
{
    partial class RecentMusicUC
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
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_logo
            // 
            this.pb_logo.Location = new System.Drawing.Point(3, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(130, 110);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoEllipsis = true;
            this.lb_name.Location = new System.Drawing.Point(3, 116);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(130, 61);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "lb_name";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecentMusicUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pb_logo);
            this.Name = "RecentMusicUC";
            this.Size = new System.Drawing.Size(136, 188);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lb_name;
    }
}
