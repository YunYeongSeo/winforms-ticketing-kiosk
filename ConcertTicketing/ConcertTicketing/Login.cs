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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string UserID
        {
            get { return textBox_ID.Text; }
        }

        public string strPassword;

        private void btn_Login2_Click(object sender, EventArgs e)
        {
            string strID = textBox_ID.Text;
            string strPassword = textBox_Password.Text;

            MessageBox.Show("추가 회차 예매 기간입니다.\n추가된 회차는 8월 22일 금요일입니다.", "추가 회차 예매 안내");
            MessageBox.Show("오전 8시 ~ 오전 11시 59분까지(KST)\n추가 회차 선예매 기간입니다.", "추가 회차 예매 안내");

            if (strID == "moble" &&  strPassword == "2025")
            {
                MessageBox.Show("선예매 가능한 아이디로 로그인했습니다.", "로그인");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (strID == "moble" && strPassword != "2025")
            {
                MessageBox.Show("잘못된 비밀번호입니다.", "로그인");
            }

            if (strID == "mb2025" && strPassword == "2025")
            {
                MessageBox.Show("로그인했습니다.", "로그인");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (strID == "mb2025" && strPassword != "2025")
            {
                MessageBox.Show("잘못된 비밀번호입니다.", "로그인");
            }

            if (strID != "moble" && strID != "mb2025")
            {
                MessageBox.Show("없는 아이디입니다.", "로그인");
            }
        }
    }
}
