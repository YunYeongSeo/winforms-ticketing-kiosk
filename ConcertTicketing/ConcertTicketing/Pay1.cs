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
    public partial class Pay1 : Form
    {
        public Pay1()
        {
            InitializeComponent();

            cb_vip.SelectedIndex = 0;
            cb_nomal.SelectedIndex = 0;
            cb_limitView.SelectedIndex = 0;

            cb_vip.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cb_nomal.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cb_limitView.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            lb_Price.TextChanged += (s, e) =>
            {
                lb_Price2.Text = lb_Price.Text;
            };
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_vip.SelectedIndex == 1)
            {
                lb_Price.Text = "198,000";
                lb_Price2.Text= "198,000";
                lb_TotalPrice.Text = "200,000";
                lb_sit.Text = "VIP석 1매";

                lb_Price.Visible = true;
                lb_Price2.Visible = true;
                lb_TotalPrice.Visible = true;
                lb_sit.Visible = true;
            }
            else if (cb_nomal.SelectedIndex == 1)
            {
                lb_Price.Text = "154,000";
                lb_Price2.Text = "154,000";
                lb_TotalPrice.Text = "156,000";
                lb_sit.Text = "일반석 1매";

                lb_Price.Visible = true;
                lb_Price2.Visible = true;
                lb_TotalPrice.Visible = true;
                lb_sit.Visible = true;
            }
            else if (cb_limitView.SelectedIndex == 1)
            {
                lb_Price.Text = "154,000";
                lb_Price2.Text = "154,000";
                lb_TotalPrice.Text = "156,000";
                lb_sit.Text = "시야제한석 1매";

                lb_Price.Visible = true;
                lb_Price2.Visible = true;
                lb_TotalPrice.Visible = true;
                lb_sit.Visible = true;
            }
            else
            {
                // 선택 없음
                lb_Price.Text = "0";
                lb_TotalPrice.Text = "0";

                lb_Price.Visible = false;
                lb_Price2.Visible = false;
                lb_TotalPrice.Visible = false;
            }
        }

        private void btn_Back1_Click(object sender, EventArgs e)
        {
            ReserveFriday Friday = new ReserveFriday();
            Friday.Show();
            this.Hide();
        }

        private void btn_next1_Click(object sender, EventArgs e)
        {
            Pay2 pay2 = new Pay2();

            pay2.Price2 = lb_Price.Text;
            pay2.Price2_2 = lb_Price.Text;
            pay2.TotalPrice = lb_TotalPrice.Text;

            pay2.Show();
            this.Hide();
        }
    }
}
