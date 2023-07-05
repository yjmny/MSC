namespace DoAnalysisMSC.Pages
{
    partial class TestResult_Simple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestResult_Simple));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.fgMeasureList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.btnSendCSV = new System.Windows.Forms.Button();
            this.dpenddate = new System.Windows.Forms.DateTimePicker();
            this.dpstartdate = new System.Windows.Forms.DateTimePicker();
            this.cbxPeriod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgMeasureList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.fgMeasureList);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel2.Controls.Add(this.btnSendCSV);
            this.splitContainer1.Panel2.Controls.Add(this.dpenddate);
            this.splitContainer1.Panel2.Controls.Add(this.dpstartdate);
            this.splitContainer1.Panel2.Controls.Add(this.cbxPeriod);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1640, 950);
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "측정이력조회(기본)";
            // 
            // fgMeasureList
            // 
            this.fgMeasureList.ColumnInfo = resources.GetString("fgMeasureList.ColumnInfo");
            this.fgMeasureList.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.fgMeasureList.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.fgMeasureList.ColumnPickerInfo.ShowToolButton = false;
            this.fgMeasureList.Location = new System.Drawing.Point(6, 100);
            this.fgMeasureList.Name = "fgMeasureList";
            this.fgMeasureList.Rows.DefaultSize = 40;
            this.fgMeasureList.Rows.Fixed = 2;
            this.fgMeasureList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgMeasureList.Size = new System.Drawing.Size(1631, 784);
            this.fgMeasureList.StyleInfo = resources.GetString("fgMeasureList.StyleInfo");
            this.fgMeasureList.TabIndex = 17;
            this.fgMeasureList.UseCompatibleTextRendering = false;
            this.fgMeasureList.Click += new System.EventHandler(this.fgMeasureList_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 41);
            this.label4.TabIndex = 16;
            this.label4.Text = "~";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(124)))), ((int)(((byte)(245)))));
            this.btnSearch.Image = global::DoAnalysisMSC.Properties.Resources.find;
            this.btnSearch.Location = new System.Drawing.Point(754, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 15;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSendCSV
            // 
            this.btnSendCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnSendCSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnSendCSV.FlatAppearance.BorderSize = 0;
            this.btnSendCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCSV.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCSV.Location = new System.Drawing.Point(1407, 34);
            this.btnSendCSV.Name = "btnSendCSV";
            this.btnSendCSV.Size = new System.Drawing.Size(230, 50);
            this.btnSendCSV.TabIndex = 13;
            this.btnSendCSV.Text = "CSV내보내기";
            this.btnSendCSV.UseVisualStyleBackColor = false;
            this.btnSendCSV.Click += new System.EventHandler(this.btnSendCSV_Click);
            // 
            // dpenddate
            // 
            this.dpenddate.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpenddate.Location = new System.Drawing.Point(536, 47);
            this.dpenddate.MinimumSize = new System.Drawing.Size(200, 31);
            this.dpenddate.Name = "dpenddate";
            this.dpenddate.Size = new System.Drawing.Size(200, 31);
            this.dpenddate.TabIndex = 4;
            // 
            // dpstartdate
            // 
            this.dpstartdate.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpstartdate.Location = new System.Drawing.Point(287, 47);
            this.dpstartdate.MinimumSize = new System.Drawing.Size(120, 31);
            this.dpstartdate.Name = "dpstartdate";
            this.dpstartdate.Size = new System.Drawing.Size(200, 31);
            this.dpstartdate.TabIndex = 3;
            // 
            // cbxPeriod
            // 
            this.cbxPeriod.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPeriod.FormattingEnabled = true;
            this.cbxPeriod.Items.AddRange(new object[] {
            "당일",
            "1일",
            "7일",
            "30일"});
            this.cbxPeriod.Location = new System.Drawing.Point(128, 47);
            this.cbxPeriod.MinimumSize = new System.Drawing.Size(100, 0);
            this.cbxPeriod.Name = "cbxPeriod";
            this.cbxPeriod.Size = new System.Drawing.Size(121, 31);
            this.cbxPeriod.TabIndex = 2;
            this.cbxPeriod.SelectedValueChanged += new System.EventHandler(this.cbxPeriod_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "기간선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "기간별 측정이력 기본 조회";
            // 
            // TestResult_Simple
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestResult_Simple";
            this.Text = "TestResult_Simple";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgMeasureList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpenddate;
        private System.Windows.Forms.DateTimePicker dpstartdate;
        private System.Windows.Forms.ComboBox cbxPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendCSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnSearch;
        private C1.Win.C1FlexGrid.C1FlexGrid fgMeasureList;
    }
}