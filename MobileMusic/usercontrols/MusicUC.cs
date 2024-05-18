using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace MobileMusic.usercontrols
{
    public partial class MusicUC : UserControl
    {
        //public static MusicItemUC Instance = new MusicItemUC();
        public static MusicUC Instance = new MusicUC();
        public static MusicHelper musicHelper = new MusicHelper();
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
            loadSongInter();
            MusicHelper.getInstance().Stop();
        }


        public void loadSongInter()
        {
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
        public void loadSongVietNam()
        {
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
        private void btn_vietNam_Click(object sender, System.EventArgs e)
        {
            btn_vietNam.BackColor = Color.Green;
            button1.BackColor = Color.YellowGreen;
            btn_international.BackColor = Color.YellowGreen;
            loadSongVietNam();
            MusicHelper.getInstance().Stop();
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
            //string searchText = tb_search.Text;
            //foreach (MusicItemUC musicItemUC in fpn_musicList.Controls)
            //{
            //    musicItemUC.lb_title.SelectionColor = Color.Black;
            //    if (searchText != "" && musicItemUC.lb_title.Text.Contains(searchText)) {
            //        fpn_musicList.ScrollControlIntoView(musicItemUC);
            //        musicItemUC.lb_title.SelectionStart = musicItemUC.lb_title.Text.IndexOf(tb_search.Text);
            //        musicItemUC.lb_title.SelectionLength = tb_search.TextLength;
            //        musicItemUC.lb_title.SelectionColor = Color.Red;
            //    }
            //    musicItemUC.lb_author.SelectionColor = Color.Gray;
            //    if (searchText != "" && musicItemUC.lb_author.Text.Contains(searchText))
            //    {
            //        fpn_musicList.ScrollControlIntoView(musicItemUC);
            //        musicItemUC.lb_author.SelectionStart = musicItemUC.lb_author.Text.IndexOf(tb_search.Text);
            //        musicItemUC.lb_author.SelectionLength = tb_search.TextLength;
            //        musicItemUC.lb_author.SelectionColor = Color.Red;
            //    }
            //}
        }

        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (tb_search.Text.Length == 1)
                {
                    if (btn_vietNam.BackColor == Color.Green)
                    {
                        loadSongVietNam();
                    }
                    else if (btn_international.BackColor == Color.Green)
                    {
                        loadSongInter();
                    }
                    else
                    {
                        loadSongs();
                    }
                    return;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {

                if (btn_vietNam.BackColor == Color.Green)
                {
                    DataRow[] dtRows = DataSource.dtMusic.Select("type = 1 AND (name LIKE '%" + tb_search.Text + "%' OR author LIKE '%" + tb_search.Text + "%')");
                    if (dtRows.Length > 0)
                    {
                        fpn_musicList.Controls.Clear();
                        DataSource data = new DataSource();
                        DataTable dtSearchSong = dtRows.CopyToDataTable();
                        data.loadSongIntoDatatable();
                        for (int i = 0; i < dtSearchSong.Rows.Count; i++)
                        {

                            MusicItemUC musicItemUC = new MusicItemUC();
                            musicItemUC.loadDataIntoMusicItemUc(
                                (int)dtSearchSong.Rows[i]["id"]
                                , (Image)dtSearchSong.Rows[i]["image"]
                                , (string)dtSearchSong.Rows[i]["music"]
                                , (string)dtSearchSong.Rows[i]["name"]
                                , (string)dtSearchSong.Rows[i]["author"]
                                , (bool)dtSearchSong.Rows[i]["isFav"]
                                , (bool)dtSearchSong.Rows[i]["isPlay"]
                                , (bool)dtSearchSong.Rows[i]["isSaved"]
                                , (string)dtSearchSong.Rows[i]["type"]);
                            fpn_musicList.Controls.Add(musicItemUC);
                        }
                    }
                }
                else if (btn_international.BackColor == Color.Green)
                {
                    DataRow[] dtRows = DataSource.dtMusic.Select("type = 0 AND (name LIKE '%" + tb_search.Text + "%' OR author LIKE '%" + tb_search.Text + "%')");
                    if (dtRows.Length > 0)
                    {
                        fpn_musicList.Controls.Clear();
                        DataSource data = new DataSource();
                        DataTable dtSearchSong = dtRows.CopyToDataTable();
                        data.loadSongIntoDatatable();
                        for (int i = 0; i < dtSearchSong.Rows.Count; i++)
                        {

                            MusicItemUC musicItemUC = new MusicItemUC();
                            musicItemUC.loadDataIntoMusicItemUc(
                                (int)dtSearchSong.Rows[i]["id"]
                                , (Image)dtSearchSong.Rows[i]["image"]
                                , (string)dtSearchSong.Rows[i]["music"]
                                , (string)dtSearchSong.Rows[i]["name"]
                                , (string)dtSearchSong.Rows[i]["author"]
                                , (bool)dtSearchSong.Rows[i]["isFav"]
                                , (bool)dtSearchSong.Rows[i]["isPlay"]
                                , (bool)dtSearchSong.Rows[i]["isSaved"]
                                , (string)dtSearchSong.Rows[i]["type"]);
                            fpn_musicList.Controls.Add(musicItemUC);
                        }
                    }
                }
                else
                {
                    DataRow[] dtRows = DataSource.dtMusic.Select("name LIKE '%" + tb_search.Text + "%' OR author LIKE '%" + tb_search.Text + "%'");
                    if (dtRows.Length > 0)
                    {
                        fpn_musicList.Controls.Clear();
                        DataSource data = new DataSource();
                        DataTable dtSearchSong = dtRows.CopyToDataTable();
                        data.loadSongIntoDatatable();
                        for (int i = 0; i < dtSearchSong.Rows.Count; i++)
                        {

                            MusicItemUC musicItemUC = new MusicItemUC();
                            musicItemUC.loadDataIntoMusicItemUc(
                                (int)dtSearchSong.Rows[i]["id"]
                                , (Image)dtSearchSong.Rows[i]["image"]
                                , (string)dtSearchSong.Rows[i]["music"]
                                , (string)dtSearchSong.Rows[i]["name"]
                                , (string)dtSearchSong.Rows[i]["author"]
                                , (bool)dtSearchSong.Rows[i]["isFav"]
                                , (bool)dtSearchSong.Rows[i]["isPlay"]
                                , (bool)dtSearchSong.Rows[i]["isSaved"]
                                , (string)dtSearchSong.Rows[i]["type"]);
                            fpn_musicList.Controls.Add(musicItemUC);
                        }
                    }
                }

            }
        }
    }
}
