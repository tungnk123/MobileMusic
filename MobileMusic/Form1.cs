using MobileMusic.usercontrols;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MobileMusic
{
    public partial class Form1 : Form
    {
        

        HomeUC homeUC = new HomeUC();
        MusicUC musicUC = new MusicUC();
        PlaylistUC playlistUC = new PlaylistUC();
        FavoriteUC favoriteUC = new FavoriteUC();

        public Form1()
        {
            InitializeComponent();
            pn_main.Controls.Add(homeUC);
            pn_main.Controls.Add(musicUC);
            pn_main.Controls.Add(playlistUC);
            pn_main.Controls.Add(favoriteUC);

            pb_homeMenu.BackColor = Color.Beige;

        }

        
        private void reset()
        {
            pb_homeMenu.BackColor = Color.Transparent;
            pb_playlist.BackColor = Color.Transparent;
            pb_musicMenu.BackColor = Color.Transparent;
            pb_favorite.BackColor = Color.Transparent;

            homeUC.reload();
            homeUC.Visible = false;


            musicUC.loadSongs();
            musicUC.Visible = false;
            playlistUC.Visible = false;

            favoriteUC.loadFavoriteSongs();
            favoriteUC.Visible = false;


            //dtLove = ClassData.dt
            

        }
        

        public void loadMusic(int id)
        {
            MusicItemUC musicItemUC = new MusicItemUC();
        }
        private void pb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_homeMenu_Click(object sender, EventArgs e)
        {
            reset();
            pb_homeMenu.BackColor = Color.Beige;
            homeUC.Visible = true;
        }

        private void pb_musicMenu_Click(object sender, EventArgs e)
        {
            reset();
            pb_musicMenu.BackColor = Color.Beige;
            musicUC.Visible = true;
        }

        private void pb_playlist_Click(object sender, EventArgs e)
        {
            reset();
            pb_playlist.BackColor = Color.Beige;
            playlistUC.Visible = true;
        }

        private void pb_favorite_Click(object sender, EventArgs e)
        {
            reset();
            pb_favorite.BackColor = Color.Beige;
            favoriteUC.Visible = true;
        }
    }
}
