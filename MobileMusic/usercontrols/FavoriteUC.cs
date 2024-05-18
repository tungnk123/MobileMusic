using System.Drawing;
using System.Windows.Forms;

namespace MobileMusic.usercontrols
{
    public partial class FavoriteUC : UserControl
    {
        public static FavoriteUC Instance = new FavoriteUC();
        public FavoriteUC()
        {
            InitializeComponent();
            loadFavoriteSongs();
            Instance = this;
        }

        public void loadFavoriteSongs()
        {
            fpn_musicList.Controls.Clear();
            DataSource data = new DataSource();
            data.loadLoveIntoDatatable();
            if (DataSource.dtLove.Rows.Count > 0)
            {
                for (int i = 0; i < DataSource.dtLove.Rows.Count; i++)
                {

                    FavoriteItemUC musicItemUC = new FavoriteItemUC();
                    musicItemUC.addData(
                        (int)DataSource.dtLove.Rows[i]["id"]
                        , (Image)DataSource.dtLove.Rows[i]["image"]
                        , (string)DataSource.dtLove.Rows[i]["music"]
                        , (string)DataSource.dtLove.Rows[i]["name"]
                        , (string)DataSource.dtLove.Rows[i]["author"]
                        , (bool)DataSource.dtLove.Rows[i]["isPlay"]
                        , (bool)DataSource.dtLove.Rows[i]["isSaved"]);
                    fpn_musicList.Controls.Add(musicItemUC);
                }
            }
        }
    }
}
