using System.Drawing;
using System.Windows.Forms;

namespace MobileMusic.usercontrols
{
    public partial class MusicUC : UserControl
    {

        public MusicUC()
        {
            InitializeComponent();
            DataSource data = new DataSource();

            loadSongs();

        }

        public void loadSongs()
        {
            fpn_musicList.Controls.Clear();
            DataSource data = new DataSource();
            data.loadSongIntoDatatable();
            for (int i = 0; i < DataSource.dtMusic.Rows.Count; i++)
            {

                MusicItemUC musicItemUC = new MusicItemUC();
                musicItemUC.loadDataIntoMusicItemUc(
                    (int)DataSource.dtMusic.Rows[i]["id"]
                    , (Image)DataSource.dtMusic.Rows[i]["image"]
                    , (string)DataSource.dtMusic.Rows[i]["music"]
                    , (string)DataSource.dtMusic.Rows[i]["name"]
                    , (string)DataSource.dtMusic.Rows[i]["author"]
                    , (bool)DataSource.dtMusic.Rows[i]["isFav"]
                    , (bool)DataSource.dtMusic.Rows[i]["isPlay"]
                    , (bool)DataSource.dtMusic.Rows[i]["isSaved"]
                    , (int)DataSource.dtMusic.Rows[i]["id"]);
                fpn_musicList.Controls.Add(musicItemUC);
            }
        }


    }
}
