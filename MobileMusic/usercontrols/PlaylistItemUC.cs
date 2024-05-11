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
    public partial class PlaylistItemUC : UserControl
    {
        int id = -1;
        int count = 0;
        public PlaylistItemUC()
        {
            InitializeComponent();
        }

        public void addData(int id, string name, int count)
        {
            this.id = id;
            this.count = count;
            this.lb_title.Text = name;
            this.lb_count.Text = count.ToString();
        }

        private void pb_deleteMusic_Click(object sender, EventArgs e)
        {
            
        }

        private void pb_deleteFolder_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa playlist này không?", "Xóa playlist", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                DataSource dataSource = new DataSource();
                DataSource.dtPlaylist.Rows[id]["isDeleted"] = true;
                dataSource.savePlayListFromDatatableToFile();
                PlaylistUC.Instance.loadPlayList();
            }
            
        }
    }
}
