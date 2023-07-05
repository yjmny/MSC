using C1.Win.C1FlexGrid;
using DoMeasureMSC.Data;
using DBMS_V1;
using EventLog;
using DwLib.Data;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Navigation;
using static C1.Util.Win.Win32;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using MessageBox = System.Windows.Forms.MessageBox;

namespace DoMeasureMSC
{
    public partial class RecipeManagePage : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSearchWord = new C1.Win.C1Input.C1ComboBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnShowAllList = new System.Windows.Forms.Button();
            this.dgvRecipeList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCalibName = new System.Windows.Forms.TextBox();
            this.cbxCalibID = new C1.Win.C1Input.C1ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.sethumi = new System.Windows.Forms.TextBox();
            this.settemp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxPatternName = new System.Windows.Forms.TextBox();
            this.cboHmi_com_ptno = new C1.Win.C1Input.C1ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtime = new System.Windows.Forms.TextBox();
            this.dgvReqSetting = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvreqmbid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvreqsampleid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnRecupeUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvRecipeDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpatternno = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcalibid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvmtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.cboSearchWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCalibID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHmi_com_ptno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1640, 950);
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "레시피 관리";
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
            this.splitContainer2.Panel2.Controls.Add(this.dgvReqSetting);
            this.splitContainer2.Panel2.Controls.Add(this.btnRecupeUpdate);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.dgvRecipeDetail);
            this.splitContainer2.Size = new System.Drawing.Size(1640, 896);
            this.splitContainer2.SplitterDistance = 350;
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
            this.splitContainer3.Panel1.Controls.Add(this.cboSearchWord);
            this.splitContainer3.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer3.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer3.Panel1.Controls.Add(this.btnShowAllList);
            this.splitContainer3.Panel1.Controls.Add(this.dgvRecipeList);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Panel2.Controls.Add(this.tbxCalibName);
            this.splitContainer3.Panel2.Controls.Add(this.cbxCalibID);
            this.splitContainer3.Panel2.Controls.Add(this.label36);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Panel2.Controls.Add(this.label11);
            this.splitContainer3.Panel2.Controls.Add(this.label6);
            this.splitContainer3.Panel2.Controls.Add(this.button1);
            this.splitContainer3.Panel2.Controls.Add(this.label5);
            this.splitContainer3.Panel2.Controls.Add(this.id);
            this.splitContainer3.Panel2.Controls.Add(this.name);
            this.splitContainer3.Panel2.Controls.Add(this.sethumi);
            this.splitContainer3.Panel2.Controls.Add(this.settemp);
            this.splitContainer3.Panel2.Controls.Add(this.label13);
            this.splitContainer3.Panel2.Controls.Add(this.label12);
            this.splitContainer3.Panel2.Controls.Add(this.tbxPatternName);
            this.splitContainer3.Panel2.Controls.Add(this.cboHmi_com_ptno);
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Panel2.Controls.Add(this.mtime);
            this.splitContainer3.Size = new System.Drawing.Size(1640, 350);
            this.splitContainer3.SplitterDistance = 815;
            this.splitContainer3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "레시피 조회";
            // 
            // cboSearchWord
            // 
            this.cboSearchWord.AllowSpinLoop = false;
            this.cboSearchWord.BackColor = System.Drawing.Color.Cornsilk;
            this.cboSearchWord.Font = new System.Drawing.Font("나눔고딕", 16F);
            this.cboSearchWord.GapHeight = 0;
            this.cboSearchWord.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cboSearchWord.Items.Add("전체");
            this.cboSearchWord.Items.Add("레시피명");
            this.cboSearchWord.Items.Add("ID");
            this.cboSearchWord.Location = new System.Drawing.Point(261, 0);
            this.cboSearchWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSearchWord.Name = "cboSearchWord";
            this.cboSearchWord.Size = new System.Drawing.Size(200, 32);
            this.cboSearchWord.TabIndex = 26;
            this.cboSearchWord.Tag = null;
            this.cboSearchWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboSearchWord.Value = "123";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(124)))), ((int)(((byte)(245)))));
            this.btnSearch.Image = global::DoMeasureMSC.Properties.Resources.find;
            this.btnSearch.Location = new System.Drawing.Point(674, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 25;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Cornsilk;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("나눔고딕", 16F);
            this.tbSearch.Location = new System.Drawing.Point(468, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(200, 32);
            this.tbSearch.TabIndex = 24;
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
            this.btnShowAllList.Name = "btnShowAllList";
            this.btnShowAllList.Size = new System.Drawing.Size(100, 32);
            this.btnShowAllList.TabIndex = 23;
            this.btnShowAllList.Text = "전체조회";
            this.btnShowAllList.UseVisualStyleBackColor = false;
            this.btnShowAllList.Click += new System.EventHandler(this.BtnShowAllList_Click);
            // 
            // dgvRecipeList
            // 
            this.dgvRecipeList.AllowUserToAddRows = false;
            this.dgvRecipeList.AllowUserToDeleteRows = false;
            this.dgvRecipeList.AllowUserToResizeColumns = false;
            this.dgvRecipeList.AllowUserToResizeRows = false;
            this.dgvRecipeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipeList.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecipeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecipeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecipeList.ColumnHeadersHeight = 50;
            this.dgvRecipeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecipeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewButtonColumn1});
            this.dgvRecipeList.EnableHeadersVisualStyles = false;
            this.dgvRecipeList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvRecipeList.Location = new System.Drawing.Point(3, 47);
            this.dgvRecipeList.MultiSelect = false;
            this.dgvRecipeList.Name = "dgvRecipeList";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecipeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRecipeList.RowHeadersVisible = false;
            this.dgvRecipeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecipeList.RowTemplate.Height = 23;
            this.dgvRecipeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipeList.Size = new System.Drawing.Size(805, 273);
            this.dgvRecipeList.TabIndex = 21;
            this.dgvRecipeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRecipeList_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "no";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "NO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "레시피명";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "레시피ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "use10";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "사용여부";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "옵션";
            this.dataGridViewButtonColumn1.MinimumWidth = 100;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn1.Text = "레시피 제외";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Coral;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(-1, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(821, 28);
            this.label4.TabIndex = 145;
            this.label4.Text = "※ 레시피 신규등록 완료시, [조회]에서 해당 레시피를 선택하고, 샘플정보를 반드시 업데이트 하세요.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxCalibName
            // 
            this.tbxCalibName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxCalibName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCalibName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxCalibName.Location = new System.Drawing.Point(616, 245);
            this.tbxCalibName.Name = "tbxCalibName";
            this.tbxCalibName.ReadOnly = true;
            this.tbxCalibName.Size = new System.Drawing.Size(182, 26);
            this.tbxCalibName.TabIndex = 144;
            this.tbxCalibName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxCalibID
            // 
            this.cbxCalibID.AllowSpinLoop = false;
            this.cbxCalibID.BackColor = System.Drawing.Color.Cornsilk;
            this.cbxCalibID.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxCalibID.GapHeight = 0;
            this.cbxCalibID.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxCalibID.Location = new System.Drawing.Point(413, 245);
            this.cbxCalibID.Name = "cbxCalibID";
            this.cbxCalibID.Size = new System.Drawing.Size(185, 26);
            this.cbxCalibID.TabIndex = 143;
            this.cbxCalibID.Tag = null;
            this.cbxCalibID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbxCalibID.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbxCalibID.SelectedItemChanged += new System.EventHandler(this.CbxCalibID_SelectedItemChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label36.Location = new System.Drawing.Point(413, 215);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(127, 19);
            this.label36.TabIndex = 94;
            this.label36.Text = "[캘리브레이션]ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 93;
            this.label3.Text = "레시피 등록";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(3, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 19);
            this.label11.TabIndex = 86;
            this.label11.Text = "[패턴모드] 설정번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(413, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "레시피ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(536, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 32);
            this.button1.TabIndex = 66;
            this.button1.Text = "레시피 신규등록";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnRecipeRegi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 82;
            this.label5.Text = "레시피명";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Cornsilk;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id.Location = new System.Drawing.Point(413, 90);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(385, 26);
            this.id.TabIndex = 83;
            this.id.Tag = "레시피ID를 입력하세요.(Ex:RECIPE_001)";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Id_KeyPress);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Cornsilk;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(3, 90);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(385, 26);
            this.name.TabIndex = 85;
            this.name.Tag = "레시피명을 입력하세요. (Ex:레시피A)";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // sethumi
            // 
            this.sethumi.BackColor = System.Drawing.Color.Cornsilk;
            this.sethumi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sethumi.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sethumi.Location = new System.Drawing.Point(206, 245);
            this.sethumi.Name = "sethumi";
            this.sethumi.Size = new System.Drawing.Size(182, 26);
            this.sethumi.TabIndex = 92;
            this.sethumi.Tag = "정치모드일때, 습도를 설정하세요.(Ex:60)";
            this.sethumi.Text = "60";
            this.sethumi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // settemp
            // 
            this.settemp.BackColor = System.Drawing.Color.Cornsilk;
            this.settemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settemp.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.settemp.Location = new System.Drawing.Point(3, 245);
            this.settemp.Name = "settemp";
            this.settemp.Size = new System.Drawing.Size(183, 26);
            this.settemp.TabIndex = 91;
            this.settemp.Tag = "정치모드일때, 온도를 설정하세요.(Ex:40)";
            this.settemp.Text = "40";
            this.settemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(217, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 19);
            this.label13.TabIndex = 89;
            this.label13.Text = "습도 설정값(%)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(3, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 19);
            this.label12.TabIndex = 90;
            this.label12.Text = "[정치모드] 온도 설정값 (℃)";
            // 
            // tbxPatternName
            // 
            this.tbxPatternName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPatternName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPatternName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxPatternName.Location = new System.Drawing.Point(206, 165);
            this.tbxPatternName.Name = "tbxPatternName";
            this.tbxPatternName.ReadOnly = true;
            this.tbxPatternName.Size = new System.Drawing.Size(182, 26);
            this.tbxPatternName.TabIndex = 88;
            this.tbxPatternName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboHmi_com_ptno
            // 
            this.cboHmi_com_ptno.AllowSpinLoop = false;
            this.cboHmi_com_ptno.BackColor = System.Drawing.Color.Cornsilk;
            this.cboHmi_com_ptno.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboHmi_com_ptno.GapHeight = 0;
            this.cboHmi_com_ptno.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cboHmi_com_ptno.Items.Add("1");
            this.cboHmi_com_ptno.Location = new System.Drawing.Point(3, 165);
            this.cboHmi_com_ptno.Name = "cboHmi_com_ptno";
            this.cboHmi_com_ptno.Size = new System.Drawing.Size(185, 26);
            this.cboHmi_com_ptno.TabIndex = 87;
            this.cboHmi_com_ptno.Tag = null;
            this.cboHmi_com_ptno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cboHmi_com_ptno.SelectedItemChanged += new System.EventHandler(this.Pattern_SelectedItemChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(413, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 81;
            this.label8.Text = "측정시간(sec)";
            // 
            // mtime
            // 
            this.mtime.BackColor = System.Drawing.Color.Cornsilk;
            this.mtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtime.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mtime.Location = new System.Drawing.Point(413, 166);
            this.mtime.Name = "mtime";
            this.mtime.Size = new System.Drawing.Size(385, 26);
            this.mtime.TabIndex = 84;
            this.mtime.Tag = "측정시간을 입력하세요.(Ex:60)";
            this.mtime.Text = "2592000";
            this.mtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvReqSetting
            // 
            this.dgvReqSetting.AllowUserToAddRows = false;
            this.dgvReqSetting.AllowUserToDeleteRows = false;
            this.dgvReqSetting.AllowUserToResizeColumns = false;
            this.dgvReqSetting.AllowUserToResizeRows = false;
            this.dgvReqSetting.BackgroundColor = System.Drawing.Color.White;
            this.dgvReqSetting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReqSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReqSetting.ColumnHeadersHeight = 50;
            this.dgvReqSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReqSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn19,
            this.dgvreqmbid,
            this.dgvreqsampleid});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReqSetting.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvReqSetting.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvReqSetting.EnableHeadersVisualStyles = false;
            this.dgvReqSetting.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvReqSetting.Location = new System.Drawing.Point(4, 178);
            this.dgvReqSetting.MultiSelect = false;
            this.dgvReqSetting.Name = "dgvReqSetting";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReqSetting.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvReqSetting.RowHeadersVisible = false;
            this.dgvReqSetting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReqSetting.RowTemplate.Height = 23;
            this.dgvReqSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReqSetting.Size = new System.Drawing.Size(1633, 352);
            this.dgvReqSetting.TabIndex = 147;
            this.dgvReqSetting.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReqSetting_CellClick);
            this.dgvReqSetting.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvReqSetting_DataError);
            // 
            // Column2
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column2.HeaderText = "NO";
            this.Column2.MinimumWidth = 50;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 50;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ch";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn19.FillWeight = 50F;
            this.dataGridViewTextBoxColumn19.HeaderText = "채널";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn19.Width = 255;
            // 
            // dgvreqmbid
            // 
            this.dgvreqmbid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvreqmbid.DataPropertyName = "reqmbid";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvreqmbid.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvreqmbid.HeaderText = "의뢰자명 | 의뢰자ID";
            this.dgvreqmbid.MinimumWidth = 150;
            this.dgvreqmbid.Name = "dgvreqmbid";
            this.dgvreqmbid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvreqmbid.Width = 662;
            // 
            // dgvreqsampleid
            // 
            this.dgvreqsampleid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvreqsampleid.DataPropertyName = "reqsampleid";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvreqsampleid.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvreqsampleid.HeaderText = "의뢰자샘플명 | 의뢰자샘플ID";
            this.dgvreqsampleid.MinimumWidth = 150;
            this.dgvreqsampleid.Name = "dgvreqsampleid";
            this.dgvreqsampleid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvreqsampleid.Width = 662;
            // 
            // btnRecupeUpdate
            // 
            this.btnRecupeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnRecupeUpdate.FlatAppearance.BorderSize = 0;
            this.btnRecupeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecupeUpdate.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRecupeUpdate.Location = new System.Drawing.Point(1355, 0);
            this.btnRecupeUpdate.Name = "btnRecupeUpdate";
            this.btnRecupeUpdate.Size = new System.Drawing.Size(282, 32);
            this.btnRecupeUpdate.TabIndex = 146;
            this.btnRecupeUpdate.Text = "레시피 수정사항 변경 후 저장";
            this.btnRecupeUpdate.UseVisualStyleBackColor = false;
            this.btnRecupeUpdate.Click += new System.EventHandler(this.BtnRecupeUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 145;
            this.label9.Text = "레시피 상세정보";
            // 
            // dgvRecipeDetail
            // 
            this.dgvRecipeDetail.AllowUserToAddRows = false;
            this.dgvRecipeDetail.AllowUserToDeleteRows = false;
            this.dgvRecipeDetail.AllowUserToResizeColumns = false;
            this.dgvRecipeDetail.AllowUserToResizeRows = false;
            this.dgvRecipeDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecipeDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecipeDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvRecipeDetail.ColumnHeadersHeight = 50;
            this.dgvRecipeDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecipeDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dgvpatternno,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dgvcalibid,
            this.dgvmtime,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dgvRecipeDetail.EnableHeadersVisualStyles = false;
            this.dgvRecipeDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvRecipeDetail.Location = new System.Drawing.Point(4, 38);
            this.dgvRecipeDetail.Name = "dgvRecipeDetail";
            this.dgvRecipeDetail.RowHeadersVisible = false;
            this.dgvRecipeDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecipeDetail.RowTemplate.Height = 23;
            this.dgvRecipeDetail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvRecipeDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipeDetail.Size = new System.Drawing.Size(1633, 119);
            this.dgvRecipeDetail.TabIndex = 142;
            this.dgvRecipeDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRecipeDetail_CellValueChanged);
            this.dgvRecipeDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvRecipeDetail_DataError_1);
            this.dgvRecipeDetail.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvRecipeDetail_EditingControlShowing);
            this.dgvRecipeDetail.SelectionChanged += new System.EventHandler(this.DgvRecipeDetail_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "no";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "NO";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "name";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "레시피명";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn8.HeaderText = "레시피ID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "rcpno";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn9.HeaderText = "레시피DBNO";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "method";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn10.HeaderText = "시험방법";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 250;
            // 
            // dgvpatternno
            // 
            this.dgvpatternno.AutoComplete = false;
            this.dgvpatternno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvpatternno.DataPropertyName = "patternid";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvpatternno.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvpatternno.HeaderText = "패턴모드 설정번호";
            this.dgvpatternno.MaxDropDownItems = 1;
            this.dgvpatternno.MinimumWidth = 100;
            this.dgvpatternno.Name = "dgvpatternno";
            this.dgvpatternno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpatternno.Width = 110;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "settemp";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn14.HeaderText = "정치모드    설정온도 (℃)";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "sethumi";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn15.HeaderText = "정치모드    설정습도 (%)";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcalibid
            // 
            this.dgvcalibid.DataPropertyName = "calibid";
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvcalibid.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvcalibid.HeaderText = "캘리브레이션ID";
            this.dgvcalibid.Name = "dgvcalibid";
            this.dgvcalibid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcalibid.Width = 110;
            // 
            // dgvmtime
            // 
            this.dgvmtime.DataPropertyName = "mtime";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvmtime.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgvmtime.HeaderText = "측정시간(sec)";
            this.dgvmtime.Name = "dgvmtime";
            this.dgvmtime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmtime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvmtime.Width = 110;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "regdate";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn16.HeaderText = "등록일자";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn16.Width = 200;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "updatedate";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn17.HeaderText = "변경일자";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn17.Width = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "의뢰자 설정";
            // 
            // RecipeManagePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1640, 950);
            this.MinimumSize = new System.Drawing.Size(1640, 950);
            this.Name = "RecipeManagePage";
            this.Text = "RecipeManagePage";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.cboSearchWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCalibID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHmi_com_ptno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeDetail)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dgvRecipeList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox sethumi;
        private System.Windows.Forms.TextBox settemp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxPatternName;
        private C1.Win.C1Input.C1ComboBox cboHmi_com_ptno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mtime;
        private System.Windows.Forms.Button button1;
        private C1.Win.C1Input.C1ComboBox cboSearchWord;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnShowAllList;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView dgvRecipeDetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRecupeUpdate;
        private System.Windows.Forms.TextBox tbxCalibName;
        private C1.Win.C1Input.C1ComboBox cbxCalibID;
        private System.Windows.Forms.DataGridView dgvReqSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvpatternno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcalibid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvreqmbid;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvreqsampleid;
        //================================================================================================================================


        public RecipeManagePage()
        {
            InitializeComponent();
            SelectRecipeList();
            ShowDetail(0, null);
            cboSearchWord.SelectedIndex = 0;

            //watermark test
            name.ForeColor = Color.Gray;
            name.Text = "Please Enter Name";

            InitInputControl();
            InitReqSetting();
           
        }

        private readonly MeasureWriteLog cMwLog = new MeasureWriteLog();
        private static readonly ILog cLog = LogManager.GetLogger("Measure");
        readonly MySqlDTO cMysqlDto = new MySqlDTO();
        readonly DBMS_V1.Data.MSC.Tbl_recipe cTbl_recipe = new DBMS_V1.Data.MSC.Tbl_recipe();

        private void InitReqSetting()
        {
            for (int i = 1; i <= 12; i++)
            {
                dgvReqSetting.Rows.Add(i.ToString());
            }

            try
            {

                DataSet ds2 = SelectReqMemberTableList();
                if (ds2.Tables.Count > 0)
                {
                    dgvreqmbid.Items.Add("미지정");
                    RcpSetting.SetNames(ds2, "reqmbno");
                    Dictionary<string, string> reqmbid = new Dictionary<string, string>();

                    for (int i = 0; i < RcpSetting.GetNames().Length; i++)
                    {
                        string s = RcpSetting.GetNames()[i];

                        if (string.IsNullOrEmpty(s) == false)
                        {
                            string sql = $"select id, name from tbl_reqmember where reqmbno='{s}' ";
                            Dictionary<string, string> row = cMysqlDto.SelectSql2(sql, "id", "name")[0];
                            dgvreqmbid.Items.Add(row["name"] + " | " + row["id"]);

                        }
                    }
                }

                DataSet ds3 = SelectReqSampleTableList();
                if (ds3.Tables.Count > 0)
                {
                    dgvreqsampleid.Items.Add("미지정");
                    RcpSetting.SetNames(ds3, "reqsampleno");

                    Dictionary<string, string> dct = new Dictionary<string, string>();

                    for (int i = 0; i < RcpSetting.GetNames().Length; i++)
                    {
                        string s = RcpSetting.GetNames()[i];
                        if (string.IsNullOrEmpty(s) == false)
                        {
                            string sql = $"select id, name from tbl_reqmember_sample where reqsampleno='{s}' ";
                            Dictionary<string, string> row = cMysqlDto.SelectSql2(sql, "id", "name")[0];
                            dgvreqsampleid.Items.Add(row["name"] + " | " + row["id"]);


                        }
                    }

                }

                DataSet ds4 = SelectCalibTableList();
                if (ds4.Tables.Count > 0)
                {
                    cbxCalibID.Items.Clear();
                    RcpSetting.SetNames(ds4, "id");

                    Dictionary<string, string> dct = new Dictionary<string, string>();

                    for (int i = 0; i < RcpSetting.GetNames().Length; i++)
                    {
                        string s = RcpSetting.GetNames()[i];
                        if (string.IsNullOrEmpty(s) == false)
                        {
                            DataRow dr = ds4.Tables[0].Rows[i];
                            cbxCalibID.Items.Add(s);
                            dgvcalibid.Items.Add(s);


                        }
                    }
                    cbxCalibID.SelectedIndex = 0;
                }
                DataSet ds5 = SelectHmiPatternTableList();
                if (ds5.Tables.Count > 0)
                {
                    cboHmi_com_ptno.Items.Clear();
                    RcpSetting.SetNames(ds5, "com_ptno");

                    Dictionary<string, string> dct = new Dictionary<string, string>();

                    for (int i = 0; i < RcpSetting.GetNames().Length; i++)
                    {
                        string s = RcpSetting.GetNames()[i];
                        if (string.IsNullOrEmpty(s) == false)
                        {
                            DataRow dr = ds5.Tables[0].Rows[i];
                            cboHmi_com_ptno.Items.Add(s);
                            dgvpatternno.Items.Add(s);


                        }
                    }
                    cboHmi_com_ptno.SelectedIndex = 0;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }



        private void InitInputControl()
        {
            name.Text = name.Tag.ToString();
            name.ForeColor = Color.Gray;

            id.Text = id.Tag.ToString();
            id.ForeColor = Color.Gray;

            if (string.IsNullOrEmpty(mtime.Text))
            {
                mtime.Text = mtime.Tag.ToString();
                mtime.ForeColor = Color.Gray;
            }

            if (string.IsNullOrEmpty(settemp.Text))
            {
                settemp.Text = settemp.Tag.ToString();
                settemp.ForeColor = Color.Gray;
            }
            if (string.IsNullOrEmpty(sethumi.Text))
            {
                sethumi.Text = sethumi.Tag.ToString();
                sethumi.ForeColor = Color.Gray;
            }

            this.id.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.id.Leave += new System.EventHandler(this.WaterMark_Leave);

            this.name.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.name.Leave += new System.EventHandler(this.WaterMark_Leave);

            this.mtime.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.mtime.Leave += new System.EventHandler(this.WaterMark_Leave);

            this.settemp.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.settemp.Leave += new System.EventHandler(this.WaterMark_Leave);

            this.sethumi.Enter += new System.EventHandler(this.WaterMake_Enter);
            this.sethumi.Leave += new System.EventHandler(this.WaterMark_Leave);
        }

        public void SelectRecipeList()
        {
            try
            {
                string sql = "select (@num:=@num+1) as no, name,id, if(use10=1,'Y','N') as use10  from tbl_recipe, (select @num:=0) as s where out10 = 0  order by name asc"; //,
                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                dgvRecipeList.DataSource = dt;

            }
            catch (Exception)
            {
                cLog.Error(cMwLog.RecipeListShowLoadError);
            }
        }
        public void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }
        public void ShowDetail(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dgv = sender as DataGridView;
            if (sender is DataGridView dgv) { }
            else return;
            //if (dgv == null) return;

            if (dgv.CurrentRow.Selected)
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    DataGridViewRow selectedRow = dgvRecipeList.Rows[index];

                    var no = string.Empty;
                    var name = string.Empty;
                    var id = string.Empty;
                    if (selectedRow.Cells.Count > 0)
                    {
                        for (int i = 0; i < selectedRow.Cells.Count; i++)
                        {
                            System.Diagnostics.Debug.WriteLine(selectedRow.Cells[i].Value + " " + dgvRecipeList.Columns[i].HeaderText);
                            if (dgvRecipeList.Columns[i].HeaderText.Equals("NO"))
                                no = selectedRow.Cells[i].Value.ToString();
                            if (dgvRecipeList.Columns[i].HeaderText.Equals("레시피명"))
                                name = selectedRow.Cells[i].Value.ToString();
                            if (dgvRecipeList.Columns[i].HeaderText.Equals("레시피ID"))
                                id = selectedRow.Cells[i].Value.ToString();

                            if (string.IsNullOrEmpty(no) == false && string.IsNullOrEmpty(name) == false && string.IsNullOrEmpty(id) == false)
                            {
                                break;
                            }
                        }

                    }

                    string strname = name.ToString();
                    if (CompTemp_showRecipedetail.Equals(strname) == false)
                    {
                        CompTemp_showRecipedetail = strname;
                    }
                    else
                    {
                        return;
                    }

                    try
                    {
                        DataTable dt = null;
                        string sql = $"select  (select @num:=@num+1) as no, name, id,   rcpno, method, patternid, settemp, sethumi,calibid,mtime, "
                                   + $"DATE_FORMAT(regdate, '%Y-%m-%d %H:%i:%s') AS regdate, "
                                   + $"DATE_FORMAT(updatedate, '%Y-%m-%d %H:%i:%s') AS updatedate "
                                   + $"from tbl_recipe, (select @num:= 0) as s where id = \"{id}\" ;";
                        dt = cMysqlDto.SelectSqlToDataTable(sql);
                        string calibid = "";
                        Dictionary<string, string> row1 = cMysqlDto.SelectSql2(sql, "calibid")[0];
                        if (row1 != null)
                        {
                            calibid = row1["calibid"].Trim();
                        }
                        CheckCalibID(calibid);
                        dgvRecipeDetail.DataSource = dt;
                        Delay(100);
                        SelectReqChannel(calibid);
                        SelectReqInfo(id);
                    }
                    catch
                    {
                        cLog.Error(cMwLog.RecipeDetailLoadError);
                    }

                }
            }
        }
        public void CheckCalibID(string calibid)
        {
            string sql = $"select count(*) as cnt from tbl_plc_calibration where id = \"{calibid}\" && out10=0;";

            int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(sql, "cnt")[0]["cnt"]);

            if (rowCnt == 0)
            {
                MessageBox.Show("캘리브레이션ID가 이전에 삭제되어 존재하지 않습니다.\r\n 레시피 수정사항 변경 후 저장해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        public void SelectReqChannel(string calibid)
        {
            string sql = $"select ch1_name,ch2_name,ch3_name,ch4_name,ch5_name,ch6_name,ch7_name,ch8_name,ch9_name,ch10_name,ch11_name,ch12_name from tbl_plc_calibration, (select @num:= 0) as s where id ='{calibid}' ";
            Dictionary<string, string> rowcal = cMysqlDto.SelectSql2(sql, "ch1_name", "ch2_name", "ch3_name", "ch4_name", "ch5_name", "ch6_name", "ch7_name", "ch8_name", "ch9_name", "ch10_name", "ch11_name", "ch12_name")[0];
            if (rowcal != null)
            {
                dgvReqSetting.Rows[0].Cells[1].Value = rowcal["ch1_name"].ToString();
                dgvReqSetting.Rows[1].Cells[1].Value = rowcal["ch2_name"].ToString();
                dgvReqSetting.Rows[2].Cells[1].Value = rowcal["ch3_name"].ToString();
                dgvReqSetting.Rows[3].Cells[1].Value = rowcal["ch4_name"].ToString();
                dgvReqSetting.Rows[4].Cells[1].Value = rowcal["ch5_name"].ToString();
                dgvReqSetting.Rows[5].Cells[1].Value = rowcal["ch6_name"].ToString();
                dgvReqSetting.Rows[6].Cells[1].Value = rowcal["ch7_name"].ToString();
                dgvReqSetting.Rows[7].Cells[1].Value = rowcal["ch8_name"].ToString();
                dgvReqSetting.Rows[8].Cells[1].Value = rowcal["ch9_name"].ToString();
                dgvReqSetting.Rows[9].Cells[1].Value = rowcal["ch10_name"].ToString();
                dgvReqSetting.Rows[10].Cells[1].Value = rowcal["ch11_name"].ToString();
                dgvReqSetting.Rows[11].Cells[1].Value = rowcal["ch12_name"].ToString();

            }

        }
        public void SelectReqInfo(string rcpid)
        {
            string dbsql = $"select reqmbid1,reqmbid2,reqmbid3,reqmbid4,reqmbid5,reqmbid6,reqmbid7,reqmbid8,reqmbid9,reqmbid10,reqmbid11,reqmbid12," +
            $"reqmbname1,reqmbname2,reqmbname3,reqmbname4,reqmbname5,reqmbname6,reqmbname7,reqmbname8,reqmbname9,reqmbname10,reqmbname11,reqmbname12," +
            $"reqsampleid1,reqsampleid2,reqsampleid3,reqsampleid4,reqsampleid5,reqsampleid6,reqsampleid7,reqsampleid8,reqsampleid9,reqsampleid10,reqsampleid11,reqsampleid12," +
            $"reqsamplename1,reqsamplename2,reqsamplename3,reqsamplename4,reqsamplename5,reqsamplename6,reqsamplename7,reqsamplename8,reqsamplename9,reqsamplename10,reqsamplename11,reqsamplename12" +
            $" from tbl_recipe, (select @num:= 0) as s where id ='{rcpid}' ";

            Dictionary<string, string> row = cMysqlDto.SelectSql2(dbsql, "reqmbid1", "reqmbid2", "reqmbid3", "reqmbid4", "reqmbid5", "reqmbid6", "reqmbid7", "reqmbid8", "reqmbid9", "reqmbid10", "reqmbid11", "reqmbid12",
                "reqmbname1", "reqmbname2", "reqmbname3", "reqmbname4", "reqmbname5", "reqmbname6", "reqmbname7", "reqmbname8", "reqmbname9", "reqmbname10", "reqmbname11", "reqmbname12",
                "reqsampleid1", "reqsampleid2", "reqsampleid3", "reqsampleid4", "reqsampleid5", "reqsampleid6", "reqsampleid7", "reqsampleid8", "reqsampleid9", "reqsampleid10", "reqsampleid11", "reqsampleid12",
                "reqsamplename1", "reqsamplename2", "reqsamplename3", "reqsamplename4", "reqsamplename5", "reqsamplename6", "reqsamplename7", "reqsamplename8", "reqsamplename9", "reqsamplename10", "reqsamplename11", "reqsamplename12")[0];

            if (row != null)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (row["reqmbname" + (i + 1)].ToString().Trim().Equals("미지정"))
                    {
                        dgvReqSetting.Rows[i].Cells[2].Value = "미지정";
                    }
                    else
                    {
                        dgvReqSetting.Rows[i].Cells[2].Value = row["reqmbname" + (i + 1)].ToString().Trim() + " | " + row["reqmbid" + (i + 1)].ToString().Trim();
                    }

                    if (row["reqsamplename" + (i + 1)].ToString().Trim().Equals("미지정"))
                    {
                        dgvReqSetting.Rows[i].Cells[3].Value = "미지정";
                    }
                    else
                    {
                        dgvReqSetting.Rows[i].Cells[3].Value = row["reqsamplename" + (i + 1)].ToString().Trim() + " | " + row["reqsampleid" + (i + 1)].ToString().Trim();
                    }
                }

            }
        }
        public DataSet SelectReqMemberTableList()
        {
            DataSet ds;
            try
            {
                string sql = $"select (@num:=@num+1) as no, reqmbno, name as reqmbname, id, if(use10=1,'Y','N') as use10 from tbl_reqmember, (select @num:=0) as s where out10=0 order by reqmbname asc "; //,out10=0
                ds = cMysqlDto.SelectSqlToDataSet(sql, "ReqListData");
            }
            catch (Exception)
            {
                ds = null;
            }
            return ds;
        }
        public DataSet SelectReqSampleTableList()
        {
            DataSet ds;
            try
            {
                string sql = $"select (@num:=@num+1) as no, reqsampleno,id, name from tbl_reqmember_sample, (select @num:=0) as s where use10 ='1' && out10=0 order by name asc "; //,out10=0
                ds = cMysqlDto.SelectSqlToDataSet(sql, "ReqSampleListData");
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message);
                ds = null;
            }
            return ds;
        }
        public DataSet SelectCalibTableList()
        {
            DataSet ds;
            try
            {
                string sql = $"select (@num:=@num+1) as no, calno, id, name from tbl_plc_calibration, (select @num:=0) as s where use10 ='1'  && out10=0  group by id order by name asc "; //,out10=0
                ds = cMysqlDto.SelectSqlToDataSet(sql, "CalibListData");
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message);
                ds = null;
            }
            return ds;
        }
        public DataSet SelectHmiPatternTableList()
        {
            DataSet ds;
            try
            {
                string sql = $"select (@num:=@num+1) as no,  com_ptno, name from tbl_hmi_pattern, (select @num:=0) as s where out10=0 group by com_ptno order by name asc "; //,out10=0
                ds = cMysqlDto.SelectSqlToDataSet(sql, "HmiPatternListData");
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message);
                ds = null;
            }
            return ds;
        }
        private void BtnShowAllList_Click(object sender, EventArgs e)
        {
            SelectRecipeList();
        }

        string CompTemp_showRecipedetail = "";
        private void DgvRecipeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            if (e.ColumnIndex == 0)
            {
                string strBtnName = "레시피 제외";
                if (MessageBox.Show("제외하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                DataGridViewRow row = dgvRecipeList.SelectedRows[0]; //선택된 Row 값 가져옴.
                //string name = row.Cells[2].Value.ToString();
                string id = row.Cells[3].Value.ToString();


                try
                {
                    cMysqlDto.OpenKeepUp();
                    string dbsql = $@"update tbl_recipe set out10=1 where id='{id}'";
                    cMysqlDto.RunSql("UPDATE", dbsql);
                    MessageBox.Show("제외되었습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SelectRecipeList();
                    //ShowDetail(sender, e);
                    cLog.Info(cMwLog.RecipeDeleteEventLog);
                }
                catch (Exception exc)
                {
                    System.Diagnostics.Debug.WriteLine(exc.Message);
                    MessageBox.Show("레시피 제외 실패", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Error(cMwLog.RecipeDeleteError);
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

        private void BtnRecipeRegi_Click(object sender, EventArgs e)
        {
            string strBtnName = "레시피 신규등록";
            if (InputDataCheck() == false)
            {
                return;
            }
            if (MessageBox.Show("레시피 등록 하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ////fgUserSetting
                DBMS_V1.Data.MSC.Tbl_recipe cTbl_recipe = new DBMS_V1.Data.MSC.Tbl_recipe()
                {
                    name = string.IsNullOrEmpty(name.Text) ? "" : name.Text.ToString(),
                    id = string.IsNullOrEmpty(id.Text) ? "" : id.Text.ToString(),
                    mtime = string.IsNullOrEmpty(mtime.Text) ? "" : mtime.Text.ToString(),
                    pattern = cboHmi_com_ptno.SelectedItem == null ? "" : cboHmi_com_ptno.SelectedItem.ToString(),
                    settemp = string.IsNullOrEmpty(settemp.Text) ? "" : settemp.Text.ToString(),
                    sethumi = string.IsNullOrEmpty(sethumi.Text) ? "" : sethumi.Text.ToString(),
                    method = "환경조건 변화별 센서연속시험",
                    calibid = cbxCalibID.SelectedItem == null ? "" : cbxCalibID.SelectedItem.ToString(),
                };

                //tbl_recipe1.name = name.Text.ToString() == null ? "" : name.Text.ToString();
                //tbl_recipe1.id = id.Text.ToString() == null ? "" : id.Text.ToString();
                //tbl_recipe1.mtime = mtime.Text.ToString() == null ? "" : mtime.Text.ToString();
                //tbl_recipe1.pattern = cboHmi_com_ptno.SelectedItem == null ? "" : cboHmi_com_ptno.SelectedItem.ToString();
                //tbl_recipe1.settemp = settemp.Text.ToString() == null ? "" : settemp.Text.ToString();
                //tbl_recipe1.sethumi = sethumi.Text.ToString() == null ? "" : sethumi.Text.ToString();
                //tbl_recipe1.method = "환경조건 변화별 센서연속시험";
                //tbl_recipe1.calibid = cbxCalibID.SelectedItem == null ? "" : cbxCalibID.SelectedItem.ToString();


                if (string.IsNullOrEmpty(cTbl_recipe.name))
                {
                    MessageBox.Show("레시피명 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(cTbl_recipe.id))
                {
                    MessageBox.Show("레시피ID 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(cTbl_recipe.mtime))
                {
                    MessageBox.Show("측정시간 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(cTbl_recipe.pattern))
                {
                    MessageBox.Show("패턴 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(cTbl_recipe.settemp))
                {
                    MessageBox.Show("온도 설정값 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(cTbl_recipe.sethumi))
                {
                    MessageBox.Show("습도 설정값 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (string.IsNullOrEmpty(cTbl_recipe.calibid))
                {
                    MessageBox.Show("캘리브레이션 정보가 누락되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                string salt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                try
                {
                    string dbsql = $"select count(*) as cnt from tbl_recipe where id=\"{cTbl_recipe.id}\" ";


                    int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(dbsql, "cnt")[0]["cnt"]);

                    if (rowCnt != 0)
                    {
                        MessageBox.Show("중복된 아이디 입니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    cTbl_recipe.regdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dbsql = ($"INSERT INTO tbl_recipe (id, name,mtime,patternid,settemp,sethumi, method, regdate,calibid) " +
$"VALUE (\"{cTbl_recipe.id}\",\"{cTbl_recipe.name}\", \"{cTbl_recipe.mtime}\",\"{cTbl_recipe.pattern}\",\"{cTbl_recipe.settemp}\",\"{cTbl_recipe.sethumi}\",  \"{cTbl_recipe.method}\", \"{cTbl_recipe.regdate}\",  \"{cTbl_recipe.calibid}\")");

                    //                    dbsql = ($"INSERT INTO tbl_recipe (id, name,mtime,patternid,settemp,sethumi, method, regdate,calibid) " +
                    //$"VALUE (\"{tbl_recipe1.id}\",\"{tbl_recipe1.name}\", \"{tbl_recipe1.mtime}\",\"{tbl_recipe1.pattern}\",\"{tbl_recipe1.settemp}\",\"{tbl_recipe1.sethumi}\",  \"{tbl_recipe1.method}\", \"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\",  \"{tbl_recipe1.calibid}\")");

                    cMysqlDto.OpenKeepUp();
                    cMysqlDto.RunSql("INSERT", dbsql);
                    MessageBox.Show("등록이 완료되었습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbsql = $"insert into tbl_loginout(logintime,mbid,exeloc) values(\"{salt}\",\"{cTbl_recipe.id}\",'new')";
                    cMysqlDto.RunSql("INSERT", dbsql);
                    SelectRecipeList();
                    name.Text = null;
                    id.Text = null;
                    settemp.Text = null;
                    sethumi.Text = null;
                    mtime.Text = null;
                    cLog.Info(cMwLog.RecipeNewRegisterEventLog);

                }
                catch (Exception)
                {
                    cLog.Error(cMwLog.RecipeRegisterError);
                }
                finally
                {
                    cMysqlDto.Close();
                }
            }

        }
        private bool InputDataCheck()
        {
            name.Text = Util.InputdataCheckHanEngNum("레시피명 입력", name.Text);
            bool isOk = string.IsNullOrEmpty(name.Text) == false;
            if (isOk == false) return isOk;

            id.Text = Util.InputdataCheckEngNum("사용자ID 입력", id.Text);
            isOk = string.IsNullOrEmpty(id.Text) == false;
            if (isOk == false) return isOk;

            mtime.Text = Util.InputdataCheckOnlyNum("측정시간 입력", mtime.Text);
            isOk = string.IsNullOrEmpty(mtime.Text) == false;
            if (isOk == false) return isOk;

            settemp.Text = Util.InputdataCheckOnlyNum("온도설정값 입력", settemp.Text);
            if (isOk == false) return isOk;

            sethumi.Text = Util.InputdataCheckOnlyNum("습도설정값 입력", sethumi.Text);
            isOk = string.IsNullOrEmpty(sethumi.Text) == false;
            if (isOk == false) return isOk;

            return isOk;
        }

        private void Reqsampleid_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        public string SelectReqSampleList(string reqsampleid)
        {
            string sql = $"select name from tbl_reqmember_sample, (select @num:=0) as s where id ='{reqsampleid}' order by name asc";
            Dictionary<string, string> row = cMysqlDto.SelectSql2(sql, "name")[0];
            if (row != null)
            {
                DBMS_V1.Data.MSC.Tbl_reqmember_sample cTbl_mb_sample = new DBMS_V1.Data.MSC.Tbl_reqmember_sample()
                {
                    name = row["name"],
                };

                return cTbl_mb_sample.name;
            }
            else { return null; }
        }

        private void BtnRecupeUpdate_Click(object sender, EventArgs e)
        {
            string strBtnName = "레시피 수정사항 변경 후 저장";
            try
            {
                if (MessageBox.Show("저장하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }



                int rowIndex = dgvRecipeDetail.CurrentRow.Index;

                cTbl_recipe.id = dgvRecipeDetail.Rows[rowIndex].Cells[2].Value == null ? "" : dgvRecipeDetail.Rows[rowIndex].Cells[2].Value.ToString();
                cTbl_recipe.pattern = dgvRecipeDetail.Rows[rowIndex].Cells[5].Value == null ? "" : dgvRecipeDetail.Rows[rowIndex].Cells[5].Value.ToString().Trim();
                cTbl_recipe.settemp = dgvRecipeDetail.Rows[rowIndex].Cells[6].Value == null ? "" : dgvRecipeDetail.Rows[rowIndex].Cells[6].Value.ToString().Trim();
                cTbl_recipe.sethumi = dgvRecipeDetail.Rows[rowIndex].Cells[7].Value == null ? "" : dgvRecipeDetail.Rows[rowIndex].Cells[7].Value.ToString().Trim();
                cTbl_recipe.calibid = dgvRecipeDetail.Rows[rowIndex].Cells[8].Value == null ? "" : dgvRecipeDetail.Rows[rowIndex].Cells[8].Value.ToString().Trim();
                cTbl_recipe.mtime = dgvRecipeDetail.Rows[rowIndex].Cells[9].Value == null ? "" : dgvRecipeDetail.Rows[rowIndex].Cells[9].Value.ToString().Trim();

                CheckReqItem();


                try
                {
                    cTbl_recipe.updatedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string dbsql = $@"UPDATE tbl_recipe 
                            SET 
                                    patternid='{cTbl_recipe.pattern}',
                                    settemp='{cTbl_recipe.settemp}',
                                    sethumi='{cTbl_recipe.sethumi}',
                                    calibid='{cTbl_recipe.calibid}',
                                    mtime='{cTbl_recipe.mtime}',
                                    updatedate = '{cTbl_recipe.updatedate}',
                                    reqmbid1='{cTbl_recipe.reqmbid1}',reqmbid2='{cTbl_recipe.reqmbid2}',reqmbid3='{cTbl_recipe.reqmbid3}',reqmbid4='{cTbl_recipe.reqmbid4}',reqmbid5='{cTbl_recipe.reqmbid5}',reqmbid6='{cTbl_recipe.reqmbid6}',reqmbid7='{cTbl_recipe.reqmbid7}',reqmbid8='{cTbl_recipe.reqmbid8}',reqmbid9='{cTbl_recipe.reqmbid9}',reqmbid10='{cTbl_recipe.reqmbid10}',reqmbid11='{cTbl_recipe.reqmbid11}',reqmbid12='{cTbl_recipe.reqmbid12}',
                                    reqmbname1='{cTbl_recipe.reqmbname1}',reqmbname2='{cTbl_recipe.reqmbname2}',reqmbname3='{cTbl_recipe.reqmbname3}',reqmbname4='{cTbl_recipe.reqmbname4}',reqmbname5='{cTbl_recipe.reqmbname5}',reqmbname6='{cTbl_recipe.reqmbname6}',reqmbname7='{cTbl_recipe.reqmbname7}',reqmbname8='{cTbl_recipe.reqmbname8}',reqmbname9='{cTbl_recipe.reqmbname9}',reqmbname10='{cTbl_recipe.reqmbname10}',reqmbname11='{cTbl_recipe.reqmbname11}',reqmbname12='{cTbl_recipe.reqmbname12}',
                                    reqsampleid1='{cTbl_recipe.reqsampleid1}',reqsampleid2='{cTbl_recipe.reqsampleid2}',reqsampleid3='{cTbl_recipe.reqsampleid3}',reqsampleid4='{cTbl_recipe.reqsampleid4}',reqsampleid5='{cTbl_recipe.reqsampleid5}',reqsampleid6='{cTbl_recipe.reqsampleid6}',reqsampleid7='{cTbl_recipe.reqsampleid7}',reqsampleid8='{cTbl_recipe.reqsampleid8}',reqsampleid9='{cTbl_recipe.reqsampleid9}',reqsampleid10='{cTbl_recipe.reqsampleid10}',reqsampleid11='{cTbl_recipe.reqsampleid11}',reqsampleid12='{cTbl_recipe.reqsampleid12}',
                                    reqsamplename1='{cTbl_recipe.reqsamplename1}',reqsamplename2='{cTbl_recipe.reqsamplename2}',reqsamplename3='{cTbl_recipe.reqsamplename3}',reqsamplename4='{cTbl_recipe.reqsamplename4}',reqsamplename5='{cTbl_recipe.reqsamplename5}',reqsamplename6='{cTbl_recipe.reqsamplename6}',reqsamplename7='{cTbl_recipe.reqsamplename7}',reqsamplename8='{cTbl_recipe.reqsamplename8}',reqsamplename9='{cTbl_recipe.reqsamplename9}',reqsamplename10='{cTbl_recipe.reqsamplename10}',reqsamplename11='{cTbl_recipe.reqsamplename11}',reqsamplename12='{cTbl_recipe.reqsamplename12}'
                                    WHERE id='{cTbl_recipe.id}'";

                    //System.Diagnostics.Debug.WriteLine(dbsql);

                    cMysqlDto.OpenKeepUp();
                    cMysqlDto.RunSql("UPDATE", dbsql);
                    MessageBox.Show("업데이트가 완료 되었습니다.", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cLog.Info(cMwLog.RecipeUpdateEventLog);

                    SelectRecipeList();

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    cLog.Error(cMwLog.RecipeUpdateError);
                    return;
                }
                finally
                {
                    cMysqlDto.Close();
                    SelectRecipeList();

                }
            }
            catch
            {
                MessageBox.Show("값이 선택되지 않았습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DgvRecipeDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void Pattern_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void DgvReqSetting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //rowno = dgvReqSetting.Rows[e.RowIndex].Index;
            //colno = dgvReqSetting.Columns[e.ColumnIndex].Index;
            if (e.RowIndex < 0) return;
            var dgv = sender as DataGridView;
            try
            {
                if (e.RowIndex >= 0 && (e.ColumnIndex == 1 || e.ColumnIndex == 3))
                {
                    dgv.BeginEdit(true);
                    ((System.Windows.Forms.ComboBox)dgv.EditingControl).DroppedDown = true;
                }
            }
            catch { }
        }

        private void DgvReqSetting_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        public string SelectCalibNameList(string id)
        {
            string sql = $"select name from tbl_plc_calibration, (select @num:=0) as s where id ='{id}' && out10=0 order by id asc";

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

        public string SelectPatternNameList(string com_ptno)
        {
            string sql = $"select name from tbl_hmi_pattern, (select @num:=0) as s where com_ptno ='{com_ptno}' && out10=0 order by com_ptno asc";

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

        private void CbxCalibID_SelectedItemChanged(object sender, EventArgs e)
        {
            if (cbxCalibID.SelectedItem == null)
            {
                tbxCalibName.Text = "";
                return;
            }
            string id = cbxCalibID.SelectedItem.ToString();
            tbxCalibName.Text = SelectCalibNameList(id);
        }

        private void Pattern_SelectedItemChanged_1(object sender, EventArgs e)
        {
            if (cboHmi_com_ptno.SelectedItem == null)
            {
                tbxPatternName.Text = "";
                return;
            }
            string com_ptno = cboHmi_com_ptno.SelectedItem.ToString();
            tbxPatternName.Text = SelectPatternNameList(com_ptno);
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
                case "레시피명":
                    sql = $"select count(*) as cnt from tbl_recipe ,(select @num:=0) as s where out10 = 0 && name like '%{tbSearch.Text}%' ";
                    break;
                case "전체":
                    sql = $"select count(*) as cnt from tbl_recipe ,(select @num:=0) as s where out10 = 0 && (name like '%{tbSearch.Text}%' or id like '%{tbSearch.Text}%')";
                    break;
            }

            try
            {


                int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(sql, "cnt")[0]["cnt"]);

                if (rowCnt == 0)
                {
                    MessageBox.Show("레시피 정보가 없습니다.", "레시피관리", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    case "레시피명":
                        sql = $"select (@num:=@num+1) as no, name,id,if(use10=1,'Y','N') as use10  from tbl_recipe , (select @num:=0) as s  where out10 = 0 && name like '%{tbSearch.Text}%' ";
                        break;
                    case "ID":
                        sql = $"select (@num:=@num+1) as no, name,id,if(use10=1,'Y','N') as use10  from tbl_recipe , (select @num:=0) as s  where out10 = 0 && id like '%{tbSearch.Text}%' ";
                        break;
                    case "전체":
                        sql = $"select (@num:=@num+1) as no,  name, id,if(use10=1,'Y','N') as use10 from tbl_recipe  , (select @num:=0) as s  where out10 = 0 && (name like '%{tbSearch.Text}%' or id like '%{tbSearch.Text}%')";
                        break;
                }

                DataTable dt = cMysqlDto.SelectSqlToDataTable(sql);
                dgvRecipeList.DataSource = dt;
                cLog.Info(cMwLog.RecipeSearchClickEventLog);
            }
            catch (Exception)
            {
                MessageBox.Show("레시피 검색 실패", "사용자관리", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cLog.Error(cMwLog.RecipeSearchLoadError);
            }
        }

        private void DgvRecipeDetail_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
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
        public void CheckReqItem()
        {
            string strTemp = dgvReqSetting.Rows[0].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname1 = "미지정";
                cTbl_recipe.reqmbid1 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname1 = reqSplit[0];
                cTbl_recipe.reqmbid1 = reqSplit[1];
            }

            strTemp = dgvReqSetting.Rows[1].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname2 = "미지정";
                cTbl_recipe.reqmbid2 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname2 = reqSplit[0];
                cTbl_recipe.reqmbid2 = reqSplit[1];
            }

            strTemp = dgvReqSetting.Rows[2].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname3 = "미지정";
                cTbl_recipe.reqmbid3 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname3 = reqSplit[0];
                cTbl_recipe.reqmbid3 = reqSplit[1];
            }

            strTemp = dgvReqSetting.Rows[3].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname4 = "미지정";
                cTbl_recipe.reqmbid4 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname4 = reqSplit[0];
                cTbl_recipe.reqmbid4 = reqSplit[1];
            }

            strTemp = dgvReqSetting.Rows[4].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname5 = "미지정";
                cTbl_recipe.reqmbid5 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname5 = reqSplit[0];
                cTbl_recipe.reqmbid5 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[5].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname6 = "미지정";
                cTbl_recipe.reqmbid6 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname6 = reqSplit[0];
                cTbl_recipe.reqmbid6 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[6].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname7 = "미지정";
                cTbl_recipe.reqmbid7 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname7 = reqSplit[0];
                cTbl_recipe.reqmbid7 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[7].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname8 = "미지정";
                cTbl_recipe.reqmbid8 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname8 = reqSplit[0];
                cTbl_recipe.reqmbid8 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[8].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname9 = "미지정";
                cTbl_recipe.reqmbid9 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname9 = reqSplit[0];
                cTbl_recipe.reqmbid9 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[9].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname10 = "미지정";
                cTbl_recipe.reqmbid10 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname10 = reqSplit[0];
                cTbl_recipe.reqmbid10 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[10].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname11 = "미지정";
                cTbl_recipe.reqmbid11 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname11 = reqSplit[0];
                cTbl_recipe.reqmbid11 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[11].Cells[2].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqmbname12 = "미지정";
                cTbl_recipe.reqmbid12 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqmbname12 = reqSplit[0];
                cTbl_recipe.reqmbid12 = reqSplit[1];
            }
            //---------------------------------------------------

            strTemp = dgvReqSetting.Rows[0].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename1 = "미지정";
                cTbl_recipe.reqsampleid1 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename1 = reqSplit[0];
                cTbl_recipe.reqsampleid1 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[1].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename2 = "미지정";
                cTbl_recipe.reqsampleid2 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename2 = reqSplit[0];
                cTbl_recipe.reqsampleid2 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[2].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename3 = "미지정";
                cTbl_recipe.reqsampleid3 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename3 = reqSplit[0];
                cTbl_recipe.reqsampleid3 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[3].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename4 = "미지정";
                cTbl_recipe.reqsampleid4 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename4 = reqSplit[0];
                cTbl_recipe.reqsampleid4 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[4].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename5 = "미지정";
                cTbl_recipe.reqsampleid5 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename5 = reqSplit[0];
                cTbl_recipe.reqsampleid5 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[5].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename6 = "미지정";
                cTbl_recipe.reqsampleid6 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename6 = reqSplit[0];
                cTbl_recipe.reqsampleid6 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[6].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename7 = "미지정";
                cTbl_recipe.reqsampleid7 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename7 = reqSplit[0];
                cTbl_recipe.reqsampleid7 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[7].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename8 = "미지정";
                cTbl_recipe.reqsampleid8 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename8 = reqSplit[0];
                cTbl_recipe.reqsampleid8 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[8].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename9 = "미지정";
                cTbl_recipe.reqsampleid9 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename9 = reqSplit[0];
                cTbl_recipe.reqsampleid9 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[9].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename10 = "미지정";
                cTbl_recipe.reqsampleid10 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename10 = reqSplit[0];
                cTbl_recipe.reqsampleid10 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[10].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename11 = "미지정";
                cTbl_recipe.reqsampleid11 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename11 = reqSplit[0];
                cTbl_recipe.reqsampleid11 = reqSplit[1];
            }
            strTemp = dgvReqSetting.Rows[11].Cells[3].Value.ToString().Trim();
            if (strTemp.Equals("미지정") || strTemp.Equals("|"))
            {
                cTbl_recipe.reqsamplename12 = "미지정";
                cTbl_recipe.reqsampleid12 = "not_set";
            }
            else
            {
                string reqmbnameid = strTemp;
                string[] reqSplit = reqmbnameid.Split('|');
                cTbl_recipe.reqsamplename12 = reqSplit[0];
                cTbl_recipe.reqsampleid12 = reqSplit[1];
            }

        }

        private void DgvRecipeDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1) return;
        }

        private void DgvRecipeDetail_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int iCalibId = 8;
            int iPtnNo = 5;

            if (dgvRecipeDetail.CurrentCell.ColumnIndex == iPtnNo && e.Control is ComboBox)
            {
                //ComboBox comboBox = e.Control as ComboBox;
                //comboBox.SelectedIndexChanged -= dgvRecipeDetail_SelectionChanged;
                //comboBox.SelectedIndexChanged -= LastColumnComboSelectionChanged;
                //comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }
            else if (dgvRecipeDetail.CurrentCell.ColumnIndex == iCalibId && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged -= DgvRecipeDetail_SelectionChanged;
                comboBox.SelectedIndexChanged -= LastColumnComboSelectionChanged;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }
        }

        private void DgvRecipeDetail_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            var currentcell = dgvRecipeDetail.CurrentCellAddress;

            int iCalibId = 8;
            int iPtnNo = 5;

            if (currentcell.X == iPtnNo)
            {

            }
            else if (currentcell.X == iCalibId)
            {
                var sendingCB = sender as DataGridViewComboBoxEditingControl;
                //DataGridViewTextBoxCell cel = (DataGridViewTextBoxCell)dgvRecipeDetail.Rows[currentcell.Y].Cells[0];
                //cel.Value = sendingCB.EditingControlFormattedValue.ToString();
                SelectReqChannel(calibid: sendingCB.EditingControlFormattedValue.ToString());
            }
        }
    }

}
