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
    public partial class MusicItemUC : UserControl
    {
        string video = "";
        bool isFav = false;
        bool isPlay = false;
        bool isSaved = false;
        int id = -1;
        int type = 0;
        public MusicItemUC()
        {
            InitializeComponent();
        }

        public void loadDataIntoMusicItemUc(int id, Image ava, string video, string name, string author, bool isFav, bool isPlay ,bool isSaved, int type)
        {
            this.id = id;
            this.lb_title.Text = name;
            this.lb_author.Text = author;
            this.pb_logo.Image = ava;
            this.video = video;
            this.isFav = isFav;
            this.isPlay = isPlay;
            this.isSaved = isSaved;
            this.type = type;
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
        }

        public void changeFavorite(bool isFavorite)
        {
            //this.pb_favorite
        }

        private void pb_favorite_Click(object sender, EventArgs e)
        {
            this.isFav = !isFav;
            updateStatus();

            DataSource.dtMusic.Rows[id - 1]["isFav"] = !(bool)DataSource.dtMusic.Rows[id - 1]["isFav"];
            DataSource dataSource = new DataSource();
            dataSource.saveSongFromDatatableToFile();
        }

        private void pb_download_Click(object sender, EventArgs e)
        {
            if (choosePathToSave((string)DataSource.dtMusic.Rows[id - 1]["music"])) {
                this.isSaved = true;
                updateStatus();
                DataSource.dtMusic.Rows[id - 1]["isSaved"] = true;
                DataSource dataSource = new DataSource();
                dataSource.saveSongFromDatatableToFile();
            }
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
        private void pb_add_Click(object sender, EventArgs e)
        {
            MusicUC.Instance.choosePlaylistUC1.Visible = true;
        }

        private void pb_play_Click(object sender, EventArgs e)
        {
            this.isPlay = !isPlay;
            updateStatus();

            DataSource.dtMusic.Rows[id - 1]["isPlay"] = true;
            DataSource dataSource = new DataSource();
            dataSource.saveSongFromDatatableToFile();
        }
    }
}
