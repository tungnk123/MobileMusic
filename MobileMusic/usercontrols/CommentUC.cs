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
    public partial class CommentUC : UserControl
    {
        public static CommentUC Instance;
        public CommentUC()
        {
            InitializeComponent();
            Instance = this;
            loadMusicData();
        }

        public void loadMusicData()
        {
           
            int id = DataSource.currentMusicId;
            string name = (string)DataSource.dtMusic.Rows[id]["name"];
            string author = (string)DataSource.dtMusic.Rows[id]["author"];
            Image image = (Image)DataSource.dtMusic.Rows[id]["image"];


            this.lb_music.Text = name;
            this.lb_author.Text = author;
            this.pb_ava.Image = image;

        }
    }
}
