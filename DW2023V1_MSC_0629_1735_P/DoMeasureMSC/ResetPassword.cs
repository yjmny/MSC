using DBMS_V1;
using DwLib.Data;
using DwLib.Data.Generic;
using System;
using System.Windows.Forms;

namespace DoMeasureMSC
{
    public partial class ResetPassword : Form
    {

        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pwbox = new System.Windows.Forms.TextBox();
            this.checkpwbox = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(43, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(43, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호 확인";
            // 
            // pwbox
            // 
            this.pwbox.BackColor = System.Drawing.Color.Cornsilk;
            this.pwbox.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwbox.Location = new System.Drawing.Point(182, 199);
            this.pwbox.Name = "pwbox";
            this.pwbox.Size = new System.Drawing.Size(258, 26);
            this.pwbox.TabIndex = 2;
            this.pwbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkpwbox
            // 
            this.checkpwbox.BackColor = System.Drawing.Color.Cornsilk;
            this.checkpwbox.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkpwbox.Location = new System.Drawing.Point(182, 276);
            this.checkpwbox.Name = "checkpwbox";
            this.checkpwbox.Size = new System.Drawing.Size(258, 26);
            this.checkpwbox.TabIndex = 3;
            this.checkpwbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(285, 519);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 40);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(384, 519);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pwbox);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkpwbox);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(20, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "비밀번호 초기화";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PasswordReset";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwbox;
        private System.Windows.Forms.TextBox checkpwbox;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        //================================================================================================================================


        public ResetPassword()
        {
            InitializeComponent();
            this.Text = CommonClass.program_title;
        }

        public static string user_id;

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (pwbox.Text.ToString() == "" || checkpwbox.Text.ToString() == "")
            {
                MessageBox.Show("값을 입력하세요", "초기화", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (pwbox.Text.Length < 4)
                {
                    MessageBox.Show("비밀번호를 4자이상 입력해 주세요.", "초기화", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    pwbox.Focus();
                    return;
                }
                if (pwbox.Text.ToString() != checkpwbox.Text.ToString())
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다.", "초기화", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                else
                {
                    string salt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string resetpw = DWSHA256.EncryptionHelper.SHA256_Salt(pwbox.Text, salt);
                    MySqlDTO msdto = new MySqlDTO();
                    msdto.OpenKeepUp();
                    string dbsql = $"update tbl_member set tbl_member.pwd=\"{resetpw}\" WHERE tbl_member.id =\"{user_id}\"";
                    msdto.RunSql("UPDATE", dbsql);

                    MessageBox.Show("변경완료", btn.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbsql = $"insert into tbl_loginout(logintime,mbid,exeloc) values(\"{salt}\",\"{user_id}\",'reset')";
                    msdto.RunSql("INSERT", dbsql);
                    pwbox.Text = "";
                    checkpwbox.Text = "";
                }

            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료 하시겠습니까?", "닫기", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }

        }
    }
}
