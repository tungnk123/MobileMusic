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
    public partial class MusicUC : UserControl
    {

        string musicPath = "";
        MusicItemUC itemUC = new MusicItemUC();

        
        public MusicUC()
        {
            InitializeComponent();
            loadData();
            //fll_musicList.Controls.Add(itemUC);
            //fll_musicList.Controls.Add(itemUC2);
            //fll_musicList.Controls.Add(itemUC3);
            //fll_musicList.Controls.Add(itemUC4);
            //fll_musicList.Controls.Add(itemUC5);
            //fll_musicList.Controls.Add(itemUC6);

        }

        public void loadData()
        {
            try
            {
                StreamReader sr = new StreamReader(musicPath);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] st = line.Split(new char[] { '*' });


                }

            }

            catch { 
            }
        }
    }
}
