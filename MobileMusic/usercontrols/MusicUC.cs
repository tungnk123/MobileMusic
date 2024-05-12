using System.Drawing;
using System.Windows.Forms;

namespace MobileMusic.usercontrols
{
    public partial class MusicUC : UserControl
    {
        //public static MusicItemUC Instance = new MusicItemUC();
        public static MusicUC Instance = new MusicUC();
        public MusicUC()
        {
            InitializeComponent();
            DataSource data = new DataSource();
            loadSongs();
            Instance = this;
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
                    , (string)DataSource.dtMusic.Rows[i]["type"]);
                fpn_musicList.Controls.Add(musicItemUC);
            }
        }


        private void International_Click(object sender, System.EventArgs e)
        {
            btn_vietNam.BackColor = Color.YellowGreen;
            button1.BackColor = Color.YellowGreen;
            btn_international.BackColor = Color.Green;
            fpn_musicList.Controls.Clear();
            DataSource data = new DataSource();
            data.loadSongIntoDatatable();
            for (int i = 0; i < DataSource.dtMusic.Rows.Count; i++)
            {
                
                if (((string)DataSource.dtMusic.Rows[i]["type"]).Equals("0"))
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
                    , (string)DataSource.dtMusic.Rows[i]["type"]);
                    fpn_musicList.Controls.Add(musicItemUC);
                }
                
            }
        }

        private void btn_vietNam_Click(object sender, System.EventArgs e)
        {
            btn_vietNam.BackColor = Color.Green;
            button1.BackColor = Color.YellowGreen;
            btn_international.BackColor = Color.YellowGreen;
            fpn_musicList.Controls.Clear();
            DataSource data = new DataSource();
            data.loadSongIntoDatatable();
            for (int i = 0; i < DataSource.dtMusic.Rows.Count; i++)
            {

                if (((string)DataSource.dtMusic.Rows[i]["type"]).Equals("1"))
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
                    , (string)DataSource.dtMusic.Rows[i]["type"]);
                    fpn_musicList.Controls.Add(musicItemUC);
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            loadSongs();
            button1.BackColor = Color.Green;
            btn_vietNam.BackColor = Color.YellowGreen;
            btn_international.BackColor = Color.YellowGreen;
        }

        private void tb_search_TextChanged(object sender, System.EventArgs e)
        {
            string searchText = tb_search.Text;
            foreach (MusicItemUC musicItemUC in fpn_musicList.Controls)
            {
                musicItemUC.lb_title.SelectionColor = Color.Black;
                if (searchText != "" && musicItemUC.lb_title.Text.Contains(searchText)) {
                    fpn_musicList.ScrollControlIntoView(musicItemUC);
                    musicItemUC.lb_title.SelectionStart = musicItemUC.lb_title.Text.IndexOf(tb_search.Text);
                    musicItemUC.lb_title.SelectionLength = tb_search.TextLength;
                    musicItemUC.lb_title.SelectionColor = Color.Red;
                }
                musicItemUC.lb_author.SelectionColor = Color.Gray;
                if (searchText != "" && musicItemUC.lb_author.Text.Contains(searchText))
                {
                    fpn_musicList.ScrollControlIntoView(musicItemUC);
                    musicItemUC.lb_author.SelectionStart = musicItemUC.lb_author.Text.IndexOf(tb_search.Text);
                    musicItemUC.lb_author.SelectionLength = tb_search.TextLength;
                    musicItemUC.lb_author.SelectionColor = Color.Red;
                }
            }
        }
    }
}
