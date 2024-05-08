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
    public partial class MusicItemUC : UserControl
    {
        public MusicItemUC()
        {
            InitializeComponent();
        }

        public void loadDataIntoMusicItemUc(Image ava, string video, string name, string author, bool isFav, bool isSaved)
        {
            this.lb_title.Text = name;
            this.lb_author.Text = author;
            this.pb_logo.Image = ava;


        }

        public void changeFavorite(bool isFavorite)
        {
            //this.pb_favorite
        }
    }
}
