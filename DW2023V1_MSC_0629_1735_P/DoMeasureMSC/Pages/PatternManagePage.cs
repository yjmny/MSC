using DBMS_V1;
using DBMS_V1.Data.MSC;
using EventLog;
using DwLib.Data;
using DWLib.Data.Generic;
using HMI_TEMI2500;
using log4net;
using log4net.Repository.Hierarchy;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;


namespace DoMeasureMSC.Pages
{
    public partial class PatternManagePage : Form
    {
        //디자인 영역====================================================================================================================
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatternManagePage));
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
            this.dgvPatternList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.btnReadPtnAutoUpdate = new System.Windows.Forms.Button();
            this.btnRegiM1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadPatternM1 = new System.Windows.Forms.Button();
            this.fgHmiGetPattern = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.com_ptno = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.fgDetail1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.fgDetail2 = new C1.Win.C1FlexGrid.C1FlexGrid();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatternList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgHmiGetPattern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgDetail1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgDetail2)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "패턴 관리";
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
            this.splitContainer4.Panel2.Controls.Add(this.dgvPatternList);
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
            this.cboSearchWord.Items.Add("패턴번호");
            this.cboSearchWord.Items.Add("패턴명");
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
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "패턴 조회";
            // 
            // dgvPatternList
            // 
            this.dgvPatternList.AllowUserToAddRows = false;
            this.dgvPatternList.AllowUserToDeleteRows = false;
            this.dgvPatternList.AllowUserToResizeColumns = false;
            this.dgvPatternList.AllowUserToResizeRows = false;
            this.dgvPatternList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatternList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatternList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatternList.ColumnHeadersHeight = 50;
            this.dgvPatternList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPatternList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvPatternList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPatternList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatternList.EnableHeadersVisualStyles = false;
            this.dgvPatternList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvPatternList.Location = new System.Drawing.Point(0, 0);
            this.dgvPatternList.MultiSelect = false;
            this.dgvPatternList.Name = "dgvPatternList";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatternList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPatternList.RowHeadersVisible = false;
            this.dgvPatternList.RowTemplate.Height = 23;
            this.dgvPatternList.RowTemplate.ReadOnly = true;
            this.dgvPatternList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatternList.Size = new System.Drawing.Size(815, 359);
            this.dgvPatternList.TabIndex = 0;
            this.dgvPatternList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPatternList_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "no";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.Column3.DataPropertyName = "com_ptno";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "패턴번호";
            this.Column3.MinimumWidth = 150;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "패턴명";
            this.Column2.MinimumWidth = 470;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 470;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "옵션";
            this.Column4.MinimumWidth = 150;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Text = "패턴제외";
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
            this.splitContainer6.Panel1.Controls.Add(this.btnReadPtnAutoUpdate);
            this.splitContainer6.Panel1.Controls.Add(this.btnRegiM1);
            this.splitContainer6.Panel1.Controls.Add(this.label3);
            this.splitContainer6.Panel1.Controls.Add(this.btnReadPatternM1);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.fgHmiGetPattern);
            this.splitContainer6.Panel2.Controls.Add(this.label5);
            this.splitContainer6.Panel2.Controls.Add(this.label6);
            this.splitContainer6.Panel2.Controls.Add(this.com_ptno);
            this.splitContainer6.Panel2.Controls.Add(this.name);
            this.splitContainer6.Size = new System.Drawing.Size(821, 446);
            this.splitContainer6.SplitterDistance = 83;
            this.splitContainer6.TabIndex = 0;
            // 
            // btnReadPtnAutoUpdate
            // 
            this.btnReadPtnAutoUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnReadPtnAutoUpdate.FlatAppearance.BorderSize = 0;
            this.btnReadPtnAutoUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadPtnAutoUpdate.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReadPtnAutoUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnReadPtnAutoUpdate.Location = new System.Drawing.Point(154, 48);
            this.btnReadPtnAutoUpdate.Name = "btnReadPtnAutoUpdate";
            this.btnReadPtnAutoUpdate.Size = new System.Drawing.Size(282, 32);
            this.btnReadPtnAutoUpdate.TabIndex = 3;
            this.btnReadPtnAutoUpdate.Text = "자동 일괄 패턴 읽기 && 업데이트";
            this.btnReadPtnAutoUpdate.UseVisualStyleBackColor = false;
            this.btnReadPtnAutoUpdate.Visible = false;
            this.btnReadPtnAutoUpdate.Click += new System.EventHandler(this.BtnReadPtnAutoUpdate_Click);
            // 
            // btnRegiM1
            // 
            this.btnRegiM1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnRegiM1.FlatAppearance.BorderSize = 0;
            this.btnRegiM1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegiM1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRegiM1.ForeColor = System.Drawing.Color.Black;
            this.btnRegiM1.Location = new System.Drawing.Point(536, 0);
            this.btnRegiM1.Name = "btnRegiM1";
            this.btnRegiM1.Size = new System.Drawing.Size(282, 32);
            this.btnRegiM1.TabIndex = 1;
            this.btnRegiM1.Text = "2. DB에 패턴 등록";
            this.btnRegiM1.UseVisualStyleBackColor = false;
            this.btnRegiM1.Click += new System.EventHandler(this.BtnRegiM1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "패턴 등록";
            // 
            // btnReadPatternM1
            // 
            this.btnReadPatternM1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnReadPatternM1.FlatAppearance.BorderSize = 0;
            this.btnReadPatternM1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadPatternM1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReadPatternM1.ForeColor = System.Drawing.Color.Black;
            this.btnReadPatternM1.Location = new System.Drawing.Point(248, 0);
            this.btnReadPatternM1.Name = "btnReadPatternM1";
            this.btnReadPatternM1.Size = new System.Drawing.Size(282, 32);
            this.btnReadPatternM1.TabIndex = 2;
            this.btnReadPatternM1.Text = "1. HMI로부터 패턴 읽기";
            this.btnReadPatternM1.UseVisualStyleBackColor = false;
            this.btnReadPatternM1.Click += new System.EventHandler(this.BtnReadPatternM1_Click);
            // 
            // fgHmiGetPattern
            // 
            this.fgHmiGetPattern.AllowEditing = false;
            this.fgHmiGetPattern.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgHmiGetPattern.AutoGenerateColumns = false;
            this.fgHmiGetPattern.BackColor = System.Drawing.Color.White;
            this.fgHmiGetPattern.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgHmiGetPattern.ColumnInfo = resources.GetString("fgHmiGetPattern.ColumnInfo");
            this.fgHmiGetPattern.ExtendLastCol = true;
            this.fgHmiGetPattern.Location = new System.Drawing.Point(4, 73);
            this.fgHmiGetPattern.Name = "fgHmiGetPattern";
            this.fgHmiGetPattern.Rows.Count = 10;
            this.fgHmiGetPattern.Rows.DefaultSize = 28;
            this.fgHmiGetPattern.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgHmiGetPattern.Size = new System.Drawing.Size(814, 286);
            this.fgHmiGetPattern.StyleInfo = resources.GetString("fgHmiGetPattern.StyleInfo");
            this.fgHmiGetPattern.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(9, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "패턴번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(9, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "패턴명";
            // 
            // com_ptno
            // 
            this.com_ptno.BackColor = System.Drawing.Color.Cornsilk;
            this.com_ptno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.com_ptno.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.com_ptno.Location = new System.Drawing.Point(94, 2);
            this.com_ptno.Name = "com_ptno";
            this.com_ptno.Size = new System.Drawing.Size(715, 26);
            this.com_ptno.TabIndex = 12;
            this.com_ptno.Tag = "HMI에서 읽어올 패턴번호를 입력하세요. (Ex:1)";
            this.com_ptno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Cornsilk;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(94, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(715, 26);
            this.name.TabIndex = 13;
            this.name.Tag = "DB에 저장할 패턴명을 입력하세요. (Ex:패턴번호230401_01)";
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
            this.splitContainer5.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.fgDetail1);
            this.splitContainer5.Panel2.Controls.Add(this.fgDetail2);
            this.splitContainer5.Size = new System.Drawing.Size(1640, 446);
            this.splitContainer5.SplitterDistance = 66;
            this.splitContainer5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(0, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "패턴 상세정보";
            // 
            // fgDetail1
            // 
            this.fgDetail1.AllowEditing = false;
            this.fgDetail1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgDetail1.BackColor = System.Drawing.Color.White;
            this.fgDetail1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgDetail1.ColumnInfo = resources.GetString("fgDetail1.ColumnInfo");
            this.fgDetail1.ExtendLastCol = true;
            this.fgDetail1.Location = new System.Drawing.Point(0, 0);
            this.fgDetail1.Name = "fgDetail1";
            this.fgDetail1.Rows.Count = 2;
            this.fgDetail1.Rows.DefaultSize = 28;
            this.fgDetail1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgDetail1.Size = new System.Drawing.Size(375, 58);
            this.fgDetail1.StyleInfo = resources.GetString("fgDetail1.StyleInfo");
            this.fgDetail1.TabIndex = 16;
            // 
            // fgDetail2
            // 
            this.fgDetail2.AllowEditing = false;
            this.fgDetail2.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgDetail2.BackColor = System.Drawing.Color.White;
            this.fgDetail2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgDetail2.ColumnInfo = resources.GetString("fgDetail2.ColumnInfo");
            this.fgDetail2.ExtendLastCol = true;
            this.fgDetail2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fgDetail2.Location = new System.Drawing.Point(381, 0);
            this.fgDetail2.Name = "fgDetail2";
            this.fgDetail2.Rows.Count = 13;
            this.fgDetail2.Rows.DefaultSize = 28;
            this.fgDetail2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgDetail2.Size = new System.Drawing.Size(1259, 364);
            this.fgDetail2.StyleInfo = resources.GetString("fgDetail2.StyleInfo");
            this.fgDetail2.TabIndex = 15;
            // 
            // PatternManagePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1640, 950);
            this.MinimumSize = new System.Drawing.Size(1640, 950);
            this.Name = "PatternManagePage";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatternList)).EndInit();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgHmiGetPattern)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgDetail1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgDetail2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView dgvPatternList;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button btnShowAllList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegiM1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox com_ptno;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button btnReadPatternM1;
        private System.Windows.Forms.TextBox tbSearch;
        private C1.Win.C1Input.C1ComboBox cboSearchWord;
        private System.Windows.Forms.Button btnReadPtnAutoUpdate;
        private C1.Win.C1FlexGrid.C1FlexGrid fgHmiGetPattern;
        private C1.Win.C1FlexGrid.C1FlexGrid fgDetail2;
        private C1.Win.C1FlexGrid.C1FlexGrid fgDetail1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        //================================================================================================================================

        public PatternManagePage()
        {
            InitializeComponent();
            cTbl_hmi_pattern = new Tbl_hmi_pattern();
            SelectPatternList();
            cboSearchWord.SelectedIndex = 0;

            com_ptno.Text = com_ptno.Tag.ToString();
            com_ptno.ForeColor = Color.Gray;

            name.Text = name.Tag.ToString();
            name.ForeColor = Color.Gray;

            this.com_ptno.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.com_ptno.Leave += new System.EventHandler(this.WaterMark_Leave);

            this.name.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.name.Leave += new System.EventHandler(this.WaterMark_Leave);
        }

        private readonly MeasureWriteLog cMwLog = new MeasureWriteLog();
        private static readonly ILog cLog = LogManager.GetLogger("Measure");
        private readonly MySqlDTO cMysqlDto = new MySqlDTO();
        readonly Tbl_hmi_pattern cTbl_hmi_pattern;

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

       

        public void SelectPatternList()
        {
            try
            {
                string tableName = "tbl_hmi_pattern";

                string sql = $@"select(@num:= @num + 1) as no, com_ptno, name
                                from
                                (select distinct com_ptno, name from {tableName} where out10='0'
                                order by com_ptno  asc) t ,(select @num:= 0) as s ;";

                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                dgvPatternList.DataSource = dt;

            }
            catch (Exception)
            {
                cLog.Error(cMwLog.PatternListShowLoadError);
            }
        }
        private void BtnRegiM1_Click(object sender, EventArgs e)
        {
            string strBtnName = "저장";
            if (fgHmiGetPattern[2, 2] == null)
            {
                MessageBox.Show("패턴정보가 없습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                cLog.Info(cMwLog.ChosenPatternRegisterEventLog);

                if (MessageBox.Show("저장 하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Tbl_hmi_pattern tPattern = new Tbl_hmi_pattern()
                    {
                        com_ptno = string.IsNullOrEmpty(com_ptno.Text) ? "" : com_ptno.Text,
                        name = string.IsNullOrEmpty(name.Text) ? "" : name.Text.ToString(),
                    };


                    if (string.IsNullOrEmpty(tPattern.com_ptno))
                    {
                        MessageBox.Show("패턴번호 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        return;
                    }
                    if (string.IsNullOrEmpty(tPattern.name))
                    {
                        MessageBox.Show("패턴명 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        return;
                    }

                    try
                    {
                        int rowCnt = 0;
                        string dbsql = $"select count(*) as cnt from tbl_hmi_pattern where com_ptno='{tPattern.com_ptno}' ";


                        rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(dbsql, "cnt")[0]["cnt"]);

                        if (rowCnt != 0)
                        {
                            dbsql = $@"Delete from tbl_hmi_pattern WHERE com_ptno = '{tPattern.com_ptno}';";
                            cMysqlDto.OpenKeepUp();
                            cMysqlDto.RunSql("DELETE", dbsql);

                            if (Measure.IsHmiUse)
                            {
                                //-------------segment list
                                //`name HMI 패턴명 (PC)',
                                //`com_ptno 'HMI 패턴NO_HMI',
                                //`com_segno 'HMI 세그먼트 번호',
                                //`pattern_name 'HMI 패턴명(HW)',
                                //`temp_tsp'HMI 온도 목표 설정치 TEMP.TSP',
                                //`humi_tsp`HMI 습도 목표 설정치 HUMI.TSP',
                                //`seg_time_h 'HMI 세그먼트 설정시간  Hour',
                                //`seg_time_l 'HMI 세그먼트 설정시간  Minute & Second',
                                //`ts1`'HMI 타임시그널 ts1',
                                //`ts2`'HMI 타임시그널 ts2',
                                //`ts3`'HMI 타임시그널 ts3',
                                //`ts4`'HMI 타임시그널 ts4',
                                //`seg_wait`

                                int iRowMax = m_alistReadPtn.Count;
                                if (iRowMax > 0)
                                {
                                    for (int iRowIndex = 0; iRowIndex < iRowMax; iRowIndex++)
                                    {
                                        string[] strValue = m_alistReadPtn[iRowIndex].ToString().Split(',');
                                        //tPattern.com_ptno
                                        //tPattern.name 
                                        tPattern.com_segno = strValue[0];
                                        tPattern.temp_tsp = strValue[1];
                                        tPattern.humi_tsp = strValue[2];
                                        tPattern.seg_time_h = strValue[3];
                                        tPattern.seg_time_l = strValue[4];
                                        tPattern.ts1 = strValue[5];
                                        tPattern.ts2 = strValue[6];
                                        tPattern.ts3 = strValue[7];
                                        tPattern.ts4 = strValue[8];
                                        tPattern.seg_wait = strValue[9];

                                        InsertPatternSql(tPattern);
                                    }
                                }
                            }
                            dbsql = $@"INSERT INTO tbl_hmi_pattern(com_ptno, name) 
                        VALUE ('{tPattern.com_ptno}','{tPattern.name}') ;";

                            cMysqlDto.RunSql("INSERT", dbsql);
                            MessageBox.Show("업데이트 완료되었습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (Measure.IsHmiUse)
                            {
                                //-------------segment list
                                //`name HMI 패턴명 (PC)',
                                //`com_ptno 'HMI 패턴NO_HMI',
                                //`com_segno 'HMI 세그먼트 번호',
                                //`pattern_name 'HMI 패턴명(HW)',
                                //`temp_tsp'HMI 온도 목표 설정치 TEMP.TSP',
                                //`humi_tsp`HMI 습도 목표 설정치 HUMI.TSP',
                                //`seg_time_h 'HMI 세그먼트 설정시간  Hour',
                                //`seg_time_l 'HMI 세그먼트 설정시간  Minute & Second',
                                //`ts1`'HMI 타임시그널 ts1',
                                //`ts2`'HMI 타임시그널 ts2',
                                //`ts3`'HMI 타임시그널 ts3',
                                //`ts4`'HMI 타임시그널 ts4',
                                //`seg_wait`

                                int iRowMax = m_alistReadPtn.Count;
                                if (iRowMax > 0)
                                {
                                    for (int iRowIndex = 0; iRowIndex < iRowMax; iRowIndex++)
                                    {
                                        string[] strValue = m_alistReadPtn[iRowIndex].ToString().Split(',');
                                        tPattern.com_segno = strValue[0];
                                        tPattern.temp_tsp = strValue[1];
                                        tPattern.humi_tsp = strValue[2];
                                        tPattern.seg_time_h = strValue[3];
                                        tPattern.seg_time_l = strValue[4];
                                        tPattern.ts1 = strValue[5];
                                        tPattern.ts2 = strValue[6];
                                        tPattern.ts3 = strValue[7];
                                        tPattern.ts4 = strValue[8];
                                        tPattern.seg_wait = strValue[9];

                                        InsertPatternSql(tPattern);
                                    }
                                }
                            }
                            else
                            {
                                dbsql = $@"INSERT INTO tbl_hmi_pattern(com_ptno, name) 
                        VALUE ('{tPattern.com_ptno}','{tPattern.name}') ;";
                                cMysqlDto.OpenKeepUp();
                                cMysqlDto.RunSql("INSERT", dbsql);
                            }


                            //--------------
                            MessageBox.Show("등록이 완료되었습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        SelectPatternList();

                    }
                    catch (Exception)
                    {
                        cLog.Error(cMwLog.ChosenPatternRegisterError);
                    }
                    finally
                    {
                        cMysqlDto.Close();
                    }
                }
            }
        }

        private void InsertPatternSql(Tbl_hmi_pattern tPattern)
        {
            string dbsql = $@"INSERT INTO tbl_hmi_pattern(name,com_ptno, com_segno, temp_tsp, humi_tsp, seg_time_h, seg_time_l, ts1, ts2, ts3, ts4, seg_wait, seg_hhmmss ) 
                    VALUE ('{tPattern.name}','{tPattern.com_ptno}','{tPattern.com_segno}', '{tPattern.temp_tsp}','{tPattern.humi_tsp}',
                           '{tPattern.seg_time_h}','{tPattern.seg_time_l}','{tPattern.ts1}', '{tPattern.ts2}','{tPattern.ts3}','{tPattern.ts4}','{tPattern.seg_wait}','{tPattern.seg_hhmmss}'
                    ) ;";

            cMysqlDto.OpenKeepUp();
            cMysqlDto.RunSql("INSERT", dbsql);
        }

        private void DgvPatternList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                string strBtnName = "패턴 제외";
                if (MessageBox.Show("제외하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                DataGridViewRow row = dgvPatternList.SelectedRows[0]; //선택된 Row 값 가져옴.
                string com_ptno = row.Cells[2].Value.ToString();


                try
                {
                    cMysqlDto.OpenKeepUp();
                    string dbsql = $@"update tbl_hmi_pattern set out10 =1 where com_ptno='{com_ptno}'";
                    cMysqlDto.RunSql("UPDATE", dbsql);

                    MessageBox.Show("제외되었습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Info(cMwLog.PatternDeleteEventLog);
                    SelectPatternList();

                }
                catch (Exception)
                {
                    MessageBox.Show("패턴 제외 실패", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Error(cMwLog.PatternDeleteError);
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

        private void ShowDetail(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fgDetail1[1, 1] = "1";
                cTbl_hmi_pattern.com_ptno = dgvPatternList.Rows[e.RowIndex].Cells[2].Value.ToString();
                cTbl_hmi_pattern.name = dgvPatternList.Rows[e.RowIndex].Cells[3].Value.ToString();

                fgDetail1[1, 2] = cTbl_hmi_pattern.com_ptno;
                fgDetail1[1, 3] = cTbl_hmi_pattern.name;

                SelectDetail2();
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc);
            }
        }

        private void SelectDetail2()
        {
            try
            {
                string tableName = "tbl_hmi_pattern";
                string columns = "com_segno, temp_tsp, humi_tsp, seg_hhmmss, ts1, ts2, ts3,ts4, seg_wait ";
                string sql = $@"select (@num:=@num+1) as no, {columns} from {tableName},(select @num:= 0) as s
                where com_ptno = '{cTbl_hmi_pattern.com_ptno}' ;";

                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                fgDetail2.SetDataBinding(dt, dt.TableName, true);


            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.ToString());
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

            string sql = "";

            string strSerchOpt = cboSearchWord.SelectedItem.ToString();

            if (tbSearch.Text.StartsWith("검색어"))
            {
                tbSearch.Text = "";
            }
            switch (strSerchOpt)
            {
                case "패턴명":
                    sql = $"select count(*) as cnt from tbl_hmi_pattern ,(select @num:=0) as s where name like '%{tbSearch.Text}%' ";
                    break;
                case "패턴번호":
                    sql = $"select count(*) as cnt from tbl_hmi_pattern ,(select @num:=0) as s where com_ptno like '%{tbSearch.Text}%'";
                    break;
                case "전체":
                    sql = $"select count(*) as cnt from tbl_hmi_pattern ,(select @num:=0) as s where (name like '%{tbSearch.Text}%' or com_ptno like '%{tbSearch.Text}%')";
                    break;
            }

            try
            {


               int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(sql, "cnt")[0]["cnt"]);

                if (rowCnt == 0)
                {
                    MessageBox.Show("패턴이 없습니다.", "패턴관리", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        sql = $"select (@num:=@num+1) as no,  com_ptno, name from tbl_hmi_pattern where name like '%{tbSearch.Text}%' group by com_ptno ";
                        break;
                    case "패턴번호":
                        sql = $"select (@num:=@num+1) as no, com_ptno, name from tbl_hmi_pattern where com_ptno like '%{tbSearch.Text}%' group by com_ptno";
                        break;
                    case "전체":
                        sql = $"select (@num:=@num+1) as no, com_ptno, name from tbl_hmi_pattern where (name like '%{tbSearch.Text}%' or com_ptno like '%{tbSearch.Text}%') group by com_ptno";
                        break;
                }

                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                dgvPatternList.DataSource = dt;
                cLog.Info(cMwLog.PatternSearchClickEventLog);
            }
            catch (Exception)
            {
                MessageBox.Show("패턴 검색 실패", "패턴관리", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnShowAllList_Click(object sender, EventArgs e)
        {
            SelectPatternList();
        }

        private void BtnReadPtnAutoUpdate_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.AllPatternRnREventLog);
        }


        private void BtnReadPatternM1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(com_ptno.Text))
            {
                MessageBox.Show("HMI 패턴번호가 지정되지 않았습니다.", "패턴번호 읽기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (com_ptno.Text.Equals(com_ptno.Tag))
            {
                MessageBox.Show("HMI 패턴번호가 지정되지 않았습니다.", "패턴번호 읽기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("패턴명이 지정되지 않았습니다.", "패턴번호 읽기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (name.Text.Equals(name.Tag))
            {
                MessageBox.Show("패턴명이 지정되지 않았습니다.", "패턴번호 읽기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("HMI로부터 패턴읽기 하시겠습니까?", "패턴번호 읽기", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (Measure.IsHmiUse)
            {
                cLog.Info(cMwLog.ChosenPatternReadEventLog);
                ReadMaualOnePattern();//수동 지정 패턴 읽기
            }
            else
            {
                MessageBox.Show("HMI 컨트롤러가 활성화되지 않았습니다.", "패턴번호 읽기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
        ArrayList m_alistReadPtn = new ArrayList();
        Tbl_hmi_pattern[] regiPatternDatas;
        private void ReadMaualOnePattern()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (HmiCtrl.mIns != null)
                {
                    if (string.IsNullOrEmpty(com_ptno.Text)) return;
                    Int32.TryParse(com_ptno.Text, out int iPatternNo);
                    if (iPatternNo == 0) return;
                    ArrayList aList = HmiCtrl.mIns.ReadPattenNo(iPatternNo: iPatternNo);
                    m_alistReadPtn = null;
                    m_alistReadPtn = aList;
                    int listCountMax = aList.Count;
                    if (listCountMax > 0)
                    {
                        fgHmiGetPattern.Rows.RemoveRange(1, fgHmiGetPattern.Rows.Count - 1);
                        if (listCountMax > 10)
                        {
                            fgHmiGetPattern.Rows.Count = listCountMax + 1;
                        }
                        else
                        {
                            fgHmiGetPattern.Rows.Count = 10;
                        }
                        int idx = 1;
                        int iIncNum = 0;
                        regiPatternDatas = null;
                        regiPatternDatas = new Tbl_hmi_pattern[listCountMax];
                        foreach (String item in aList)
                        {
                            regiPatternDatas[iIncNum] = new Tbl_hmi_pattern();
                            //System.Diagnostics.Debug.WriteLine(item);
                            string[] sData = item.Split(',');

                            regiPatternDatas[iIncNum].com_segno = sData[0];
                            regiPatternDatas[iIncNum].temp_tsp = sData[1];
                            regiPatternDatas[iIncNum].humi_tsp = sData[2];
                            regiPatternDatas[iIncNum].seg_time_h = sData[3];
                            regiPatternDatas[iIncNum].seg_time_l = sData[4];
                            regiPatternDatas[iIncNum].ts1 = sData[5];
                            regiPatternDatas[iIncNum].ts2 = sData[6];
                            regiPatternDatas[iIncNum].ts3 = sData[7];
                            regiPatternDatas[iIncNum].ts4 = sData[8];
                            regiPatternDatas[iIncNum].seg_wait = sData[9];

                            Int32.TryParse(regiPatternDatas[iIncNum].seg_time_h, out Int32 HH);
                            string smm = regiPatternDatas[iIncNum].seg_time_l.Substring(0, 2);
                            string ssec = regiPatternDatas[iIncNum].seg_time_l.Substring(2);
                            Int32.TryParse(smm, out Int32 mm);
                            Int32.TryParse(ssec, out Int32 sec);
                            string sHH = string.Format("{0:D2}", HH);
                            smm = string.Format("{0:D2}", mm);
                            ssec = string.Format("{0:D2}", sec);
                            regiPatternDatas[iIncNum].seg_hhmmss = sHH + ":" + smm + ":" + ssec;

                            fgHmiGetPattern[idx, 1] = idx;
                            fgHmiGetPattern[idx, 2] = regiPatternDatas[iIncNum].com_segno;
                            fgHmiGetPattern[idx, 3] = regiPatternDatas[iIncNum].temp_tsp;
                            fgHmiGetPattern[idx, 4] = regiPatternDatas[iIncNum].humi_tsp;
                            fgHmiGetPattern[idx, 5] = regiPatternDatas[iIncNum].seg_hhmmss;

                            iIncNum++;
                            idx++;
                        }
                    }

                }
            }
            catch
            {
                cLog.Error(cMwLog.ChosenPatternReadError);
            }
            finally
            { this.Cursor = Cursors.Default; }
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
    }
}