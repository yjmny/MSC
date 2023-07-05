using PlcLSE_V1.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlcLSE_V1
{
    public partial class FrmPlcTest : Form
    {

        // 디자인 영역====================================================================================================================
        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxAddrNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxByteSet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxByteGet = new System.Windows.Forms.TextBox();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnSendGet = new System.Windows.Forms.Button();
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.btnSend3 = new System.Windows.Forms.Button();
            this.tbxWordSet1 = new System.Windows.Forms.TextBox();
            this.tbxWordGet1 = new System.Windows.Forms.TextBox();
            this.tbxDwordSet1 = new System.Windows.Forms.TextBox();
            this.tbxDword32Get = new System.Windows.Forms.TextBox();
            this.btnBitSet = new System.Windows.Forms.Button();
            this.tbxBitGet = new System.Windows.Forms.TextBox();
            this.tbxBitSet = new System.Windows.Forms.TextBox();
            this.btnBitGet = new System.Windows.Forms.Button();
            this.btnM100_M106 = new System.Windows.Forms.Button();
            this.tbxM0100_0106 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnM0_M1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button42 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.cboAddrMap = new PlcLSE_V1.Controls.dwComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.tbxPlcData01 = new System.Windows.Forms.TextBox();
            this.tbxPlcData00 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal01 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal00 = new System.Windows.Forms.TextBox();
            this.tbxPlcData9 = new System.Windows.Forms.TextBox();
            this.tbxPlcData8 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal9 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal8 = new System.Windows.Forms.TextBox();
            this.tbxPlcData7 = new System.Windows.Forms.TextBox();
            this.tbxPlcData6 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal7 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal6 = new System.Windows.Forms.TextBox();
            this.tbxPlcData5 = new System.Windows.Forms.TextBox();
            this.tbxPlcData4 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal5 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal4 = new System.Windows.Forms.TextBox();
            this.tbxPlcData3 = new System.Windows.Forms.TextBox();
            this.tbxPlcData2 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal3 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal2 = new System.Windows.Forms.TextBox();
            this.tbxPlcData1 = new System.Windows.Forms.TextBox();
            this.tbxPlcData0 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal1 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0 = new System.Windows.Forms.TextBox();
            this.button28 = new System.Windows.Forms.Button();
            this.textBoxAI1_12 = new System.Windows.Forms.TextBox();
            this.button27 = new System.Windows.Forms.Button();
            this.textBoxCh12 = new System.Windows.Forms.TextBox();
            this.button26 = new System.Windows.Forms.Button();
            this.textBoxCh11 = new System.Windows.Forms.TextBox();
            this.button25 = new System.Windows.Forms.Button();
            this.textBoxCh10 = new System.Windows.Forms.TextBox();
            this.button24 = new System.Windows.Forms.Button();
            this.textBoxCh9 = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.textBoxCh8 = new System.Windows.Forms.TextBox();
            this.button22 = new System.Windows.Forms.Button();
            this.textBoxCh7 = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.textBoxCh6 = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.textBoxCh5 = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.textBoxCh4 = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.textBoxCh3 = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.textBoxCh2 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCh1 = new System.Windows.Forms.TextBox();
            this.btnCh1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxAddrNo
            // 
            this.tbxAddrNo.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAddrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddrNo.Location = new System.Drawing.Point(227, 38);
            this.tbxAddrNo.Name = "tbxAddrNo";
            this.tbxAddrNo.Size = new System.Drawing.Size(100, 21);
            this.tbxAddrNo.TabIndex = 12;
            this.tbxAddrNo.Text = "0001";
            this.tbxAddrNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Map ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Addr No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Set Value";
            // 
            // tbxByteSet
            // 
            this.tbxByteSet.BackColor = System.Drawing.SystemColors.Info;
            this.tbxByteSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxByteSet.Location = new System.Drawing.Point(333, 38);
            this.tbxByteSet.Name = "tbxByteSet";
            this.tbxByteSet.Size = new System.Drawing.Size(100, 21);
            this.tbxByteSet.TabIndex = 15;
            this.tbxByteSet.Text = "1";
            this.tbxByteSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Get Value";
            // 
            // tbxByteGet
            // 
            this.tbxByteGet.BackColor = System.Drawing.Color.Silver;
            this.tbxByteGet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxByteGet.Location = new System.Drawing.Point(439, 38);
            this.tbxByteGet.Name = "tbxByteGet";
            this.tbxByteGet.Size = new System.Drawing.Size(100, 21);
            this.tbxByteGet.TabIndex = 17;
            this.tbxByteGet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSend1
            // 
            this.btnSend1.Location = new System.Drawing.Point(545, 35);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(114, 23);
            this.btnSend1.TabIndex = 19;
            this.btnSend1.Text = "Byte Set";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSendSet_Click);
            // 
            // btnSendGet
            // 
            this.btnSendGet.Location = new System.Drawing.Point(665, 64);
            this.btnSendGet.Name = "btnSendGet";
            this.btnSendGet.Size = new System.Drawing.Size(114, 23);
            this.btnSendGet.TabIndex = 21;
            this.btnSendGet.Text = "Word16 Get";
            this.btnSendGet.UseVisualStyleBackColor = true;
            this.btnSendGet.Click += new System.EventHandler(this.btnSendGet_Click);
            // 
            // btnConnect1
            // 
            this.btnConnect1.Location = new System.Drawing.Point(1440, 462);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(106, 23);
            this.btnConnect1.TabIndex = 22;
            this.btnConnect1.Text = "Connect Test";
            this.btnConnect1.UseVisualStyleBackColor = true;
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "DWORD32 Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(545, 64);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(114, 23);
            this.btnSend2.TabIndex = 27;
            this.btnSend2.Text = "WORD16 Set";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // btnSend3
            // 
            this.btnSend3.Location = new System.Drawing.Point(545, 93);
            this.btnSend3.Name = "btnSend3";
            this.btnSend3.Size = new System.Drawing.Size(114, 23);
            this.btnSend3.TabIndex = 33;
            this.btnSend3.Text = "DWORD32 Set";
            this.btnSend3.UseVisualStyleBackColor = true;
            this.btnSend3.Click += new System.EventHandler(this.btnSend3_Click);
            // 
            // tbxWordSet1
            // 
            this.tbxWordSet1.BackColor = System.Drawing.SystemColors.Info;
            this.tbxWordSet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxWordSet1.Location = new System.Drawing.Point(333, 67);
            this.tbxWordSet1.Name = "tbxWordSet1";
            this.tbxWordSet1.Size = new System.Drawing.Size(100, 21);
            this.tbxWordSet1.TabIndex = 25;
            this.tbxWordSet1.Text = "1";
            this.tbxWordSet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxWordGet1
            // 
            this.tbxWordGet1.BackColor = System.Drawing.Color.Silver;
            this.tbxWordGet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxWordGet1.Location = new System.Drawing.Point(439, 67);
            this.tbxWordGet1.Name = "tbxWordGet1";
            this.tbxWordGet1.Size = new System.Drawing.Size(100, 21);
            this.tbxWordGet1.TabIndex = 26;
            this.tbxWordGet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDwordSet1
            // 
            this.tbxDwordSet1.BackColor = System.Drawing.SystemColors.Info;
            this.tbxDwordSet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDwordSet1.Location = new System.Drawing.Point(333, 96);
            this.tbxDwordSet1.Name = "tbxDwordSet1";
            this.tbxDwordSet1.Size = new System.Drawing.Size(100, 21);
            this.tbxDwordSet1.TabIndex = 31;
            this.tbxDwordSet1.Text = "1";
            this.tbxDwordSet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDword32Get
            // 
            this.tbxDword32Get.BackColor = System.Drawing.Color.Silver;
            this.tbxDword32Get.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDword32Get.Location = new System.Drawing.Point(439, 96);
            this.tbxDword32Get.Name = "tbxDword32Get";
            this.tbxDword32Get.Size = new System.Drawing.Size(100, 21);
            this.tbxDword32Get.TabIndex = 32;
            this.tbxDword32Get.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBitSet
            // 
            this.btnBitSet.Location = new System.Drawing.Point(545, 122);
            this.btnBitSet.Name = "btnBitSet";
            this.btnBitSet.Size = new System.Drawing.Size(114, 23);
            this.btnBitSet.TabIndex = 36;
            this.btnBitSet.Text = "Bit Set";
            this.btnBitSet.UseVisualStyleBackColor = true;
            // 
            // tbxBitGet
            // 
            this.tbxBitGet.BackColor = System.Drawing.Color.Silver;
            this.tbxBitGet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBitGet.Location = new System.Drawing.Point(439, 125);
            this.tbxBitGet.Name = "tbxBitGet";
            this.tbxBitGet.Size = new System.Drawing.Size(100, 21);
            this.tbxBitGet.TabIndex = 35;
            this.tbxBitGet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxBitSet
            // 
            this.tbxBitSet.BackColor = System.Drawing.SystemColors.Info;
            this.tbxBitSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBitSet.Location = new System.Drawing.Point(333, 125);
            this.tbxBitSet.Name = "tbxBitSet";
            this.tbxBitSet.Size = new System.Drawing.Size(100, 21);
            this.tbxBitSet.TabIndex = 34;
            this.tbxBitSet.Text = "1";
            this.tbxBitSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBitGet
            // 
            this.btnBitGet.Location = new System.Drawing.Point(665, 122);
            this.btnBitGet.Name = "btnBitGet";
            this.btnBitGet.Size = new System.Drawing.Size(114, 23);
            this.btnBitGet.TabIndex = 37;
            this.btnBitGet.Text = "Bit Get";
            this.btnBitGet.UseVisualStyleBackColor = true;
            // 
            // btnM100_M106
            // 
            this.btnM100_M106.Location = new System.Drawing.Point(69, 200);
            this.btnM100_M106.Name = "btnM100_M106";
            this.btnM100_M106.Size = new System.Drawing.Size(145, 23);
            this.btnM100_M106.TabIndex = 38;
            this.btnM100_M106.Text = "Bit Read M100~M106";
            this.btnM100_M106.UseVisualStyleBackColor = true;
            this.btnM100_M106.Click += new System.EventHandler(this.btnBitReadM100_M106_Click);
            // 
            // tbxM0100_0106
            // 
            this.tbxM0100_0106.BackColor = System.Drawing.Color.Silver;
            this.tbxM0100_0106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxM0100_0106.Location = new System.Drawing.Point(220, 203);
            this.tbxM0100_0106.Name = "tbxM0100_0106";
            this.tbxM0100_0106.Size = new System.Drawing.Size(319, 21);
            this.tbxM0100_0106.TabIndex = 39;
            this.tbxM0100_0106.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(220, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 21);
            this.textBox2.TabIndex = 41;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnM0_M1
            // 
            this.btnM0_M1.Location = new System.Drawing.Point(69, 173);
            this.btnM0_M1.Name = "btnM0_M1";
            this.btnM0_M1.Size = new System.Drawing.Size(145, 23);
            this.btnM0_M1.TabIndex = 40;
            this.btnM0_M1.Text = "Bit Read M0~M01";
            this.btnM0_M1.UseVisualStyleBackColor = true;
            this.btnM0_M1.Click += new System.EventHandler(this.btnM0_M1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(220, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 21);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "Bit Read M0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(220, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(319, 21);
            this.textBox3.TabIndex = 43;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Bit Read M100";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "개별 읽기";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "연속 읽기";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 57;
            this.label5.Text = "연속 쓰기";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "개별 쓰기";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Silver;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(914, 253);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(319, 21);
            this.textBox4.TabIndex = 55;
            this.textBox4.Text = "2진수로 입력";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(634, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 54;
            this.button4.Text = "Bit Write M0";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Silver;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(914, 280);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(319, 21);
            this.textBox5.TabIndex = 53;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(634, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 23);
            this.button5.TabIndex = 52;
            this.button5.Text = "Bit Write M0";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(634, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 23);
            this.button6.TabIndex = 50;
            this.button6.Text = "Bit Write M0";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(634, 200);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 23);
            this.button7.TabIndex = 48;
            this.button7.Text = "Bit Wirte M1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Info;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(785, 279);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 61;
            this.textBox8.Text = "1111111111111111";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Info;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(785, 250);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 60;
            this.textBox9.Text = "0";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Info;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(785, 205);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 21);
            this.textBox10.TabIndex = 59;
            this.textBox10.Text = "1";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Info;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(785, 176);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 21);
            this.textBox11.TabIndex = 58;
            this.textBox11.Text = "0";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Info;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(785, 414);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 82;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Info;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(785, 369);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 21);
            this.textBox12.TabIndex = 81;
            this.textBox12.Text = "1";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Info;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(785, 340);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 21);
            this.textBox13.TabIndex = 80;
            this.textBox13.Text = "0";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 79;
            this.label9.Text = "연속 쓰기";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 78;
            this.label10.Text = "개별 쓰기";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(634, 414);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 23);
            this.button8.TabIndex = 76;
            this.button8.Text = "WORD16 Write M0";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(634, 337);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(145, 23);
            this.button10.TabIndex = 73;
            this.button10.Text = "WORD16 Write D1000";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(634, 364);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(145, 23);
            this.button11.TabIndex = 72;
            this.button11.Text = "DWORD32 Wirte D1000";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 71;
            this.label11.Text = "연속 읽기";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 70;
            this.label12.Text = "개별 읽기";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.Silver;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(220, 417);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(319, 21);
            this.textBox16.TabIndex = 69;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(69, 414);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(145, 23);
            this.button12.TabIndex = 68;
            this.button12.Text = "WORD16 Read D200";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.Silver;
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(220, 444);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(319, 21);
            this.textBox17.TabIndex = 67;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(69, 441);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(145, 23);
            this.button13.TabIndex = 66;
            this.button13.Text = "WORD16  Read D210";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.Silver;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(238, 340);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(301, 21);
            this.textBox18.TabIndex = 65;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(76, 337);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(156, 23);
            this.button14.TabIndex = 64;
            this.button14.Text = "WORD Read D200~202";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.Silver;
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(238, 367);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(301, 21);
            this.textBox19.TabIndex = 63;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(69, 364);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(163, 23);
            this.button15.TabIndex = 62;
            this.button15.Text = "DWORD Read D200,202";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.Silver;
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(914, 340);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(301, 21);
            this.textBox20.TabIndex = 84;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Silver;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(914, 367);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(301, 21);
            this.textBox6.TabIndex = 85;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1560, 517);
            this.tabControl1.TabIndex = 86;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button42);
            this.tabPage1.Controls.Add(this.button41);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.cboAddrMap);
            this.tabPage1.Controls.Add(this.textBox20);
            this.tabPage1.Controls.Add(this.tbxAddrNo);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBox12);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox13);
            this.tabPage1.Controls.Add(this.tbxByteSet);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tbxByteGet);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.btnSend1);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.btnSendGet);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.tbxWordSet1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.tbxWordGet1);
            this.tabPage1.Controls.Add(this.textBox16);
            this.tabPage1.Controls.Add(this.btnSend2);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox17);
            this.tabPage1.Controls.Add(this.tbxDwordSet1);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.tbxDword32Get);
            this.tabPage1.Controls.Add(this.textBox18);
            this.tabPage1.Controls.Add(this.btnSend3);
            this.tabPage1.Controls.Add(this.button14);
            this.tabPage1.Controls.Add(this.tbxBitSet);
            this.tabPage1.Controls.Add(this.textBox19);
            this.tabPage1.Controls.Add(this.tbxBitGet);
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.btnBitSet);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.btnBitGet);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.btnM100_M106);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.tbxM0100_0106);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.btnM0_M1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1552, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(785, 93);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(114, 23);
            this.button42.TabIndex = 87;
            this.button42.Text = "FLOAT32 Set";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(905, 93);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(114, 23);
            this.button41.TabIndex = 86;
            this.button41.Text = "FLOAT32 Get";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // cboAddrMap
            // 
            this.cboAddrMap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAddrMap.FormattingEnabled = true;
            this.cboAddrMap.Items.AddRange(new object[] {
            "M",
            "D"});
            this.cboAddrMap.Location = new System.Drawing.Point(100, 37);
            this.cboAddrMap.Name = "cboAddrMap";
            this.cboAddrMap.Size = new System.Drawing.Size(121, 22);
            this.cboAddrMap.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button32);
            this.tabPage2.Controls.Add(this.btnConnect1);
            this.tabPage2.Controls.Add(this.button33);
            this.tabPage2.Controls.Add(this.button34);
            this.tabPage2.Controls.Add(this.button35);
            this.tabPage2.Controls.Add(this.button36);
            this.tabPage2.Controls.Add(this.button37);
            this.tabPage2.Controls.Add(this.button38);
            this.tabPage2.Controls.Add(this.button39);
            this.tabPage2.Controls.Add(this.button40);
            this.tabPage2.Controls.Add(this.button29);
            this.tabPage2.Controls.Add(this.button30);
            this.tabPage2.Controls.Add(this.button31);
            this.tabPage2.Controls.Add(this.tbxPlcData01);
            this.tabPage2.Controls.Add(this.tbxPlcData00);
            this.tabPage2.Controls.Add(this.tbxPlcSignal01);
            this.tabPage2.Controls.Add(this.tbxPlcSignal00);
            this.tabPage2.Controls.Add(this.tbxPlcData9);
            this.tabPage2.Controls.Add(this.tbxPlcData8);
            this.tabPage2.Controls.Add(this.tbxPlcSignal9);
            this.tabPage2.Controls.Add(this.tbxPlcSignal8);
            this.tabPage2.Controls.Add(this.tbxPlcData7);
            this.tabPage2.Controls.Add(this.tbxPlcData6);
            this.tabPage2.Controls.Add(this.tbxPlcSignal7);
            this.tabPage2.Controls.Add(this.tbxPlcSignal6);
            this.tabPage2.Controls.Add(this.tbxPlcData5);
            this.tabPage2.Controls.Add(this.tbxPlcData4);
            this.tabPage2.Controls.Add(this.tbxPlcSignal5);
            this.tabPage2.Controls.Add(this.tbxPlcSignal4);
            this.tabPage2.Controls.Add(this.tbxPlcData3);
            this.tabPage2.Controls.Add(this.tbxPlcData2);
            this.tabPage2.Controls.Add(this.tbxPlcSignal3);
            this.tabPage2.Controls.Add(this.tbxPlcSignal2);
            this.tabPage2.Controls.Add(this.tbxPlcData1);
            this.tabPage2.Controls.Add(this.tbxPlcData0);
            this.tabPage2.Controls.Add(this.tbxPlcSignal1);
            this.tabPage2.Controls.Add(this.tbxPlcSignal0);
            this.tabPage2.Controls.Add(this.button28);
            this.tabPage2.Controls.Add(this.textBoxAI1_12);
            this.tabPage2.Controls.Add(this.button27);
            this.tabPage2.Controls.Add(this.textBoxCh12);
            this.tabPage2.Controls.Add(this.button26);
            this.tabPage2.Controls.Add(this.textBoxCh11);
            this.tabPage2.Controls.Add(this.button25);
            this.tabPage2.Controls.Add(this.textBoxCh10);
            this.tabPage2.Controls.Add(this.button24);
            this.tabPage2.Controls.Add(this.textBoxCh9);
            this.tabPage2.Controls.Add(this.button23);
            this.tabPage2.Controls.Add(this.textBoxCh8);
            this.tabPage2.Controls.Add(this.button22);
            this.tabPage2.Controls.Add(this.textBoxCh7);
            this.tabPage2.Controls.Add(this.button21);
            this.tabPage2.Controls.Add(this.textBoxCh6);
            this.tabPage2.Controls.Add(this.button20);
            this.tabPage2.Controls.Add(this.textBoxCh5);
            this.tabPage2.Controls.Add(this.button19);
            this.tabPage2.Controls.Add(this.textBoxCh4);
            this.tabPage2.Controls.Add(this.button18);
            this.tabPage2.Controls.Add(this.textBoxCh3);
            this.tabPage2.Controls.Add(this.button17);
            this.tabPage2.Controls.Add(this.textBoxCh2);
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.textBox14);
            this.tabPage2.Controls.Add(this.textBox15);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.textBoxCh1);
            this.tabPage2.Controls.Add(this.btnCh1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1552, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(1309, 400);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(215, 23);
            this.button32.TabIndex = 152;
            this.button32.Text = "Ch12 DWORD Write D1492~1498";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(1309, 373);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(215, 23);
            this.button33.TabIndex = 151;
            this.button33.Text = "Ch11 DWORD Write D1448~1454";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(1309, 346);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(215, 23);
            this.button34.TabIndex = 150;
            this.button34.Text = "Ch10 DWORD Write D1404~1410";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(1309, 319);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(215, 23);
            this.button35.TabIndex = 149;
            this.button35.Text = "Ch9 DWORD Write D1360~1366";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(1309, 292);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(215, 23);
            this.button36.TabIndex = 148;
            this.button36.Text = "Ch8 DWORD Write D1316~1322";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(1309, 265);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(215, 23);
            this.button37.TabIndex = 147;
            this.button37.Text = "Ch7 DWORD Write D1272~1278";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(1309, 238);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(215, 23);
            this.button38.TabIndex = 146;
            this.button38.Text = "Ch6 DWORD Write D1228~1234";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(1309, 211);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(215, 23);
            this.button39.TabIndex = 145;
            this.button39.Text = "Ch5 DWORD Write D1184~1190";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(1309, 184);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(215, 23);
            this.button40.TabIndex = 144;
            this.button40.Text = "Ch4 DWORD Write D1140~1146";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(1309, 78);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(215, 23);
            this.button29.TabIndex = 143;
            this.button29.Text = "Ch3 DWORD Write D1096~1134";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(1309, 51);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(215, 23);
            this.button30.TabIndex = 142;
            this.button30.Text = "Ch2 DWORD Write D1052~1090";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(1309, 22);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(215, 23);
            this.button31.TabIndex = 141;
            this.button31.Text = "Ch1 DWORD Write D1008~1046";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // tbxPlcData01
            // 
            this.tbxPlcData01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData01.Location = new System.Drawing.Point(1203, 184);
            this.tbxPlcData01.Name = "tbxPlcData01";
            this.tbxPlcData01.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData01.TabIndex = 140;
            this.tbxPlcData01.Text = "10";
            this.tbxPlcData01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData00
            // 
            this.tbxPlcData00.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData00.Location = new System.Drawing.Point(1097, 184);
            this.tbxPlcData00.Name = "tbxPlcData00";
            this.tbxPlcData00.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData00.TabIndex = 139;
            this.tbxPlcData00.Text = "0";
            this.tbxPlcData00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal01
            // 
            this.tbxPlcSignal01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal01.Location = new System.Drawing.Point(991, 184);
            this.tbxPlcSignal01.Name = "tbxPlcSignal01";
            this.tbxPlcSignal01.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal01.TabIndex = 138;
            this.tbxPlcSignal01.Text = "4000";
            this.tbxPlcSignal01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal00
            // 
            this.tbxPlcSignal00.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal00.Location = new System.Drawing.Point(885, 184);
            this.tbxPlcSignal00.Name = "tbxPlcSignal00";
            this.tbxPlcSignal00.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal00.TabIndex = 137;
            this.tbxPlcSignal00.Text = "0";
            this.tbxPlcSignal00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData9
            // 
            this.tbxPlcData9.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData9.Location = new System.Drawing.Point(1203, 130);
            this.tbxPlcData9.Name = "tbxPlcData9";
            this.tbxPlcData9.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData9.TabIndex = 136;
            this.tbxPlcData9.Text = "10";
            this.tbxPlcData9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData8
            // 
            this.tbxPlcData8.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData8.Location = new System.Drawing.Point(1097, 130);
            this.tbxPlcData8.Name = "tbxPlcData8";
            this.tbxPlcData8.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData8.TabIndex = 135;
            this.tbxPlcData8.Text = "8";
            this.tbxPlcData8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal9
            // 
            this.tbxPlcSignal9.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal9.Location = new System.Drawing.Point(991, 130);
            this.tbxPlcSignal9.Name = "tbxPlcSignal9";
            this.tbxPlcSignal9.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal9.TabIndex = 134;
            this.tbxPlcSignal9.Text = "4000";
            this.tbxPlcSignal9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal8
            // 
            this.tbxPlcSignal8.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal8.Location = new System.Drawing.Point(885, 130);
            this.tbxPlcSignal8.Name = "tbxPlcSignal8";
            this.tbxPlcSignal8.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal8.TabIndex = 133;
            this.tbxPlcSignal8.Text = "3201";
            this.tbxPlcSignal8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData7
            // 
            this.tbxPlcData7.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData7.Location = new System.Drawing.Point(1203, 103);
            this.tbxPlcData7.Name = "tbxPlcData7";
            this.tbxPlcData7.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData7.TabIndex = 132;
            this.tbxPlcData7.Text = "8";
            this.tbxPlcData7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData6
            // 
            this.tbxPlcData6.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData6.Location = new System.Drawing.Point(1097, 103);
            this.tbxPlcData6.Name = "tbxPlcData6";
            this.tbxPlcData6.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData6.TabIndex = 131;
            this.tbxPlcData6.Text = "6";
            this.tbxPlcData6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal7
            // 
            this.tbxPlcSignal7.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal7.Location = new System.Drawing.Point(991, 103);
            this.tbxPlcSignal7.Name = "tbxPlcSignal7";
            this.tbxPlcSignal7.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal7.TabIndex = 130;
            this.tbxPlcSignal7.Text = "3200";
            this.tbxPlcSignal7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal6
            // 
            this.tbxPlcSignal6.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal6.Location = new System.Drawing.Point(885, 103);
            this.tbxPlcSignal6.Name = "tbxPlcSignal6";
            this.tbxPlcSignal6.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal6.TabIndex = 129;
            this.tbxPlcSignal6.Text = "2401";
            this.tbxPlcSignal6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData5
            // 
            this.tbxPlcData5.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData5.Location = new System.Drawing.Point(1203, 77);
            this.tbxPlcData5.Name = "tbxPlcData5";
            this.tbxPlcData5.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData5.TabIndex = 128;
            this.tbxPlcData5.Text = "6";
            this.tbxPlcData5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData4
            // 
            this.tbxPlcData4.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData4.Location = new System.Drawing.Point(1097, 77);
            this.tbxPlcData4.Name = "tbxPlcData4";
            this.tbxPlcData4.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData4.TabIndex = 127;
            this.tbxPlcData4.Text = "4";
            this.tbxPlcData4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal5
            // 
            this.tbxPlcSignal5.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal5.Location = new System.Drawing.Point(991, 77);
            this.tbxPlcSignal5.Name = "tbxPlcSignal5";
            this.tbxPlcSignal5.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal5.TabIndex = 126;
            this.tbxPlcSignal5.Text = "2400";
            this.tbxPlcSignal5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal4
            // 
            this.tbxPlcSignal4.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal4.Location = new System.Drawing.Point(885, 77);
            this.tbxPlcSignal4.Name = "tbxPlcSignal4";
            this.tbxPlcSignal4.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal4.TabIndex = 125;
            this.tbxPlcSignal4.Text = "1601";
            this.tbxPlcSignal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData3
            // 
            this.tbxPlcData3.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData3.Location = new System.Drawing.Point(1203, 50);
            this.tbxPlcData3.Name = "tbxPlcData3";
            this.tbxPlcData3.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData3.TabIndex = 124;
            this.tbxPlcData3.Text = "4";
            this.tbxPlcData3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData2
            // 
            this.tbxPlcData2.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData2.Location = new System.Drawing.Point(1097, 50);
            this.tbxPlcData2.Name = "tbxPlcData2";
            this.tbxPlcData2.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData2.TabIndex = 123;
            this.tbxPlcData2.Text = "2";
            this.tbxPlcData2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal3
            // 
            this.tbxPlcSignal3.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal3.Location = new System.Drawing.Point(991, 50);
            this.tbxPlcSignal3.Name = "tbxPlcSignal3";
            this.tbxPlcSignal3.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal3.TabIndex = 122;
            this.tbxPlcSignal3.Text = "1600";
            this.tbxPlcSignal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal2
            // 
            this.tbxPlcSignal2.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal2.Location = new System.Drawing.Point(885, 50);
            this.tbxPlcSignal2.Name = "tbxPlcSignal2";
            this.tbxPlcSignal2.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal2.TabIndex = 121;
            this.tbxPlcSignal2.Text = "801";
            this.tbxPlcSignal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData1
            // 
            this.tbxPlcData1.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData1.Location = new System.Drawing.Point(1203, 23);
            this.tbxPlcData1.Name = "tbxPlcData1";
            this.tbxPlcData1.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData1.TabIndex = 120;
            this.tbxPlcData1.Text = "2";
            this.tbxPlcData1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData0
            // 
            this.tbxPlcData0.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0.Location = new System.Drawing.Point(1097, 23);
            this.tbxPlcData0.Name = "tbxPlcData0";
            this.tbxPlcData0.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0.TabIndex = 119;
            this.tbxPlcData0.Text = "0";
            this.tbxPlcData0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal1
            // 
            this.tbxPlcSignal1.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal1.Location = new System.Drawing.Point(991, 23);
            this.tbxPlcSignal1.Name = "tbxPlcSignal1";
            this.tbxPlcSignal1.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal1.TabIndex = 118;
            this.tbxPlcSignal1.Text = "800";
            this.tbxPlcSignal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0
            // 
            this.tbxPlcSignal0.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0.Location = new System.Drawing.Point(885, 23);
            this.tbxPlcSignal0.Name = "tbxPlcSignal0";
            this.tbxPlcSignal0.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0.TabIndex = 117;
            this.tbxPlcSignal0.Text = "0";
            this.tbxPlcSignal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(91, 394);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(215, 23);
            this.button28.TabIndex = 116;
            this.button28.Text = "Ch1~12, AI1~12  Run";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // textBoxAI1_12
            // 
            this.textBoxAI1_12.BackColor = System.Drawing.Color.Silver;
            this.textBoxAI1_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAI1_12.Location = new System.Drawing.Point(312, 346);
            this.textBoxAI1_12.Name = "textBoxAI1_12";
            this.textBoxAI1_12.Size = new System.Drawing.Size(493, 21);
            this.textBoxAI1_12.TabIndex = 115;
            this.textBoxAI1_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(91, 346);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(215, 23);
            this.button27.TabIndex = 114;
            this.button27.Text = "AI1~12 DWORD Read D700~722";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.btnAI1_12_Click);
            // 
            // textBoxCh12
            // 
            this.textBoxCh12.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh12.Location = new System.Drawing.Point(312, 319);
            this.textBoxCh12.Name = "textBoxCh12";
            this.textBoxCh12.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh12.TabIndex = 113;
            this.textBoxCh12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(91, 319);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(215, 23);
            this.button26.TabIndex = 112;
            this.button26.Text = "Ch12 DWORD Read D1488~1498";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.btnCh12_Click);
            // 
            // textBoxCh11
            // 
            this.textBoxCh11.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh11.Location = new System.Drawing.Point(312, 292);
            this.textBoxCh11.Name = "textBoxCh11";
            this.textBoxCh11.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh11.TabIndex = 111;
            this.textBoxCh11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(91, 292);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(215, 23);
            this.button25.TabIndex = 110;
            this.button25.Text = "Ch11 DWORD Read D1444~1454";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.btnCh11_Click);
            // 
            // textBoxCh10
            // 
            this.textBoxCh10.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh10.Location = new System.Drawing.Point(312, 265);
            this.textBoxCh10.Name = "textBoxCh10";
            this.textBoxCh10.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh10.TabIndex = 109;
            this.textBoxCh10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(91, 265);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(215, 23);
            this.button24.TabIndex = 108;
            this.button24.Text = "Ch10 DWORD Read D1400~1410";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.btnCh10_Click);
            // 
            // textBoxCh9
            // 
            this.textBoxCh9.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh9.Location = new System.Drawing.Point(312, 238);
            this.textBoxCh9.Name = "textBoxCh9";
            this.textBoxCh9.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh9.TabIndex = 107;
            this.textBoxCh9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(91, 238);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(215, 23);
            this.button23.TabIndex = 106;
            this.button23.Text = "Ch9 DWORD Read D1356~1366";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.btnCh9_Click);
            // 
            // textBoxCh8
            // 
            this.textBoxCh8.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh8.Location = new System.Drawing.Point(312, 211);
            this.textBoxCh8.Name = "textBoxCh8";
            this.textBoxCh8.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh8.TabIndex = 105;
            this.textBoxCh8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(91, 211);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(215, 23);
            this.button22.TabIndex = 104;
            this.button22.Text = "Ch8 DWORD Read D1312~1322";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.btnCh8_Click);
            // 
            // textBoxCh7
            // 
            this.textBoxCh7.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh7.Location = new System.Drawing.Point(312, 184);
            this.textBoxCh7.Name = "textBoxCh7";
            this.textBoxCh7.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh7.TabIndex = 103;
            this.textBoxCh7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(91, 184);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(215, 23);
            this.button21.TabIndex = 102;
            this.button21.Text = "Ch7 DWORD Read D1268~1278";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.btnCh7_Click);
            // 
            // textBoxCh6
            // 
            this.textBoxCh6.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh6.Location = new System.Drawing.Point(312, 157);
            this.textBoxCh6.Name = "textBoxCh6";
            this.textBoxCh6.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh6.TabIndex = 101;
            this.textBoxCh6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(91, 157);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(215, 23);
            this.button20.TabIndex = 100;
            this.button20.Text = "Ch6 DWORD Read D1224~1234";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.btnCh6_Click);
            // 
            // textBoxCh5
            // 
            this.textBoxCh5.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh5.Location = new System.Drawing.Point(312, 130);
            this.textBoxCh5.Name = "textBoxCh5";
            this.textBoxCh5.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh5.TabIndex = 99;
            this.textBoxCh5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(91, 130);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(215, 23);
            this.button19.TabIndex = 98;
            this.button19.Text = "Ch5 DWORD Read D1180~1190";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.btnCh5_Click);
            // 
            // textBoxCh4
            // 
            this.textBoxCh4.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh4.Location = new System.Drawing.Point(312, 103);
            this.textBoxCh4.Name = "textBoxCh4";
            this.textBoxCh4.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh4.TabIndex = 97;
            this.textBoxCh4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(91, 103);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(215, 23);
            this.button18.TabIndex = 96;
            this.button18.Text = "Ch4 DWORD Read D1136~1146";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.btnCh4_Click);
            // 
            // textBoxCh3
            // 
            this.textBoxCh3.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh3.Location = new System.Drawing.Point(312, 76);
            this.textBoxCh3.Name = "textBoxCh3";
            this.textBoxCh3.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh3.TabIndex = 95;
            this.textBoxCh3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(91, 76);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(215, 23);
            this.button17.TabIndex = 94;
            this.button17.Text = "Ch3 DWORD Read D1092~1134";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnCh3_Click);
            // 
            // textBoxCh2
            // 
            this.textBoxCh2.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh2.Location = new System.Drawing.Point(312, 49);
            this.textBoxCh2.Name = "textBoxCh2";
            this.textBoxCh2.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh2.TabIndex = 93;
            this.textBoxCh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(91, 49);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(215, 23);
            this.button16.TabIndex = 92;
            this.button16.Text = "Ch2 DWORD Read D1048~1090";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnCh2_Click);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.Silver;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(367, 445);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(301, 21);
            this.textBox14.TabIndex = 91;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Info;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(238, 445);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 21);
            this.textBox15.TabIndex = 90;
            this.textBox15.Text = "0";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 447);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 12);
            this.label13.TabIndex = 89;
            this.label13.Text = "개별 쓰기";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(87, 442);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(145, 23);
            this.button9.TabIndex = 88;
            this.button9.Text = "WORD16 Write D1000";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 12);
            this.label14.TabIndex = 87;
            this.label14.Text = "개별 읽기";
            // 
            // textBoxCh1
            // 
            this.textBoxCh1.BackColor = System.Drawing.Color.Silver;
            this.textBoxCh1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCh1.Location = new System.Drawing.Point(312, 22);
            this.textBoxCh1.Name = "textBoxCh1";
            this.textBoxCh1.Size = new System.Drawing.Size(493, 21);
            this.textBoxCh1.TabIndex = 86;
            this.textBoxCh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCh1
            // 
            this.btnCh1.Location = new System.Drawing.Point(91, 20);
            this.btnCh1.Name = "btnCh1";
            this.btnCh1.Size = new System.Drawing.Size(215, 23);
            this.btnCh1.TabIndex = 85;
            this.btnCh1.Text = "Ch1 DWORD Read D1004~1046";
            this.btnCh1.UseVisualStyleBackColor = true;
            this.btnCh1.Click += new System.EventHandler(this.btnCh1_Click);
            // 
            // frmPlcTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1584, 574);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPlcTest";
            this.Text = "Doowon PLC Controller";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.dwComboBox cboAddrMap;
        private System.Windows.Forms.TextBox tbxAddrNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxByteSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxByteGet;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnSendGet;
        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Button btnSend3;
        private System.Windows.Forms.TextBox tbxWordSet1;
        private System.Windows.Forms.TextBox tbxWordGet1;
        private System.Windows.Forms.TextBox tbxDwordSet1;
        private System.Windows.Forms.TextBox tbxDword32Get;
        private System.Windows.Forms.Button btnBitSet;
        private System.Windows.Forms.TextBox tbxBitGet;
        private System.Windows.Forms.TextBox tbxBitSet;
        private System.Windows.Forms.Button btnBitGet;
        private System.Windows.Forms.Button btnM100_M106;
        private System.Windows.Forms.TextBox tbxM0100_0106;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnM0_M1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCh1;
        private System.Windows.Forms.Button btnCh1;
        private System.Windows.Forms.TextBox textBoxCh2;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBoxCh3;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TextBox textBoxAI1_12;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.TextBox textBoxCh12;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.TextBox textBoxCh11;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.TextBox textBoxCh10;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox textBoxCh9;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TextBox textBoxCh8;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TextBox textBoxCh7;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.TextBox textBoxCh6;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox textBoxCh5;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox textBoxCh4;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.TextBox tbxPlcData01;
        private System.Windows.Forms.TextBox tbxPlcData00;
        private System.Windows.Forms.TextBox tbxPlcSignal01;
        private System.Windows.Forms.TextBox tbxPlcSignal00;
        private System.Windows.Forms.TextBox tbxPlcData9;
        private System.Windows.Forms.TextBox tbxPlcData8;
        private System.Windows.Forms.TextBox tbxPlcSignal9;
        private System.Windows.Forms.TextBox tbxPlcSignal8;
        private System.Windows.Forms.TextBox tbxPlcData7;
        private System.Windows.Forms.TextBox tbxPlcData6;
        private System.Windows.Forms.TextBox tbxPlcSignal7;
        private System.Windows.Forms.TextBox tbxPlcSignal6;
        private System.Windows.Forms.TextBox tbxPlcData5;
        private System.Windows.Forms.TextBox tbxPlcData4;
        private System.Windows.Forms.TextBox tbxPlcSignal5;
        private System.Windows.Forms.TextBox tbxPlcSignal4;
        private System.Windows.Forms.TextBox tbxPlcData3;
        private System.Windows.Forms.TextBox tbxPlcData2;
        private System.Windows.Forms.TextBox tbxPlcSignal3;
        private System.Windows.Forms.TextBox tbxPlcSignal2;
        private System.Windows.Forms.TextBox tbxPlcData1;
        private System.Windows.Forms.TextBox tbxPlcData0;
        private System.Windows.Forms.TextBox tbxPlcSignal1;
        private System.Windows.Forms.TextBox tbxPlcSignal0;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        //================================================================================================================================



        public static FrmPlcTest mIns;
        PlcComm plcComm1 = null;
        public FrmPlcTest()
        {
            InitializeComponent();
            mIns = this;
            plcComm1 = new PlcComm(ip: "192.168.0.153", port: 2004);

        }

        private void btnConnect1_Click(object sender, EventArgs e)
        {
            bool isConn = plcComm1.IsConnect() == 1 ? true : false;
            if (isConn)
                btnConnect1.BackColor = Color.Green;
            else
                btnConnect1.BackColor = Color.Red;
        }

        private void btnSendSet_Click(object sender, EventArgs e)
        {
            string mapId = cboAddrMap.Text;
            string mapAddrNo = tbxAddrNo.Text;
            string setValue = tbxByteSet.Text;
            if (string.IsNullOrEmpty(mapId)) { return; }
            if (string.IsNullOrEmpty(mapAddrNo)) { return; }
            if (string.IsNullOrEmpty(setValue)) { return; }

            plcComm1.WriteByte(mapId + mapAddrNo, setValue);

        }
        private void btnSend2_Click(object sender, EventArgs e)
        {
            string mapId = cboAddrMap.Text;
            string mapAddrNo = tbxAddrNo.Text;
            string setValue = tbxWordSet1.Text;
            if (string.IsNullOrEmpty(mapId)) { return; }
            if (string.IsNullOrEmpty(mapAddrNo)) { return; }
            if (string.IsNullOrEmpty(setValue)) { return; }

            plcComm1.WriteWord16bit(mapId + mapAddrNo, setValue);
            tbxWordGet1.Text = plcComm1.ReadWord16bit(mapId + mapAddrNo);
        }

        private void btnSend3_Click(object sender, EventArgs e)
        {
            string mapId = cboAddrMap.Text;
            string mapAddrNo = tbxAddrNo.Text;
            string setValue = tbxDwordSet1.Text;
            if (string.IsNullOrEmpty(mapId)) { return; }
            if (string.IsNullOrEmpty(mapAddrNo)) { return; }
            if (string.IsNullOrEmpty(setValue)) { return; }

            string sInt32_Float = "INT32";
            plcComm1.WriteDword32bit(mapId + mapAddrNo, setValue, sInt32_Float);
            tbxDword32Get.Text = plcComm1.ReadDword32bit(mapId + mapAddrNo, sInt32_Float);
        }


        private void btnSendGet_Click(object sender, EventArgs e)
        {
            string mapId = cboAddrMap.Text;
            string mapAddrNo = tbxAddrNo.Text;
            if (string.IsNullOrEmpty(mapId)) { return; }
            if (string.IsNullOrEmpty(mapAddrNo)) { return; }

            tbxWordGet1.Text = plcComm1.ReadWord16bit(mapId + mapAddrNo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mapId = cboAddrMap.Text;
            string mapAddrNo = tbxAddrNo.Text;//나눰1078->539
            if (string.IsNullOrEmpty(mapId)) { return; }
            if (string.IsNullOrEmpty(mapAddrNo)) { return; }
            Int32.TryParse(mapAddrNo, out int iAddr);
            iAddr = iAddr / 2;
            mapAddrNo = iAddr.ToString();
            tbxDword32Get.Text = plcComm1.ReadDword32bit(mapId + mapAddrNo, "INT32");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            string mapId = cboAddrMap.Text;
            string mapAddrNo = tbxAddrNo.Text;
            if (string.IsNullOrEmpty(mapId)) { return; }
            if (string.IsNullOrEmpty(mapAddrNo)) { return; }
            Int32.TryParse(mapAddrNo, out int iAddr);
            iAddr = iAddr / 2;
            mapAddrNo = iAddr.ToString();
            tbxDword32Get.Text = plcComm1.ReadDword32bit(mapId + mapAddrNo, "FLOAT");
        }

        //int iBitDataCount = 1;
        private void btnBitReadM100_M106_Click(object sender, EventArgs e)
        {
            string[] addrMapList = new string[] { "M0100", "M0101", "M0102", "M0103", "M0104", "M0105", "M0106" };
            string strRtn = plcComm1.ReadBitEachRun(addrMapList); //,로 분리
            tbxM0100_0106.Text = strRtn;
            return;
            //--------------------------------------------------------------------------------------------------------------
        }


        private void btnM0_M1_Click(object sender, EventArgs e)
        {
            string[] addrMapList = new string[] { "M0000", "M0001" };
            string strRtn = plcComm1.ReadBitEachRun(addrMapList); //,로 분리
            textBox2.Text = strRtn;
            return;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] addrMapList = new string[] { "M0000" };
            string strRtn = plcComm1.ReadBitStreamRun(addrMapList); //,로 분리
            textBox1.Text = strRtn;
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] addrMapList = new string[] { "M0100" };
            string strRtn = plcComm1.ReadBitStreamRun(addrMapList); //,로 분리
            textBox3.Text = strRtn;
            return;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox11.Text)) return;
            int setValue = Convert.ToInt32(textBox11.Text);

            string[] addrMapList = new string[] { "M0000" };
            string strRtn = plcComm1.WriteBitEachRun(addrMapList, setValue); //,로 분리
            btnM0_M1_Click(null, null);
            return;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox10.Text)) return;
            int setValue = Convert.ToInt32(textBox10.Text);

            string[] addrMapList = new string[] { "M0001" };
            string strRtn = plcComm1.WriteBitEachRun(addrMapList, setValue); //,로 분리
            btnM0_M1_Click(null, null);
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox9.Text)) return;
            long val = Convert.ToInt64(textBox9.Text);
            string setValue16 = String.Format("{0:D16}", val);

            string[] addrMapList = new string[] { "M0000" };
            string strRtn = plcComm1.WriteBitStreamRun(addrMapList, setValue16); //,로 분리
            return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox8.Text)) return;
            long val = Convert.ToInt64(textBox8.Text);
            string setValue16 = String.Format("{0:D16}", val);

            string[] addrMapList = new string[] { "M0000" };
            string strRtn = plcComm1.WriteBitStreamRun(addrMapList, setValue16); //,로 분리
            return;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] addrMapList = new string[] { "D0200", "D0201", "D0202" };
            string strRtn = plcComm1.ReadWordEachRun(addrMapList); //,로 분리
            textBox18.Text = strRtn;
            return;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int iMapNo1 = 200;
            iMapNo1 = XGT.AddressCalcDword2Word(iMapNo1);
            int iMapNo2 = 202;
            iMapNo2 = XGT.AddressCalcDword2Word(iMapNo2);
            string sAddr1 = "D" + String.Format("{0:D4}", iMapNo1);
            string sAddr2 = "D" + String.Format("{0:D4}", iMapNo2);

            string[] addrMapList = new string[] { sAddr1, sAddr2 };
            string[] strArry_int32_float = new string[] { "INT32", "INT32" };

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리

            textBox19.Text = strRtn;
            return;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] addrMapList = new string[] { "D0400" };
            string strRtn = plcComm1.ReadWordStreamRun(addrMapList); //,로 분리
            textBox16.Text = strRtn;
            return;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] addrMapList = new string[] { "D0200", "D0201" };
            string strRtn = plcComm1.ReadWordStreamRun(addrMapList); //,로 분리
            textBox17.Text = strRtn;
            return;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox13.Text)) return;
            int setValue = Convert.ToInt32(textBox13.Text);

            string[] addrMapList = new string[] { "D1000", "D1010" };
            string strRtn = plcComm1.WriteWordEachRun(addrMapList, setValue); //,로 분리
            strRtn = plcComm1.ReadWordEachRun(addrMapList); //,로 분리
            textBox20.Text = strRtn;
            return;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox12.Text)) return;
            float setValue = Convert.ToSingle(textBox12.Text);

            int iMapNo1 = 1000;
            iMapNo1 = XGT.AddressCalcDword2Word(iMapNo1);
            int iMapNo2 = 1100;
            iMapNo2 = XGT.AddressCalcDword2Word(iMapNo2);
            string sAddr1 = "D" + String.Format("{0:D4}", iMapNo1);
            string sAddr2 = "D" + String.Format("{0:D4}", iMapNo2);

            string[] addrMapList = new string[] { sAddr1, sAddr2 };
            string[] strArry_int32_float = new string[] { "FLOAT", "FLOAT" };
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setValue); //,로 분리

            //---------------------
            strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBox6.Text = strRtn;
            return;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text)) return;
            int setValue = Convert.ToInt32(textBox7.Text);
            int setValue2 = Convert.ToInt32(textBox7.Text);
            int iMapNo1 = 1000;
            iMapNo1 = XGT.AddressCalcByte2Word(iMapNo1);
            int iMapNo2 = 1001;
            iMapNo2 = XGT.AddressCalcByte2Word(iMapNo2);
            string sAddr1 = "D" + String.Format("{0:D4}", iMapNo1);
            string sAddr2 = "D" + String.Format("{0:D4}", iMapNo2);

            string[] addrMapList = new string[] { sAddr1, sAddr2 };
            string strRtn = plcComm1.WriteWordStreamRun(addrMapList, setValue, setValue2); //,로 분리
            textBox20.Text = strRtn;
            return;
        }

        private void btnCh1_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh1.Text = "";
            int iDataCountMax = 22;
            int iDataProcMax = 16;
            int startAddress = 1004;
            int nextIndex = 0;
            int addCount = 0;

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh1.Text = strRtn;

            addrMapList = null;
            addrMapList = new string[addCount];
            startAddress = nextIndex;
            strArry_int32_float = null;
            strArry_int32_float = new string[addCount];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                strArry_int32_float[idx] = "FLOAT";
            }

            strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh1.Text += strRtn;
            return;

        }

        private void btnCh2_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh2.Text = "";
            int iDataCountMax = 22;
            int iDataProcMax = 16;
            int startAddress = 1048;
            int nextIndex = 0;
            int addCount = 0;

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh2.Text = strRtn;

            addrMapList = null;
            addrMapList = new string[addCount];
            startAddress = nextIndex;
            strArry_int32_float = null;
            strArry_int32_float = new string[addCount];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                strArry_int32_float[idx] = "FLOAT";
            }

            strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh2.Text += strRtn;
            return;
        }

        private void btnCh3_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh3.Text = "";
            //int iDataCountMax = 22;
            int iDataProcMax = 16;
            int startAddress = 1092;
            int nextIndex = 0;
            int addCount = 0;

            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh3.Text = strRtn;

            addrMapList = null;
            addrMapList = new string[addCount];
            startAddress = nextIndex;
            strArry_int32_float = null;
            strArry_int32_float = new string[addCount];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                strArry_int32_float[idx] = "FLOAT";
            }

            strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh3.Text += strRtn;
            return;
        }

        private void btnCh4_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh4.Text = "";
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1136;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh4.Text = strRtn;

            return;
        }

        private void btnCh5_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh5.Text = "";
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1180;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh5.Text = strRtn;

            return;
        }
        private void btnCh6_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh6.Text = "";
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1224;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh6.Text = strRtn;

            return;
        }
        private void btnCh7_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh7.Text = "";
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1268;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh7.Text = strRtn;

            return;

        }

        private void btnCh8_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh8.Text = "";
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1312;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }

            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh8.Text = strRtn;

            return;

        }

        private void btnCh9_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh9.Text = "";
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1356;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }

            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh9.Text = strRtn;

            return;
        }

        private void btnCh10_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh10.Text = "";
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1400;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh10.Text = strRtn;

            return;
        }

        private void btnCh11_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh11.Text = "";
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1444;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh11.Text = strRtn;

            return;
        }

        private void btnCh12_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxCh12.Text = "";
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1488;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxCh12.Text = strRtn;

            return;

        }

        private void btnAI1_12_Click(object sender, EventArgs e)
        {
            //-------------------------
            //개별 읽기 DWORD
            textBoxAI1_12.Text = "";
            int iDataCountMax = 12;
            int iDataProcMax = 16;
            int startAddress = 700;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                strArry_int32_float[idx] = "FLOAT";
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            textBoxAI1_12.Text = strRtn;

            return;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            btnCh1_Click(null, null);
            btnCh2_Click(null, null);
            btnCh3_Click(null, null);
            btnCh4_Click(null, null);
            btnCh5_Click(null, null);
            btnCh6_Click(null, null);
            btnCh7_Click(null, null);
            btnCh8_Click(null, null);
            btnCh9_Click(null, null);
            btnCh10_Click(null, null);
            btnCh11_Click(null, null);
            btnCh12_Click(null, null);
            btnAI1_12_Click(null, null);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal1.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal2.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal3.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal4.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal5.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal6.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal7.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal8.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal9.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData1.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData2.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData3.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData4.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData5.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData6.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData7.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData8.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData9.Text)) return;

            int iDataCountMax = 20;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1008;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal1.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData1.Text);

            setDataValueList[4] = Convert.ToSingle(tbxPlcSignal2.Text);
            setDataValueList[5] = Convert.ToSingle(tbxPlcSignal3.Text);
            setDataValueList[6] = Convert.ToSingle(tbxPlcData2.Text);
            setDataValueList[7] = Convert.ToSingle(tbxPlcData3.Text);

            setDataValueList[8] = Convert.ToSingle(tbxPlcSignal4.Text);
            setDataValueList[9] = Convert.ToSingle(tbxPlcSignal5.Text);
            setDataValueList[10] = Convert.ToSingle(tbxPlcData4.Text);
            setDataValueList[11] = Convert.ToSingle(tbxPlcData5.Text);

            setDataValueList[12] = Convert.ToSingle(tbxPlcSignal6.Text);
            setDataValueList[13] = Convert.ToSingle(tbxPlcSignal7.Text);
            setDataValueList[14] = Convert.ToSingle(tbxPlcData6.Text);
            setDataValueList[15] = Convert.ToSingle(tbxPlcData7.Text);

            setDataValueList[16] = Convert.ToSingle(tbxPlcSignal8.Text);
            setDataValueList[17] = Convert.ToSingle(tbxPlcSignal9.Text);
            setDataValueList[18] = Convert.ToSingle(tbxPlcData8.Text);
            setDataValueList[19] = Convert.ToSingle(tbxPlcData9.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //------------------add
            addrMapList = null;
            addrMapList = new string[addCount];
            startAddress = nextIndex;
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            startIndex = iDataProcMax;
            endIndex = iDataCountMax;
            strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Ch1
            btnCh1_Click(null, null);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal1.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal2.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal3.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal4.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal5.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal6.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal7.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal8.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal9.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData1.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData2.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData3.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData4.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData5.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData6.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData7.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData8.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData9.Text)) return;

            int iDataCountMax = 20;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1052;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal1.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData1.Text);

            setDataValueList[4] = Convert.ToSingle(tbxPlcSignal2.Text);
            setDataValueList[5] = Convert.ToSingle(tbxPlcSignal3.Text);
            setDataValueList[6] = Convert.ToSingle(tbxPlcData2.Text);
            setDataValueList[7] = Convert.ToSingle(tbxPlcData3.Text);

            setDataValueList[8] = Convert.ToSingle(tbxPlcSignal4.Text);
            setDataValueList[9] = Convert.ToSingle(tbxPlcSignal5.Text);
            setDataValueList[10] = Convert.ToSingle(tbxPlcData4.Text);
            setDataValueList[11] = Convert.ToSingle(tbxPlcData5.Text);

            setDataValueList[12] = Convert.ToSingle(tbxPlcSignal6.Text);
            setDataValueList[13] = Convert.ToSingle(tbxPlcSignal7.Text);
            setDataValueList[14] = Convert.ToSingle(tbxPlcData6.Text);
            setDataValueList[15] = Convert.ToSingle(tbxPlcData7.Text);

            setDataValueList[16] = Convert.ToSingle(tbxPlcSignal8.Text);
            setDataValueList[17] = Convert.ToSingle(tbxPlcSignal9.Text);
            setDataValueList[18] = Convert.ToSingle(tbxPlcData8.Text);
            setDataValueList[19] = Convert.ToSingle(tbxPlcData9.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //------------------add
            addrMapList = null;
            addrMapList = new string[addCount];
            startAddress = nextIndex;
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            startIndex = iDataProcMax;
            endIndex = iDataCountMax;
            strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Ch2
            btnCh2_Click(null, null);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal1.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal2.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal3.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal4.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal5.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal6.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal7.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal8.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal9.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData1.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData2.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData3.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData4.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData5.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData6.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData7.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData8.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData9.Text)) return;

            int iDataCountMax = 20;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1096;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal1.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData1.Text);

            setDataValueList[4] = Convert.ToSingle(tbxPlcSignal2.Text);
            setDataValueList[5] = Convert.ToSingle(tbxPlcSignal3.Text);
            setDataValueList[6] = Convert.ToSingle(tbxPlcData2.Text);
            setDataValueList[7] = Convert.ToSingle(tbxPlcData3.Text);

            setDataValueList[8] = Convert.ToSingle(tbxPlcSignal4.Text);
            setDataValueList[9] = Convert.ToSingle(tbxPlcSignal5.Text);
            setDataValueList[10] = Convert.ToSingle(tbxPlcData4.Text);
            setDataValueList[11] = Convert.ToSingle(tbxPlcData5.Text);

            setDataValueList[12] = Convert.ToSingle(tbxPlcSignal6.Text);
            setDataValueList[13] = Convert.ToSingle(tbxPlcSignal7.Text);
            setDataValueList[14] = Convert.ToSingle(tbxPlcData6.Text);
            setDataValueList[15] = Convert.ToSingle(tbxPlcData7.Text);

            setDataValueList[16] = Convert.ToSingle(tbxPlcSignal8.Text);
            setDataValueList[17] = Convert.ToSingle(tbxPlcSignal9.Text);
            setDataValueList[18] = Convert.ToSingle(tbxPlcData8.Text);
            setDataValueList[19] = Convert.ToSingle(tbxPlcData9.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //------------------add
            addrMapList = null;
            addrMapList = new string[addCount];
            startAddress = nextIndex;
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            startIndex = iDataProcMax;
            endIndex = iDataCountMax;
            strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Ch3
            btnCh3_Click(null, null);

        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal01.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData01.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1140;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal00.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal01.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData00.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData01.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Channel
            btnCh4_Click(null, null);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal01.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData01.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1184;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal00.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal01.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData00.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData01.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Channel
            btnCh5_Click(null, null);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal01.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData01.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1228;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal00.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal01.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData00.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData01.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Channel
            btnCh6_Click(null, null);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal01.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData01.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1272;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal00.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal01.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData00.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData01.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Channel
            btnCh7_Click(null, null);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal01.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData01.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1316;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal00.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal01.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData00.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData01.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Channel
            btnCh8_Click(null, null);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal01.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData01.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1360;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal00.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal01.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData00.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData01.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Channel
            btnCh9_Click(null, null);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal01.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData01.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1404;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal00.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal01.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData00.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData01.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Channel
            btnCh10_Click(null, null);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal01.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData01.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1448;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal00.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal01.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData00.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData01.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Channel
            btnCh11_Click(null, null);

        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal01.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData00.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData01.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1492;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal00.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal01.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData00.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData01.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Channel
            btnCh12_Click(null, null);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            string mapId = cboAddrMap.Text;
            string mapAddrNo = tbxAddrNo.Text;
            string setValue = tbxDwordSet1.Text;
            if (string.IsNullOrEmpty(mapId)) { return; }
            if (string.IsNullOrEmpty(mapAddrNo)) { return; }
            if (string.IsNullOrEmpty(setValue)) { return; }

            string sInt32_Float = "FLOAT";
            plcComm1.WriteDword32bit(mapId + mapAddrNo, setValue, sInt32_Float);
            tbxDword32Get.Text = plcComm1.ReadDword32bit(mapId + mapAddrNo, sInt32_Float);
        }
    }
}
