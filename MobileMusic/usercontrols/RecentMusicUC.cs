﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MobileMusic.usercontrols
{
    public partial class RecentMusicUC : UserControl
    {
        public RecentMusicUC()
        {
            InitializeComponent();
        }

        public void addData(Image ava, string name)
        {
            this.pb_logo.Image = ava;
            this.lb_name.Text = name;
        }
    }
}
