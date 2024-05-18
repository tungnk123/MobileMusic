using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileMusic.usercontrols
{
    public partial class CommentItemUC : UserControl
    {
        public int star = 0;
        public string comment = "";
        public bool gender = true;
        public CommentItemUC()
        {
            InitializeComponent();
        }

        public void addData(string comment, bool gender, int star)
        {
            this.star = star;
            this.comment = comment;
            this.gender = gender;
            this.lb_content.Text = comment;
            if (gender)
            {
                pb_ava.Image = Properties.Resources.ic_man;
                lb_name.Text = "Anh";
            }
            else
            {
                pb_ava.Image = Properties.Resources.ic_woman;
                lb_name.Text = "Chị";
            }

            switch (star)
            {
                case 1:
                    {
                        pb_star1.Image = Properties.Resources.ic_star;
                        pb_star2.Image = Properties.Resources.ic_star_empty;
                        pb_star3.Image = Properties.Resources.ic_star_empty;
                        pb_star4.Image = Properties.Resources.ic_star_empty;
                        pb_star5.Image = Properties.Resources.ic_star_empty;
                        break;
                    }

                case 2:
                    {
                        pb_star1.Image = Properties.Resources.ic_star;
                        pb_star2.Image = Properties.Resources.ic_star;
                        pb_star3.Image = Properties.Resources.ic_star_empty;
                        pb_star4.Image = Properties.Resources.ic_star_empty;
                        pb_star5.Image = Properties.Resources.ic_star_empty;
                        break;
                    }




                case 3:
                    {
                        pb_star1.Image = Properties.Resources.ic_star;
                        pb_star2.Image = Properties.Resources.ic_star;
                        pb_star3.Image = Properties.Resources.ic_star;
                        pb_star4.Image = Properties.Resources.ic_star_empty;
                        pb_star5.Image = Properties.Resources.ic_star_empty;
                        break;
                    }

                case 4:
                    {
                        pb_star1.Image = Properties.Resources.ic_star;
                        pb_star2.Image = Properties.Resources.ic_star;
                        pb_star3.Image = Properties.Resources.ic_star;
                        pb_star4.Image = Properties.Resources.ic_star;
                        pb_star5.Image = Properties.Resources.ic_star_empty;
                        break;
                    }

                case 5:
                    {
                        pb_star1.Image = Properties.Resources.ic_star;
                        pb_star2.Image = Properties.Resources.ic_star;
                        pb_star3.Image = Properties.Resources.ic_star;
                        pb_star4.Image = Properties.Resources.ic_star;
                        pb_star5.Image = Properties.Resources.ic_star;
                        break;
                    }

                    
            }
        }

        
    }
}
