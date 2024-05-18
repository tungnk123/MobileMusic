using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileMusic.usercontrols
{
    public partial class CommentForm : Form
    {
        string path = "D:\\tai-lieu-uit\\nam-3\\C#\\BaiTH2\\MobileMusic\\MobileMusic\\bin\\Debug\\assets\\comment\\comment.txt";
        public static CommentForm Instance;
        string video = "";
        bool isFav = false;
        bool isPlay = false;
        bool isPlaying = false;
        bool isSaved = false;
        int id = -1;
        string type = "";
        int star = 0;
        public CommentForm()
        {
            InitializeComponent();
            Instance = this;
            loadMusicData();
            loadComment();
        }

        public void loadMusicData()
        {

            int id = DataSource.currentMusicId;
            string name = (string)DataSource.dtMusic.Rows[id]["name"];
            string author = (string)DataSource.dtMusic.Rows[id]["author"];
            Image image = (Image)DataSource.dtMusic.Rows[id]["image"];
            bool isFav = (bool)DataSource.dtMusic.Rows[id]["isFav"];
            bool isPlay = (bool)DataSource.dtMusic.Rows[id]["isPlay"];
            bool isSaved= (bool)DataSource.dtMusic.Rows[id]["isSaved"];
            this.video = (string)DataSource.dtMusic.Rows[id]["music"];

            this.isFav = isFav;
            this.isPlay = isPlay;   
            this.isSaved = isSaved;
            this.id = id;

            this.lb_music.Text = name;
            this.lb_author.Text = author;
            this.pb_ava.Image = image;
            updateStatus();
        }

        public void updateStatus()
        {
            if (isFav)
            {
                this.pb_favorite.Image = Properties.Resources.ic_favorite;
            }
            else
            {
                this.pb_favorite.Image = Properties.Resources.ic_favorite_empty;
            }
            if (isSaved)
            {
                this.pb_download.Image = Properties.Resources.ic_download_done;
            }
            else
            {
                this.pb_download.Image = Properties.Resources.ic_download;
            }

            if (isPlaying)
            {
                this.pb_play.Image = Properties.Resources.ic_pause;
            }
            else
            {
                this.pb_play.Image = Properties.Resources.ic_play;
            }
        }

        private void pb_play_Click(object sender, EventArgs e)
        {
            if (!this.isPlaying)
            {
                this.isPlaying = !isPlaying;
                updateStatus();

                DataSource.dtMusic.Rows[id]["isPlay"] = true;
                DataSource dataSource = new DataSource();
                dataSource.saveSongFromDatatableToFile();

                if (MusicHelper.getInstance().isPlaying())
                {
                    MusicHelper.getInstance().Stop();
                }
                MusicHelper.getInstance().Play(video);
            }
            else
            {
                MusicHelper.getInstance().Stop();
                this.isPlaying = !isPlaying;
                updateStatus();
            }
        }

        private void pb_favorite_Click(object sender, EventArgs e)
        {
            this.isFav = !isFav;
            updateStatus();

            DataSource.dtMusic.Rows[id]["isFav"] = !(bool)DataSource.dtMusic.Rows[id]["isFav"];
            DataSource dataSource = new DataSource();
            dataSource.saveSongFromDatatableToFile();
        }

        private void pb_add_Click(object sender, EventArgs e)
        {
            this.choosePlaylistUC1.Visible = true;
            this.choosePlaylistUC1.songIdClicked = id;
        }

        
        public bool choosePathToSave(string musicPath)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "MP3 files (*.mp3)|*.mp3";
            saveFileDialog.FileName = Path.GetFileName(musicPath);
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                string fullFileName = Path.GetFullPath(musicPath);


                try
                {
                    File.Copy(fullFileName, savePath, true);
                    Console.WriteLine("File copied successfully!");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error copying file: " + ex.Message);
                }

            }
            return false;
        }
        private void pb_download_Click(object sender, EventArgs e)
        {
            if (choosePathToSave((string)DataSource.dtMusic.Rows[id]["music"]))
            {
                this.isSaved = true;
                updateStatus();
                DataSource.dtMusic.Rows[id]["isSaved"] = true;
                DataSource dataSource = new DataSource();
                dataSource.saveSongFromDatatableToFile();
            }
        }

        private void btn_gui_Click(object sender, EventArgs e)
        {
            CommentItemUC commentItemUC = new CommentItemUC();
            commentItemUC.addData(tb_comment.Text, rbt_anh.Checked, star);
            flowLayoutPanel1.Controls.Add(commentItemUC);
            tb_comment.Text = "";
            saveCommentToFile(commentItemUC);

        }

        void saveCommentToFile(CommentItemUC commentItemUC)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(id + "*" + commentItemUC.comment + "*" + commentItemUC.gender + "*" + commentItemUC.star);
                }
            }
            
        }

        public void loadComment()
        {
            StreamReader sr = new StreamReader(path);
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');
                if (Int32.Parse(st[0]) == id)
                {
                    string comment = st[1];
                    bool gender = bool.Parse(st[2]);
                    int star = int.Parse(st[3]);

                    CommentItemUC commentItem = new CommentItemUC();
                    commentItem.addData(comment, gender, star);
                    flowLayoutPanel1.Controls.Add(commentItem);
                }


            }
            sr.Close();
        }

        private void rdb_chi_CheckedChanged(object sender, EventArgs e)
        {
            rbt_anh.Checked = false;
        }

        private void rbt_anh_CheckedChanged(object sender, EventArgs e)
        {
            rbt_chi.Checked = false;
        }

        private void CommentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FavoriteUC.Instance.loadFavoriteSongs();
        }

        private void pb_star1_Click(object sender, EventArgs e)
        {
            star = 1;
            pb_star1.Image = Properties.Resources.ic_star;
            pb_star2.Image = Properties.Resources.ic_star_empty;
            pb_star3.Image = Properties.Resources.ic_star_empty;
            pb_star4.Image = Properties.Resources.ic_star_empty;
            pb_star5.Image = Properties.Resources.ic_star_empty;
        }

        private void pb_star2_Click(object sender, EventArgs e)
        {
            star = 2;
            pb_star1.Image = Properties.Resources.ic_star;
            pb_star2.Image = Properties.Resources.ic_star;
            pb_star3.Image = Properties.Resources.ic_star_empty;
            pb_star4.Image = Properties.Resources.ic_star_empty;
            pb_star5.Image = Properties.Resources.ic_star_empty;
        }

        private void pb_star3_Click(object sender, EventArgs e)
        {
            star = 3;
            pb_star1.Image = Properties.Resources.ic_star;
            pb_star2.Image = Properties.Resources.ic_star;
            pb_star3.Image = Properties.Resources.ic_star;
            pb_star4.Image = Properties.Resources.ic_star_empty;
            pb_star5.Image = Properties.Resources.ic_star_empty;
        }

        private void pb_star4_Click(object sender, EventArgs e)
        {
            star = 4;
            pb_star1.Image = Properties.Resources.ic_star;
            pb_star2.Image = Properties.Resources.ic_star;
            pb_star3.Image = Properties.Resources.ic_star;
            pb_star4.Image = Properties.Resources.ic_star;
            pb_star5.Image = Properties.Resources.ic_star_empty;
        }

        private void pb_star5_Click(object sender, EventArgs e)
        {
            star = 5;
            pb_star1.Image = Properties.Resources.ic_star;
            pb_star2.Image = Properties.Resources.ic_star;
            pb_star3.Image = Properties.Resources.ic_star;
            pb_star4.Image = Properties.Resources.ic_star;
            pb_star5.Image = Properties.Resources.ic_star;
        }

    }
}
