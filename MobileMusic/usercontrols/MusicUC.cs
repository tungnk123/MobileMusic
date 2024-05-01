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
    public partial class MusicUC : UserControl
    {
        MusicItemUC itemUC = new MusicItemUC();
        MusicItemUC itemUC2 = new MusicItemUC();
        MusicItemUC itemUC3 = new MusicItemUC();
        MusicItemUC itemUC4= new MusicItemUC();
        MusicItemUC itemUC5= new MusicItemUC();
        MusicItemUC itemUC6= new MusicItemUC();
        public MusicUC()
        {
            InitializeComponent();
            fll_musicList.Controls.Add(itemUC);
            fll_musicList.Controls.Add(itemUC2);
            fll_musicList.Controls.Add(itemUC3);
            fll_musicList.Controls.Add(itemUC4);
            fll_musicList.Controls.Add(itemUC5);
            fll_musicList.Controls.Add(itemUC6);

        }
    }
}
