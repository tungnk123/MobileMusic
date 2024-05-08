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
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
            loadRecents();
        }

        private void lb_recents_Click(object sender, EventArgs e)
        {
            
            loadRecents();
        }

        private void loadRecents()
        {
            lb_recents.ForeColor = Color.Green;
            lb_download.ForeColor = Color.Black;
            fpn_recent.Controls.Clear();
            DataSource data = new DataSource();
            data.loadRecentIntoDatatable();
            for (int i = 0; i < DataSource.dtRecents.Rows.Count; i++)
            {
                RecentMusicUC recentMusicUC = new RecentMusicUC();
                recentMusicUC.addData(((Image)DataSource.dtRecents.Rows[i]["image"]), (string)DataSource.dtRecents.Rows[i]["title"]);
                fpn_recent.Controls.Add(recentMusicUC);
            }
        }

        private void lb_download_Click(object sender, EventArgs e)
        {
            
            loadDownload();
        }

        private void loadDownload()
        {
            lb_download.ForeColor = Color.Green;
            lb_recents.ForeColor = Color.Black;
            fpn_recent.Controls.Clear();
            DataSource data = new DataSource();
            data.loadDownloadIntoDatatable();
            if (DataSource.dtDownload.Rows.Count > 0)
            {
                for (int i = 0; i < DataSource.dtDownload.Rows.Count; i++)
                {
                    RecentMusicUC recentMusicUC = new RecentMusicUC();
                    recentMusicUC.addData(((Image)DataSource.dtDownload.Rows[i]["image"]), (string)DataSource.dtDownload.Rows[i]["title"]);
                    fpn_recent.Controls.Add(recentMusicUC);
                }
            }
        }
    }
}
