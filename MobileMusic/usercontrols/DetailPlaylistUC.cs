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
    public partial class DetailPlaylistUC : UserControl
    {
        public static DetailPlaylistUC Instance = new DetailPlaylistUC();
        public DetailPlaylistUC()
        {
            InitializeComponent();
            loadSongFromPlaylist(DataSource.currentPlaylistId);
            Instance = this;
        }

        public void loadSongFromPlaylist(int playlistId)
        {
            fpn_musicList.Controls.Clear();
            DataSource data = new DataSource();
            data.loadPlaylistSongIntoMap();
            if (DataSource.map.ContainsKey(playlistId))
            {
                for (int i = 0; i < DataSource.map[playlistId].Count; i++)
                {
                    SongInPlayListUC musicItemUC = DataSource.map[playlistId][i];
                    fpn_musicList.Controls.Add(musicItemUC);
                }
            }
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PlaylistUC.Instance.loadPlayList();
        }
    }
}
