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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private bool FridaySelect = false;
        private bool SaturdaySelect = false;
        private bool SundaySelect = false;
        private bool LoginSelect = false;
        private bool CanReserve = false;

        public Login login;

        private void btn_TimeNow_Click(object sender, EventArgs e)
        {
            string inputTime = tb_TimeNow.Text.Trim();

            if (string.IsNullOrWhiteSpace(inputTime))
            {
                MessageBox.Show("시간을 입력해주세요. (예: 00:00)");
                CanReserve = false;
                return;
            }

            if (!LoginSelect || login == null)
            {
                MessageBox.Show("먼저 로그인을 해주세요.");
                CanReserve = false;
                return;
            }

            if (TimeSpan.TryParse(inputTime, out TimeSpan time))
            {
                TimeSpan startTime = new TimeSpan(8, 0, 0);
                TimeSpan endTime = new TimeSpan(11, 59, 0);

                if (time >= startTime && time <= endTime)
                {
                    MessageBox.Show("선예매 아이디로만 예매 가능합니다.", "선예매");

                    if (login.UserID == "moble")
                    {
                        MessageBox.Show("선예매 아이디입니다.\n예매할 수 있습니다.", "선예매");
                        CanReserve = true;
                    }
                    else
                    {
                        MessageBox.Show("선예매 아이디가 아닙니다. \n예매할 수 없습니다.", "선예매");
                        CanReserve = false;
                    }
                }
                else
                {
                    MessageBox.Show("현재는 일반 예매 시간입니다. \n모든 아이디로 예매할 수 있습니다.", "선예매");
                    CanReserve = true;
                }
            }

            else
            {
                MessageBox.Show("시간 형식이 올바르지 않습니다. (예: 00:00)", "선예매");
                CanReserve = false;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            login = new Login();

            if (login.ShowDialog() == DialogResult.OK)
            {
                lb_Login_ID.Text = login.UserID + " 님 반갑습니다!";
                
                lb_Login_ID.Visible = true;

                btn_Login.Visible = false;

                LoginSelect = true;
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            lb_Login_ID.Text = "";

            btn_Login.Visible = true;
        }

        private void btn_Friday_Click(object sender, EventArgs e)
        {
            pb_time_Friday.Visible = true;
            pb_time_Saturday.Visible = false;
            pb_time_Sunday.Visible = false;
            lb_choice_day.Visible = false;

            FridaySelect = true;
            SaturdaySelect = false;
            SundaySelect = false;
        }

        private void btn_Saturday_Click(object sender, EventArgs e)
        {
            pb_time_Friday.Visible = false;
            pb_time_Saturday.Visible = true;
            pb_time_Sunday.Visible = false;
            lb_choice_day.Visible = false;

            FridaySelect = false;
            SaturdaySelect = true;
            SundaySelect = false;
        }

        private void btn_Sunday_Click(object sender, EventArgs e)
        {
            pb_time_Friday.Visible = false;
            pb_time_Saturday.Visible = false;
            pb_time_Sunday.Visible = true;
            lb_choice_day.Visible = false;

            FridaySelect = false;
            SaturdaySelect = false;
            SundaySelect = true;
        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            if (!LoginSelect)
            {
                MessageBox.Show("로그인 후 예매 가능합니다.", "로그인");
                btn_Login.PerformClick();

                if (!LoginSelect)
                    return;
            }

            string inputTime = tb_TimeNow.Text.Trim();
            if (string.IsNullOrWhiteSpace(inputTime))
            {
                MessageBox.Show("시간을 입력해주세요. (예: 00:00)", "시간");
                return;
            }

            if (!TimeSpan.TryParse(inputTime, out TimeSpan time))
            {
                MessageBox.Show("시간 형식이 올바르지 않습니다. (예: 00:00)", "시간");
                return;
            }

            TimeSpan startTime = new TimeSpan(8, 0, 0);
            TimeSpan endTime = new TimeSpan(11, 59, 0);

            if (time >= startTime && time <= endTime)
            {
                if (login.UserID == "moble")
                {
                    CanReserve = true;
                }
                else
                {
                    MessageBox.Show("선예매 아이디가 아닙니다.\n예매할 수 없습니다.", "예매 불가");
                    CanReserve = false;
                }
            }
            else
            {
                CanReserve = true;
            }


            if (!CanReserve)
            {
                return;
            }

            if (FridaySelect)
            {
                ReserveFriday Friday = new ReserveFriday();
                Friday.Show();
                this.Hide();
            }
            else if (SaturdaySelect)
            {
                MessageBox.Show("추가 회차만 예매 가능합니다.", "날짜 선택");
            }
            else if (SundaySelect)
            {
                MessageBox.Show("추가 회차만 예매 가능합니다.", "날짜 선택");
            }
            else
            {
                MessageBox.Show("날짜를 선택해주세요.", "날짜 선택");
            }
        }
    }
}