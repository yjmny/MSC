using DoMeasureMSC.Pages;
using DBMS_V1;
using EventLog;
using DwLib.Data.Generic;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;


namespace DoMeasureMSC
{
    public partial class RecipeWindow : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.btnShowAllList = new System.Windows.Forms.Button();
            this.dgvTableRecipeList = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRecipeChoose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboSearchWord = new C1.Win.C1Input.C1ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableRecipeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSearchWord)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "레시피 선택";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(124)))), ((int)(((byte)(245)))));
            this.btnSearch.Image = global::DoMeasureMSC.Properties.Resources.find;
            this.btnSearch.Location = new System.Drawing.Point(652, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 14;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnShowAllList
            // 
            this.btnShowAllList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnShowAllList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnShowAllList.FlatAppearance.BorderSize = 0;
            this.btnShowAllList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllList.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShowAllList.Location = new System.Drawing.Point(690, 66);
            this.btnShowAllList.Name = "btnShowAllList";
            this.btnShowAllList.Size = new System.Drawing.Size(100, 32);
            this.btnShowAllList.TabIndex = 13;
            this.btnShowAllList.Text = "전체조회";
            this.btnShowAllList.UseVisualStyleBackColor = false;
            this.btnShowAllList.Click += new System.EventHandler(this.BtnShowAllList_Click);
            // 
            // dgvTableRecipeList
            // 
            this.dgvTableRecipeList.AllowUserToAddRows = false;
            this.dgvTableRecipeList.AllowUserToDeleteRows = false;
            this.dgvTableRecipeList.AllowUserToResizeColumns = false;
            this.dgvTableRecipeList.AllowUserToResizeRows = false;
            this.dgvTableRecipeList.BackgroundColor = System.Drawing.Color.White;
            this.dgvTableRecipeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTableRecipeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableRecipeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableRecipeList.ColumnHeadersHeight = 50;
            this.dgvTableRecipeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTableRecipeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.name,
            this.id,
            this.method});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableRecipeList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTableRecipeList.EnableHeadersVisualStyles = false;
            this.dgvTableRecipeList.Location = new System.Drawing.Point(31, 104);
            this.dgvTableRecipeList.Name = "dgvTableRecipeList";
            this.dgvTableRecipeList.RowHeadersVisible = false;
            this.dgvTableRecipeList.RowTemplate.Height = 23;
            this.dgvTableRecipeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableRecipeList.Size = new System.Drawing.Size(760, 309);
            this.dgvTableRecipeList.TabIndex = 15;
            this.dgvTableRecipeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTableRecipeList_CellDoubleClick);
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.no.DefaultCellStyle = dataGridViewCellStyle2;
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.no.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "레시피명";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 200;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "레시피ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 200;
            // 
            // method
            // 
            this.method.DataPropertyName = "method";
            this.method.HeaderText = "시험방법";
            this.method.Name = "method";
            this.method.ReadOnly = true;
            this.method.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.method.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.method.Width = 309;
            // 
            // btnRecipeChoose
            // 
            this.btnRecipeChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnRecipeChoose.FlatAppearance.BorderSize = 0;
            this.btnRecipeChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipeChoose.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRecipeChoose.ForeColor = System.Drawing.Color.White;
            this.btnRecipeChoose.Location = new System.Drawing.Point(475, 447);
            this.btnRecipeChoose.Name = "btnRecipeChoose";
            this.btnRecipeChoose.Size = new System.Drawing.Size(209, 40);
            this.btnRecipeChoose.TabIndex = 16;
            this.btnRecipeChoose.Text = "레시피를 측정으로 선택";
            this.btnRecipeChoose.UseVisualStyleBackColor = false;
            this.btnRecipeChoose.Click += new System.EventHandler(this.BtnRecipeChoose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(690, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 40);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // cboSearchWord
            // 
            this.cboSearchWord.AllowSpinLoop = false;
            this.cboSearchWord.BackColor = System.Drawing.Color.Cornsilk;
            this.cboSearchWord.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboSearchWord.GapHeight = 0;
            this.cboSearchWord.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cboSearchWord.Items.Add("전체");
            this.cboSearchWord.Items.Add("레시피명");
            this.cboSearchWord.Items.Add("레시피ID");
            this.cboSearchWord.Location = new System.Drawing.Point(320, 65);
            this.cboSearchWord.Name = "cboSearchWord";
            this.cboSearchWord.Size = new System.Drawing.Size(120, 32);
            this.cboSearchWord.TabIndex = 18;
            this.cboSearchWord.Tag = null;
            this.cboSearchWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.btnShowAllList);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnRecipeChoose);
            this.panel1.Controls.Add(this.cboSearchWord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvTableRecipeList);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 505);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Cornsilk;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch.Location = new System.Drawing.Point(446, 65);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(200, 32);
            this.tbSearch.TabIndex = 25;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RecipeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(842, 514);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecipeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "레시피선택";
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableRecipeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSearchWord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.Button btnShowAllList;
        private System.Windows.Forms.DataGridView dgvTableRecipeList;
        private System.Windows.Forms.Button btnRecipeChoose;
        private System.Windows.Forms.Button btnCancel;
        private C1.Win.C1Input.C1ComboBox cboSearchWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn method;
        private System.Windows.Forms.TextBox tbSearch;
        //================================================================================================================================


        public RecipeWindow()
        {
            InitializeComponent();

            RwSelectRecipeTableList();
            cboSearchWord.SelectedIndex = 0;

        }

        private readonly MeasureWriteLog cMwLog = new MeasureWriteLog();
        private static readonly ILog cLog = LogManager.GetLogger("Measure");
        private readonly MySqlDTO cMysqlDto = new MySqlDTO();

        public void RwSelectRecipeTableList()
        {
            try
            {
                string sql = "select (@num:=@num+1) as no, name,id,  method from tbl_recipe, (select @num:=0) as s where out10=0 order by name asc"; //,
                cMysqlDto.OpenKeepUp();
                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                dgvTableRecipeList.DataSource = dt;
                cMysqlDto.Close();

            }
            catch (Exception)
            {
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.RecipeSearchListClickEventLog);
            System.Windows.Controls.Button btn = sender as System.Windows.Controls.Button;
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                MessageBox.Show("검색어를 입력하세요", "검색", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            string sql = "";

            string strSerchOpt = cboSearchWord.SelectedItem.ToString();

            if (tbSearch.Text.StartsWith("검색어"))
            {
                tbSearch.Text = "";
            }
            cMysqlDto.OpenKeepUp();
            switch (strSerchOpt)
            {
                case "레시피명":
                    sql = $"select count(*) as cnt from tbl_recipe ,(select @num:=0) as s where out10=0 && name like '%{tbSearch.Text}%' ";
                    break;
                case "레시피ID":
                    sql = $"select count(*) as cnt from tbl_recipe ,(select @num:=0) as s where out10=0 && id like '%{tbSearch.Text}%' ";
                    break;

                case "전체":

                    sql = $"select count(*) as cnt from tbl_recipe ,(select @num:=0) as s where out10=0 && (name like '%{tbSearch.Text}%' or id like '%{tbSearch.Text}%')";
                    break;
            }


            try
            {


                int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(sql, "cnt")[0]["cnt"]);
                cMysqlDto.Close();
                if (rowCnt == 0)
                {
                    MessageBox.Show("레시피 정보가 없습니다.", "검색", MessageBoxButton.OK, MessageBoxImage.Information);
                    tbSearch.Text = "";
                    cMysqlDto.Close();
                    return;

                }
            }
            catch (Exception)
            {
                cMysqlDto.Close();
            }

            try
            {
                cMysqlDto.OpenKeepUp();
                switch (strSerchOpt)
                {
                    case "레시피명":
                        sql = $"select (@num:=@num+1) as no, name,  method, id  from tbl_recipe, (select @num:=0) as s  where out10=0 && name like '%{tbSearch.Text}%' ";
                        break;
                    case "레시피ID":
                        sql = $"select (@num:=@num+1) as no, name,  method, id  from tbl_recipe, (select @num:=0) as s  where out10=0 && id like '%{tbSearch.Text}%' ";
                        break;

                    case "전체":
                        sql = $"select (@num:=@num+1) as no, name,  method, id from tbl_recipe, (select @num:=0) as s  where out10=0 && (name like '%{tbSearch.Text}%' or id like '%{tbSearch.Text}%')";
                        break;
                }

                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                dgvTableRecipeList.DataSource = dt;
                cMysqlDto.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("레시피 검색 실패", btn.Content.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BtnShowAllList_Click(object sender, EventArgs e)
        {
            RwSelectRecipeTableList();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void DgvTableRecipeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isOk = true;
            bool isUsePopup = false;
            try
            {


                DataGridView dtg = new DataGridView();
                dtg = dgvTableRecipeList;
                string name = dtg.CurrentRow.Cells["name"].Value.ToString();
                string id = dtg.CurrentRow.Cells["id"].Value.ToString();
                if (CommonClass.isMacroOn)
                { }
                else
                {
                    if (dtg != null)
                    {

                    }
                    else
                    {
                        isOk = false;
                        MessageBox.Show("레시피를 선택하세요.", "레시피선택", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                }



                if (CommonClass.isMacroOn) { }
                else
                {
                    if (MessageBox.Show("[" + name.ToString() + "]을(를) " + "레시피로 선택 하시겠습니까?", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    {
                        return;
                    }
                    else
                    {
                        string sql = $"select calibid from tbl_recipe where id = \"{id}\"";

                        Dictionary<string, string> row1 = cMysqlDto.SelectSql2(sql, "calibid")[0];
                        string calibid = row1["calibid"];
                        CheckCalibID(calibid, id, name);
                    }

                }

            }
            catch (Exception) { }

            if (isUsePopup)
            {
                if (isOk == false)
                    return;
                else
                {
                    if (CommonClass.isMacroOn)
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("선택완료 되었습니다.", "레시피선택", MessageBoxButton.OK, MessageBoxImage.Information);
                        cLog.Info(cMwLog.RecipeChooseClickEventLog);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void BtnRecipeChoose_Click(object sender, EventArgs e)
        {
            //System.Windows.Controls.Button btn = sender as System.Windows.Controls.Button;
            try
            {
                DataGridViewRow row = dgvTableRecipeList.SelectedRows[0]; //선택된 Row 값 가져옴.
                string name = row.Cells[1].Value.ToString();
                string id = row.Cells[2].Value.ToString();
                if (row != null)
                {

                }
                else
                {
                    MessageBox.Show("레시피를 선택하세요.", "레시피로 선택", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }


                if (MessageBox.Show("[" + name.ToString() + "]을(를) 레시피로 선택 하시겠습니까?", "레시피로 선택", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                {
                    return;
                }
                else
                {
                    string sql = $"select calibid from tbl_recipe where id = \"{id}\"";

                    Dictionary<string, string> row1 = cMysqlDto.SelectSql2(sql, "calibid")[0];
                    string calibid = row1["calibid"];
                    CheckCalibID(calibid, id, name);

                }


            }
            catch (Exception) { }



        }


        public void CheckCalibID(string calibid, string id, string name)
        {
            //bool isOk = true;

            string sql = $"select count(*) as cnt from tbl_plc_calibration where id = \"{calibid}\" && out10=0;";

            int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(sql, "cnt")[0]["cnt"]);

            if (rowCnt == 0)
            {
                //isOk = false;
                MessageBox.Show("캘리브레이션ID가 이전에 삭제되어 존재하지 않습니다.\r\n 레시피 수정사항 변경 후 저장해주세요.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                return;

            }
            else
            {
                MeasureManagePage.rcpname = name;
                MeasureManagePage.rcpid = id;

                //if (isOk == false)
                //    return;
                //else
                //{
                    MessageBox.Show("레시피로 선택이 완료 되었습니다.", "레시피로 선택", MessageBoxButton.OK, MessageBoxImage.Information);
                    DialogResult = DialogResult.OK;
                   this.Close();
                //}
            }
        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
