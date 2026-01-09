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
    public partial class Pay2 : Form
    {
        private bool KakaoMoneySelect = false;
        private bool KakaoCardSelect = false;
        private bool CardSelect = false;
        private bool DepositSelect = false;

        public string Price2
        {
            get => lb_Price_2.Text;
            set => lb_Price_2.Text = value;
        }

        public string Price2_2
        {
            get => lb_Price2_2.Text;
            set => lb_Price2_2.Text = value;
        }

        public string TotalPrice
        {
            get => lb_TotalPrice2.Text;
            set => lb_TotalPrice2.Text = value;
        }

        public Pay2()
        {
            InitializeComponent();

            btn_Pay.BackColor = Color.FromArgb(65, 210, 107);

            lb_Price2_2.Text = lb_Price_2.Text;
        }

        private void btn_KakaoMoney_Click(object sender, EventArgs e)
        {
            lb_Deposit.Visible = false;
            gb_Card.Visible = false;

            KakaoMoneySelect = true;
            KakaoCardSelect = false;
            CardSelect = false;
            DepositSelect = false;
        }

        private void btn_KakaoCard_Click(object sender, EventArgs e)
        {
            lb_Deposit.Visible = false;
            gb_Card.Visible = false;

            KakaoMoneySelect = false;
            KakaoCardSelect = true;
            CardSelect = false;
            DepositSelect = false;
        }

        private void btn_Card_Click(object sender, EventArgs e)
        {
            lb_Deposit.Visible = false;
            gb_Card.Visible = true;

            cb_Card.SelectedIndex = 0;
            cb_n.SelectedIndex = 0;

            KakaoMoneySelect = false;
            KakaoCardSelect = false;
            CardSelect = true;
            DepositSelect = false;
        }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            lb_Deposit.Visible = true;
            gb_Card.Visible = false;

            KakaoMoneySelect = false;
            KakaoCardSelect = false;
            CardSelect = false;
            DepositSelect = true;
        }

        private void UpdateDeliveryAndTotal()
        {
            lb_delivery.Visible = rb3.Checked;  // 택배만 배송비 표시

            if (rb3.Checked)
            {
                if (lb_Price_2.Text == "154,000")
                    lb_TotalPrice2.Text = "157,200";
                else if (lb_Price_2.Text == "200,000")
                    lb_TotalPrice2.Text = "203,200";
            }
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_name.Text) || string.IsNullOrWhiteSpace(tb_num.Text) || string.IsNullOrWhiteSpace(tb_email.Text))
            {
                MessageBox.Show("이름, 전화번호, 이메일을 입력해주세요.", "주문자 정보");
                return;
            }

            else if (!rb1.Checked && !rb2.Checked && !rb3.Checked)
            {
                MessageBox.Show("티켓 수령 방법을 선택해주세요.", "수령방법");
                return;
            }

            else if (!KakaoCardSelect && !KakaoMoneySelect && !CardSelect && !DepositSelect)
            {
                MessageBox.Show("결제 수단을 선택해주세요.", "결제수단");
                return;
            }

            else if (!cb1.Checked || !cb2.Checked || !cb3.Checked || !cb3.Checked)
            {
                MessageBox.Show("예매자 동의를 체크해주세요.", "예매자동의");
                return;
            }

            if (DepositSelect)
            {
                MessageBox.Show("※ 본 공연은 원활한 예매 진행을 위해 무통장 입금으로 예매가 불가함을 안내드립니다.", "예매 불가");
            }

            UpdateDeliveryAndTotal();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Pay1 pay1 = new Pay1();
            pay1.Show();
            this.Hide();
        }

        private void cb_All_CheckedChanged(object sender, EventArgs e)
        {
            bool IsCheck = cb_All.Checked;

            cb1.Checked = IsCheck;
            cb2.Checked = IsCheck;
            cb3.Checked = IsCheck;
            cb4.Checked = IsCheck;
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            SyncCheckAll();
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            SyncCheckAll();
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            SyncCheckAll();
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            SyncCheckAll();
        }

        private void SyncCheckAll()
        {
            cb_All.Checked = cb1.Checked && cb2.Checked && cb3.Checked && cb4.Checked;
        }
    }
}
