namespace ConcertTicketing
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Friday = new System.Windows.Forms.Button();
            this.btn_Saturday = new System.Windows.Forms.Button();
            this.btn_Sunday = new System.Windows.Forms.Button();
            this.lb_choice_day = new System.Windows.Forms.Label();
            this.btn_Reserve = new System.Windows.Forms.Button();
            this.pb_time_Friday = new System.Windows.Forms.PictureBox();
            this.pb_time_Saturday = new System.Windows.Forms.PictureBox();
            this.pb_time_Sunday = new System.Windows.Forms.PictureBox();
            this.lb_Login_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TimeNow = new System.Windows.Forms.TextBox();
            this.btn_TimeNow = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_time_Friday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_time_Saturday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_time_Sunday)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1009, 886);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Login.Location = new System.Drawing.Point(633, 7);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(61, 23);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "로그인";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Friday
            // 
            this.btn_Friday.BackColor = System.Drawing.Color.White;
            this.btn_Friday.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Friday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Friday.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Friday.Location = new System.Drawing.Point(32, 604);
            this.btn_Friday.Name = "btn_Friday";
            this.btn_Friday.Size = new System.Drawing.Size(293, 46);
            this.btn_Friday.TabIndex = 3;
            this.btn_Friday.Text = "2025년 08월 22일 금요일";
            this.btn_Friday.UseVisualStyleBackColor = false;
            this.btn_Friday.Click += new System.EventHandler(this.btn_Friday_Click);
            // 
            // btn_Saturday
            // 
            this.btn_Saturday.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Saturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Saturday.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Saturday.Location = new System.Drawing.Point(32, 651);
            this.btn_Saturday.Name = "btn_Saturday";
            this.btn_Saturday.Size = new System.Drawing.Size(293, 46);
            this.btn_Saturday.TabIndex = 3;
            this.btn_Saturday.Text = "2025년 08월 23일 토요일";
            this.btn_Saturday.UseVisualStyleBackColor = true;
            this.btn_Saturday.Click += new System.EventHandler(this.btn_Saturday_Click);
            // 
            // btn_Sunday
            // 
            this.btn_Sunday.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Sunday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sunday.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Sunday.Location = new System.Drawing.Point(32, 698);
            this.btn_Sunday.Name = "btn_Sunday";
            this.btn_Sunday.Size = new System.Drawing.Size(293, 46);
            this.btn_Sunday.TabIndex = 3;
            this.btn_Sunday.Text = "2025년 08월 24일 일요일";
            this.btn_Sunday.UseVisualStyleBackColor = true;
            this.btn_Sunday.Click += new System.EventHandler(this.btn_Sunday_Click);
            // 
            // lb_choice_day
            // 
            this.lb_choice_day.AutoSize = true;
            this.lb_choice_day.BackColor = System.Drawing.Color.White;
            this.lb_choice_day.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_choice_day.Location = new System.Drawing.Point(609, 667);
            this.lb_choice_day.Name = "lb_choice_day";
            this.lb_choice_day.Size = new System.Drawing.Size(163, 15);
            this.lb_choice_day.TabIndex = 4;
            this.lb_choice_day.Text = "날짜를 선택해주세요!";
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reserve.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Reserve.ForeColor = System.Drawing.Color.White;
            this.btn_Reserve.Location = new System.Drawing.Point(727, 826);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Size = new System.Drawing.Size(262, 56);
            this.btn_Reserve.TabIndex = 6;
            this.btn_Reserve.Text = "예매하기";
            this.btn_Reserve.UseVisualStyleBackColor = false;
            this.btn_Reserve.Click += new System.EventHandler(this.btn_Reserve_Click);
            // 
            // pb_time_Friday
            // 
            this.pb_time_Friday.Image = ((System.Drawing.Image)(resources.GetObject("pb_time_Friday.Image")));
            this.pb_time_Friday.Location = new System.Drawing.Point(371, 602);
            this.pb_time_Friday.Name = "pb_time_Friday";
            this.pb_time_Friday.Size = new System.Drawing.Size(606, 149);
            this.pb_time_Friday.TabIndex = 7;
            this.pb_time_Friday.TabStop = false;
            this.pb_time_Friday.Visible = false;
            // 
            // pb_time_Saturday
            // 
            this.pb_time_Saturday.Image = ((System.Drawing.Image)(resources.GetObject("pb_time_Saturday.Image")));
            this.pb_time_Saturday.Location = new System.Drawing.Point(377, 604);
            this.pb_time_Saturday.Name = "pb_time_Saturday";
            this.pb_time_Saturday.Size = new System.Drawing.Size(606, 149);
            this.pb_time_Saturday.TabIndex = 8;
            this.pb_time_Saturday.TabStop = false;
            this.pb_time_Saturday.Visible = false;
            // 
            // pb_time_Sunday
            // 
            this.pb_time_Sunday.Image = ((System.Drawing.Image)(resources.GetObject("pb_time_Sunday.Image")));
            this.pb_time_Sunday.Location = new System.Drawing.Point(383, 604);
            this.pb_time_Sunday.Name = "pb_time_Sunday";
            this.pb_time_Sunday.Size = new System.Drawing.Size(606, 149);
            this.pb_time_Sunday.TabIndex = 9;
            this.pb_time_Sunday.TabStop = false;
            this.pb_time_Sunday.Visible = false;
            // 
            // lb_Login_ID
            // 
            this.lb_Login_ID.AutoSize = true;
            this.lb_Login_ID.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Login_ID.Location = new System.Drawing.Point(555, 10);
            this.lb_Login_ID.Name = "lb_Login_ID";
            this.lb_Login_ID.Size = new System.Drawing.Size(12, 13);
            this.lb_Login_ID.TabIndex = 10;
            this.lb_Login_ID.Text = " ";
            this.lb_Login_ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(582, 698);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "                                                       \r\n                        " +
    "                    \r\n";
            // 
            // tb_TimeNow
            // 
            this.tb_TimeNow.Location = new System.Drawing.Point(674, 163);
            this.tb_TimeNow.Name = "tb_TimeNow";
            this.tb_TimeNow.Size = new System.Drawing.Size(334, 21);
            this.tb_TimeNow.TabIndex = 12;
            // 
            // btn_TimeNow
            // 
            this.btn_TimeNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimeNow.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_TimeNow.Location = new System.Drawing.Point(533, 163);
            this.btn_TimeNow.Name = "btn_TimeNow";
            this.btn_TimeNow.Size = new System.Drawing.Size(135, 21);
            this.btn_TimeNow.TabIndex = 13;
            this.btn_TimeNow.Text = "현재 시간 입력";
            this.btn_TimeNow.UseVisualStyleBackColor = true;
            this.btn_TimeNow.Click += new System.EventHandler(this.btn_TimeNow_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.White;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_LogOut.Location = new System.Drawing.Point(700, 7);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(71, 23);
            this.btn_LogOut.TabIndex = 14;
            this.btn_LogOut.Text = "로그아웃";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 894);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_TimeNow);
            this.Controls.Add(this.tb_TimeNow);
            this.Controls.Add(this.lb_Login_ID);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.lb_choice_day);
            this.Controls.Add(this.btn_Sunday);
            this.Controls.Add(this.btn_Saturday);
            this.Controls.Add(this.btn_Friday);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pb_time_Sunday);
            this.Controls.Add(this.pb_time_Saturday);
            this.Controls.Add(this.pb_time_Friday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainScreen";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_time_Friday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_time_Saturday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_time_Sunday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Friday;
        private System.Windows.Forms.Button btn_Saturday;
        private System.Windows.Forms.Button btn_Sunday;
        private System.Windows.Forms.Label lb_choice_day;
        private System.Windows.Forms.Button btn_Reserve;
        private System.Windows.Forms.PictureBox pb_time_Friday;
        private System.Windows.Forms.PictureBox pb_time_Saturday;
        private System.Windows.Forms.PictureBox pb_time_Sunday;
        private System.Windows.Forms.Label lb_Login_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TimeNow;
        private System.Windows.Forms.Button btn_TimeNow;
        private System.Windows.Forms.Button btn_LogOut;
    }
}