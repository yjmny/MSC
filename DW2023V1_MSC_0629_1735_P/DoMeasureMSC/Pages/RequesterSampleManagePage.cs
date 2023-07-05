using DoMeasureMSC.Data;
using DBMS_V1;
using DBMS_V1.Data.WVP;
using EventLog;
using DwLib.Data;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DoMeasureMSC
{
    public partial class RequesterSampleManagePage : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cboSearchWord = new C1.Win.C1Input.C1ComboBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.btnShowAllList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRequesterSampleList = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqmbname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqmbid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samplediv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.btnReqSampleRegi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.tbxid = new System.Windows.Forms.TextBox();
            this.cboadtype = new C1.Win.C1Input.C1ComboBox();
            this.cbouse = new C1.Win.C1Input.C1ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbosamplediv = new C1.Win.C1Input.C1ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboreqmbid = new C1.Win.C1Input.C1ComboBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReqSampleUpdate = new System.Windows.Forms.Button();
            this.dgvRequesterSampleDetail = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colreqsampleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladtype = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colsamplediv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequesterSampleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboadtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbosamplediv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboreqmbid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequesterSampleDetail)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "의뢰자 샘플 관리";
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
            this.splitContainer4.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer4.Panel1.Controls.Add(this.cboSearchWord);
            this.splitContainer4.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer4.Panel1.Controls.Add(this.btnShowAllList);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgvRequesterSampleList);
            this.splitContainer4.Size = new System.Drawing.Size(815, 446);
            this.splitContainer4.SplitterDistance = 82;
            this.splitContainer4.TabIndex = 0;
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
            this.tbSearch.TabIndex = 17;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.cboSearchWord.Items.Add("의뢰자샘플명");
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
            this.btnShowAllList.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "의뢰자 샘플 조회";
            // 
            // dgvRequesterSampleList
            // 
            this.dgvRequesterSampleList.AllowUserToAddRows = false;
            this.dgvRequesterSampleList.AllowUserToDeleteRows = false;
            this.dgvRequesterSampleList.AllowUserToResizeColumns = false;
            this.dgvRequesterSampleList.AllowUserToResizeRows = false;
            this.dgvRequesterSampleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequesterSampleList.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequesterSampleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequesterSampleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequesterSampleList.ColumnHeadersHeight = 50;
            this.dgvRequesterSampleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRequesterSampleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.name,
            this.id,
            this.reqmbname,
            this.reqmbid,
            this.adtype,
            this.samplediv,
            this.Column16});
            this.dgvRequesterSampleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequesterSampleList.EnableHeadersVisualStyles = false;
            this.dgvRequesterSampleList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvRequesterSampleList.Location = new System.Drawing.Point(0, 0);
            this.dgvRequesterSampleList.MultiSelect = false;
            this.dgvRequesterSampleList.Name = "dgvRequesterSampleList";
            this.dgvRequesterSampleList.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequesterSampleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRequesterSampleList.RowHeadersVisible = false;
            this.dgvRequesterSampleList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRequesterSampleList.RowTemplate.Height = 23;
            this.dgvRequesterSampleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequesterSampleList.Size = new System.Drawing.Size(815, 360);
            this.dgvRequesterSampleList.TabIndex = 0;
            this.dgvRequesterSampleList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRequesterSampleList_CellClick);
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.no.DataPropertyName = "no";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.no.DefaultCellStyle = dataGridViewCellStyle2;
            this.no.FillWeight = 177.665F;
            this.no.Frozen = true;
            this.no.HeaderText = "NO";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.no.Width = 50;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.FillWeight = 87.05584F;
            this.name.Frozen = true;
            this.name.HeaderText = "의뢰자샘플명";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 150;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.id.DefaultCellStyle = dataGridViewCellStyle4;
            this.id.FillWeight = 87.05584F;
            this.id.Frozen = true;
            this.id.HeaderText = "의뢰자샘플ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 90;
            // 
            // reqmbname
            // 
            this.reqmbname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reqmbname.DataPropertyName = "reqmbname";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.reqmbname.DefaultCellStyle = dataGridViewCellStyle5;
            this.reqmbname.FillWeight = 87.05584F;
            this.reqmbname.Frozen = true;
            this.reqmbname.HeaderText = "의뢰자명";
            this.reqmbname.Name = "reqmbname";
            this.reqmbname.ReadOnly = true;
            this.reqmbname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reqmbname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.reqmbname.Width = 150;
            // 
            // reqmbid
            // 
            this.reqmbid.DataPropertyName = "reqmbid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.reqmbid.DefaultCellStyle = dataGridViewCellStyle6;
            this.reqmbid.HeaderText = "의뢰자ID";
            this.reqmbid.Name = "reqmbid";
            this.reqmbid.ReadOnly = true;
            this.reqmbid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reqmbid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // adtype
            // 
            this.adtype.DataPropertyName = "adtype";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.adtype.DefaultCellStyle = dataGridViewCellStyle7;
            this.adtype.FillWeight = 87.05584F;
            this.adtype.HeaderText = "샘플형식";
            this.adtype.Name = "adtype";
            this.adtype.ReadOnly = true;
            this.adtype.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adtype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // samplediv
            // 
            this.samplediv.DataPropertyName = "samplediv";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.samplediv.DefaultCellStyle = dataGridViewCellStyle8;
            this.samplediv.FillWeight = 87.05584F;
            this.samplediv.HeaderText = "샘플구분";
            this.samplediv.Name = "samplediv";
            this.samplediv.ReadOnly = true;
            this.samplediv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.samplediv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "option";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.Column16.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column16.FillWeight = 87.05584F;
            this.Column16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column16.HeaderText = "옵션";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column16.Text = "샘플 제외";
            this.Column16.UseColumnTextForButtonValue = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.btnReqSampleRegi);
            this.splitContainer6.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer6.Size = new System.Drawing.Size(821, 446);
            this.splitContainer6.SplitterDistance = 82;
            this.splitContainer6.TabIndex = 0;
            // 
            // btnReqSampleRegi
            // 
            this.btnReqSampleRegi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnReqSampleRegi.FlatAppearance.BorderSize = 0;
            this.btnReqSampleRegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqSampleRegi.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReqSampleRegi.ForeColor = System.Drawing.Color.Black;
            this.btnReqSampleRegi.Location = new System.Drawing.Point(536, 0);
            this.btnReqSampleRegi.Name = "btnReqSampleRegi";
            this.btnReqSampleRegi.Size = new System.Drawing.Size(282, 32);
            this.btnReqSampleRegi.TabIndex = 1;
            this.btnReqSampleRegi.Text = "의뢰자 샘플 신규등록";
            this.btnReqSampleRegi.UseVisualStyleBackColor = false;
            this.btnReqSampleRegi.Click += new System.EventHandler(this.BtnReqSampleRegi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "의뢰자 샘플 등록";
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
            this.tableLayoutPanel1.Controls.Add(this.tbxname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboadtype, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbouse, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbosamplediv, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "의뢰자샘플명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(413, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "의뢰자샘플ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(3, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "의뢰자명 | 의뢰자ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(413, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "의뢰자 샘플형식";
            // 
            // tbxname
            // 
            this.tbxname.BackColor = System.Drawing.Color.Cornsilk;
            this.tbxname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxname.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxname.Location = new System.Drawing.Point(3, 33);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(385, 26);
            this.tbxname.TabIndex = 8;
            this.tbxname.Tag = "의뢰자샘플명을 입력하세요. (Ex:천_SUS타입)";
            this.tbxname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbxname_KeyPress);
            // 
            // tbxid
            // 
            this.tbxid.BackColor = System.Drawing.Color.Cornsilk;
            this.tbxid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxid.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxid.Location = new System.Drawing.Point(413, 33);
            this.tbxid.Name = "tbxid";
            this.tbxid.Size = new System.Drawing.Size(385, 26);
            this.tbxid.TabIndex = 9;
            this.tbxid.Tag = "의뢰자샘플ID을 입력하세요 (Ex:SFKIMS_SUS_RINGTYPE1)";
            this.tbxid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbxid_KeyPress);
            // 
            // cboadtype
            // 
            this.cboadtype.AllowSpinLoop = false;
            this.cboadtype.AutoCompleteCustomSource.AddRange(new string[] {
            "아날로그",
            "디지털"});
            this.cboadtype.BackColor = System.Drawing.Color.Cornsilk;
            this.cboadtype.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboadtype.GapHeight = 0;
            this.cboadtype.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cboadtype.Items.Add("아날로그");
            this.cboadtype.Items.Add("디지털");
            this.cboadtype.Location = new System.Drawing.Point(413, 113);
            this.cboadtype.MaximumSize = new System.Drawing.Size(385, 0);
            this.cboadtype.MinimumSize = new System.Drawing.Size(385, 0);
            this.cboadtype.Name = "cboadtype";
            this.cboadtype.Size = new System.Drawing.Size(385, 26);
            this.cboadtype.TabIndex = 20;
            this.cboadtype.Tag = null;
            this.cboadtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbouse
            // 
            this.cbouse.AllowSpinLoop = false;
            this.cbouse.BackColor = System.Drawing.Color.Cornsilk;
            this.cbouse.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbouse.GapHeight = 0;
            this.cbouse.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbouse.Items.Add("YES");
            this.cbouse.Items.Add("NO");
            this.cbouse.Location = new System.Drawing.Point(413, 193);
            this.cbouse.MaximumSize = new System.Drawing.Size(385, 0);
            this.cbouse.MinimumSize = new System.Drawing.Size(385, 0);
            this.cbouse.Name = "cbouse";
            this.cbouse.Size = new System.Drawing.Size(385, 26);
            this.cbouse.TabIndex = 18;
            this.cbouse.Tag = null;
            this.cbouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(413, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "사용여부";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(3, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "샘플구분";
            // 
            // cbosamplediv
            // 
            this.cbosamplediv.AllowSpinLoop = false;
            this.cbosamplediv.BackColor = System.Drawing.Color.Cornsilk;
            this.cbosamplediv.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbosamplediv.GapHeight = 0;
            this.cbosamplediv.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbosamplediv.Items.Add("온도");
            this.cbosamplediv.Items.Add("습도");
            this.cbosamplediv.Items.Add("기타");
            this.cbosamplediv.Location = new System.Drawing.Point(3, 193);
            this.cbosamplediv.MaximumSize = new System.Drawing.Size(385, 0);
            this.cbosamplediv.MinimumSize = new System.Drawing.Size(385, 0);
            this.cbosamplediv.Name = "cbosamplediv";
            this.cbosamplediv.Size = new System.Drawing.Size(385, 26);
            this.cbosamplediv.TabIndex = 21;
            this.cbosamplediv.Tag = null;
            this.cbosamplediv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboreqmbid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 44);
            this.panel1.TabIndex = 90;
            // 
            // cboreqmbid
            // 
            this.cboreqmbid.AllowSpinLoop = false;
            this.cboreqmbid.BackColor = System.Drawing.Color.Cornsilk;
            this.cboreqmbid.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboreqmbid.GapHeight = 0;
            this.cboreqmbid.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cboreqmbid.Location = new System.Drawing.Point(4, 0);
            this.cboreqmbid.MaximumSize = new System.Drawing.Size(385, 26);
            this.cboreqmbid.MinimumSize = new System.Drawing.Size(385, 26);
            this.cboreqmbid.Name = "cboreqmbid";
            this.cboreqmbid.Size = new System.Drawing.Size(385, 26);
            this.cboreqmbid.TabIndex = 7;
            this.cboreqmbid.Tag = null;
            this.cboreqmbid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboreqmbid.SelectedItemChanged += new System.EventHandler(this.Cboreqname_SelectedItemChanged);
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
            this.splitContainer5.Panel1.Controls.Add(this.btnReqSampleUpdate);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer5.Panel2.Controls.Add(this.dgvRequesterSampleDetail);
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
            this.label4.Size = new System.Drawing.Size(152, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "의뢰자 샘플 상세정보";
            // 
            // btnReqSampleUpdate
            // 
            this.btnReqSampleUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnReqSampleUpdate.FlatAppearance.BorderSize = 0;
            this.btnReqSampleUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqSampleUpdate.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReqSampleUpdate.Location = new System.Drawing.Point(1355, 26);
            this.btnReqSampleUpdate.Name = "btnReqSampleUpdate";
            this.btnReqSampleUpdate.Size = new System.Drawing.Size(282, 32);
            this.btnReqSampleUpdate.TabIndex = 0;
            this.btnReqSampleUpdate.Text = "의뢰자 샘플 수정사항 변경 후 저장";
            this.btnReqSampleUpdate.UseVisualStyleBackColor = false;
            this.btnReqSampleUpdate.Click += new System.EventHandler(this.BtnReqSampleUpdate_Click);
            // 
            // dgvRequesterSampleDetail
            // 
            this.dgvRequesterSampleDetail.AllowUserToAddRows = false;
            this.dgvRequesterSampleDetail.AllowUserToDeleteRows = false;
            this.dgvRequesterSampleDetail.AllowUserToResizeColumns = false;
            this.dgvRequesterSampleDetail.AllowUserToResizeRows = false;
            this.dgvRequesterSampleDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequesterSampleDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequesterSampleDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRequesterSampleDetail.ColumnHeadersHeight = 50;
            this.dgvRequesterSampleDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRequesterSampleDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column8,
            this.Column9,
            this.colreqsampleno,
            this.Column7,
            this.Column1,
            this.Column10,
            this.coladtype,
            this.colsamplediv,
            this.Column13,
            this.Column14,
            this.Column19});
            this.dgvRequesterSampleDetail.DataMember = "dgvRequesterSampleDetail";
            this.dgvRequesterSampleDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRequesterSampleDetail.EnableHeadersVisualStyles = false;
            this.dgvRequesterSampleDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvRequesterSampleDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvRequesterSampleDetail.Name = "dgvRequesterSampleDetail";
            this.dgvRequesterSampleDetail.RowHeadersVisible = false;
            this.dgvRequesterSampleDetail.RowTemplate.Height = 23;
            this.dgvRequesterSampleDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequesterSampleDetail.Size = new System.Drawing.Size(1640, 365);
            this.dgvRequesterSampleDetail.TabIndex = 0;
            this.dgvRequesterSampleDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRequesterSampleDetail_CellClick);
            this.dgvRequesterSampleDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvRequesterSampleDetail_DataError);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "no";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "NO";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "name";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "의뢰자샘플명";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "id";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "의뢰자샘플ID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 150;
            // 
            // colreqsampleno
            // 
            this.colreqsampleno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colreqsampleno.DataPropertyName = "reqsampleno";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.colreqsampleno.DefaultCellStyle = dataGridViewCellStyle15;
            this.colreqsampleno.Frozen = true;
            this.colreqsampleno.HeaderText = "의뢰자샘플DBNO";
            this.colreqsampleno.MinimumWidth = 150;
            this.colreqsampleno.Name = "colreqsampleno";
            this.colreqsampleno.ReadOnly = true;
            this.colreqsampleno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colreqsampleno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colreqsampleno.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "reqmbname";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "의뢰자명";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "reqmbid";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "의뢰자ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "method";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column10.HeaderText = "시험방법";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 240;
            // 
            // coladtype
            // 
            this.coladtype.DataPropertyName = "adtype";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.coladtype.DefaultCellStyle = dataGridViewCellStyle19;
            this.coladtype.HeaderText = "샘플형식";
            this.coladtype.Items.AddRange(new object[] {
            "아날로그",
            "디지털"});
            this.coladtype.Name = "coladtype";
            this.coladtype.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coladtype.Width = 150;
            // 
            // colsamplediv
            // 
            this.colsamplediv.DataPropertyName = "samplediv";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.colsamplediv.DefaultCellStyle = dataGridViewCellStyle20;
            this.colsamplediv.HeaderText = "샘플구분";
            this.colsamplediv.Items.AddRange(new object[] {
            "온도",
            "습도",
            "기타"});
            this.colsamplediv.Name = "colsamplediv";
            this.colsamplediv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colsamplediv.Width = 150;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "regdate";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column13.HeaderText = "등록일자";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column13.Width = 200;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "updatedate";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.Column14.DefaultCellStyle = dataGridViewCellStyle22;
            this.Column14.HeaderText = "변경일자";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column14.Width = 200;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "use10";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column19.DefaultCellStyle = dataGridViewCellStyle23;
            this.Column19.HeaderText = "사용여부";
            this.Column19.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.Column19.Name = "Column19";
            this.Column19.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column19.Width = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "최대";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox4.Location = new System.Drawing.Point(3, 193);
            this.richTextBox4.Multiline = false;
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(385, 40);
            this.richTextBox4.TabIndex = 10;
            this.richTextBox4.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "최소";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "허용오차";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(413, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "시험방법";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox5.Location = new System.Drawing.Point(413, 193);
            this.richTextBox5.Multiline = false;
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(385, 40);
            this.richTextBox5.TabIndex = 15;
            this.richTextBox5.Text = "";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox6.Location = new System.Drawing.Point(3, 273);
            this.richTextBox6.Multiline = false;
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(385, 40);
            this.richTextBox6.TabIndex = 16;
            this.richTextBox6.Text = "";
            // 
            // richTextBox7
            // 
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox7.Location = new System.Drawing.Point(413, 273);
            this.richTextBox7.Multiline = false;
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(385, 40);
            this.richTextBox7.TabIndex = 17;
            this.richTextBox7.Text = "";
            // 
            // RequesterSampleManagePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1640, 950);
            this.MinimumSize = new System.Drawing.Size(1640, 950);
            this.Name = "RequesterSampleManagePage";
            this.Text = "RequesterSampleManagePage";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequesterSampleList)).EndInit();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboadtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbosamplediv)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboreqmbid)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequesterSampleDetail)).EndInit();
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
        private System.Windows.Forms.Button btnReqSampleRegi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReqSampleUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private C1.Win.C1Input.C1ComboBox cboreqmbid;
        private System.Windows.Forms.DataGridView dgvRequesterSampleDetail;
        private System.Windows.Forms.DataGridView dgvRequesterSampleList;
        private C1.Win.C1Input.C1ComboBox cbouse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.PictureBox btnSearch;
        private C1.Win.C1Input.C1ComboBox cboSearchWord;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.TextBox tbxid;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label13;
        private C1.Win.C1Input.C1ComboBox cboadtype;
        private System.Windows.Forms.Label label14;
        private C1.Win.C1Input.C1ComboBox cbosamplediv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqmbname;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqmbid;
        private System.Windows.Forms.DataGridViewTextBoxColumn adtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn samplediv;
        private System.Windows.Forms.DataGridViewButtonColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colreqsampleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewComboBoxColumn coladtype;
        private System.Windows.Forms.DataGridViewComboBoxColumn colsamplediv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column19;
        //================================================================================================================================


        public RequesterSampleManagePage()
        {
            InitializeComponent();
            SelectReqSmapleList();
            cboSearchWord.SelectedIndex = 0;
            cbouse.SelectedIndex = 0;
            cboadtype.SelectedIndex = 0;
            cbosamplediv.SelectedIndex = 0;
            InitInputControl();
            InitReqMemberTableList();
            
        }

        private readonly MeasureWriteLog cMwLog = new MeasureWriteLog();
        private static readonly ILog cLog = LogManager.GetLogger("Measure");
        private readonly MySqlDTO cMysqlDto = new MySqlDTO();

        private void InitReqMemberTableList()
        {
            try
            {
                DataSet ds2 = SelectReqMemberTableList();
                if (ds2.Tables.Count > 0)
                {

                    RcpSetting.SetNames(ds2, "reqmbno");
                    Dictionary<string, string> reqmbid = new Dictionary<string, string>();

                    for (int i = 0; i < RcpSetting.GetNames().Length; i++)
                    {
                        string s = RcpSetting.GetNames()[i];

                        if (string.IsNullOrEmpty(s) == false)
                        {
                            string sql = $"select id, name from tbl_reqmember where reqmbno='{s}' ";
                            Dictionary<string, string> row = cMysqlDto.SelectSql2(sql, "id", "name")[0];
                            cboreqmbid.Items.Add(row["name"] + " | " + row["id"]);

                        }
                    }
                    if (cboreqmbid.Items.Count > 0)
                        cboreqmbid.SelectedIndex = 0;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }



        private void InitInputControl()
        {
            tbxname.Text = tbxname.Tag.ToString();
            tbxname.ForeColor = Color.Gray;

            tbxid.Text = tbxid.Tag.ToString();
            tbxid.ForeColor = Color.Gray;

            this.tbxid.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.tbxid.Leave += new System.EventHandler(this.WaterMark_Leave);

            this.tbxname.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.tbxname.Leave += new System.EventHandler(this.WaterMark_Leave);
        }

        public DataSet SelectReqMemberTableList()
        {
            DataSet ds;
            try
            {
                string sql = $"select (@num:=@num+1) as no, reqmbno, name as reqmbname, id, if(use10=1,'Y','N') as use10 from tbl_reqmember, (select @num:=0) as s where out10=0 && use10 ='1' order by reqmbname asc "; //,out10=0
                ds = cMysqlDto.SelectSqlToDataSet(sql, "ReqListData");
            }
            catch (Exception)
            {

                ds = null;
            }
            return ds;
        }
        public void SelectReqSmapleList()
        {
            try
            {
                string sql = $@"select (@num:=@num+1) as no, name,id, reqmbname, reqmbid, adtype, samplediv
                                        from tbl_reqmember_sample, (select @num:=0) as s 
                                        where out10 = 0 order by reqmbname asc";

                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                dgvRequesterSampleList.DataSource = dt;

            }
            catch (Exception)
            {
                cLog.Error(cMwLog.RequesterSmapleListShowLoadError);
            }
        }
        public void ShowDetail(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //DataGridView dgv = sender as DataGridView;
            if (sender is DataGridView dgv) { }
            else return;

            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvRequesterSampleList.Rows[index];
                var id = selectedRow.Cells[3].Value.ToString();
                //var no = selectedRow.Cells[1].Value.ToString();
               // var reqmbid = selectedRow.Cells[6].Value.ToString();


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
                    string sql = $"select  (select @num:=@num+1) as no, name, id, reqsampleno, reqmbname, reqmbid,  method, adtype, samplediv, "
                        + $"DATE_FORMAT(regdate, '%Y-%m-%d %H:%i:%s') AS regdate, DATE_FORMAT(updatedate, '%Y-%m-%d %H:%i:%s') AS updatedate, "
                        + $"if (use10 = 1,'YES','NO') as use10 "
                        + $"from tbl_reqmember_sample, (select @num:=0) as s where id=\"{id}\" && out10='0' ";
                    dt = cMysqlDto.SelectSqlToDataTable(sql);
                    dgvRequesterSampleDetail.DataSource = dt;
                }
                catch
                {
                    cLog.Error(cMwLog.RequesterSmapleDetailLoadError);
                }

            }
        }


        private void BtnShowAllList_Click(object sender, EventArgs e)
        {
            SelectReqSmapleList();
        }

        string CompShowReqdetail = "";
        private void DgvRequesterSampleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                string strBtnName = "의뢰자샘플 제외";
                if (MessageBox.Show("제외하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                DataGridViewRow row = dgvRequesterSampleList.SelectedRows[0]; //선택된 Row 값 가져옴.
                string id = row.Cells[3].Value.ToString();


                try
                {
                    cMysqlDto.OpenKeepUp();

                    string dbsql = $@"update tbl_reqmember_sample set out10=1 where id = '{id}' ";
                    cMysqlDto.RunSql("UPDATE", dbsql);
                    MessageBox.Show("제외되었습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Info(cMwLog.RequesterSampleDeleteEventLog);
                    SelectReqSmapleList();
                    //ShowDetail(sender, e);

                }
                catch (Exception)
                {
                    MessageBox.Show("의뢰자샘플 제외 실패", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Error(cMwLog.RequesterSmapleDeleteError);
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

        private void BtnReqSampleRegi_Click(object sender, EventArgs e)
        {

            string strBtnName = "의뢰자샘플 신규등록";
            if (InputDataCheck() == false)
            {
                return;
            }
            if (MessageBox.Show("의뢰자샘플 등록 하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string reqmbnameid = cboreqmbid.SelectedItem.ToString().Trim();
                string[] Split = reqmbnameid.Split('|');


                ////fgUserSetting
                tbl_reqmember_sample tbl_reqmember_sample1 = new tbl_reqmember_sample()
                {
                    name = string.IsNullOrEmpty(tbxname.Text) ? "" : tbxname.Text.ToString(),
                    id = string.IsNullOrEmpty(tbxid.Text) ? "" : tbxid.Text.ToString(),
                    reqmbid = cboreqmbid.SelectedItem == null ? "" : Split[1],
                    reqmbname = cboreqmbid.SelectedItem == null ? "" : Split[0],

                    method = "환경조건 변화별 센서연속시험",
                    adtype = cboadtype.SelectedItem == null ? "" : cboadtype.SelectedItem.ToString(),
                    samplediv = cbosamplediv.SelectedItem == null ? "" : cbosamplediv.SelectedItem.ToString(),
                };
                string use10 = cbouse.SelectedItem == null ? "" : cbouse.SelectedItem.ToString();
                tbl_reqmember_sample1.use10 = use10.Equals("YES") == true ? "1" : "0";

                //tbl_reqmember_sample.name = tbxname.Text.ToString() == null ? "" : tbxname.Text.ToString();
                //tbl_reqmember_sample.id = tbxid.Text.ToString() == null ? "" : tbxid.Text.ToString();
                //tbl_reqmember_sample.reqmbid = cboreqmbid.SelectedItem == null ? "" : Split[1];
                //tbl_reqmember_sample.reqmbname = cboreqmbid.SelectedItem == null ? "" : Split[0];
                //string use10 = cbouse.SelectedItem == null ? "" : cbouse.SelectedItem.ToString();
                //tbl_reqmember_sample.use10 = use10.Equals("YES") == true ? "1" : "0";
                //tbl_reqmember_sample.method = "환경조건 변화별 센서연속시험";
                //tbl_reqmember_sample.adtype = cboadtype.SelectedItem == null ? "" : cboadtype.SelectedItem.ToString();
                //tbl_reqmember_sample.samplediv = cbosamplediv.SelectedItem == null ? "" : cbosamplediv.SelectedItem.ToString();

                if (string.IsNullOrEmpty(tbl_reqmember_sample1.reqmbname))
                {
                    MessageBox.Show("의뢰자명 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(tbl_reqmember_sample1.name))
                {
                    MessageBox.Show("의뢰자 샘플명 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(tbl_reqmember_sample1.id))
                {
                    MessageBox.Show("의뢰자 샘플ID 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    string dbsql = $"select count(*) as cnt from tbl_reqmember_sample where id=\"{tbl_reqmember_sample1.id}\" ";


                   int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(dbsql, "cnt")[0]["cnt"]);

                    if (rowCnt != 0)
                    {
                        MessageBox.Show("중복된 아이디 입니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    tbl_reqmember_sample1.regdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dbsql = ($"INSERT INTO tbl_reqmember_sample (id, name, use10,adtype,samplediv, reqmbname, reqmbid ,max, min, marginoferror, method, regdate) " +
                       $"VALUE (\"{tbl_reqmember_sample1.id}\",\"{tbl_reqmember_sample1.name}\", \"{tbl_reqmember_sample1.use10}\" , \"{tbl_reqmember_sample1.adtype}\" ,\"{tbl_reqmember_sample1.samplediv}\" ," +
                       $"\"{tbl_reqmember_sample1.reqmbname}\" ,\"{tbl_reqmember_sample1.reqmbid}\", \"{tbl_reqmember_sample1.max}\", \"{tbl_reqmember_sample1.min}\", \"{tbl_reqmember_sample1.marginoferror}\", \"{tbl_reqmember_sample1.method}\", \"{tbl_reqmember_sample1.regdate}\")");


                    cMysqlDto.OpenKeepUp();
                    cMysqlDto.RunSql("INSERT", dbsql);
                    MessageBox.Show(strBtnName + "이 완료되었습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Info(cMwLog.RequesterSampleManageNewRegisterEventLog);
                    SelectReqSmapleList();

                    tbxname.Text = "";
                    tbxid.Text = "";
                    cboreqmbid.SelectedItem = null;

                }
                catch (Exception)
                {
                    cLog.Error(cMwLog.RequesterSmapleRegisterError);
                }
                finally
                {
                    cMysqlDto.Close();
                }
            }

        }
        private bool InputDataCheck()
        {
            tbxname.Text = Util.InputdataCheckHanEngNum("의뢰자샘플명 입력", tbxname.Text);
            bool isOk = string.IsNullOrEmpty(tbxname.Text) == false;
            if (isOk == false) return isOk;

            tbxid.Text = Util.InputdataCheckEngNum("의뢰자샘플ID 입력", tbxid.Text);
            isOk = string.IsNullOrEmpty(tbxid.Text) == false;
            if (isOk == false) return isOk;

            return isOk;
        }

        private void BtnReqSampleUpdate_Click(object sender, EventArgs e)
        {
            string strBtnName = "의뢰자샘플 수정사항 변경 후 저장";
            try
            {
                if (MessageBox.Show("저장하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                int rowIndex = dgvRequesterSampleDetail.CurrentRow.Index;


                tbl_reqmember_sample tbl_reqmember_sample1 = new tbl_reqmember_sample()
                {
                    reqmbname = dgvRequesterSampleDetail.Rows[rowIndex].Cells[4].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[4].Value.ToString(),
                    reqmbid = dgvRequesterSampleDetail.Rows[rowIndex].Cells[5].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[5].Value.ToString(),
                    name = dgvRequesterSampleDetail.Rows[rowIndex].Cells[1].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[1].Value.ToString(),
                    id = dgvRequesterSampleDetail.Rows[rowIndex].Cells[2].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[2].Value.ToString(),
                    reqsampleno = dgvRequesterSampleDetail.Rows[rowIndex].Cells[3].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[3].Value.ToString(),
                    method = dgvRequesterSampleDetail.Rows[rowIndex].Cells[6].Value == null ? "환경조건 변화별 센서연속시험" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[6].Value.ToString(),
                    adtype = dgvRequesterSampleDetail.Rows[rowIndex].Cells[7].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[7].Value.ToString(),
                    samplediv = dgvRequesterSampleDetail.Rows[rowIndex].Cells[8].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[8].Value.ToString(),

                };
                //tbl_reqmember_sample1.reqmbname = dgvRequesterSampleDetail.Rows[rowIndex].Cells[4].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[4].Value.ToString();
                //tbl_reqmember_sample1.reqmbid = dgvRequesterSampleDetail.Rows[rowIndex].Cells[5].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[5].Value.ToString();
                //tbl_reqmember_sample1.name = dgvRequesterSampleDetail.Rows[rowIndex].Cells[1].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[1].Value.ToString();
                //tbl_reqmember_sample1.id = dgvRequesterSampleDetail.Rows[rowIndex].Cells[2].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[2].Value.ToString();
                //tbl_reqmember_sample1.reqsampleno = dgvRequesterSampleDetail.Rows[rowIndex].Cells[3].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[3].Value.ToString();
                //tbl_reqmember_sample1.method = dgvRequesterSampleDetail.Rows[rowIndex].Cells[6].Value == null ? "환경조건 변화별 센서연속시험" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[6].Value.ToString();
                //tbl_reqmember_sample1.adtype = dgvRequesterSampleDetail.Rows[rowIndex].Cells[7].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[7].Value.ToString();
                //tbl_reqmember_sample1.samplediv = dgvRequesterSampleDetail.Rows[rowIndex].Cells[8].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[8].Value.ToString();
                string use10 = dgvRequesterSampleDetail.Rows[rowIndex].Cells[11].Value == null ? "" : dgvRequesterSampleDetail.Rows[rowIndex].Cells[11].Value.ToString();
                tbl_reqmember_sample1.use10 = use10.Equals("YES") == true ? "1" : "0";

                if (string.IsNullOrEmpty(tbl_reqmember_sample1.name))
                {
                    MessageBox.Show("[의뢰자샘플명] 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(tbl_reqmember_sample1.id))
                {
                    MessageBox.Show("[의뢰자샘플ID] 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }

                try
                {
                    tbl_reqmember_sample1.updatedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string dbsql = $@"UPDATE tbl_reqmember_sample 
                        SET 
                            reqmbname= '{tbl_reqmember_sample1.reqmbname}',
                            reqmbid= '{tbl_reqmember_sample1.reqmbid}',
                            id= '{tbl_reqmember_sample1.id}',
                            name= '{tbl_reqmember_sample1.name}',
                            method= '{tbl_reqmember_sample1.method}',
                            adtype= '{tbl_reqmember_sample1.adtype}',
                            samplediv= '{tbl_reqmember_sample1.samplediv}',
                            updatedate = '{tbl_reqmember_sample1.updatedate}',
                            use10 = '{tbl_reqmember_sample1.use10}'

                        WHERE  reqsampleno='{tbl_reqmember_sample1.reqsampleno}' ";

                    cMysqlDto.OpenKeepUp();
                    cMysqlDto.RunSql("UPDATE", dbsql);
                    MessageBox.Show(strBtnName + "가 완료되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Info(cMwLog.RequesterSampleManageUpdateEventLog);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    cLog.Error(cMwLog.RequesterSmapleUpdateError);
                    return;
                }
                finally
                {
                    cMysqlDto.Close();
                }

                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                    SelectReqSmapleList();
                else
                    BtnSearch_Click(null, null);
            }
            catch
            {
                MessageBox.Show("값이 선택되지 않았습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (MessageBox.Show("검색어에 특수문자(%)를 제한합니다.", "의뢰자샘플관리", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
                case "의뢰자샘플명":
                    sql = $"select count(*) as cnt from tbl_reqmember_sample ,(select @num:=0) as s where out10 = 0 && name like '%{tbSearch.Text}%' ";
                    break;
                case "ID":
                    sql = $"select count(*) as cnt from tbl_reqmember_sample ,(select @num:=0) as s where out10 = 0 && id like '%{tbSearch.Text}%'";
                    break;
                case "전체":
                    sql = $"select count(*) as cnt from tbl_reqmember_sample ,(select @num:=0) as s where out10 = 0 && (name like '%{tbSearch.Text}%' or id like '%{tbSearch.Text}%')";
                    break;
                case "의뢰자명":
                    sql = $"select count(*) as cnt from tbl_reqmember_sample ,(select @num:=0) as s where  out10 = 0 && reqmbname like '%{tbSearch.Text}%' ";
                    break;
            }

            try
            {


                int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(sql, "cnt")[0]["cnt"]);

                if (rowCnt == 0)
                {
                    MessageBox.Show("의뢰자샘플 정보가 없습니다.", "의뢰자샘플관리", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    case "의뢰자샘플명":
                        sql = $"select (@num:=@num+1) as no, reqmbname,name,   id, adtype, samplediv  from tbl_reqmember_sample , (select @num:=0) as s  where out10 = 0 && name like '%{tbSearch.Text}%' ";
                        break;
                    case "ID":
                        sql = $"select (@num:=@num+1) as no, reqmbname,name, id, adtype, samplediv from tbl_reqmember_sample  , (select @num:=0) as s  where out10 = 0 && id like '%{tbSearch.Text}%'";
                        break;
                    case "전체":
                        sql = $"select (@num:=@num+1) as no, reqmbname,name,  id, adtype, samplediv from tbl_reqmember_sample  , (select @num:=0) as s  where out10 = 0 && (name like '%{tbSearch.Text}%' or id like '%{tbSearch.Text}%' or reqmbname like '%{tbSearch.Text}%')";
                        break;
                    case "의뢰자명":
                        sql = $"select (@num:=@num+1) as no, reqmbname,name,  id, adtype, samplediv  from tbl_reqmember_sample  , (select @num:=0) as s  where out10 = 0 && reqmbname like '%{tbSearch.Text}%'";
                        break;
                }


                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                dgvRequesterSampleList.DataSource = dt;
                cLog.Info(cMwLog.RequesterSampleSearchClickEventLog);
            }
            catch (Exception)
            {
                MessageBox.Show("의뢰자샘플 검색 실패", "의뢰자샘플관리", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cLog.Info(cMwLog.RequesterSmapleSearchLoadError);
            }
        }

        private void DgvRequesterSampleDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;


            //사용여부 위치(8)
            if (e.RowIndex >= 0 && (e.ColumnIndex == 8))
            {
                dgv.BeginEdit(true);
                if (dgv.EditingControl != null)
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

        private void DgvRequesterSampleDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }



        private void Tbxname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Tbxid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Cboreqname_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        public string SelectReqNameList(string id)
        {
            string sql = $"select name from tbl_reqmember, (select @num:=0) as s where id ='{id}' && out10=0 order by id asc";

            List<Dictionary<string, string>> dicReturn = cMysqlDto.SelectSql2(sql, "name");
            if (dicReturn != null)
                if (dicReturn.Count > 0)
                {
                    Dictionary<string, string> row = dicReturn[0];
                    if (row != null)
                    {
                        return row["name"];
                    }
                    else { return null; }
                }
            return null;
        }


    }
}
