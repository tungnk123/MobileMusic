using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileMusic.usercontrols
{
    public partial class AddPlaylist : UserControl
    {
        public AddPlaylist()
        {
            InitializeComponent();
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DataSource.dtPlaylist.Rows.Add(DataSource.countLinePlaylist, tb_name.Text, 0, false);
            DataSource data = new DataSource();
            data.savePlayListFromDatatableToFile();
            this.Visible = false;
            tb_name.Text = "";
            PlaylistUC.Instance.loadPlayList();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
