using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileMusic.usercontrols
{
    public partial class ChoosePlaylistUC : UserControl
    {
        Dictionary<int, string> map = new Dictionary<int, string>();
        public int songIdClicked = -1;
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
            string valueToFind = cb_playlists.Text;
            int key = map.FirstOrDefault(x => (string)DataSource.dtPlaylist.Rows[x.Key]["title"] == valueToFind).Key;
            SongInPlayListUC songInPlayListUC = new SongInPlayListUC();
            int idSong = (int)DataSource.dtMusic.Rows[songIdClicked]["id"] - 1;
            songInPlayListUC.loadDataIntoMusicItemUc(
            (int)DataSource.dtMusic.Rows[songIdClicked]["id"] - 1
                    , (Image)DataSource.dtMusic.Rows[songIdClicked]["image"]
                    , (string)DataSource.dtMusic.Rows[songIdClicked]["music"]
                    , (string)DataSource.dtMusic.Rows[songIdClicked]["name"]
                    , (string)DataSource.dtMusic.Rows[songIdClicked]["author"]
                    , (bool)DataSource.dtMusic.Rows[songIdClicked]["isFav"]
                    , (bool)DataSource.dtMusic.Rows[songIdClicked]["isPlay"]
                    , (bool)DataSource.dtMusic.Rows[songIdClicked]["isSaved"]
                    , (string)DataSource.dtMusic.Rows[songIdClicked]["type"]
                    , false);
            if (!DataSource.map.ContainsKey(key))
            {
                DataSource.map[key] = new List<SongInPlayListUC> ();
            }
            bool songExists = DataSource.map[key].Any(x => x.id == idSong);

            if (songExists)
            {
                MessageBox.Show("Đã tồn tại bài nhạc trong playlist này rồi!");
            }
            else
            {
                DataSource.map[key].Add(songInPlayListUC);
                DataSource data = new DataSource();
                DataSource.dtPlaylist.Rows[key]["count"] = (int)DataSource.dtPlaylist.Rows[key]["count"] + 1;
                data.savePlaylistSongFromMapIntoFile();
                data.savePlayListFromDatatableToFile();
                this.Visible = false;
            }
        }

        private void ChoosePlaylistUC_Load(object sender, EventArgs e)
        {
            
            DataSource data = new DataSource();
            data.loadPlayListIntoDatatable();
            for (int i = 0; i < DataSource.dtPlaylist.Rows.Count; i++)
            {
                if (!(bool)DataSource.dtPlaylist.Rows[i]["isDeleted"])
                {
                    map.Add((int)DataSource.dtPlaylist.Rows[i]["id"], (string)DataSource.dtPlaylist.Rows[i]["title"]);
                }
                
            }
            foreach (string playlistName in map.Values)
            {
                cb_playlists.Items.Add(playlistName);
            }
        }
    }
}
