namespace DoMeasureMSC
{
    partial class Form3
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
            this.ucTextBox2 = new DoOneControl.ucTextBox();
            this.ucTextBox1 = new DoOneControl.ucTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucTextBox2
            // 
            this.ucTextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucTextBox2.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTextBox2.Location = new System.Drawing.Point(50, 107);
            this.ucTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.ucTextBox2.Name = "ucTextBox2";
            this.ucTextBox2.Size = new System.Drawing.Size(454, 44);
            this.ucTextBox2.TabIndex = 1;
            this.ucTextBox2.Load += new System.EventHandler(this.ucTextBox2_Load);
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTextBox1.Location = new System.Drawing.Point(50, 29);
            this.ucTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.Size = new System.Drawing.Size(454, 44);
            this.ucTextBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(89, 191);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 221);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Noto Sans, 12pt 일때, Height : 44\n굴림 9pt 일때, Height 22";
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox1.Items.Add("Canada");
            this.c1ComboBox1.Items.Add("Finland");
            this.c1ComboBox1.Items.Add("France");
            this.c1ComboBox1.Items.Add("Great Britain");
            this.c1ComboBox1.Items.Add("India");
            this.c1ComboBox1.Items.Add("Ireland");
            this.c1ComboBox1.Items.Add("Japan");
            this.c1ComboBox1.Items.Add("Spain");
            this.c1ComboBox1.Items.Add("USA");
            this.c1ComboBox1.Location = new System.Drawing.Point(572, 215);
            this.c1ComboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(133, 19);
            this.c1ComboBox1.TabIndex = 3;
            this.c1ComboBox1.Tag = null;
            this.c1ComboBox1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.c1ComboBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c1ComboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ucTextBox2);
            this.Controls.Add(this.ucTextBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DoOneControl.ucTextBox ucTextBox1;
        private DoOneControl.ucTextBox ucTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
    }
}