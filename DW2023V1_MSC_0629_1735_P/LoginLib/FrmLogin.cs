using DBMS_V1;
using DeviceChecker;
using DwLib.Data;
using DwLib.Data.Generic;
using DWLib.Data.Generic;
using EventLog;
using log4net;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginLib
{
    public partial class FrmLogin : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnDeviceCheck = new System.Windows.Forms.Button();
            this.pwBox1 = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxLog = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(124)))), ((int)(((byte)(245)))));
            this.splitContainer1.Panel1.BackgroundImage = global::LoginLib.Properties.Resources.logo2;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(484, 560);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 100;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.tbxLog);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Size = new System.Drawing.Size(484, 489);
            this.splitContainer2.SplitterDistance = 271;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Panel2.Controls.Add(this.label7);
            this.splitContainer3.Panel2.Controls.Add(this.btnClose);
            this.splitContainer3.Panel2.Controls.Add(this.btnLogin);
            this.splitContainer3.Panel2.Controls.Add(this.btnDeviceCheck);
            this.splitContainer3.Panel2.Controls.Add(this.pwBox1);
            this.splitContainer3.Panel2.Controls.Add(this.tbxId);
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Size = new System.Drawing.Size(484, 271);
            this.splitContainer3.SplitterDistance = 200;
            this.splitContainer3.TabIndex = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 6.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 48);
            this.label2.TabIndex = 101;
            this.label2.Text = "시험장치를 사용하기 위해\r\n생성된 아이디와 비밀번호를\r\n 입력하세요.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 102;
            this.label1.Text = "로그인";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(198, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "취소";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(112, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(70, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnDeviceCheck
            // 
            this.btnDeviceCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(156)))), ((int)(((byte)(0)))));
            this.btnDeviceCheck.FlatAppearance.BorderSize = 0;
            this.btnDeviceCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeviceCheck.Font = new System.Drawing.Font("Noto Sans", 6.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeviceCheck.ForeColor = System.Drawing.Color.White;
            this.btnDeviceCheck.Location = new System.Drawing.Point(24, 216);
            this.btnDeviceCheck.Name = "btnDeviceCheck";
            this.btnDeviceCheck.Size = new System.Drawing.Size(70, 40);
            this.btnDeviceCheck.TabIndex = 2;
            this.btnDeviceCheck.Text = "장치 체크";
            this.btnDeviceCheck.UseVisualStyleBackColor = false;
            this.btnDeviceCheck.Click += new System.EventHandler(this.BtnDeviceCheck_Click);
            // 
            // pwBox1
            // 
            this.pwBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.pwBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwBox1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwBox1.Location = new System.Drawing.Point(82, 160);
            this.pwBox1.Name = "pwBox1";
            this.pwBox1.PasswordChar = '*';
            this.pwBox1.Size = new System.Drawing.Size(186, 25);
            this.pwBox1.TabIndex = 1;
            this.pwBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pwBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PwBox1_MouseClick);
            this.pwBox1.TextChanged += new System.EventHandler(this.PwBox1_TextChanged);
            // 
            // tbxId
            // 
            this.tbxId.BackColor = System.Drawing.Color.Cornsilk;
            this.tbxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxId.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxId.Location = new System.Drawing.Point(82, 64);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(186, 25);
            this.tbxId.TabIndex = 0;
            this.tbxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxId.Click += new System.EventHandler(this.TbxId_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(80, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(80, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "아이디";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Copyright 2023. Doowon All Rights Reserved.";
            // 
            // tbxLog
            // 
            this.tbxLog.BackColor = System.Drawing.Color.LightGray;
            this.tbxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxLog.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLog.ForeColor = System.Drawing.Color.Red;
            this.tbxLog.Location = new System.Drawing.Point(12, 36);
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ReadOnly = true;
            this.tbxLog.Size = new System.Drawing.Size(460, 146);
            this.tbxLog.TabIndex = 5;
            this.tbxLog.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "로그";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = global::LoginLib.Properties.Resources.icon_pw_30;
            this.label8.Location = new System.Drawing.Point(26, 148);
            this.label8.MaximumSize = new System.Drawing.Size(40, 40);
            this.label8.MinimumSize = new System.Drawing.Size(40, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 40);
            this.label8.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Image = global::LoginLib.Properties.Resources.id_30;
            this.label7.Location = new System.Drawing.Point(26, 52);
            this.label7.MaximumSize = new System.Drawing.Size(40, 40);
            this.label7.MinimumSize = new System.Drawing.Size(40, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 40);
            this.label7.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 560);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MinimumSizeChanged += new System.EventHandler(this.Form1_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnDeviceCheck;
        private System.Windows.Forms.TextBox pwBox1;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tbxLog;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        //================================================================================================================================


        public FrmLogin()
        {
            InitializeComponent();
            FormStyleSettigns();
        }

        private string m_loginID;
        private string m_loginTime;
        readonly MySqlDTO cMysqlDto = new MySqlDTO();
        readonly FrmCommCheck cFrmCommCheck = null;
        private readonly LoginWriteLog cLwLog = new LoginWriteLog();
        private static readonly ILog cLog = LogManager.GetLogger("Measure");
        string m_sProgramName = "";
        int m_ProgId = 0;

        private void ProgramNameSetting(int programId)
        {
            m_ProgId = programId;
            if (programId == 1)
            {
                m_sProgramName = "측정프로그램";
            }
            else if (programId == 2)
            {
                m_sProgramName = "분석프로그램";
            }
        }


        public FrmLogin(int programId, string s_mbid)
        {
            InitializeComponent();
            FormStyleSettigns();
            ProgramNameSetting(programId);
            if (CommonClass.isDeveloperMode)
            {
                tbxId.Text = "ID0001";
                pwBox1.Text = "1234";

            }

            cFrmCommCheck = new FrmCommCheck();
            switch (programId)
            {
                case 1:
                    DeviceCheck();
                    break;
                case 2:
                    CheckDeviceDB();
                    break;

            }

            if (string.IsNullOrEmpty(s_mbid)) { }
            else
            {
                switch (programId)
                {
                    case 1:
                        LoginLogic(CommonClass.ms_programId);//, s_mbid, CommonClass.mbpwd);
                        break;

                    case 2:
                        LoginLogic(CommonClass.an_programId);//, s_mbid, CommonClass.mbpwd);
                        break;

                }

            }



        }

        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }

        private void FormStyleSettigns()
        {
            this.Text = CommonClass.program_title;
            this.ControlBox = false;

        }

        private void LoginLogic(int programId)//, string mbid = "", string mbpwd = "")
        {
            bool isOk = cMysqlDto.Open();
            if (isOk == false) { return; }

            //if (string.IsNullOrEmpty(CommonClass.mbid) == false && string.IsNullOrEmpty(CommonClass.mbpwd) == false)
            //{
            //    tbxId.Text = CommonClass.mbid;
            //    loginID = CommonClass.mbid;
            //    pwBox1.Text = CommonClass.mbpwd;
            //    switch (programId)
            //    {
            //        case 1: CommonClass.ms_mbno = "1"; break;
            //        case 2: CommonClass.an_mbno = "1"; break;
            //    }

            //}
            //else
            //{
            if (string.IsNullOrWhiteSpace(tbxId.Text))
            {
                tbxLog.Text = "ID 를 입력해 주세요";
                tbxId.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(pwBox1.Text))
            {
                tbxLog.Text = "비밀번호를 입력해 주세요";
                pwBox1.Focus();
                return;
            }
            else if (tbxId.Text.Length < 4)
            {
                tbxLog.Text = "ID를 4자이상 입력해 주세요";
                tbxId.Focus();
                return;
            }
            else if (pwBox1.Text.Length < 4)
            {
                tbxLog.Text = "비밀번호를 4자 이상 입력해 주세요";
                pwBox1.Focus();
                return;
            }
            m_loginID = tbxId.Text;
            switch (programId)
            {
                case 1: Measure.mbno = "0"; break;
                case 2: Analysis.mbno = "0"; break;
            }
            //}

            try
            {

                string latestsalt = "";
                string sql = $"SELECT logintime FROM tbl_loginout WHERE tbl_loginout.mbid =\"{tbxId.Text}\" order by logintime desc\r\nlimit 1; ";

                List<Dictionary<string, string>> dicReturn = new List<Dictionary<string, string>>();
                Dictionary<string, string> row = new Dictionary<string, string>();
                dicReturn = cMysqlDto.SelectSql2(sql, "logintime");

                if (dicReturn.Count == 0)
                {
                    tbxLog.Text = "해당  ID가 존재하지 않습니다.";
                    tbxId.Focus();
                    return;
                }

                row = dicReturn[0];
                if (row != null)
                {
                    latestsalt = row["logintime"].ToString(); //최종 로그인시간
                }

                string result = DWSHA256.EncryptionHelper.SHA256_Salt(pwBox1.Text, latestsalt);//최종로그인시간과 입력한 pw값 암호화

                sql = $"SELECT id, pwd, mbno, use10,out10 FROM tbl_member WHERE tbl_member.id =\"{tbxId.Text}\"";

                Dictionary<string, string> row2 = cMysqlDto.SelectSql2(sql, "id", "pwd", "mbno", "use10", "out10")[0];
                if (row != null)
                {
                    string s_use10 = row2["use10"].ToString();
                    string s_out10 = row2["out10"].ToString();
                    string s_pwd = row2["pwd"].ToString();
                    string s_mbno = row2["mbno"].ToString();
                    string s_id = row2["id"].ToString();

                    if (s_use10.Equals("1") && s_out10.Equals("0"))
                    {
                        if (result.Equals(s_pwd)) //저장된 pw와 result 값이 같으면
                        {

                            string salt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            m_loginTime = salt;
                            string pwupdate = DWSHA256.EncryptionHelper.SHA256_Salt(pwBox1.Text, salt); //pw새로운시간으로 업데이트
                            cMysqlDto.Close();

                            sql = $"update tbl_member set tbl_member.pwd=\"{pwupdate}\" WHERE tbl_member.id =\"{tbxId.Text}\"";
                            cMysqlDto.OpenKeepUp();
                            cMysqlDto.RunSql("UPDATE", sql);
                            cMysqlDto.Close();

                            sql = $"insert into tbl_loginout(logintime,mbid,logouttime,exeloc) values(\"{m_loginTime}\",\"{m_loginID}\",\"{""}\",'')";
                            cMysqlDto.OpenKeepUp();
                            cMysqlDto.RunSql("INSERT", sql);
                            cMysqlDto.Close();

                            if (programId == 1)
                            {
                                Measure.program_run = true;
                                Measure.mbno = s_mbno;
                                Measure.mbid = m_loginID;
                                Measure.mbpwd = pwBox1.Text;

                                Measure.loginTime = m_loginTime;
                                Measure.loginok = "login";
                                Measure.isExit = false;
                                LoginResultSettings(programId, true, false);
                                if (CommonClass.IsDBCtrlConn10 == false)
                                {
                                    if (MessageBox.Show("데이터베이스가 연결되어 있지 않습니다.\r\n그럼에도 연결하시겠습니까?", "로그인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                    {
                                        return;
                                    }
                                }
                                if (CommonClass.IsHmiCtrlConn10 == false || CommonClass.IsRecoCtrlConn10 == false)
                                {
                                    if (MessageBox.Show("장치가 연결되어 있지 않습니다.\r\n그럼에도 연결하시겠습니까?", "로그인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                    {
                                        return;
                                    }
                                }
                                this.Close();

                            }
                            else if (programId == 2)
                            {
                                Analysis.program_run = true;
                                Analysis.mbno = s_mbno;
                                Analysis.mbid = m_loginID;
                                Analysis.mbpwd = pwBox1.Text;

                                Analysis.loginTime = m_loginTime;
                                Analysis.loginok = "login";
                                Analysis.isExit = false;
                                LoginResultSettings(programId, true, false);

                                this.Close();

                            }

                        }

                        else
                        {
                            tbxLog.Text = "해당 비밀번호가 일치하지 않습니다.";
                            cLog.Info(cLwLog.LoginError);
                            LoginResultSettings(programId,false, true);

                        }

                    }
                    else
                    {
                        tbxLog.Text = "사용할 수 없는 아이디입니다.";
                        cLog.Info(cLwLog.LoginError);
                        LoginResultSettings(programId,false, true);

                    }
                }
                else
                {
                    tbxLog.Text = "존재하지않는 아이디 입니다.";
                    cLog.Info(cLwLog.LoginError);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cMysqlDto.Close();
            }

        }

        private void LoginResultSettings(int programId, bool isLoginResult,bool isExitEnable)
        {
            switch (programId)
            {
                case 1:
                    Measure.loginSuccess = isLoginResult;
                    Measure.program_exit = isExitEnable;
                    break;
                case 2:
                    Analysis.loginSuccess = isLoginResult;
                    Analysis.program_exit = isExitEnable;
                    break;
            }
        }

        private void CheckDeviceDB()
        {
            if (cFrmCommCheck != null)
            {
                if (cFrmCommCheck.IsDbCheck())
                {
                    tbxLog.Text = cFrmCommCheck.DeviceCheckString;
                    Task.Delay(1000).GetAwaiter().GetResult();

                }
                else
                {
                    tbxLog.Text = cFrmCommCheck.DeviceCheckString;
                    btnDeviceCheck.Visible = true;
                }
            }
        }

        private void DeviceCheck()
        {
            if (cFrmCommCheck != null)
            {
                if (cFrmCommCheck.IsDeviceLsitCheck(programId: 1, projectName: "MSC"))
                {
                    tbxLog.Text = cFrmCommCheck.DeviceCheckString;
                    Task.Delay(1000).GetAwaiter().GetResult();
                }
                else
                {
                    tbxLog.Text = cFrmCommCheck.DeviceCheckString;
                    btnDeviceCheck.Visible = true;
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("로그인을 취소 하고, 프로그램을 종료하시겠습니까?", "취소", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Environment.Exit(0);
            }
            else
            {

            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (tbxId.Text.Equals(""))// || pwBox1.Text==null)
            {
                MessageBox.Show("아이디를 입력하세요", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pwBox1.Text.Equals(""))
            {
                MessageBox.Show("비밀번호를 입력하세요", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (InputDataCheck() == false)
            {
                return;
            }

            LoginLogic(programId: m_ProgId);

        }

        private bool InputDataCheck()
        {

            tbxId.Text = Util.InputdataCheckEngNum(m_sProgramName, tbxId.Text);
            bool isOk = string.IsNullOrEmpty(tbxId.Text) == false;
            if (isOk == false) return isOk;


            pwBox1.Text = Util.InputdataCheckEngNumSpectial(m_sProgramName, pwBox1.Text);
            isOk = string.IsNullOrEmpty(pwBox1.Text) == false;
            if (isOk == false) return isOk;

            return isOk;
        }

        public void LogoutUpdateDB(string mbid, string logouttime, string exeLocation, int programId)
        {

            //string sql = $"update tbl_loginout set  logouttime= '" + logouttime + "', exeloc='" + exeLocation + "'"
            //    + " where mbid='" + mbid + "' and logintime='" + CommonClass.loginTime + "'";
            string strLoginTime = "";// DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sql;
            switch (programId)
            {
                case 1: strLoginTime = Measure.loginTime; break;
                case 2: strLoginTime = Analysis.loginTime; break;

            }

            sql = $@"update tbl_loginout set  logouttime= '{logouttime}', exeloc='{exeLocation}' 
                    where mbid='{mbid}' and logintime='{strLoginTime}'";

            cMysqlDto.OpenKeepUp();
            cMysqlDto.RunSql("UPDATE", sql);
            cMysqlDto.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (tbxId != null)
            {
                this.ActiveControl = tbxId;
                tbxId.Focus();
                if (tbxId.Text.Length > 0)
                {

                    tbxId.SelectionStart = tbxId.Text.Length;
                }
            }
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            return;
        }

        #region // 타이틀바 더블클릭 방지
        private const int WM_NCLBUTTONDBLCLK = 0xA3;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCLBUTTONDBLCLK:
                    if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
                        this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    return;
                default:
                    break;
            }

            base.WndProc(ref m);
        }
        #endregion

        private void BtnDeviceCheck_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DeviceCheck();
            this.Cursor = Cursors.Default;
        }

        private void TbxId_Click(object sender, EventArgs e)
        {
            if (tbxId != null)
            {
            }
        }

        private void PwBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PwBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pwBox1 != null)
            {

            }
        }
    }
}
