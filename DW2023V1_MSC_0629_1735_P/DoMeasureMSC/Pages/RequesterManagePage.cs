using DBMS_V1;
using DBMS_V1.Data.MSC;
using DBMS_V1.Data.WVP;
using EventLog;
using DwLib.Data;
using log4net;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using Tbl_reqmember = DBMS_V1.Data.MSC.Tbl_reqmember;

namespace DoMeasureMSC
{
    public partial class RequesterManagePage : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.cboSearchWord = new C1.Win.C1Input.C1ComboBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnShowAllList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRequesterList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.btnReqRegi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.divlevel = new C1.Win.C1Input.C1ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.team = new System.Windows.Forms.TextBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRequesterUpdate = new System.Windows.Forms.Button();
            this.dgvRequesterDetail = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequesterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divlevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequesterDetail)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "의뢰자 관리";
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
            this.splitContainer4.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer4.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer4.Panel1.Controls.Add(this.btnShowAllList);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgvRequesterList);
            this.splitContainer4.Size = new System.Drawing.Size(815, 446);
            this.splitContainer4.SplitterDistance = 82;
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
            this.cboSearchWord.Items.Add("의뢰자명");
            this.cboSearchWord.Items.Add("ID");
            this.cboSearchWord.Location = new System.Drawing.Point(261, 0);
            this.cboSearchWord.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cboSearchWord.Name = "cboSearchWord";
            this.cboSearchWord.Size = new System.Drawing.Size(200, 32);
            this.cboSearchWord.TabIndex = 16;
            this.cboSearchWord.Tag = null;
            this.cboSearchWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboSearchWord.Value = "123";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(124)))), ((int)(((byte)(245)))));
            this.btnSearch.Image = global::DoMeasureMSC.Properties.Resources.find;
            this.btnSearch.Location = new System.Drawing.Point(674, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 11;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Cornsilk;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("나눔고딕", 16F);
            this.tbSearch.Location = new System.Drawing.Point(468, 0);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(200, 32);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowAllList
            // 
            this.btnShowAllList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnShowAllList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnShowAllList.FlatAppearance.BorderSize = 0;
            this.btnShowAllList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllList.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShowAllList.Location = new System.Drawing.Point(712, 0);
            this.btnShowAllList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
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
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "의뢰지 조회";
            // 
            // dgvRequesterList
            // 
            this.dgvRequesterList.AllowUserToAddRows = false;
            this.dgvRequesterList.AllowUserToDeleteRows = false;
            this.dgvRequesterList.AllowUserToResizeColumns = false;
            this.dgvRequesterList.AllowUserToResizeRows = false;
            this.dgvRequesterList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequesterList.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequesterList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequesterList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequesterList.ColumnHeadersHeight = 50;
            this.dgvRequesterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRequesterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column16,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequesterList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRequesterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequesterList.EnableHeadersVisualStyles = false;
            this.dgvRequesterList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvRequesterList.Location = new System.Drawing.Point(0, 0);
            this.dgvRequesterList.MultiSelect = false;
            this.dgvRequesterList.Name = "dgvRequesterList";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequesterList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRequesterList.RowHeadersVisible = false;
            this.dgvRequesterList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRequesterList.RowTemplate.Height = 23;
            this.dgvRequesterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequesterList.Size = new System.Drawing.Size(815, 360);
            this.dgvRequesterList.TabIndex = 0;
            this.dgvRequesterList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRequesterList_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "no";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 50F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "NO";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 150F;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "의뢰자명";
            this.Column2.MinimumWidth = 150;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.FillWeight = 150F;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "의뢰자ID";
            this.Column3.MinimumWidth = 150;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 150;
            // 
            // Column16
            // 
            this.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column16.DataPropertyName = "teamname";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Column16.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column16.FillWeight = 150F;
            this.Column16.Frozen = true;
            this.Column16.HeaderText = "소속";
            this.Column16.MinimumWidth = 150;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column16.Width = 150;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "use10";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.FillWeight = 150F;
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "사용여부";
            this.Column4.MinimumWidth = 150;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column5.FillWeight = 150F;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column5.HeaderText = "옵션";
            this.Column5.MinimumWidth = 150;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Text = "의뢰자 제외";
            this.Column5.UseColumnTextForButtonValue = true;
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
            this.splitContainer6.Panel1.Controls.Add(this.btnReqRegi);
            this.splitContainer6.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer6.Size = new System.Drawing.Size(821, 446);
            this.splitContainer6.SplitterDistance = 82;
            this.splitContainer6.TabIndex = 0;
            // 
            // btnReqRegi
            // 
            this.btnReqRegi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnReqRegi.FlatAppearance.BorderSize = 0;
            this.btnReqRegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqRegi.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReqRegi.ForeColor = System.Drawing.Color.Black;
            this.btnReqRegi.Location = new System.Drawing.Point(536, 0);
            this.btnReqRegi.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnReqRegi.Name = "btnReqRegi";
            this.btnReqRegi.Size = new System.Drawing.Size(282, 32);
            this.btnReqRegi.TabIndex = 1;
            this.btnReqRegi.Text = "의뢰자 신규등록";
            this.btnReqRegi.UseVisualStyleBackColor = false;
            this.btnReqRegi.Click += new System.EventHandler(this.BtnReqRegi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "의뢰자 등록";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.divlevel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.id, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.contact, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.team, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "의뢰자명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(413, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "의뢰자ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(3, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "등급";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(413, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "소속";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(3, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "연락처";
            // 
            // divlevel
            // 
            this.divlevel.AllowSpinLoop = false;
            this.divlevel.BackColor = System.Drawing.Color.Cornsilk;
            this.divlevel.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.divlevel.GapHeight = 0;
            this.divlevel.ImagePadding = new System.Windows.Forms.Padding(0);
            this.divlevel.Items.Add("일반");
            this.divlevel.Items.Add("VIP");
            this.divlevel.Location = new System.Drawing.Point(3, 113);
            this.divlevel.MaximumSize = new System.Drawing.Size(385, 0);
            this.divlevel.MinimumSize = new System.Drawing.Size(385, 0);
            this.divlevel.Name = "divlevel";
            this.divlevel.Size = new System.Drawing.Size(385, 26);
            this.divlevel.TabIndex = 7;
            this.divlevel.Tag = "의뢰자 등급을 선택하세요.";
            this.divlevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Cornsilk;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.name.Location = new System.Drawing.Point(3, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(385, 26);
            this.name.TabIndex = 8;
            this.name.Tag = "의뢰자명을 입력하세요.(Ex:김의뢰자)";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Cornsilk;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.id.Location = new System.Drawing.Point(413, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(385, 26);
            this.id.TabIndex = 9;
            this.id.Tag = "의뢰자ID를 입력하세요. (Ex:REQ_0001)";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Id_KeyPress);
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.Color.Cornsilk;
            this.contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contact.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.contact.Location = new System.Drawing.Point(3, 193);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(385, 26);
            this.contact.TabIndex = 10;
            this.contact.Tag = "연락처를 입력하세요. (Ex:063-214-8556)";
            this.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // team
            // 
            this.team.BackColor = System.Drawing.Color.Cornsilk;
            this.team.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.team.Location = new System.Drawing.Point(413, 113);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(385, 26);
            this.team.TabIndex = 11;
            this.team.Tag = "소속을 입력하세요. (Ex:두원글로벌)";
            this.team.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.splitContainer5.Panel1.Controls.Add(this.btnRequesterUpdate);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.dgvRequesterDetail);
            this.splitContainer5.Size = new System.Drawing.Size(1640, 446);
            this.splitContainer5.SplitterDistance = 67;
            this.splitContainer5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(0, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "의뢰자 상세정보";
            // 
            // btnRequesterUpdate
            // 
            this.btnRequesterUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnRequesterUpdate.FlatAppearance.BorderSize = 0;
            this.btnRequesterUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequesterUpdate.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRequesterUpdate.Location = new System.Drawing.Point(1355, 26);
            this.btnRequesterUpdate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnRequesterUpdate.Name = "btnRequesterUpdate";
            this.btnRequesterUpdate.Size = new System.Drawing.Size(282, 32);
            this.btnRequesterUpdate.TabIndex = 0;
            this.btnRequesterUpdate.Text = "의뢰자 수정사항 변경 후 저장";
            this.btnRequesterUpdate.UseVisualStyleBackColor = false;
            this.btnRequesterUpdate.Click += new System.EventHandler(this.BtnRequesterUpdate_Click);
            // 
            // dgvRequesterDetail
            // 
            this.dgvRequesterDetail.AllowUserToAddRows = false;
            this.dgvRequesterDetail.AllowUserToDeleteRows = false;
            this.dgvRequesterDetail.AllowUserToResizeColumns = false;
            this.dgvRequesterDetail.AllowUserToResizeRows = false;
            this.dgvRequesterDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequesterDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequesterDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRequesterDetail.ColumnHeadersHeight = 50;
            this.dgvRequesterDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRequesterDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequesterDetail.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvRequesterDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRequesterDetail.EnableHeadersVisualStyles = false;
            this.dgvRequesterDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvRequesterDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvRequesterDetail.Name = "dgvRequesterDetail";
            this.dgvRequesterDetail.RowHeadersVisible = false;
            this.dgvRequesterDetail.RowTemplate.Height = 23;
            this.dgvRequesterDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequesterDetail.Size = new System.Drawing.Size(1640, 365);
            this.dgvRequesterDetail.TabIndex = 0;
            this.dgvRequesterDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRequesterDetail_CellClick);
            this.dgvRequesterDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvRequesterDetail_DataError);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "no";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "NO";
            this.Column6.MinimumWidth = 50;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "name";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "의뢰자명";
            this.Column7.MinimumWidth = 150;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "id";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column8.HeaderText = "의뢰자ID";
            this.Column8.MinimumWidth = 150;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "teamname";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column9.HeaderText = "소속";
            this.Column9.MinimumWidth = 150;
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "divlevel";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column10.HeaderText = "의뢰자등급";
            this.Column10.Items.AddRange(new object[] {
            "VIP",
            "일반"});
            this.Column10.MinimumWidth = 150;
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.Width = 150;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "use10";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column11.HeaderText = "사용여부";
            this.Column11.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.Column11.MinimumWidth = 150;
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "contact";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column12.HeaderText = "연락처";
            this.Column12.MinimumWidth = 200;
            this.Column12.Name = "Column12";
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column12.Width = 200;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "regdate";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column13.HeaderText = "등록일자";
            this.Column13.MinimumWidth = 200;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column13.Width = 200;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "updatedate";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.Column14.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column14.HeaderText = "변경일자";
            this.Column14.MinimumWidth = 200;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column14.Width = 200;
            // 
            // Column15
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.Column15.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column15.HeaderText = "옵션";
            this.Column15.MinimumWidth = 237;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column15.Width = 237;
            // 
            // RequesterManagePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1640, 950);
            this.MinimumSize = new System.Drawing.Size(1640, 950);
            this.Name = "RequesterManagePage";
            this.Text = "Requester";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequesterList)).EndInit();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divlevel)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequesterDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer4;

        private System.Windows.Forms.SplitContainer splitContainer5;

        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button btnShowAllList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReqRegi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRequesterUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private C1.Win.C1Input.C1ComboBox divlevel;
        private System.Windows.Forms.DataGridView dgvRequesterDetail;
        private System.Windows.Forms.DataGridView dgvRequesterList;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox btnSearch;
        private C1.Win.C1Input.C1ComboBox cboSearchWord;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column10;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        //================================================================================================================================


        public RequesterManagePage()
        {
            InitializeComponent();
            SelectRequesterList();
            cboSearchWord.SelectedIndex = 0;
            divlevel.SelectedIndex = 0;
            InitializeInputControl();
        }

        private readonly MeasureWriteLog cMwLog = new MeasureWriteLog();
        private static readonly ILog cLog = LogManager.GetLogger("Measure");
        private readonly MySqlDTO cMysqlDto = new MySqlDTO();
        string m_sCompareShowReqdetail = "";


        public void SelectRequesterList()
        {
            try
            {
                string sql = "select (@num:=@num+1) as no, name, id, teamname, if(use10=1,'Y','N') as use10 from tbl_reqmember, (select @num:=0) as s where out10 = 0  order by name asc "; //,out10=0
                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                dgvRequesterList.DataSource = dt;

            }
            catch (Exception)
            {
                cLog.Error(cMwLog.RequesterListShowLoadError);
            }
        }
        public void ShowDetail(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //DataGridView dgv = sender as DataGridView;
            if (sender is DataGridView dgv) { }
            else return;

            if (dgv == null) return;
            if (dgv.CurrentRow.Selected)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvRequesterList.Rows[index];
                var id = selectedRow.Cells[3].Value.ToString();
                var no = selectedRow.Cells[1].Value.ToString();


                string strId = id.ToString();
                if (m_sCompareShowReqdetail.Equals(strId) == false)
                {
                    m_sCompareShowReqdetail = strId;
                }
                else
                {
                    return;
                }

                try
                {
                    DataTable dt = null;

                    string sql = $"select (select @num:=\"{no}\")as no, name, id, teamname, if (divlevel = 1,'VIP','일반') as divlevel,if (use10 = 1,'YES','NO') as use10, contact, DATE_FORMAT(regdate, '%Y-%m-%d %H:%i:%s') AS regdate, DATE_FORMAT(updatedate, '%Y-%m-%d %H:%i:%s') AS updatedate from tbl_reqmember where id=\"{id}\" ";
                    dt = cMysqlDto.SelectSqlToDataTable(sql);
                    dgvRequesterDetail.DataSource = dt;
                }
                catch
                {
                    cLog.Error(cMwLog.RequesterDetailLoadError);
                }
            }
        }


        private void InitializeInputControl()
        {
            name.Text = name.Tag.ToString();
            name.ForeColor = Color.Gray;

            id.Text = id.Tag.ToString();
            id.ForeColor = Color.Gray;

            if (string.IsNullOrEmpty(team.Text))
            {
                team.Text = team.Tag.ToString();
                team.ForeColor = Color.Gray;
            }

            if (string.IsNullOrEmpty(contact.Text))
            {
                contact.Text = contact.Tag.ToString();
                contact.ForeColor = Color.Gray;
            }


            this.id.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.id.Leave += new System.EventHandler(this.WaterMark_Leave);

            this.name.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.name.Leave += new System.EventHandler(this.WaterMark_Leave);

            this.team.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.team.Leave += new System.EventHandler(this.WaterMark_Leave);

            this.contact.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.contact.Leave += new System.EventHandler(this.WaterMark_Leave);

        }

        private void BtnShowAllList_Click(object sender, EventArgs e)
        {
            SelectRequesterList();
        }

        private void BtnReqRegi_Click(object sender, EventArgs e)
        {
            string strBtnName = "의뢰자 신규등록";
            if (InputDataCheck() == false)
            {
                return;
            }
            if (MessageBox.Show("의뢰자 등록 하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ////fgUserSetting
                Tbl_member tbl_reqmember = new Tbl_member()
                {
                    name = string.IsNullOrEmpty(name.Text) ? "" : name.Text.ToString(),
                    id = string.IsNullOrEmpty(id.Text) ? "" : id.Text.ToString(),
                    divlevel = divlevel.SelectedItem == null ? "" : divlevel.SelectedItem.ToString(),
                    contact = string.IsNullOrEmpty(contact.Text) ? "" : contact.Text.ToString(),
                    teamname = string.IsNullOrEmpty(team.Text) ? "" : team.Text.ToString(),
                };


                if (tbl_reqmember.divlevel == "VIP") tbl_reqmember.divlevel = "1";
                else tbl_reqmember.divlevel = "0";


                if (string.IsNullOrEmpty(tbl_reqmember.name))
                {
                    MessageBox.Show("의뢰자명 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(tbl_reqmember.id))
                {
                    MessageBox.Show("의뢰자ID 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }

                if (string.IsNullOrEmpty(tbl_reqmember.divlevel))
                {
                    MessageBox.Show("등급 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(tbl_reqmember.contact))
                {
                    MessageBox.Show("연락처 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(tbl_reqmember.teamname))
                {
                    MessageBox.Show("소속 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }

                //string salt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                try
                {
                    string dbsql = $"select count(*) as cnt from tbl_reqmember where id=\"{tbl_reqmember.id}\" ";


                    int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(dbsql, "cnt")[0]["cnt"]);

                    if (rowCnt != 0)
                    {
                        MessageBox.Show("중복된 아이디 입니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    tbl_reqmember.regdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dbsql = ($"INSERT INTO tbl_reqmember(id, name, divlevel, teamname, contact, regdate) VALUE (\"{tbl_reqmember.id}\",\"{tbl_reqmember.name}\" ,\"{tbl_reqmember.divlevel}\", \"{tbl_reqmember.teamname}\", \"{tbl_reqmember.contact}\",  \"{tbl_reqmember.regdate}\")");


                    cMysqlDto.OpenKeepUp();
                    cMysqlDto.RunSql("INSERT", dbsql);
                    MessageBox.Show("등록이 완료되었습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Info(cMwLog.RequesterManageNewRegisterEventLog);
                    SelectRequesterList();
                    name.Text = "";
                    id.Text = "";
                    team.Text = "";
                    contact.Text = "";
                }
                catch (Exception)
                {
                    cLog.Error(cMwLog.RequesterRegisterError);
                }
                finally
                {
                    cMysqlDto.Close();
                }
            }
        }
        private bool InputDataCheck()
        {
            name.Text = Util.InputdataCheckHanEngNum("의뢰자명 입력", name.Text);
            bool isOk = string.IsNullOrEmpty(name.Text) == false;
            if (isOk == false) return isOk;

            id.Text = Util.InputdataCheckEngNum("의뢰자ID 입력", id.Text);
            isOk = string.IsNullOrEmpty(id.Text) == false;
            if (isOk == false) return isOk;

            contact.Text = Util.InputdataCheckNumHipeun("연락처 입력", contact.Text);
            isOk = string.IsNullOrEmpty(contact.Text) == false;
            if (isOk == false) return isOk;

            team.Text = Util.InputdataCheckHanEngNum("소속 입력", team.Text);
            isOk = string.IsNullOrEmpty(team.Text) == false;
            if (isOk == false) return isOk;

            return isOk;
        }

        private void BtnRequesterUpdate_Click(object sender, EventArgs e)
        {
            string strBtnName = "의뢰자 수정사항 변경 후 저장";
            try
            {
                if (MessageBox.Show("저장하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                int rowIndex = dgvRequesterDetail.CurrentRow.Index;


                Tbl_reqmember tbl_reqmember = new Tbl_reqmember()
                {
                    name = dgvRequesterDetail.Rows[rowIndex].Cells[2].Value == null ? "" : dgvRequesterDetail.Rows[rowIndex].Cells[2].Value.ToString(),
                    id = dgvRequesterDetail.Rows[rowIndex].Cells[3].Value == null ? "" : dgvRequesterDetail.Rows[rowIndex].Cells[3].Value.ToString(),
                    teamname = dgvRequesterDetail.Rows[rowIndex].Cells[4].Value == null ? "" : dgvRequesterDetail.Rows[rowIndex].Cells[4].Value.ToString(),
                    divlevel = dgvRequesterDetail.Rows[rowIndex].Cells[5].Value == null ? "" : dgvRequesterDetail.Rows[rowIndex].Cells[5].Value.ToString(),
                    use10 = dgvRequesterDetail.Rows[rowIndex].Cells[6].Value == null ? "" : dgvRequesterDetail.Rows[rowIndex].Cells[6].Value.ToString(),
                    contact = dgvRequesterDetail.Rows[rowIndex].Cells[7].Value == null ? "" : dgvRequesterDetail.Rows[rowIndex].Cells[7].Value.ToString(),
                };


                if (tbl_reqmember.divlevel == "VIP") tbl_reqmember.divlevel = "1";
                else tbl_reqmember.divlevel = "0";
                if (tbl_reqmember.use10 == "YES") tbl_reqmember.use10 = "1";
                else tbl_reqmember.use10 = "0";
                if (string.IsNullOrEmpty(tbl_reqmember.teamname))
                {
                    MessageBox.Show("[소속] 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(tbl_reqmember.contact))
                {
                    MessageBox.Show("[연락처] 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                try
                {
                    tbl_reqmember.updatedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string dbsql = $@"UPDATE tbl_reqmember SET  teamname = '{tbl_reqmember.teamname}',divlevel = '{tbl_reqmember.divlevel}', use10 = '{tbl_reqmember.use10}', contact = '{tbl_reqmember.contact}', updatedate = '{tbl_reqmember.updatedate}' WHERE id='{tbl_reqmember.id}'";

                    cMysqlDto.OpenKeepUp();
                    cMysqlDto.RunSql("UPDATE", dbsql);
                    SelectRequesterList();
                    cLog.Info(cMwLog.RequesterManageUpdateEventLog);
                    MessageBox.Show("업데이트가 완료 되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception exc)
                {
                    System.Diagnostics.Debug.WriteLine(exc.Message);
                    cLog.Error(cMwLog.RequesterUpdateError);
                    return;
                }
                finally
                {

                    cMysqlDto.Close();
                    SelectRequesterList();
                }

            }
            catch
            {
                MessageBox.Show("값이 선택되지 않았습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvRequesterList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0)
            {
                string strBtnName = "의뢰자 제외";
                if (MessageBox.Show("제외하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                DataGridViewRow row = dgvRequesterList.SelectedRows[0]; //선택된 Row 값 가져옴.
                string id = row.Cells[3].Value.ToString();
                //string name = row.Cells[2].Value.ToString();


                try
                {
                    cMysqlDto.OpenKeepUp();
                    string dbsql = $@"update tbl_reqmember set out10=1 where id='{id}'";
                    cMysqlDto.RunSql("UPDATE", dbsql);
                    MessageBox.Show("제외되었습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Info(cMwLog.RequesterDeleteEventLog);
                    SelectRequesterList();

                }
                catch (Exception)
                {
                    MessageBox.Show("의뢰자 제외 실패", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Error(cMwLog.RequesterDeleteError);
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

        private void BtnSearch_Click_1(object sender, EventArgs e)
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
                if (MessageBox.Show("검색어에 특수문자(%)를 제한합니다.", "사용자관리", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
                case "의뢰자명":
                    sql = $"select count(*) as cnt from tbl_reqmember ,(select @num:=0) as s where out10 = 0 && name like '%{tbSearch.Text}%' ";
                    break;
                case "ID":
                    sql = $"select count(*) as cnt from tbl_reqmember ,(select @num:=0) as s where out10 = 0 && id like '%{tbSearch.Text}%'";
                    break;
                case "전체":
                    sql = $"select count(*) as cnt from tbl_reqmember ,(select @num:=0) as s where out10 = 0 && (name like '%{tbSearch.Text}%' or id like '%{tbSearch.Text}%')";
                    break;
            }

            try
            {


               int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(sql, "cnt")[0]["cnt"]);

                if (rowCnt == 0)
                {
                    MessageBox.Show("의뢰자가 없습니다.", "사용자관리", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    case "의뢰자명":
                        sql = $"select (@num:=@num+1) as no, name, id,teamname, if(use10=1,'Y','N') as use10 from tbl_reqmember where out10 = 0 && name like '%{tbSearch.Text}%' ";
                        break;
                    case "ID":
                        sql = $"select (@num:=@num+1) as no, name, id, teamname, if(use10=1,'Y','N') as use10  from tbl_reqmember where out10 = 0 && id like '%{tbSearch.Text}%'";
                        break;
                    case "전체":
                        sql = $"select (@num:=@num+1) as no, name, id, teamname, if(use10=1,'Y','N') as use10 from tbl_reqmember where out10 = 0 && (name like '%{tbSearch.Text}%' or id like '%{tbSearch.Text}%')";
                        break;
                }

                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                dgvRequesterList.DataSource = dt;
                cLog.Info(cMwLog.RequesterSearchClickEventLog);
            }
            catch (Exception)
            {
                MessageBox.Show("의뢰자 검색 실패", "의뢰자관리", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cLog.Error(cMwLog.RequesterSearchLoadError);
            }
        }

        private void DgvRequesterDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;


            //사용여부 위치(8)
            if (e.RowIndex >= 0 && (e.ColumnIndex == 5 || e.ColumnIndex == 6))
            {
                dgv.BeginEdit(true);
                ((System.Windows.Forms.ComboBox)dgv.EditingControl).DroppedDown = true;
            }
        }

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

        private void DgvRequesterDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

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
