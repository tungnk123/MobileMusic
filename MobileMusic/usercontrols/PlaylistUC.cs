using MahApps.Metro.Controls.Dialogs;
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
    public partial class PlaylistUC : UserControl
    {

        public static PlaylistUC Instance;
        public PlaylistUC()
        {
            InitializeComponent();
            loadPlayList();
            Instance = this;
        }

        public void loadPlayList()
        {
            fpn_musicList.Controls.Clear();
            DataSource data = new DataSource();
            data.loadPlayListIntoDatatable();
            for (int i = 0; i < DataSource.dtPlaylist.Rows.Count; i++)
            {

                if (!(bool)DataSource.dtPlaylist.Rows[i]["isDeleted"])
                {
                    PlaylistItemUC playlistItemUC = new PlaylistItemUC();
                    playlistItemUC.addData((int)DataSource.dtPlaylist.Rows[i]["id"]
                        , (string)DataSource.dtPlaylist.Rows[i]["title"]
                        , (int)DataSource.dtPlaylist.Rows[i]["count"]);
                    fpn_musicList.Controls.Add(playlistItemUC);
                }
            }
        }

        private void btn_addPlaylist_Click(object sender, EventArgs e)
        {
            addPlaylist1.Visible = true;
        }
    }
}
