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
    public partial class ChoosePlaylistUC : UserControl
    {
        public ChoosePlaylistUC()
        {
            InitializeComponent();
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void ChoosePlaylistUC_Load(object sender, EventArgs e)
        {
            List<string> playlistNames = new List<string> { "Playlist 1", "Playlist 2", "Playlist 3" };
            foreach (string playlistName in playlistNames)
            {
                cb_playlists.Items.Add(playlistName);
            }
        }
    }
}
