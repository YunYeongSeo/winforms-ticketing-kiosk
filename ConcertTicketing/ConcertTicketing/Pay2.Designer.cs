namespace ConcertTicketing
{
    partial class Pay2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Deposit = new System.Windows.Forms.Label();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_Card = new System.Windows.Forms.Button();
            this.btn_KakaoCard = new System.Windows.Forms.Button();
            this.btn_KakaoMoney = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.cb_Card = new System.Windows.Forms.ComboBox();
            this.gb_Card = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_n = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb_All = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Price2_2 = new System.Windows.Forms.Label();
            this.lb_TotalPrice2 = new System.Windows.Forms.Label();
            this.lb_sit2 = new System.Windows.Forms.Label();
            this.lb_Price_2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_delivery = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 502);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(34, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "* 필수";
            // 
            // lb_Deposit
            // 
            this.lb_Deposit.AutoSize = true;
            this.lb_Deposit.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Deposit.ForeColor = System.Drawing.Color.Red;
            this.lb_Deposit.Location = new System.Drawing.Point(3, 487);
            this.lb_Deposit.Name = "lb_Deposit";
            this.lb_Deposit.Size = new System.Drawing.Size(644, 15);
            this.lb_Deposit.TabIndex = 27;
            this.lb_Deposit.Text = "※ 본 공연은 원활한 예매 진행을 위해 무통장 입금으로 예매가 불가함을 안내드립니다. ";
            this.lb_Deposit.Visible = false;
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deposit.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Deposit.Location = new System.Drawing.Point(309, 433);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(267, 51);
            this.btn_Deposit.TabIndex = 25;
            this.btn_Deposit.Text = "무통장입금";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_Card
            // 
            this.btn_Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Card.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Card.Location = new System.Drawing.Point(36, 433);
            this.btn_Card.Name = "btn_Card";
            this.btn_Card.Size = new System.Drawing.Size(267, 51);
            this.btn_Card.TabIndex = 24;
            this.btn_Card.Text = "신용카드";
            this.btn_Card.UseVisualStyleBackColor = true;
            this.btn_Card.Click += new System.EventHandler(this.btn_Card_Click);
            // 
            // btn_KakaoCard
            // 
            this.btn_KakaoCard.BackColor = System.Drawing.Color.Yellow;
            this.btn_KakaoCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KakaoCard.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_KakaoCard.Location = new System.Drawing.Point(309, 376);
            this.btn_KakaoCard.Name = "btn_KakaoCard";
            this.btn_KakaoCard.Size = new System.Drawing.Size(267, 51);
            this.btn_KakaoCard.TabIndex = 23;
            this.btn_KakaoCard.Text = "카카오페이 카드";
            this.btn_KakaoCard.UseVisualStyleBackColor = false;
            this.btn_KakaoCard.Click += new System.EventHandler(this.btn_KakaoCard_Click);
            // 
            // btn_KakaoMoney
            // 
            this.btn_KakaoMoney.BackColor = System.Drawing.Color.Yellow;
            this.btn_KakaoMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KakaoMoney.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_KakaoMoney.Location = new System.Drawing.Point(36, 376);
            this.btn_KakaoMoney.Name = "btn_KakaoMoney";
            this.btn_KakaoMoney.Size = new System.Drawing.Size(267, 51);
            this.btn_KakaoMoney.TabIndex = 22;
            this.btn_KakaoMoney.Text = "카카오페이 머니";
            this.btn_KakaoMoney.UseVisualStyleBackColor = false;
            this.btn_KakaoMoney.Click += new System.EventHandler(this.btn_KakaoMoney_Click);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(468, 237);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(166, 21);
            this.tb_email.TabIndex = 21;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(243, 237);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(166, 21);
            this.tb_num.TabIndex = 20;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(93, 237);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(82, 21);
            this.tb_name.TabIndex = 19;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb3.Location = new System.Drawing.Point(273, 119);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(123, 19);
            this.rb3.TabIndex = 16;
            this.rb3.Text = "배송(3,200)원";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb2.Location = new System.Drawing.Point(147, 119);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(100, 19);
            this.rb2.TabIndex = 17;
            this.rb2.Text = "모바일티켓";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb1.Location = new System.Drawing.Point(34, 119);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(85, 19);
            this.rb1.TabIndex = 18;
            this.rb1.Text = "현장수령";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // cb_Card
            // 
            this.cb_Card.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Card.FormattingEnabled = true;
            this.cb_Card.Items.AddRange(new object[] {
            "카드를 선택해주세요.",
            "삼성카드",
            "KB국민카드",
            "현대카드",
            "BC카드",
            "신한카드",
            "NH농협카드",
            "NH문화누리카드",
            "하나카드",
            "롯데카드",
            "씨티카드",
            "카카오뱅크카드",
            "카카오페이카드",
            "케이뱅크카드",
            "우리카드",
            "광주카드",
            "전북카드",
            "수협카드",
            "KDB산업은행카드",
            "제주카드"});
            this.cb_Card.Location = new System.Drawing.Point(12, 22);
            this.cb_Card.Name = "cb_Card";
            this.cb_Card.Size = new System.Drawing.Size(361, 23);
            this.cb_Card.TabIndex = 9;
            // 
            // gb_Card
            // 
            this.gb_Card.Controls.Add(this.label4);
            this.gb_Card.Controls.Add(this.cb_Card);
            this.gb_Card.Controls.Add(this.cb_n);
            this.gb_Card.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_Card.Location = new System.Drawing.Point(36, 511);
            this.gb_Card.Name = "gb_Card";
            this.gb_Card.Size = new System.Drawing.Size(540, 128);
            this.gb_Card.TabIndex = 26;
            this.gb_Card.TabStop = false;
            this.gb_Card.Text = "카드";
            this.gb_Card.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(9, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "*할부 개월은 카드 결제 단계에서 선택 가능합니다.";
            // 
            // cb_n
            // 
            this.cb_n.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_n.FormattingEnabled = true;
            this.cb_n.Items.AddRange(new object[] {
            "무이자",
            "2개월",
            "3개월"});
            this.cb_n.Location = new System.Drawing.Point(410, 22);
            this.cb_n.Name = "cb_n";
            this.cb_n.Size = new System.Drawing.Size(113, 23);
            this.cb_n.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(663, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(627, 608);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb4.Location = new System.Drawing.Point(671, 61);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(481, 19);
            this.cb4.TabIndex = 31;
            this.cb4.Text = "[필수] 예매 및 취소 수수료 / 취소기한을 확인하였으며 동의합니다.";
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb4_CheckedChanged);
            // 
            // cb_All
            // 
            this.cb_All.AutoSize = true;
            this.cb_All.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_All.Location = new System.Drawing.Point(1192, 16);
            this.cb_All.Name = "cb_All";
            this.cb_All.Size = new System.Drawing.Size(90, 19);
            this.cb_All.TabIndex = 30;
            this.cb_All.Text = "전체동의";
            this.cb_All.UseVisualStyleBackColor = true;
            this.cb_All.CheckedChanged += new System.EventHandler(this.cb_All_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb3.Location = new System.Drawing.Point(672, 429);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(368, 19);
            this.cb3.TabIndex = 34;
            this.cb3.Text = "[필수] 개인정보 제3자 제공 동의 및 주의사항       ";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb1.Location = new System.Drawing.Point(672, 347);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(365, 19);
            this.cb1.TabIndex = 32;
            this.cb1.Text = "[필수] 카카오 전자금융 이용약관 동의                ";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb2.Location = new System.Drawing.Point(672, 388);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(376, 19);
            this.cb2.TabIndex = 33;
            this.cb2.Text = "[필수] 개인정보 수집/이용에 동의합니다.              ";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1296, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 651);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(69, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "* ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(659, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(2, 719);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1291, -7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(2, 719);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(1296, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 45);
            this.label8.TabIndex = 39;
            this.label8.Text = "SUPER JUNIOR\r\n20th Anniversary TOUR\r\n〈SUPER SHOW 10〉 in SEOUL";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(1365, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "2025년 8월 21일(목) 10:59까지";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(1318, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "2025.08.22(금) 20:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(216, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 45);
            this.label2.TabIndex = 42;
            this.label2.Text = "                              \r\n                            \r\n                   " +
    "            ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.White;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Back.Location = new System.Drawing.Point(1300, 591);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(125, 50);
            this.btn_Back.TabIndex = 43;
            this.btn_Back.Text = "<   이전";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.Transparent;
            this.btn_Pay.FlatAppearance.BorderSize = 0;
            this.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pay.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Pay.Location = new System.Drawing.Point(1425, 590);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(125, 50);
            this.btn_Pay.TabIndex = 44;
            this.btn_Pay.Text = "결제하기";
            this.btn_Pay.UseVisualStyleBackColor = false;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1309, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 45);
            this.label3.TabIndex = 45;
            this.label3.Text = "                              \r\n                            \r\n                   " +
    "            ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_Price2_2
            // 
            this.lb_Price2_2.AutoSize = true;
            this.lb_Price2_2.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Price2_2.Location = new System.Drawing.Point(1476, 302);
            this.lb_Price2_2.Name = "lb_Price2_2";
            this.lb_Price2_2.Size = new System.Drawing.Size(11, 12);
            this.lb_Price2_2.TabIndex = 73;
            this.lb_Price2_2.Text = "0";
            // 
            // lb_TotalPrice2
            // 
            this.lb_TotalPrice2.AutoSize = true;
            this.lb_TotalPrice2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_TotalPrice2.ForeColor = System.Drawing.Color.LimeGreen;
            this.lb_TotalPrice2.Location = new System.Drawing.Point(1421, 484);
            this.lb_TotalPrice2.Name = "lb_TotalPrice2";
            this.lb_TotalPrice2.Size = new System.Drawing.Size(22, 21);
            this.lb_TotalPrice2.TabIndex = 72;
            this.lb_TotalPrice2.Text = "0";
            // 
            // lb_sit2
            // 
            this.lb_sit2.AutoSize = true;
            this.lb_sit2.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_sit2.Location = new System.Drawing.Point(1318, 162);
            this.lb_sit2.Name = "lb_sit2";
            this.lb_sit2.Size = new System.Drawing.Size(11, 13);
            this.lb_sit2.TabIndex = 71;
            this.lb_sit2.Text = " ";
            // 
            // lb_Price_2
            // 
            this.lb_Price_2.AutoSize = true;
            this.lb_Price_2.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Price_2.Location = new System.Drawing.Point(1454, 274);
            this.lb_Price_2.Name = "lb_Price_2";
            this.lb_Price_2.Size = new System.Drawing.Size(16, 15);
            this.lb_Price_2.TabIndex = 70;
            this.lb_Price_2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(1422, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 74;
            this.label9.Text = "               ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(1411, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 75;
            this.label10.Text = "               ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(1411, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 76;
            this.label11.Text = "               ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(1424, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 77;
            this.label12.Text = "               ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_delivery
            // 
            this.lb_delivery.AutoSize = true;
            this.lb_delivery.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_delivery.Location = new System.Drawing.Point(1470, 434);
            this.lb_delivery.Name = "lb_delivery";
            this.lb_delivery.Size = new System.Drawing.Size(48, 15);
            this.lb_delivery.TabIndex = 78;
            this.lb_delivery.Text = "3,200";
            this.lb_delivery.Visible = false;
            // 
            // Pay2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 651);
            this.Controls.Add(this.lb_delivery);
            this.Controls.Add(this.lb_Price2_2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_TotalPrice2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_Price_2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_sit2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.btn_Card);
            this.Controls.Add(this.btn_KakaoCard);
            this.Controls.Add(this.btn_KakaoMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb_All);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Deposit);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.gb_Card);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pay2";
            this.Text = "Pay2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_Card.ResumeLayout(false);
            this.gb_Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Deposit;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Button btn_Card;
        private System.Windows.Forms.Button btn_KakaoCard;
        private System.Windows.Forms.Button btn_KakaoMoney;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.ComboBox cb_Card;
        private System.Windows.Forms.GroupBox gb_Card;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_n;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb_All;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Price2_2;
        private System.Windows.Forms.Label lb_TotalPrice2;
        private System.Windows.Forms.Label lb_sit2;
        private System.Windows.Forms.Label lb_Price_2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_delivery;
    }
}