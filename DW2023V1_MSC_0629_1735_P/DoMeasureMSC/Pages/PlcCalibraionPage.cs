using DBMS_V1;
using DBMS_V1.Data.MSC;
using EventLog;
using DwLib.Data;
using log4net;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace DoMeasureMSC.Pages
{
    public partial class PlcCalibraionPage : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlcCalibraionPage));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.cboSearchWord = new C1.Win.C1Input.C1ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.btnShowAllList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCalibList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.btnRegi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fgChannelInfo2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.fgChannelInfo1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSearchWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalibList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgChannelInfo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgChannelInfo1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer1.Size = new System.Drawing.Size(1640, 950);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1640, 500);
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "캘리브레이션 관리";
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
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer3.Size = new System.Drawing.Size(1640, 446);
            this.splitContainer3.SplitterDistance = 815;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.cboSearchWord);
            this.splitContainer4.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer4.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer4.Panel1.Controls.Add(this.btnShowAllList);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgvCalibList);
            this.splitContainer4.Size = new System.Drawing.Size(815, 446);
            this.splitContainer4.SplitterDistance = 83;
            this.splitContainer4.TabIndex = 0;
            // 
            // cboSearchWord
            // 
            this.cboSearchWord.AllowSpinLoop = false;
            this.cboSearchWord.BackColor = System.Drawing.Color.Cornsilk;
            this.cboSearchWord.Font = new System.Drawing.Font("나눔고딕", 16F);
            this.cboSearchWord.GapHeight = 0;
            this.cboSearchWord.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cboSearchWord.Items.Add("전체");
            this.cboSearchWord.Items.Add("캘리브레이션명");
            this.cboSearchWord.Items.Add("ID");
            this.cboSearchWord.Location = new System.Drawing.Point(261, 0);
            this.cboSearchWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSearchWord.Name = "cboSearchWord";
            this.cboSearchWord.Size = new System.Drawing.Size(200, 32);
            this.cboSearchWord.TabIndex = 19;
            this.cboSearchWord.Tag = null;
            this.cboSearchWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboSearchWord.Value = "123";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Cornsilk;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("나눔고딕", 16F);
            this.tbSearch.Location = new System.Drawing.Point(468, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(200, 32);
            this.tbSearch.TabIndex = 18;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(124)))), ((int)(((byte)(245)))));
            this.btnSearch.Image = global::DoMeasureMSC.Properties.Resources.find;
            this.btnSearch.Location = new System.Drawing.Point(674, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 12;
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
            this.btnShowAllList.Location = new System.Drawing.Point(712, 0);
            this.btnShowAllList.Name = "btnShowAllList";
            this.btnShowAllList.Size = new System.Drawing.Size(100, 32);
            this.btnShowAllList.TabIndex = 4;
            this.btnShowAllList.Text = "전체조회";
            this.btnShowAllList.UseVisualStyleBackColor = false;
            this.btnShowAllList.Click += new System.EventHandler(this.BtnShowAllList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "캘리브레이션 조회";
            // 
            // dgvCalibList
            // 
            this.dgvCalibList.AllowUserToAddRows = false;
            this.dgvCalibList.AllowUserToDeleteRows = false;
            this.dgvCalibList.AllowUserToResizeColumns = false;
            this.dgvCalibList.AllowUserToResizeRows = false;
            this.dgvCalibList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCalibList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalibList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalibList.ColumnHeadersHeight = 50;
            this.dgvCalibList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCalibList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalibList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCalibList.EnableHeadersVisualStyles = false;
            this.dgvCalibList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvCalibList.Location = new System.Drawing.Point(0, 0);
            this.dgvCalibList.MultiSelect = false;
            this.dgvCalibList.Name = "dgvCalibList";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalibList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCalibList.RowHeadersVisible = false;
            this.dgvCalibList.RowTemplate.Height = 23;
            this.dgvCalibList.RowTemplate.ReadOnly = true;
            this.dgvCalibList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalibList.Size = new System.Drawing.Size(815, 335);
            this.dgvCalibList.TabIndex = 0;
            this.dgvCalibList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPatternList_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "no";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "NO";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 50;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "ID";
            this.Column3.MinimumWidth = 150;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "캘리브레이션명";
            this.Column2.MinimumWidth = 150;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column4.HeaderText = "옵션";
            this.Column4.MinimumWidth = 150;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Text = "제외";
            this.Column4.UseColumnTextForButtonValue = true;
            this.Column4.Width = 150;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.btnRegi);
            this.splitContainer6.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.label8);
            this.splitContainer6.Panel2.Controls.Add(this.label5);
            this.splitContainer6.Panel2.Controls.Add(this.label6);
            this.splitContainer6.Panel2.Controls.Add(this.id);
            this.splitContainer6.Panel2.Controls.Add(this.name);
            this.splitContainer6.Size = new System.Drawing.Size(821, 446);
            this.splitContainer6.SplitterDistance = 83;
            this.splitContainer6.TabIndex = 0;
            // 
            // btnRegi
            // 
            this.btnRegi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnRegi.FlatAppearance.BorderSize = 0;
            this.btnRegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegi.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRegi.ForeColor = System.Drawing.Color.Black;
            this.btnRegi.Location = new System.Drawing.Point(536, 0);
            this.btnRegi.Name = "btnRegi";
            this.btnRegi.Size = new System.Drawing.Size(282, 32);
            this.btnRegi.TabIndex = 1;
            this.btnRegi.Text = "캘리브레이션 신규등록";
            this.btnRegi.UseVisualStyleBackColor = false;
            this.btnRegi.Click += new System.EventHandler(this.BtnRegi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "캘리브레이션 등록";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Coral;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(0, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(821, 28);
            this.label8.TabIndex = 146;
            this.label8.Text = "※ 캘리브레이션 신규등록 완료시, [조회]에서 해당 캘리브레이션을 선택하고, 채널정보를 반드시 업데이트 하세요.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "캘리브레이션 ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "캘리브레이션명";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Cornsilk;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id.Location = new System.Drawing.Point(154, 48);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(655, 26);
            this.id.TabIndex = 12;
            this.id.Tag = "캘리브레이션ID를 입력하세요. (Ex:CALIB_01)";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Id_KeyPress);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Cornsilk;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(154, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(655, 26);
            this.name.TabIndex = 13;
            this.name.Tag = "캘리브레이션명을 입력하세요. (Ex:캘리브레이션_01)";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer5.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.tbxid);
            this.splitContainer5.Panel2.Controls.Add(this.label7);
            this.splitContainer5.Panel2.Controls.Add(this.fgChannelInfo2);
            this.splitContainer5.Panel2.Controls.Add(this.fgChannelInfo1);
            this.splitContainer5.Size = new System.Drawing.Size(1640, 446);
            this.splitContainer5.SplitterDistance = 66;
            this.splitContainer5.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(1358, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(282, 32);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "캘리브레이션 수정사항 변경 후 저장";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(0, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "캘리브레이션 상세정보";
            // 
            // tbxid
            // 
            this.tbxid.BackColor = System.Drawing.Color.White;
            this.tbxid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxid.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxid.Location = new System.Drawing.Point(12, 26);
            this.tbxid.Name = "tbxid";
            this.tbxid.ReadOnly = true;
            this.tbxid.Size = new System.Drawing.Size(137, 26);
            this.tbxid.TabIndex = 13;
            this.tbxid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(12, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "캘리브레이션 ID";
            // 
            // fgChannelInfo2
            // 
            this.fgChannelInfo2.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgChannelInfo2.BackColor = System.Drawing.Color.White;
            this.fgChannelInfo2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgChannelInfo2.ColumnInfo = resources.GetString("fgChannelInfo2.ColumnInfo");
            this.fgChannelInfo2.Location = new System.Drawing.Point(674, 0);
            this.fgChannelInfo2.Name = "fgChannelInfo2";
            this.fgChannelInfo2.Rows.Count = 25;
            this.fgChannelInfo2.Rows.DefaultSize = 28;
            this.fgChannelInfo2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgChannelInfo2.Size = new System.Drawing.Size(966, 364);
            this.fgChannelInfo2.StyleInfo = resources.GetString("fgChannelInfo2.StyleInfo");
            this.fgChannelInfo2.TabIndex = 5;
            // 
            // fgChannelInfo1
            // 
            this.fgChannelInfo1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgChannelInfo1.BackColor = System.Drawing.Color.White;
            this.fgChannelInfo1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgChannelInfo1.ColumnInfo = resources.GetString("fgChannelInfo1.ColumnInfo");
            this.fgChannelInfo1.Location = new System.Drawing.Point(160, -3);
            this.fgChannelInfo1.Name = "fgChannelInfo1";
            this.fgChannelInfo1.Rows.Count = 13;
            this.fgChannelInfo1.Rows.DefaultSize = 28;
            this.fgChannelInfo1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgChannelInfo1.Size = new System.Drawing.Size(502, 367);
            this.fgChannelInfo1.StyleInfo = resources.GetString("fgChannelInfo1.StyleInfo");
            this.fgChannelInfo1.TabIndex = 4;
            // 
            // PlcCalibraionPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1640, 950);
            this.MinimumSize = new System.Drawing.Size(1640, 950);
            this.Name = "PlcCalibraionPage";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboSearchWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalibList)).EndInit();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgChannelInfo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgChannelInfo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView dgvCalibList;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button btnShowAllList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbSearch;
        private C1.Win.C1Input.C1ComboBox cboSearchWord;
        private C1.Win.C1FlexGrid.C1FlexGrid fgChannelInfo1;
        private C1.Win.C1FlexGrid.C1FlexGrid fgChannelInfo2;
        private System.Windows.Forms.TextBox tbxid;
        private System.Windows.Forms.Label label7;
        private Label label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column4;
        //================================================================================================================================


        public PlcCalibraionPage()
        {
            InitializeComponent();
            SelectCalibrationList();
            cboSearchWord.SelectedIndex = 0;
            cTbl_calib = new Tbl_plc_calibration();

            InitializeInfo1();
            InitializeInfo2();

            id.Text = id.Tag.ToString();
            id.ForeColor = Color.Gray;

            name.Text = name.Tag.ToString();
            name.ForeColor = Color.Gray;

            this.id.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.id.Leave += new System.EventHandler(this.WaterMark_Leave);

            this.name.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.name.Leave += new System.EventHandler(this.WaterMark_Leave);
        }

        private readonly MeasureWriteLog cMwLog = new MeasureWriteLog();
        private static readonly ILog cLog = LogManager.GetLogger("Measure");
        private readonly MySqlDTO cMysqlDto = new MySqlDTO();
        readonly Tbl_plc_calibration cTbl_calib;

        private void WaterMake_Enter(object sender, EventArgs e)
        {
            var tbControl = sender as System.Windows.Forms.TextBox;
            if (tbControl.ForeColor == Color.Gray)
            {
                tbControl.Text = "";
                tbControl.ForeColor = Color.Black;
            }
        }

        private void WaterMark_Leave(object sender, EventArgs e)
        {
            var tbControl = sender as System.Windows.Forms.TextBox;
            if (String.IsNullOrEmpty(tbControl.Text))
            {
                tbControl.Text = tbControl.Tag.ToString();
                tbControl.ForeColor = Color.Gray;
            }
        }
        private void InitializeInfo1()
        {
            for (int i = 1; i < fgChannelInfo1.Rows.Count; i++)
            {
                fgChannelInfo1[i, 1] = i.ToString();
                fgChannelInfo1[i, 2] = "Ch" + i.ToString();
            }
        }

        private void InitializeInfo2()
        {
            for (int i = 1; i < fgChannelInfo2.Rows.Count; i++)//96
            {
                fgChannelInfo2[i, 1] = i.ToString();
            }
            for (int i = 1; i <= 5; i++)//96
            {
                for (int j = 1; j <= 5; j++)
                {
                    fgChannelInfo2[i, 2] = "Ch1";
                    fgChannelInfo2[j, 3] = "1" + "-" + j.ToString();
                }
            }
            for (int i = 1 + 5; i <= 5 + 5; i++)//96
            {
                for (int j = 1 + 5; j <= 5 + 5; j++)
                {
                    fgChannelInfo2[i, 2] = "Ch2";
                    fgChannelInfo2[j, 3] = "2" + "-" + (j - 5).ToString();
                }
            }
            for (int i = 1 + 5 + 5; i <= 5 + 5 + 5; i++)//96
            {
                for (int j = 1 + 5 + 5; j <= 5 + 5 + 5; j++)
                {
                    fgChannelInfo2[i, 2] = "Ch3";
                    fgChannelInfo2[j, 3] = "3" + "-" + (j - (5 + 5)).ToString();
                }
            }
            int index = 16;
            fgChannelInfo2[index, 2] = "Ch4"; fgChannelInfo2[index, 3] = "4" + "-" + (1).ToString(); index++;
            fgChannelInfo2[index, 2] = "Ch5"; fgChannelInfo2[index, 3] = "5" + "-" + (1).ToString(); index++;
            fgChannelInfo2[index, 2] = "Ch6"; fgChannelInfo2[index, 3] = "6" + "-" + (1).ToString(); index++;
            fgChannelInfo2[index, 2] = "Ch7"; fgChannelInfo2[index, 3] = "7" + "-" + (1).ToString(); index++;
            fgChannelInfo2[index, 2] = "Ch8"; fgChannelInfo2[index, 3] = "8" + "-" + (1).ToString(); index++;
            fgChannelInfo2[index, 2] = "Ch9"; fgChannelInfo2[index, 3] = "9" + "-" + (1).ToString(); index++;
            fgChannelInfo2[index, 2] = "Ch10"; fgChannelInfo2[index, 3] = "10" + "-" + (1).ToString(); index++;
            fgChannelInfo2[index, 2] = "Ch11"; fgChannelInfo2[index, 3] = "11" + "-" + (1).ToString(); index++;
            fgChannelInfo2[index, 2] = "Ch12"; fgChannelInfo2[index, 3] = "12" + "-" + (1).ToString();

        }



        public void SelectCalibrationList()
        {
            try
            {
                string sql = "select (@num:=@num+1) as no, id, name from tbl_plc_calibration ,(select @num:=0) as s where out10 =0 order by id asc";
                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);

                dgvCalibList.DataSource = dt;

            }
            catch (Exception)
            {
                cLog.Error(cMwLog.PLCListShowLoadError);
            }
        }
        private void BtnRegi_Click(object sender, EventArgs e)
        {

            string strBtnName = "캘리브레이션 신규등록";
            if (InputDataCheck() == false)
            {
                return;
            }
            if (MessageBox.Show(strBtnName + "을(를) 하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ////fgUserSetting
                Tbl_plc_calibration cTbl_calib = new Tbl_plc_calibration()
                {
                    id = string.IsNullOrEmpty(id.Text) ? "" : id.Text.ToString(),
                    name = string.IsNullOrEmpty(name.Text) ? "" : name.Text.ToString(),
                };
                cTbl_calib.no = cTbl_calib.id;

                if (string.IsNullOrEmpty(cTbl_calib.id))
                {
                    MessageBox.Show("캘리브레이선 ID 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(cTbl_calib.name))
                {
                    MessageBox.Show("캘리브레이선명 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }

                try
                {
                    cTbl_calib.regdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string dbsql = ($"INSERT INTO tbl_plc_calibration(id, no, name, regdate) " +
$"VALUE ('{cTbl_calib.id}','{cTbl_calib.no}','{cTbl_calib.name}','{cTbl_calib.regdate}')");

                    //string dbsql = ($"INSERT INTO tbl_plc_calibration(id, no, name, regdate) " +
                    //$"VALUE (\"{tbl_calib.id}\",\"{tbl_calib.no}\",\"{tbl_calib.name}\",\"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\")");


                    cMysqlDto.OpenKeepUp();
                    cMysqlDto.RunSql("INSERT", dbsql);
                    MessageBox.Show("등록이 완료되었습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Info(cMwLog.PLCNewRegisterEventLog);
                    SelectCalibrationList();
                    id.Text = "";
                    name.Text = "";

                }
                catch (Exception)
                {
                    cLog.Error(cMwLog.PLCRegisterError);
                }
                finally
                {
                    cMysqlDto.Close();
                }
            }
        }

        private bool InputDataCheck()
        {
            name.Text = Util.InputdataCheckHanEngNum("캘리브레이션명 입력", name.Text);
            bool isOk = string.IsNullOrEmpty(name.Text) == false;
            if (isOk == false) return isOk;

            id.Text = Util.InputdataCheckEngNum("캘리브레이션ID 입력", id.Text);
            isOk = string.IsNullOrEmpty(id.Text) == false;
            if (isOk == false) return isOk;


            return isOk;
        }

        private void DgvPatternList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                string strBtnName = "캘리브레이션 제외";
                if (MessageBox.Show("제외하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                DataGridViewRow row = dgvCalibList.SelectedRows[0]; //선택된 Row 값 가져옴.
                string id = row.Cells[2].Value.ToString();


                try
                {
                    cMysqlDto.OpenKeepUp();
                    string dbsql = $@"update tbl_plc_calibration set out10=1 where id='{id}'";
                    cMysqlDto.RunSql("UPDATE", dbsql);

                    MessageBox.Show("제외되었습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Info(cMwLog.PLCDeleteEventLog);
                    SelectCalibrationList();

                }
                catch (Exception)
                {
                    MessageBox.Show("캘리브레이션 제외 실패", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Error(cMwLog.PLCDeleteError);
                }
                finally
                {
                    cMysqlDto.Close();
                }
            }
            else
            {
                ShowDetail(sender, e);
            }

        }

        string CompShowReqdetail = "";
        private void ShowDetail(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (sender is DataGridView dgv) { }
            else
                return;

            if (dgv.CurrentRow.Selected)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvCalibList.Rows[index];
                var id = selectedRow.Cells[2].Value.ToString();
                //var name = selectedRow.Cells[3].Value.ToString();


                string strId = id.ToString();
                if (CompShowReqdetail.Equals(strId) == false)
                {
                    CompShowReqdetail = strId;
                }
                else
                {
                    return;
                }

                try
                {
                    DataTable dt = null;

                    string sql = $"select  * "
                        + $"from tbl_plc_calibration as s where id=\"{id}\" ";
                    dt = cMysqlDto.SelectSqlToDataTable(sql);
                    if (dt == null) return;
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            for (int col = 0; col < dt.Columns.Count; col++)
                            {
                                string getColName = dt.Columns[col].ColumnName;
                                string getValue = dt.Rows[i][col].ToString();
                                switch (getColName)
                                {
                                    case "calno": cTbl_calib.calno = getValue; break;    //calno,5
                                    case "id": cTbl_calib.id = getValue; tbxid.Text = getValue; break;    //id,C1
                                    case "no": cTbl_calib.no = getValue; break;    //no, C1
                                    case "name": cTbl_calib.name = getValue; break;    //name,CN테스트1
                                    case "use10": cTbl_calib.use10 = getValue; break;    //use10,1
                                    case "regdate": cTbl_calib.regdate = getValue; break;    //regdate,2023 - 05 - 25 오후 2:45:35
                                    case "updatedate": cTbl_calib.updatedate = getValue; break;    //updatedate,

                                    case "ch1_plc_min1": cTbl_calib.ch1_plc_min1 = getValue; fgChannelInfo2[1, 4] = getValue; break;    //ch1_plc_min1,0
                                    case "ch1_plc_max1": cTbl_calib.ch1_plc_max1 = getValue; fgChannelInfo2[1, 5] = getValue; break;    //ch1_plc_max1,800
                                    case "ch1_plc_min2": cTbl_calib.ch1_plc_min2 = getValue; fgChannelInfo2[2, 4] = getValue; break;    //ch1_plc_min2,801
                                    case "ch1_plc_max2": cTbl_calib.ch1_plc_max2 = getValue; fgChannelInfo2[2, 5] = getValue; break;    //ch1_plc_max2,1600
                                    case "ch1_plc_min3": cTbl_calib.ch1_plc_min3 = getValue; fgChannelInfo2[3, 4] = getValue; break;    //ch1_plc_min3,1601
                                    case "ch1_plc_max3": cTbl_calib.ch1_plc_max3 = getValue; fgChannelInfo2[3, 5] = getValue; break;    //ch1_plc_max3,2400
                                    case "ch1_plc_min4": cTbl_calib.ch1_plc_min4 = getValue; fgChannelInfo2[4, 4] = getValue; break;    //ch1_plc_min4,2401
                                    case "ch1_plc_max4": cTbl_calib.ch1_plc_max4 = getValue; fgChannelInfo2[4, 5] = getValue; break;    //ch1_plc_max4,3200
                                    case "ch1_plc_min5": cTbl_calib.ch1_plc_min5 = getValue; fgChannelInfo2[5, 4] = getValue; break;    //ch1_plc_min5,3201
                                    case "ch1_plc_max5": cTbl_calib.ch1_plc_max5 = getValue; fgChannelInfo2[5, 5] = getValue; break;    //ch1_plc_max5,4000
                                    case "ch1_pc_min1": cTbl_calib.ch1_pc_min1 = getValue; fgChannelInfo2[1, 6] = getValue; break;    //ch1_pc_min1,0
                                    case "ch1_pc_max1": cTbl_calib.ch1_pc_max1 = getValue; fgChannelInfo2[1, 7] = getValue; break;    //ch1_pc_max1,2
                                    case "ch1_pc_min2": cTbl_calib.ch1_pc_min2 = getValue; fgChannelInfo2[2, 6] = getValue; break;    //ch1_pc_min2,2.1
                                    case "ch1_pc_max2": cTbl_calib.ch1_pc_max2 = getValue; fgChannelInfo2[2, 7] = getValue; break;    //ch1_pc_max2,4
                                    case "ch1_pc_min3": cTbl_calib.ch1_pc_min3 = getValue; fgChannelInfo2[3, 6] = getValue; break;    //ch1_pc_min3,4.1
                                    case "ch1_pc_max3": cTbl_calib.ch1_pc_max3 = getValue; fgChannelInfo2[3, 7] = getValue; break;    //ch1_pc_max3,6
                                    case "ch1_pc_min4": cTbl_calib.ch1_pc_min4 = getValue; fgChannelInfo2[4, 6] = getValue; break;    //ch1_pc_min4,6.1
                                    case "ch1_pc_max4": cTbl_calib.ch1_pc_max4 = getValue; fgChannelInfo2[4, 7] = getValue; break;    //ch1_pc_max4,8
                                    case "ch1_pc_min5": cTbl_calib.ch1_pc_min5 = getValue; fgChannelInfo2[5, 6] = getValue; break;    //ch1_pc_min5,8.1
                                    case "ch1_pc_max5": cTbl_calib.ch1_pc_max5 = getValue; fgChannelInfo2[5, 7] = getValue; break;    //ch1_pc_max5,10

                                    case "ch2_plc_min1": cTbl_calib.ch2_plc_min1 = getValue; fgChannelInfo2[6, 4] = getValue; break;     //ch2_plc_min1,0
                                    case "ch2_plc_max1": cTbl_calib.ch2_plc_max1 = getValue; fgChannelInfo2[6, 5] = getValue; break;    //ch2_plc_max1,800
                                    case "ch2_plc_min2": cTbl_calib.ch2_plc_min2 = getValue; fgChannelInfo2[7, 4] = getValue; break;     //ch2_plc_min2,801
                                    case "ch2_plc_max2": cTbl_calib.ch2_plc_max2 = getValue; fgChannelInfo2[7, 5] = getValue; break;   //ch2_plc_max2,1600
                                    case "ch2_plc_min3": cTbl_calib.ch2_plc_min3 = getValue; fgChannelInfo2[8, 4] = getValue; break;     //ch2_plc_min3,1601
                                    case "ch2_plc_max3": cTbl_calib.ch2_plc_max3 = getValue; fgChannelInfo2[8, 5] = getValue; break;    //ch2_plc_max3,2400
                                    case "ch2_plc_min4": cTbl_calib.ch2_plc_min4 = getValue; fgChannelInfo2[9, 4] = getValue; break;    //ch2_plc_min4,2401
                                    case "ch2_plc_max4": cTbl_calib.ch2_plc_max4 = getValue; fgChannelInfo2[9, 5] = getValue; break;    //ch2_plc_max4,3200
                                    case "ch2_plc_min5": cTbl_calib.ch2_plc_min5 = getValue; fgChannelInfo2[10, 4] = getValue; break;     //ch2_plc_min5,3201
                                    case "ch2_plc_max5": cTbl_calib.ch2_plc_max5 = getValue; fgChannelInfo2[10, 5] = getValue; break;     //ch2_plc_max5,4000
                                    case "ch2_pc_min1": cTbl_calib.ch2_pc_min1 = getValue; fgChannelInfo2[6, 6] = getValue; break;      //ch2_pc_min1,0
                                    case "ch2_pc_max1": cTbl_calib.ch2_pc_max1 = getValue; fgChannelInfo2[6, 7] = getValue; break;      //ch2_pc_max1,2
                                    case "ch2_pc_min2": cTbl_calib.ch2_pc_min2 = getValue; fgChannelInfo2[7, 6] = getValue; break;      //ch2_pc_min2,2.1
                                    case "ch2_pc_max2": cTbl_calib.ch2_pc_max2 = getValue; fgChannelInfo2[7, 7] = getValue; break;     //ch2_pc_max2,4
                                    case "ch2_pc_min3": cTbl_calib.ch2_pc_min3 = getValue; fgChannelInfo2[8, 6] = getValue; break;      //ch2_pc_min3,4.1
                                    case "ch2_pc_max3": cTbl_calib.ch2_pc_max3 = getValue; fgChannelInfo2[8, 7] = getValue; break;     //ch2_pc_max3,6
                                    case "ch2_pc_min4": cTbl_calib.ch2_pc_min4 = getValue; fgChannelInfo2[9, 6] = getValue; break;      //ch2_pc_min4,6.1
                                    case "ch2_pc_max4": cTbl_calib.ch2_pc_max4 = getValue; fgChannelInfo2[9, 7] = getValue; break;     //ch2_pc_max4,8
                                    case "ch2_pc_min5": cTbl_calib.ch2_pc_min5 = getValue; fgChannelInfo2[10, 6] = getValue; break;      //ch2_pc_min5,8.1
                                    case "ch2_pc_max5": cTbl_calib.ch2_pc_max5 = getValue; fgChannelInfo2[10, 7] = getValue; break;     //ch2_pc_max5,10

                                    case "ch3_plc_min1": cTbl_calib.ch3_plc_min1 = getValue; fgChannelInfo2[11, 4] = getValue; break;      //ch3_plc_min1,0
                                    case "ch3_plc_max1": cTbl_calib.ch3_plc_max1 = getValue; fgChannelInfo2[11, 5] = getValue; break;    //ch3_plc_max1,800
                                    case "ch3_plc_min2": cTbl_calib.ch3_plc_min2 = getValue; fgChannelInfo2[12, 4] = getValue; break;      //ch3_plc_min2,801
                                    case "ch3_plc_max2": cTbl_calib.ch3_plc_max2 = getValue; fgChannelInfo2[12, 5] = getValue; break;    //ch3_plc_max2,1600
                                    case "ch3_plc_min3": cTbl_calib.ch3_plc_min3 = getValue; fgChannelInfo2[13, 4] = getValue; break;      //ch3_plc_min3,1601
                                    case "ch3_plc_max3": cTbl_calib.ch3_plc_max3 = getValue; fgChannelInfo2[13, 5] = getValue; break;    //ch3_plc_max3,2400
                                    case "ch3_plc_min4": cTbl_calib.ch3_plc_min4 = getValue; fgChannelInfo2[14, 4] = getValue; break;      //ch3_plc_min4,2401
                                    case "ch3_plc_max4": cTbl_calib.ch3_plc_max4 = getValue; fgChannelInfo2[14, 5] = getValue; break;    //ch3_plc_max4,3200
                                    case "ch3_plc_min5": cTbl_calib.ch3_plc_min5 = getValue; fgChannelInfo2[15, 4] = getValue; break;      //ch3_plc_min5,3201
                                    case "ch3_plc_max5": cTbl_calib.ch3_plc_max5 = getValue; fgChannelInfo2[15, 5] = getValue; break;    //ch3_plc_max5,4000
                                    case "ch3_pc_min1": cTbl_calib.ch3_pc_min1 = getValue; fgChannelInfo2[11, 6] = getValue; break;       //ch3_pc_min1,0
                                    case "ch3_pc_max1": cTbl_calib.ch3_pc_max1 = getValue; fgChannelInfo2[11, 7] = getValue; break;      //ch3_pc_max1,2
                                    case "ch3_pc_min2": cTbl_calib.ch3_pc_min2 = getValue; fgChannelInfo2[12, 6] = getValue; break;       //ch3_pc_min2,2.1
                                    case "ch3_pc_max2": cTbl_calib.ch3_pc_max2 = getValue; fgChannelInfo2[12, 7] = getValue; break;      //ch3_pc_max2,4
                                    case "ch3_pc_min3": cTbl_calib.ch3_pc_min3 = getValue; fgChannelInfo2[13, 6] = getValue; break;       //ch3_pc_min3,4.1
                                    case "ch3_pc_max3": cTbl_calib.ch3_pc_max3 = getValue; fgChannelInfo2[13, 7] = getValue; break;      //ch3_pc_max3,6
                                    case "ch3_pc_min4": cTbl_calib.ch3_pc_min4 = getValue; fgChannelInfo2[14, 6] = getValue; break;       //ch3_pc_min4,6.1
                                    case "ch3_pc_max4": cTbl_calib.ch3_pc_max4 = getValue; fgChannelInfo2[14, 7] = getValue; break;      //ch3_pc_max4,8
                                    case "ch3_pc_min5": cTbl_calib.ch3_pc_min5 = getValue; fgChannelInfo2[15, 6] = getValue; break;       //ch3_pc_min5,8.1
                                    case "ch3_pc_max5": cTbl_calib.ch3_pc_max5 = getValue; fgChannelInfo2[15, 7] = getValue; break;      //ch3_pc_max5,10

                                    case "ch4_plc_min1": cTbl_calib.ch4_plc_min1 = getValue; fgChannelInfo2[16, 4] = getValue; break;    //ch4_plc_min1,0
                                    case "ch4_plc_max1": cTbl_calib.ch4_plc_max1 = getValue; fgChannelInfo2[16, 5] = getValue; break;    //ch4_plc_max1,4000
                                    case "ch4_pc_min1": cTbl_calib.ch4_pc_min1 = getValue; fgChannelInfo2[16, 6] = getValue; break;    //ch4_pc_min1,0
                                    case "ch4_pc_max1": cTbl_calib.ch4_pc_max1 = getValue; fgChannelInfo2[16, 7] = getValue; break;    //ch4_pc_max1,10

                                    case "ch5_plc_min1": cTbl_calib.ch5_plc_min1 = getValue; fgChannelInfo2[17, 4] = getValue; break;      //ch5_plc_min1,0
                                    case "ch5_plc_max1": cTbl_calib.ch5_plc_max1 = getValue; fgChannelInfo2[17, 5] = getValue; break;    //ch5_plc_max1,4000
                                    case "ch5_pc_min1": cTbl_calib.ch5_pc_min1 = getValue; fgChannelInfo2[17, 6] = getValue; break;       //ch5_pc_min1,0
                                    case "ch5_pc_max1": cTbl_calib.ch5_pc_max1 = getValue; fgChannelInfo2[17, 7] = getValue; break;      //ch5_pc_max1,10

                                    case "ch6_plc_min1": cTbl_calib.ch6_plc_min1 = getValue; fgChannelInfo2[18, 4] = getValue; break;     //ch6_plc_min1,0
                                    case "ch6_plc_max1": cTbl_calib.ch6_plc_max1 = getValue; fgChannelInfo2[18, 5] = getValue; break;   //ch6_plc_max1,4000
                                    case "ch6_pc_min1": cTbl_calib.ch6_pc_min1 = getValue; fgChannelInfo2[18, 6] = getValue; break;      //ch6_pc_min1,0
                                    case "ch6_pc_max1": cTbl_calib.ch6_pc_max1 = getValue; fgChannelInfo2[18, 7] = getValue; break;     //ch6_pc_max1,10

                                    case "ch7_plc_min1": cTbl_calib.ch7_plc_min1 = getValue; fgChannelInfo2[19, 4] = getValue; break;      //ch7_plc_min1,0
                                    case "ch7_plc_max1": cTbl_calib.ch7_plc_max1 = getValue; fgChannelInfo2[19, 5] = getValue; break;    //ch7_plc_max1,4000
                                    case "ch7_pc_min1": cTbl_calib.ch7_pc_min1 = getValue; fgChannelInfo2[19, 6] = getValue; break;       //ch7_pc_min1,0
                                    case "ch7_pc_max1": cTbl_calib.ch7_pc_max1 = getValue; fgChannelInfo2[19, 7] = getValue; break;      //ch7_pc_max1,10

                                    case "ch8_plc_min1": cTbl_calib.ch8_plc_min1 = getValue; fgChannelInfo2[20, 4] = getValue; break;       //ch8_plc_min1,0
                                    case "ch8_plc_max1": cTbl_calib.ch8_plc_max1 = getValue; fgChannelInfo2[20, 5] = getValue; break;     //ch8_plc_max1,4000
                                    case "ch8_pc_min1": cTbl_calib.ch8_pc_min1 = getValue; fgChannelInfo2[20, 6] = getValue; break;        //ch8_pc_min1,0
                                    case "ch8_pc_max1": cTbl_calib.ch8_pc_max1 = getValue; fgChannelInfo2[20, 7] = getValue; break;       //ch8_pc_max1,10

                                    case "ch9_plc_min1": cTbl_calib.ch9_plc_min1 = getValue; fgChannelInfo2[21, 4] = getValue; break;       //ch9_plc_min1,0
                                    case "ch9_plc_max1": cTbl_calib.ch9_plc_max1 = getValue; fgChannelInfo2[21, 5] = getValue; break;     //ch9_plc_max1,4000
                                    case "ch9_pc_min1": cTbl_calib.ch9_pc_min1 = getValue; fgChannelInfo2[21, 6] = getValue; break;        //ch9_pc_min1,0
                                    case "ch9_pc_max1": cTbl_calib.ch9_pc_max1 = getValue; fgChannelInfo2[21, 7] = getValue; break;       //ch9_pc_max1,10

                                    case "ch10_plc_min1": cTbl_calib.ch10_plc_min1 = getValue; fgChannelInfo2[22, 4] = getValue; break;       //ch10_plc_min1,0
                                    case "ch10_plc_max1": cTbl_calib.ch10_plc_max1 = getValue; fgChannelInfo2[22, 5] = getValue; break;     //ch10_plc_max1,4000
                                    case "ch10_pc_min1": cTbl_calib.ch10_pc_min1 = getValue; fgChannelInfo2[22, 6] = getValue; break;        //ch10_pc_min1,0
                                    case "ch10_pc_max1": cTbl_calib.ch10_pc_max1 = getValue; fgChannelInfo2[22, 7] = getValue; break;       //ch10_pc_max1,10

                                    case "ch11_plc_min1": cTbl_calib.ch11_plc_min1 = getValue; fgChannelInfo2[23, 4] = getValue; break;       //ch11_plc_min1,0
                                    case "ch11_plc_max1": cTbl_calib.ch11_plc_max1 = getValue; fgChannelInfo2[23, 5] = getValue; break;     //ch11_plc_max1,4000
                                    case "ch11_pc_min1": cTbl_calib.ch11_pc_min1 = getValue; fgChannelInfo2[23, 6] = getValue; break;        //ch11_pc_min1,0
                                    case "ch11_pc_max1": cTbl_calib.ch11_pc_max1 = getValue; fgChannelInfo2[23, 7] = getValue; break;       //ch11_pc_max1,10

                                    case "ch12_plc_min1": cTbl_calib.ch12_plc_min1 = getValue; fgChannelInfo2[24, 4] = getValue; break;       //ch12_plc_min1,0
                                    case "ch12_plc_max1": cTbl_calib.ch12_plc_max1 = getValue; fgChannelInfo2[24, 5] = getValue; break;     //ch12_plc_max1,4000
                                    case "ch12_pc_min1": cTbl_calib.ch12_pc_min1 = getValue; fgChannelInfo2[24, 6] = getValue; break;        //ch12_pc_min1,0
                                    case "ch12_pc_max1": cTbl_calib.ch12_pc_max1 = getValue; fgChannelInfo2[24, 7] = getValue; break;       //ch12_pc_max1,10

                                    case "ch1_name": cTbl_calib.ch1_name = getValue; fgChannelInfo1[1, 3] = getValue; break;    //ch1_name,AI01
                                    case "ch2_name": cTbl_calib.ch2_name = getValue; fgChannelInfo1[2, 3] = getValue; break;    //ch2_name, AI02
                                    case "ch3_name": cTbl_calib.ch3_name = getValue; fgChannelInfo1[3, 3] = getValue; break;    //ch3_name,AI03
                                    case "ch4_name": cTbl_calib.ch4_name = getValue; fgChannelInfo1[4, 3] = getValue; break;    //ch4_name, AI04
                                    case "ch5_name": cTbl_calib.ch5_name = getValue; fgChannelInfo1[5, 3] = getValue; break;    //ch5_name,AI05
                                    case "ch6_name": cTbl_calib.ch6_name = getValue; fgChannelInfo1[6, 3] = getValue; break;    //ch6_name, AI06
                                    case "ch7_name": cTbl_calib.ch7_name = getValue; fgChannelInfo1[7, 3] = getValue; break;    //ch7_name,AI07
                                    case "ch8_name": cTbl_calib.ch8_name = getValue; fgChannelInfo1[8, 3] = getValue; break;    //ch8_name, AI08
                                    case "ch9_name": cTbl_calib.ch9_name = getValue; fgChannelInfo1[9, 3] = getValue; break;    //ch9_name,AI09
                                    case "ch10_name": cTbl_calib.ch10_name = getValue; fgChannelInfo1[10, 3] = getValue; break;    //ch10_name, AI10
                                    case "ch11_name": cTbl_calib.ch11_name = getValue; fgChannelInfo1[11, 3] = getValue; break;    //ch11_name,AI11
                                    case "ch12_name": cTbl_calib.ch12_name = getValue; fgChannelInfo1[12, 3] = getValue; break;    //ch12_name, AI12

                                    case "ch1_unit": cTbl_calib.ch1_unit = getValue; fgChannelInfo1[1, 4] = getValue; break;    //ch1_unit,AI01
                                    case "ch2_unit": cTbl_calib.ch2_unit = getValue; fgChannelInfo1[2, 4] = getValue; break;    //ch2_unit, AI02
                                    case "ch3_unit": cTbl_calib.ch3_unit = getValue; fgChannelInfo1[3, 4] = getValue; break;    //ch3_unit,AI03
                                    case "ch4_unit": cTbl_calib.ch4_unit = getValue; fgChannelInfo1[4, 4] = getValue; break;    //ch4_unit, AI04
                                    case "ch5_unit": cTbl_calib.ch5_unit = getValue; fgChannelInfo1[5, 4] = getValue; break;    //ch5_unit,AI05
                                    case "ch6_unit": cTbl_calib.ch6_unit = getValue; fgChannelInfo1[6, 4] = getValue; break;    //ch6_unit, AI06
                                    case "ch7_unit": cTbl_calib.ch7_unit = getValue; fgChannelInfo1[7, 4] = getValue; break;    //ch7_unit,AI07
                                    case "ch8_unit": cTbl_calib.ch8_unit = getValue; fgChannelInfo1[8, 4] = getValue; break;    //ch8_unit, AI08
                                    case "ch9_unit": cTbl_calib.ch9_unit = getValue; fgChannelInfo1[9, 4] = getValue; break;    //ch9_unit,AI09
                                    case "ch10_unit": cTbl_calib.ch10_unit = getValue; fgChannelInfo1[10, 4] = getValue; break;    //ch10_unit, AI10
                                    case "ch11_unit": cTbl_calib.ch11_unit = getValue; fgChannelInfo1[11, 4] = getValue; break;    //ch11_unit,AI11
                                    case "ch12_unit": cTbl_calib.ch12_unit = getValue; fgChannelInfo1[12, 4] = getValue; break;    //ch12_unit, AI12
                                }

                            }
                        }
                    }

                }
                catch
                {
                    cLog.Error(cMwLog.PLCDetailLoadError);
                }


            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = Util.InputdataCheck("검색어 입력", tbSearch.Text);
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                MessageBox.Show("검색어를 입력하세요", "검색", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int errChar = tbSearch.Text.IndexOf("%");
            if (errChar != -1)
            {
                if (MessageBox.Show("검색어에 특수문자(%)를 제한합니다.", "패턴관리", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tbSearch.Focus();
                    return;
                }
            }
            //Button btn = sender as Button;
            string sql = "";

            string strSerchOpt = cboSearchWord.SelectedItem.ToString();

            if (tbSearch.Text.StartsWith("검색어"))
            {
                tbSearch.Text = "";
            }
            switch (strSerchOpt)
            {
                case "패턴명":
                    sql = $"select count(*) as cnt from tbl_plc_calibration ,(select @num:=0) as s where name like '%{tbSearch.Text}%' ";
                    break;
                case "패턴번호":
                    sql = $"select count(*) as cnt from tbl_plc_calibration ,(select @num:=0) as s where number like '%{tbSearch.Text}%'";
                    break;
                case "전체":
                    sql = $"select count(*) as cnt from tbl_plc_calibration ,(select @num:=0) as s where (name like '%{tbSearch.Text}%' or number like '%{tbSearch.Text}%')";
                    break;
            }

            try
            {


               int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(sql, "cnt")[0]["cnt"]);

                if (rowCnt == 0)
                {
                    MessageBox.Show("데이터가 없습니다.", "캘리브레이션 관리", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbSearch.Text = "";
                    return;
                }
            }
            catch (Exception)
            {
            }

            try
            {
                switch (strSerchOpt)
                {
                    case "패턴명":
                        sql = $"select (@num:=@num+1) as no, id,  name from tbl_plc_calibration where name like '%{tbSearch.Text}%' ";
                        break;
                    case "패턴번호":
                        sql = $"select (@num:=@num+1) as no, id, name from tbl_plc_calibration where number like '%{tbSearch.Text}%'";
                        break;
                    case "전체":
                        sql = $"select (@num:=@num+1) as no, id, name from tbl_plc_calibration where (name like '%{tbSearch.Text}%' or number like '%{tbSearch.Text}%')";
                        break;
                }

                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                dgvCalibList.DataSource = dt;
                cLog.Info(cMwLog.PLCSearchClickEventLog);
            }
            catch (Exception)
            {
                MessageBox.Show("패턴 검색 실패", "패턴관리", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cLog.Error(cMwLog.PLCSearchLoadError);
            }
        }

        private void BtnShowAllList_Click(object sender, EventArgs e)
        {
            SelectCalibrationList();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string strBtnName = "캘리브레이션 수정사항 변경 후 저장";
            try
            {

                if (MessageBox.Show("저장하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                if (string.IsNullOrEmpty(cTbl_calib.name))
                {
                    MessageBox.Show("캘리브레이션이 선택되지 않았습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                cTbl_calib.id = tbxid.Text;

                string[] defaultPlcValue = { "0", "800", "801", "1600", "1601", "2400", "2401", "3200", "3201", "4000" };
                string[] defaultPCValue = { "0", "2", "2.1", "4", "4.1", "6", "6.1", "8", "8.1", "10" };

                cTbl_calib.ch1_plc_min1 = fgChannelInfo2[1, 4] == null ? defaultPlcValue[0] : fgChannelInfo2[1, 4].ToString(); //ch1_plc_min1,0
                cTbl_calib.ch1_plc_max1 = fgChannelInfo2[1, 5] == null ? defaultPlcValue[1] : fgChannelInfo2[1, 5].ToString(); //ch1_plc_max1,800
                cTbl_calib.ch1_plc_min2 = fgChannelInfo2[2, 4] == null ? defaultPlcValue[2] : fgChannelInfo2[2, 4].ToString();    //ch1_plc_min2,801
                cTbl_calib.ch1_plc_max2 = fgChannelInfo2[2, 5] == null ? defaultPlcValue[3] : fgChannelInfo2[2, 5].ToString();     //ch1_plc_max2,1600
                cTbl_calib.ch1_plc_min3 = fgChannelInfo2[3, 4] == null ? defaultPlcValue[4] : fgChannelInfo2[3, 4].ToString();    //ch1_plc_min3,1601
                cTbl_calib.ch1_plc_max3 = fgChannelInfo2[3, 5] == null ? defaultPlcValue[5] : fgChannelInfo2[3, 5].ToString();     //ch1_plc_max3,2400
                cTbl_calib.ch1_plc_min4 = fgChannelInfo2[4, 4] == null ? defaultPlcValue[6] : fgChannelInfo2[4, 4].ToString();     //ch1_plc_min4,2401
                cTbl_calib.ch1_plc_max4 = fgChannelInfo2[4, 5] == null ? defaultPlcValue[7] : fgChannelInfo2[4, 5].ToString();     //ch1_plc_max4,3200
                cTbl_calib.ch1_plc_min5 = fgChannelInfo2[5, 4] == null ? defaultPlcValue[8] : fgChannelInfo2[5, 4].ToString();    //ch1_plc_min5,3201
                cTbl_calib.ch1_plc_max5 = fgChannelInfo2[5, 5] == null ? defaultPlcValue[9] : fgChannelInfo2[5, 5].ToString();     //ch1_plc_max5,4000

                cTbl_calib.ch1_pc_min1 = fgChannelInfo2[1, 6] == null ? defaultPCValue[0] : fgChannelInfo2[1, 6].ToString();    //ch1_pc_min1,0
                cTbl_calib.ch1_pc_max1 = fgChannelInfo2[1, 7] == null ? defaultPCValue[1] : fgChannelInfo2[1, 7].ToString();    //ch1_pc_max1,2
                cTbl_calib.ch1_pc_min2 = fgChannelInfo2[2, 6] == null ? defaultPCValue[2] : fgChannelInfo2[2, 6].ToString();   //ch1_pc_min2,2.1
                cTbl_calib.ch1_pc_max2 = fgChannelInfo2[2, 7] == null ? defaultPCValue[3] : fgChannelInfo2[2, 7].ToString();    //ch1_pc_max2,4
                cTbl_calib.ch1_pc_min3 = fgChannelInfo2[3, 6] == null ? defaultPCValue[4] : fgChannelInfo2[3, 6].ToString();   //ch1_pc_min3,4.1
                cTbl_calib.ch1_pc_max3 = fgChannelInfo2[3, 7] == null ? defaultPCValue[5] : fgChannelInfo2[3, 7].ToString();    //ch1_pc_max3,6
                cTbl_calib.ch1_pc_min4 = fgChannelInfo2[4, 6] == null ? defaultPCValue[6] : fgChannelInfo2[4, 6].ToString();   //ch1_pc_min4,6.1
                cTbl_calib.ch1_pc_max4 = fgChannelInfo2[4, 7] == null ? defaultPCValue[7] : fgChannelInfo2[4, 7].ToString();    //ch1_pc_max4,8
                cTbl_calib.ch1_pc_min5 = fgChannelInfo2[5, 6] == null ? defaultPCValue[8] : fgChannelInfo2[5, 6].ToString();   //ch1_pc_min5,8.1
                cTbl_calib.ch1_pc_max5 = fgChannelInfo2[5, 7] == null ? defaultPCValue[9] : fgChannelInfo2[5, 7].ToString();    //ch1_pc_max5,10

                cTbl_calib.ch2_plc_min1 = fgChannelInfo2[6, 4] == null ? defaultPlcValue[0] : fgChannelInfo2[6, 4].ToString();    //ch2_plc_min1,0
                cTbl_calib.ch2_plc_max1 = fgChannelInfo2[6, 5] == null ? defaultPlcValue[1] : fgChannelInfo2[6, 5].ToString();    //ch2_plc_max1,800
                cTbl_calib.ch2_plc_min2 = fgChannelInfo2[7, 4] == null ? defaultPlcValue[2] : fgChannelInfo2[7, 4].ToString();    //ch2_plc_min2,801
                cTbl_calib.ch2_plc_max2 = fgChannelInfo2[7, 5] == null ? defaultPlcValue[3] : fgChannelInfo2[7, 5].ToString();   //ch2_plc_max2,1600
                cTbl_calib.ch2_plc_min3 = fgChannelInfo2[8, 4] == null ? defaultPlcValue[4] : fgChannelInfo2[8, 4].ToString();    //ch2_plc_min3,1601
                cTbl_calib.ch2_plc_max3 = fgChannelInfo2[8, 5] == null ? defaultPlcValue[5] : fgChannelInfo2[8, 5].ToString();    //ch2_plc_max3,2400
                cTbl_calib.ch2_plc_min4 = fgChannelInfo2[9, 4] == null ? defaultPlcValue[6] : fgChannelInfo2[9, 4].ToString();   //ch2_plc_min4,2401
                cTbl_calib.ch2_plc_max4 = fgChannelInfo2[9, 5] == null ? defaultPlcValue[7] : fgChannelInfo2[9, 5].ToString();    //ch2_plc_max4,3200
                cTbl_calib.ch2_plc_min5 = fgChannelInfo2[10, 4] == null ? defaultPlcValue[8] : fgChannelInfo2[10, 4].ToString();     //ch2_plc_min5,3201
                cTbl_calib.ch2_plc_max5 = fgChannelInfo2[10, 5] == null ? defaultPlcValue[9] : fgChannelInfo2[10, 5].ToString();     //ch2_plc_max5,4000

                cTbl_calib.ch2_pc_min1 = fgChannelInfo2[6, 6] == null ? defaultPCValue[0] : fgChannelInfo2[6, 6].ToString();       //ch2_pc_min1,0
                cTbl_calib.ch2_pc_max1 = fgChannelInfo2[6, 7] == null ? defaultPCValue[1] : fgChannelInfo2[6, 7].ToString(); ;      //ch2_pc_max1,2
                cTbl_calib.ch2_pc_min2 = fgChannelInfo2[7, 6] == null ? defaultPCValue[2] : fgChannelInfo2[7, 6].ToString();       //ch2_pc_min2,2.1
                cTbl_calib.ch2_pc_max2 = fgChannelInfo2[7, 7] == null ? defaultPCValue[3] : fgChannelInfo2[7, 7].ToString(); ;     //ch2_pc_max2,4
                cTbl_calib.ch2_pc_min3 = fgChannelInfo2[8, 6] == null ? defaultPCValue[4] : fgChannelInfo2[8, 6].ToString();       //ch2_pc_min3,4.1
                cTbl_calib.ch2_pc_max3 = fgChannelInfo2[8, 7] == null ? defaultPCValue[5] : fgChannelInfo2[8, 7].ToString(); ;     //ch2_pc_max3,6
                cTbl_calib.ch2_pc_min4 = fgChannelInfo2[9, 6] == null ? defaultPCValue[6] : fgChannelInfo2[9, 6].ToString();       //ch2_pc_min4,6.1
                cTbl_calib.ch2_pc_max4 = fgChannelInfo2[9, 7] == null ? defaultPCValue[7] : fgChannelInfo2[9, 7].ToString(); ;     //ch2_pc_max4,8
                cTbl_calib.ch2_pc_min5 = fgChannelInfo2[10, 6] == null ? defaultPCValue[8] : fgChannelInfo2[10, 6].ToString();       //ch2_pc_min5,8.1
                cTbl_calib.ch2_pc_max5 = fgChannelInfo2[10, 7] == null ? defaultPCValue[9] : fgChannelInfo2[10, 7].ToString();     //ch2_pc_max5,10

                cTbl_calib.ch3_plc_min1 = fgChannelInfo2[11, 4] == null ? defaultPlcValue[0] : fgChannelInfo2[11, 4].ToString();     //ch3_plc_min1,0
                cTbl_calib.ch3_plc_max1 = fgChannelInfo2[11, 5] == null ? defaultPlcValue[1] : fgChannelInfo2[11, 5].ToString();    //ch3_plc_max1,800
                cTbl_calib.ch3_plc_min2 = fgChannelInfo2[12, 4] == null ? defaultPlcValue[2] : fgChannelInfo2[12, 4].ToString();       //ch3_plc_min2,801
                cTbl_calib.ch3_plc_max2 = fgChannelInfo2[12, 5] == null ? defaultPlcValue[3] : fgChannelInfo2[12, 5].ToString(); ;    //ch3_plc_max2,1600
                cTbl_calib.ch3_plc_min3 = fgChannelInfo2[13, 4] == null ? defaultPlcValue[4] : fgChannelInfo2[13, 4].ToString();       //ch3_plc_min3,1601
                cTbl_calib.ch3_plc_max3 = fgChannelInfo2[13, 5] == null ? defaultPlcValue[5] : fgChannelInfo2[13, 5].ToString(); ;    //ch3_plc_max3,2400
                cTbl_calib.ch3_plc_min4 = fgChannelInfo2[14, 4] == null ? defaultPlcValue[6] : fgChannelInfo2[14, 4].ToString();       //ch3_plc_min4,2401
                cTbl_calib.ch3_plc_max4 = fgChannelInfo2[14, 5] == null ? defaultPlcValue[7] : fgChannelInfo2[14, 5].ToString(); ;    //ch3_plc_max4,3200
                cTbl_calib.ch3_plc_min5 = fgChannelInfo2[15, 4] == null ? defaultPlcValue[8] : fgChannelInfo2[15, 4].ToString();       //ch3_plc_min5,3201
                cTbl_calib.ch3_plc_max5 = fgChannelInfo2[15, 5] == null ? defaultPlcValue[9] : fgChannelInfo2[15, 5].ToString(); ;    //ch3_plc_max5,4000

                cTbl_calib.ch3_pc_min1 = fgChannelInfo2[11, 6] == null ? defaultPCValue[0] : fgChannelInfo2[11, 6].ToString();       //ch3_pc_min1,0
                cTbl_calib.ch3_pc_max1 = fgChannelInfo2[11, 7] == null ? defaultPCValue[1] : fgChannelInfo2[11, 7].ToString();       //ch3_pc_max1,2
                cTbl_calib.ch3_pc_min2 = fgChannelInfo2[12, 6] == null ? defaultPCValue[2] : fgChannelInfo2[12, 6].ToString();       //ch3_pc_min2,2.1
                cTbl_calib.ch3_pc_max2 = fgChannelInfo2[12, 7] == null ? defaultPCValue[3] : fgChannelInfo2[12, 7].ToString();       //ch3_pc_max2,4
                cTbl_calib.ch3_pc_min3 = fgChannelInfo2[13, 6] == null ? defaultPCValue[4] : fgChannelInfo2[13, 6].ToString();       //ch3_pc_min3,4.1
                cTbl_calib.ch3_pc_max3 = fgChannelInfo2[13, 7] == null ? defaultPCValue[5] : fgChannelInfo2[13, 7].ToString();       //ch3_pc_max3,6
                cTbl_calib.ch3_pc_min4 = fgChannelInfo2[14, 6] == null ? defaultPCValue[6] : fgChannelInfo2[14, 6].ToString();       //ch3_pc_min4,6.1
                cTbl_calib.ch3_pc_max4 = fgChannelInfo2[14, 7] == null ? defaultPCValue[7] : fgChannelInfo2[14, 7].ToString();       //ch3_pc_max4,8
                cTbl_calib.ch3_pc_min5 = fgChannelInfo2[15, 6] == null ? defaultPCValue[8] : fgChannelInfo2[15, 6].ToString();       //ch3_pc_min5,8.1
                cTbl_calib.ch3_pc_max5 = fgChannelInfo2[15, 7] == null ? defaultPCValue[9] : fgChannelInfo2[15, 7].ToString();       //ch3_pc_max5,10

                cTbl_calib.ch4_plc_min1 = fgChannelInfo2[16, 4] == null ? "0" : fgChannelInfo2[16, 4].ToString();    //ch4_plc_min1,0
                cTbl_calib.ch4_plc_max1 = fgChannelInfo2[16, 5] == null ? "4000" : fgChannelInfo2[16, 5].ToString();     //ch4_plc_max1,4000
                cTbl_calib.ch4_pc_min1 = fgChannelInfo2[16, 6] == null ? "0" : fgChannelInfo2[16, 6].ToString();   //ch4_pc_min1,0
                cTbl_calib.ch4_pc_max1 = fgChannelInfo2[16, 7] == null ? "10" : fgChannelInfo2[16, 7].ToString();    //ch4_pc_max1,10

                cTbl_calib.ch5_plc_min1 = fgChannelInfo2[17, 4] == null ? "0" : fgChannelInfo2[17, 4].ToString();      //ch5_plc_min1,0
                cTbl_calib.ch5_plc_max1 = fgChannelInfo2[17, 5] == null ? "4000" : fgChannelInfo2[17, 5].ToString();     //ch5_plc_max1,4000
                cTbl_calib.ch5_pc_min1 = fgChannelInfo2[17, 6] == null ? "0" : fgChannelInfo2[17, 6].ToString();      //ch5_pc_min1,0
                cTbl_calib.ch5_pc_max1 = fgChannelInfo2[17, 7] == null ? "10" : fgChannelInfo2[17, 7].ToString();      //ch5_pc_max1,10

                cTbl_calib.ch6_plc_min1 = fgChannelInfo2[18, 4] == null ? "0" : fgChannelInfo2[18, 4].ToString();     //ch6_plc_min1,0
                cTbl_calib.ch6_plc_max1 = fgChannelInfo2[18, 5] == null ? "4000" : fgChannelInfo2[18, 5].ToString();    //ch6_plc_max1,4000
                cTbl_calib.ch6_pc_min1 = fgChannelInfo2[18, 6] == null ? "0" : fgChannelInfo2[18, 6].ToString();     //ch6_pc_min1,0
                cTbl_calib.ch6_pc_max1 = fgChannelInfo2[18, 7] == null ? "10" : fgChannelInfo2[18, 7].ToString();     //ch6_pc_max1,10

                cTbl_calib.ch7_plc_min1 = fgChannelInfo2[19, 4] == null ? "0" : fgChannelInfo2[19, 4].ToString();      //ch7_plc_min1,0
                cTbl_calib.ch7_plc_max1 = fgChannelInfo2[19, 5] == null ? "4000" : fgChannelInfo2[19, 5].ToString();    //ch7_plc_max1,4000
                cTbl_calib.ch7_pc_min1 = fgChannelInfo2[19, 6] == null ? "0" : fgChannelInfo2[19, 6].ToString();       //ch7_pc_min1,0
                cTbl_calib.ch7_pc_max1 = fgChannelInfo2[19, 7] == null ? "10" : fgChannelInfo2[19, 7].ToString(); ;      //ch7_pc_max1,10

                cTbl_calib.ch8_plc_min1 = fgChannelInfo2[20, 4] == null ? "0" : fgChannelInfo2[20, 4].ToString();      //ch8_plc_min1,0
                cTbl_calib.ch8_plc_max1 = fgChannelInfo2[20, 5] == null ? "4000" : fgChannelInfo2[20, 5].ToString();     //ch8_plc_max1,4000
                cTbl_calib.ch8_pc_min1 = fgChannelInfo2[20, 6] == null ? "0" : fgChannelInfo2[20, 6].ToString();       //ch8_pc_min1,0
                cTbl_calib.ch8_pc_max1 = fgChannelInfo2[20, 7] == null ? "10" : fgChannelInfo2[20, 7].ToString();       //ch8_pc_max1,10

                cTbl_calib.ch9_plc_min1 = fgChannelInfo2[21, 4] == null ? "0" : fgChannelInfo2[21, 4].ToString();        //ch9_plc_min1,0
                cTbl_calib.ch9_plc_max1 = fgChannelInfo2[21, 5] == null ? "4000" : fgChannelInfo2[21, 5].ToString(); ;     //ch9_plc_max1,4000
                cTbl_calib.ch9_pc_min1 = fgChannelInfo2[21, 6] == null ? "0" : fgChannelInfo2[21, 6].ToString();        //ch9_pc_min1,0
                cTbl_calib.ch9_pc_max1 = fgChannelInfo2[21, 7] == null ? "10" : fgChannelInfo2[21, 7].ToString();        //ch9_pc_max1,10

                cTbl_calib.ch10_plc_min1 = fgChannelInfo2[22, 4] == null ? "0" : fgChannelInfo2[22, 4].ToString();       //ch10_plc_min1,0
                cTbl_calib.ch10_plc_max1 = fgChannelInfo2[22, 5] == null ? "4000" : fgChannelInfo2[22, 5].ToString();     //ch10_plc_max1,4000
                cTbl_calib.ch10_pc_min1 = fgChannelInfo2[22, 6] == null ? "0" : fgChannelInfo2[22, 6].ToString();         //ch10_pc_min1,0
                cTbl_calib.ch10_pc_max1 = fgChannelInfo2[22, 7] == null ? "10" : fgChannelInfo2[22, 7].ToString();       //ch10_pc_max1,10

                cTbl_calib.ch11_plc_min1 = fgChannelInfo2[23, 4] == null ? "0" : fgChannelInfo2[23, 4].ToString();       //ch11_plc_min1,0
                cTbl_calib.ch11_plc_max1 = fgChannelInfo2[23, 5] == null ? "4000" : fgChannelInfo2[23, 5].ToString();      //ch11_plc_max1,4000
                cTbl_calib.ch11_pc_min1 = fgChannelInfo2[23, 6] == null ? "0" : fgChannelInfo2[23, 6].ToString();         //ch11_pc_min1,0
                cTbl_calib.ch11_pc_max1 = fgChannelInfo2[23, 7] == null ? "10" : fgChannelInfo2[23, 7].ToString();     //ch11_pc_max1,10

                cTbl_calib.ch12_plc_min1 = fgChannelInfo2[24, 4] == null ? "0" : fgChannelInfo2[24, 4].ToString();       //ch12_plc_min1,0
                cTbl_calib.ch12_plc_max1 = fgChannelInfo2[24, 5] == null ? "4000" : fgChannelInfo2[24, 5].ToString();      //ch12_plc_max1,4000
                cTbl_calib.ch12_pc_min1 = fgChannelInfo2[24, 6] == null ? "0" : fgChannelInfo2[24, 6].ToString();        //ch12_pc_min1,0
                cTbl_calib.ch12_pc_max1 = fgChannelInfo2[24, 7] == null ? "10" : fgChannelInfo2[24, 7].ToString();        //ch12_pc_max1,10

                cTbl_calib.ch1_name = fgChannelInfo1[1, 3] == null ? "AI01" : fgChannelInfo1[1, 3].ToString();    //ch1_name, AI01
                cTbl_calib.ch2_name = fgChannelInfo1[2, 3] == null ? "AI02" : fgChannelInfo1[2, 3].ToString();    //ch2_name, AI02
                cTbl_calib.ch3_name = fgChannelInfo1[3, 3] == null ? "AI03" : fgChannelInfo1[3, 3].ToString();    //ch3_name,AI03
                cTbl_calib.ch4_name = fgChannelInfo1[4, 3] == null ? "AI04" : fgChannelInfo1[4, 3].ToString();    //ch4_name, AI04
                cTbl_calib.ch5_name = fgChannelInfo1[5, 3] == null ? "AI05" : fgChannelInfo1[5, 3].ToString();    //ch5_name,AI05
                cTbl_calib.ch6_name = fgChannelInfo1[6, 3] == null ? "AI06" : fgChannelInfo1[6, 3].ToString();    //ch6_name, AI06
                cTbl_calib.ch7_name = fgChannelInfo1[7, 3] == null ? "AI07" : fgChannelInfo1[7, 3].ToString();    //ch7_name,AI07
                cTbl_calib.ch8_name = fgChannelInfo1[8, 3] == null ? "AI08" : fgChannelInfo1[8, 3].ToString();    //ch8_name, AI08
                cTbl_calib.ch9_name = fgChannelInfo1[9, 3] == null ? "AI09" : fgChannelInfo1[9, 3].ToString();    //ch9_name,AI09
                cTbl_calib.ch10_name = fgChannelInfo1[10, 3] == null ? "AI10" : fgChannelInfo1[10, 3].ToString();     //ch10_name, AI10
                cTbl_calib.ch11_name = fgChannelInfo1[11, 3] == null ? "AI11" : fgChannelInfo1[11, 3].ToString();     //ch11_name,AI11
                cTbl_calib.ch12_name = fgChannelInfo1[12, 3] == null ? "AI12" : fgChannelInfo1[12, 3].ToString();     //ch12_name, AI12

                cTbl_calib.ch1_unit = fgChannelInfo1[1, 4] == null ? "AI01" : fgChannelInfo1[1, 4].ToString();    //ch1_unit,AI01
                cTbl_calib.ch2_unit = fgChannelInfo1[2, 4] == null ? "AI02" : fgChannelInfo1[2, 4].ToString();    //ch2_unit, AI02
                cTbl_calib.ch3_unit = fgChannelInfo1[3, 4] == null ? "AI03" : fgChannelInfo1[3, 4].ToString();    //ch3_unit,AI03
                cTbl_calib.ch4_unit = fgChannelInfo1[4, 4] == null ? "AI04" : fgChannelInfo1[4, 4].ToString();    //ch4_unit, AI04
                cTbl_calib.ch5_unit = fgChannelInfo1[5, 4] == null ? "AI05" : fgChannelInfo1[5, 4].ToString();    //ch5_unit,AI05
                cTbl_calib.ch6_unit = fgChannelInfo1[6, 4] == null ? "AI06" : fgChannelInfo1[6, 4].ToString();    //ch6_unit, AI06
                cTbl_calib.ch7_unit = fgChannelInfo1[7, 4] == null ? "AI07" : fgChannelInfo1[7, 4].ToString();    //ch7_unit,AI07
                cTbl_calib.ch8_unit = fgChannelInfo1[8, 4] == null ? "AI08" : fgChannelInfo1[8, 4].ToString();    //ch8_unit, AI08
                cTbl_calib.ch9_unit = fgChannelInfo1[9, 4] == null ? "AI09" : fgChannelInfo1[9, 4].ToString();    //ch9_unit,AI09
                cTbl_calib.ch10_unit = fgChannelInfo1[10, 4] == null ? "AI10" : fgChannelInfo1[10, 4].ToString();   //ch10_unit, AI10
                cTbl_calib.ch11_unit = fgChannelInfo1[11, 4] == null ? "AI11" : fgChannelInfo1[11, 4].ToString();   //ch11_unit,AI11
                cTbl_calib.ch12_unit = fgChannelInfo1[12, 4] == null ? "AI12" : fgChannelInfo1[12, 4].ToString();    //ch12_unit, AI12


                try
                {

                    string strNowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    string dbsql = $@"UPDATE tbl_plc_calibration 
                        SET  
                        ch1_plc_min1='{cTbl_calib.ch1_plc_min1}',
                        ch1_plc_max1='{cTbl_calib.ch1_plc_max1}',
                        ch1_plc_min2='{cTbl_calib.ch1_plc_min2}',
                        ch1_plc_max2='{cTbl_calib.ch1_plc_max2}',
                        ch1_plc_min3='{cTbl_calib.ch1_plc_min3}',
                        ch1_plc_max3='{cTbl_calib.ch1_plc_max3}',
                        ch1_plc_min4='{cTbl_calib.ch1_plc_min4}',
                        ch1_plc_max4='{cTbl_calib.ch1_plc_max4}',
                        ch1_plc_min5='{cTbl_calib.ch1_plc_min5}',
                        ch1_plc_max5='{cTbl_calib.ch1_plc_max5}',
                        ch1_pc_min1='{cTbl_calib.ch1_pc_min1}',
                        ch1_pc_max1='{cTbl_calib.ch1_pc_max1}',
                        ch1_pc_min2='{cTbl_calib.ch1_pc_min2}',
                        ch1_pc_max2='{cTbl_calib.ch1_pc_max2}',
                        ch1_pc_min3='{cTbl_calib.ch1_pc_min3}',
                        ch1_pc_max3='{cTbl_calib.ch1_pc_max3}',
                        ch1_pc_min4='{cTbl_calib.ch1_pc_min4}',
                        ch1_pc_max4='{cTbl_calib.ch1_pc_max4}',
                        ch1_pc_min5='{cTbl_calib.ch1_pc_min5}',
                        ch1_pc_max5='{cTbl_calib.ch1_pc_max5}',
                        ch2_plc_min1='{cTbl_calib.ch2_plc_min1}',
                        ch2_plc_max1='{cTbl_calib.ch2_plc_max1}',
                        ch2_plc_min2='{cTbl_calib.ch2_plc_min2}',
                        ch2_plc_max2='{cTbl_calib.ch2_plc_max2}',
                        ch2_plc_min3='{cTbl_calib.ch2_plc_min3}',
                        ch2_plc_max3='{cTbl_calib.ch2_plc_max3}',
                        ch2_plc_min4='{cTbl_calib.ch2_plc_min4}',
                        ch2_plc_max4='{cTbl_calib.ch2_plc_max4}',
                        ch2_plc_min5='{cTbl_calib.ch2_plc_min5}',
                        ch2_plc_max5='{cTbl_calib.ch2_plc_max5}',
                        ch2_pc_min1='{cTbl_calib.ch2_pc_min1}',
                        ch2_pc_max1='{cTbl_calib.ch2_pc_max1}',
                        ch2_pc_min2='{cTbl_calib.ch2_pc_min2}',
                        ch2_pc_max2='{cTbl_calib.ch2_pc_max2}',
                        ch2_pc_min3='{cTbl_calib.ch2_pc_min3}',
                        ch2_pc_max3='{cTbl_calib.ch2_pc_max3}',
                        ch2_pc_min4='{cTbl_calib.ch2_pc_min4}',
                        ch2_pc_max4='{cTbl_calib.ch2_pc_max4}',
                        ch2_pc_min5='{cTbl_calib.ch2_pc_min5}',
                        ch2_pc_max5='{cTbl_calib.ch2_pc_max5}',
                        ch3_plc_min1='{cTbl_calib.ch3_plc_min1}',
                        ch3_plc_max1='{cTbl_calib.ch3_plc_max1}',
                        ch3_plc_min2='{cTbl_calib.ch3_plc_min2}',
                        ch3_plc_max2='{cTbl_calib.ch3_plc_max2}',
                        ch3_plc_min3='{cTbl_calib.ch3_plc_min3}',
                        ch3_plc_max3='{cTbl_calib.ch3_plc_max3}',
                        ch3_plc_min4='{cTbl_calib.ch3_plc_min4}',
                        ch3_plc_max4='{cTbl_calib.ch3_plc_max4}',
                        ch3_plc_min5='{cTbl_calib.ch3_plc_min5}',
                        ch3_plc_max5='{cTbl_calib.ch3_plc_max5}',
                        ch3_pc_min1='{cTbl_calib.ch3_pc_min1}',
                        ch3_pc_max1='{cTbl_calib.ch3_pc_max1}',
                        ch3_pc_min2='{cTbl_calib.ch3_pc_min2}',
                        ch3_pc_max2='{cTbl_calib.ch3_pc_max2}',
                        ch3_pc_min3='{cTbl_calib.ch3_pc_min3}',
                        ch3_pc_max3='{cTbl_calib.ch3_pc_max3}',
                        ch3_pc_min4='{cTbl_calib.ch3_pc_min4}',
                        ch3_pc_max4='{cTbl_calib.ch3_pc_max4}',
                        ch3_pc_min5='{cTbl_calib.ch3_pc_min5}',
                        ch3_pc_max5='{cTbl_calib.ch3_pc_max5}',
                        ch4_plc_min1='{cTbl_calib.ch4_plc_min1}',
                        ch4_plc_max1='{cTbl_calib.ch4_plc_max1}',
                        ch4_pc_min1='{cTbl_calib.ch4_pc_min1}',
                        ch4_pc_max1='{cTbl_calib.ch4_pc_max1}',
                        ch5_plc_min1='{cTbl_calib.ch5_plc_min1}',
                        ch5_plc_max1='{cTbl_calib.ch5_plc_max1}',
                        ch5_pc_min1='{cTbl_calib.ch5_pc_min1}',
                        ch5_pc_max1='{cTbl_calib.ch5_pc_max1}',
                        ch6_plc_min1='{cTbl_calib.ch6_plc_min1}',
                        ch6_plc_max1='{cTbl_calib.ch6_plc_max1}',
                        ch6_pc_min1='{cTbl_calib.ch6_pc_min1}',
                        ch6_pc_max1='{cTbl_calib.ch6_pc_max1}',
                        ch7_plc_min1='{cTbl_calib.ch7_plc_min1}',
                        ch7_plc_max1='{cTbl_calib.ch7_plc_max1}',
                        ch7_pc_min1='{cTbl_calib.ch7_pc_min1}',
                        ch7_pc_max1='{cTbl_calib.ch7_pc_max1}',
                        ch8_plc_min1='{cTbl_calib.ch8_plc_min1}',
                        ch8_plc_max1='{cTbl_calib.ch8_plc_max1}',
                        ch8_pc_min1='{cTbl_calib.ch8_pc_min1}',
                        ch8_pc_max1='{cTbl_calib.ch8_pc_max1}',
                        ch9_plc_min1='{cTbl_calib.ch9_plc_min1}',
                        ch9_plc_max1='{cTbl_calib.ch9_plc_max1}',
                        ch9_pc_min1='{cTbl_calib.ch9_pc_min1}',
                        ch9_pc_max1='{cTbl_calib.ch9_pc_max1}',
                        ch10_plc_min1='{cTbl_calib.ch10_plc_min1}',
                        ch10_plc_max1='{cTbl_calib.ch10_plc_max1}',
                        ch10_pc_min1='{cTbl_calib.ch10_pc_min1}',
                        ch10_pc_max1='{cTbl_calib.ch10_pc_max1}',
                        ch11_plc_min1='{cTbl_calib.ch11_plc_min1}',
                        ch11_plc_max1='{cTbl_calib.ch11_plc_max1}',
                        ch11_pc_min1='{cTbl_calib.ch11_pc_min1}',
                        ch11_pc_max1='{cTbl_calib.ch11_pc_max1}',
                        ch12_plc_min1='{cTbl_calib.ch12_plc_min1}',
                        ch12_plc_max1='{cTbl_calib.ch12_plc_max1}',
                        ch12_pc_min1='{cTbl_calib.ch12_pc_min1}',
                        ch12_pc_max1='{cTbl_calib.ch12_pc_max1}',
                        ch1_name='{cTbl_calib.ch1_name}',
                        ch2_name='{cTbl_calib.ch2_name}',
                        ch3_name='{cTbl_calib.ch3_name}',
                        ch4_name='{cTbl_calib.ch4_name}',
                        ch5_name='{cTbl_calib.ch5_name}',
                        ch6_name='{cTbl_calib.ch6_name}',
                        ch7_name='{cTbl_calib.ch7_name}',
                        ch8_name='{cTbl_calib.ch8_name}',
                        ch9_name='{cTbl_calib.ch9_name}',
                        ch10_name='{cTbl_calib.ch10_name}',
                        ch11_name='{cTbl_calib.ch11_name}',
                        ch12_name='{cTbl_calib.ch12_name}',
                        ch1_unit='{cTbl_calib.ch1_unit}',
                        ch2_unit='{cTbl_calib.ch2_unit}',
                        ch3_unit='{cTbl_calib.ch3_unit}',
                        ch4_unit='{cTbl_calib.ch4_unit}',
                        ch5_unit='{cTbl_calib.ch5_unit}',
                        ch6_unit='{cTbl_calib.ch6_unit}',
                        ch7_unit='{cTbl_calib.ch7_unit}',
                        ch8_unit='{cTbl_calib.ch8_unit}',
                        ch9_unit='{cTbl_calib.ch9_unit}',
                        ch10_unit='{cTbl_calib.ch10_unit}',
                        ch11_unit='{cTbl_calib.ch11_unit}',
                        ch12_unit='{cTbl_calib.ch12_unit}',
                        updatedate = '{strNowTime}' 
                      WHERE id = '{cTbl_calib.id}' ; ";

                    cMysqlDto.OpenKeepUp();
                    cMysqlDto.RunSql("UPDATE", dbsql);

                    MessageBox.Show("업데이트가 완료 되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Info(cMwLog.PLCUpdateEventLog);

                }
                catch (Exception exc)
                {
                    System.Diagnostics.Debug.WriteLine(exc.Message);
                    cLog.Error(cMwLog.PLCUpdateError);
                    return;
                }
                finally
                {
                    cMysqlDto.Close();

                }

                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                    SelectCalibrationList();
                else
                    BtnSearch_Click(null, null);
            }
            catch
            {
            }
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                return;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                return;
            }
            else
            {
                e.Handled = false;
            }
        }

    }
}