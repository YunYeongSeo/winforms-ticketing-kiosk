using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcertTicketing
{
    public partial class MapF1 : Form
    {
        public MapF1()
        {
            InitializeComponent();


            for (int i = 1; i <= 11; i++)
            {
                string btnName = "btn_MapF1_1_" + i;

                var btn = this.Controls.Find(btnName, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    btn.BackColor = Color.FromArgb(190, 168, 134);
                }
            }

            for (int i = 1; i <= 13; i++)
            {
                string btnName = "btn_MapF1_2_" + i;

                var btn = this.Controls.Find(btnName, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    btn.BackColor = Color.FromArgb(190, 168, 134);
                }
            }

            for (int i = 1; i <= 15; i++)
            {
                string btnName = "btn_MapF1_3_" + i;

                var btn = this.Controls.Find(btnName, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    btn.BackColor = Color.FromArgb(190, 168, 134);
                }
            }

            for (int i = 1; i <= 17; i++)
            {
                string btnName = "btn_MapF1_4_" + i;

                var btn = this.Controls.Find(btnName, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    btn.BackColor = Color.FromArgb(190, 168, 134);
                }
            }

            for (int i = 1; i <= 19; i++)
            {
                string btnName = "btn_MapF1_5_" + i;

                var btn = this.Controls.Find(btnName, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    btn.BackColor = Color.FromArgb(190, 168, 134);
                }
            }

            for (int i = 1; i <= 21; i++)
            {
                string btnName = "btn_MapF1_6_" + i;

                var btn = this.Controls.Find(btnName, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    btn.BackColor = Color.FromArgb(190, 168, 134);
                }
            }

            for (int i = 1; i <= 23; i++)
            {
                string btnName = "btn_MapF1_7_" + i;

                var btn = this.Controls.Find(btnName, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    btn.BackColor = Color.FromArgb(190, 168, 134);
                }
            }

            for (int i = 1; i <= 25; i++)
            {
                string btnName = "btn_MapF1_8_" + i;

                var btn = this.Controls.Find(btnName, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    btn.BackColor = Color.FromArgb(190, 168, 134);
                }
            }

            for (int i = 1; i <= 27; i++)
            {
                string btnName = "btn_MapF1_9_" + i;

                var btn = this.Controls.Find(btnName, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    btn.BackColor = Color.FromArgb(190, 168, 134);
                }
            }

            for (int i = 1; i <= 29; i++)
            {
                string btnName = "btn_MapF1_10_" + i;

                var btn = this.Controls.Find(btnName, true).FirstOrDefault() as Button;

                if (btn != null)
                {
                    btn.BackColor = Color.FromArgb(190, 168, 134);
                }
            }
        }

        private void btn_Move_Friday_Click(object sender, EventArgs e)
        {
            ReserveFriday Friday = new ReserveFriday();
            Friday.Show();
            this.Hide();
        }

        private void btn_choice_Complete_Click(object sender, EventArgs e)
        {
            Pay1 pay1 = new Pay1();
            pay1.Show();
            this.Hide();
        }

    }
}
