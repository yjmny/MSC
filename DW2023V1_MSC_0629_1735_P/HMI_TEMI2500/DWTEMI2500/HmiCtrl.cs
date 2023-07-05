using log4net;
using NetworkLib;
using System;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HMI_TEMI2500.Protocol;

namespace HMI_TEMI2500
{
    public partial class HmiCtrl : Form
    {

        // 디자인 영역====================================================================================================================
        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnTempSetValue1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnD100 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxD100 = new System.Windows.Forms.TextBox();
            this.btnReadPatternNo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGetD1725_D1733 = new System.Windows.Forms.Button();
            this.btnSendD1708 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxD1708 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxD1707 = new System.Windows.Forms.TextBox();
            this.btnSendD1707 = new System.Windows.Forms.Button();
            this.btnSendD1702 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxD1702 = new System.Windows.Forms.TextBox();
            this.btnSendD1701 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxD1701 = new System.Windows.Forms.TextBox();
            this.btnFixToProg = new System.Windows.Forms.Button();
            this.btnProgToFix = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 49);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "연결체크 - PING";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 418);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(960, 131);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnTempSetValue1
            // 
            this.btnTempSetValue1.Location = new System.Drawing.Point(6, 98);
            this.btnTempSetValue1.Name = "btnTempSetValue1";
            this.btnTempSetValue1.Size = new System.Drawing.Size(168, 33);
            this.btnTempSetValue1.TabIndex = 3;
            this.btnTempSetValue1.Text = "온도 설정값 R";
            this.btnTempSetValue1.UseVisualStyleBackColor = true;
            this.btnTempSetValue1.Click += new System.EventHandler(this.BtnTempSetValue1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "습도 설정값 R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "현재 온도 값 R";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "현재 습도 값 R";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 33);
            this.button4.TabIndex = 7;
            this.button4.Text = "온도 출력 값 R";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(354, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 33);
            this.button5.TabIndex = 8;
            this.button5.Text = "습도 출력 값 R";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(350, 319);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 33);
            this.button6.TabIndex = 11;
            this.button6.Text = "운전시간 초 R";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(176, 319);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 33);
            this.button7.TabIndex = 10;
            this.button7.Text = "운전시간 분 R";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(2, 319);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(168, 33);
            this.button8.TabIndex = 9;
            this.button8.Text = "운전시간 시 R";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(778, 98);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(168, 33);
            this.button9.TabIndex = 13;
            this.button9.Text = "운전중지 STOP W";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(604, 98);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(168, 33);
            this.button10.TabIndex = 12;
            this.button10.Text = "운전시작 RUN W";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(524, 319);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(168, 33);
            this.button11.TabIndex = 14;
            this.button11.Text = "운전시간 시분초 R";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(778, 144);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(168, 33);
            this.button12.TabIndex = 16;
            this.button12.Text = "온도 설정 W";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(778, 183);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(168, 33);
            this.button13.TabIndex = 15;
            this.button13.Text = "습도 설정값 W";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(610, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 21);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "50.0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(610, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 21);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "80.0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(6, 215);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(168, 33);
            this.button14.TabIndex = 19;
            this.button14.Text = "설정(온도,습도)값 R2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.Location = new System.Drawing.Point(180, 215);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(168, 33);
            this.button15.TabIndex = 20;
            this.button15.Text = "현재(온도,습도)값 R2";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.Location = new System.Drawing.Point(354, 215);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(168, 33);
            this.button16.TabIndex = 21;
            this.button16.Text = "현재,설정 (온도,습도)값 R4";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.Button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(354, 176);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(168, 33);
            this.button17.TabIndex = 24;
            this.button17.Text = "풍속 출력 값 R";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(180, 176);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(168, 33);
            this.button18.TabIndex = 23;
            this.button18.Text = "현재 풍속 값 R";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(6, 176);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(168, 33);
            this.button19.TabIndex = 22;
            this.button19.Text = "풍속 설정값 R";
            this.button19.UseVisualStyleBackColor = true;

            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.MistyRose;
            this.button20.Location = new System.Drawing.Point(354, 254);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(196, 33);
            this.button20.TabIndex = 27;
            this.button20.Text = "현재,설정 (온도,습도,풍속)값 R6";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.MistyRose;
            this.button21.Location = new System.Drawing.Point(180, 254);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(168, 33);
            this.button21.TabIndex = 26;
            this.button21.Text = "현재(온도,습도,풍속)값 R3";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.MistyRose;
            this.button22.Location = new System.Drawing.Point(6, 254);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(168, 33);
            this.button22.TabIndex = 25;
            this.button22.Text = "설정(온도,습도,풍속)값 R3";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 400);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTempSetValue1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.button20);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.button21);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button22);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button17);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button18);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button19);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button14);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기본 통신";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button24);
            this.tabPage2.Controls.Add(this.button23);
            this.tabPage2.Controls.Add(this.btnProgToFix);
            this.tabPage2.Controls.Add(this.btnFixToProg);
            this.tabPage2.Controls.Add(this.btnD100);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbxD100);
            this.tabPage2.Controls.Add(this.btnReadPatternNo);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnGetD1725_D1733);
            this.tabPage2.Controls.Add(this.btnSendD1708);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbxD1708);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbxD1707);
            this.tabPage2.Controls.Add(this.btnSendD1707);
            this.tabPage2.Controls.Add(this.btnSendD1702);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbxD1702);
            this.tabPage2.Controls.Add(this.btnSendD1701);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbxD1701);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "프로그램 패턴 읽기";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnD100
            // 
            this.btnD100.Location = new System.Drawing.Point(199, 204);
            this.btnD100.Name = "btnD100";
            this.btnD100.Size = new System.Drawing.Size(181, 23);
            this.btnD100.TabIndex = 36;
            this.btnD100.Text = "D100 운전할 패턴번호 설정";
            this.btnD100.UseVisualStyleBackColor = true;
            this.btnD100.Click += new System.EventHandler(this.BtnD100_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 35;
            this.label7.Text = "패턴 번호 지정";
            // 
            // tbxD100
            // 
            this.tbxD100.Location = new System.Drawing.Point(93, 206);
            this.tbxD100.Name = "tbxD100";
            this.tbxD100.Size = new System.Drawing.Size(100, 21);
            this.tbxD100.TabIndex = 34;
            this.tbxD100.Text = "1";
            this.tbxD100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReadPatternNo
            // 
            this.btnReadPatternNo.Location = new System.Drawing.Point(8, 175);
            this.btnReadPatternNo.Name = "btnReadPatternNo";
            this.btnReadPatternNo.Size = new System.Drawing.Size(335, 23);
            this.btnReadPatternNo.TabIndex = 33;
            this.btnReadPatternNo.Text = "패턴번호_세그먼트번호 연속 읽기";
            this.btnReadPatternNo.UseVisualStyleBackColor = true;
            this.btnReadPatternNo.Click += new System.EventHandler(this.BtnReadPatternNo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "세그먼트 시간 값이 (-1) 인 경우에는 End Signal";
            // 
            // btnGetD1725_D1733
            // 
            this.btnGetD1725_D1733.Location = new System.Drawing.Point(199, 122);
            this.btnGetD1725_D1733.Name = "btnGetD1725_D1733";
            this.btnGetD1725_D1733.Size = new System.Drawing.Size(144, 23);
            this.btnGetD1725_D1733.TabIndex = 31;
            this.btnGetD1725_D1733.Text = "D1725~D1733 연속 읽기";
            this.btnGetD1725_D1733.UseVisualStyleBackColor = true;
            this.btnGetD1725_D1733.Click += new System.EventHandler(this.BtnGetD1725_D1733_Click);
            // 
            // btnSendD1708
            // 
            this.btnSendD1708.Location = new System.Drawing.Point(199, 93);
            this.btnSendD1708.Name = "btnSendD1708";
            this.btnSendD1708.Size = new System.Drawing.Size(144, 23);
            this.btnSendD1708.TabIndex = 30;
            this.btnSendD1708.Text = "D1708 Done 체크";
            this.btnSendD1708.UseVisualStyleBackColor = true;
            this.btnSendD1708.Click += new System.EventHandler(this.BtnSendD1708_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(585, 26);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(361, 342);
            this.richTextBox2.TabIndex = 29;
            this.richTextBox2.Text = "\t1-1725\n\t2-1726\n\t3-1727\n\t4-1728\n\t5-1729\n\t6-1730\n\t7-1731\n\t8-1732\n\t9-1733";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "D1725~D1733 (9개) 온도, 습도 TSP 와 세그먼트 시간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "D1708 DONE";
            // 
            // tbxD1708
            // 
            this.tbxD1708.Location = new System.Drawing.Point(93, 95);
            this.tbxD1708.Name = "tbxD1708";
            this.tbxD1708.Size = new System.Drawing.Size(100, 21);
            this.tbxD1708.TabIndex = 10;
            this.tbxD1708.Text = "0->1";
            this.tbxD1708.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Read Trigger";
            // 
            // tbxD1707
            // 
            this.tbxD1707.Location = new System.Drawing.Point(93, 66);
            this.tbxD1707.Name = "tbxD1707";
            this.tbxD1707.Size = new System.Drawing.Size(100, 21);
            this.tbxD1707.TabIndex = 7;
            this.tbxD1707.Text = "2";
            this.tbxD1707.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSendD1707
            // 
            this.btnSendD1707.Location = new System.Drawing.Point(199, 64);
            this.btnSendD1707.Name = "btnSendD1707";
            this.btnSendD1707.Size = new System.Drawing.Size(144, 23);
            this.btnSendD1707.TabIndex = 6;
            this.btnSendD1707.Text = "D1707 설정 Send";
            this.btnSendD1707.UseVisualStyleBackColor = true;
            this.btnSendD1707.Click += new System.EventHandler(this.BtnSendD1707_Click);
            // 
            // btnSendD1702
            // 
            this.btnSendD1702.Location = new System.Drawing.Point(199, 35);
            this.btnSendD1702.Name = "btnSendD1702";
            this.btnSendD1702.Size = new System.Drawing.Size(144, 23);
            this.btnSendD1702.TabIndex = 5;
            this.btnSendD1702.Text = "D1702 설정 Send";
            this.btnSendD1702.UseVisualStyleBackColor = true;
            this.btnSendD1702.Click += new System.EventHandler(this.BtnSendD1702_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "세그먼트 번호";
            // 
            // tbxD1702
            // 
            this.tbxD1702.Location = new System.Drawing.Point(93, 37);
            this.tbxD1702.Name = "tbxD1702";
            this.tbxD1702.Size = new System.Drawing.Size(100, 21);
            this.tbxD1702.TabIndex = 3;
            this.tbxD1702.Text = "1";
            this.tbxD1702.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSendD1701
            // 
            this.btnSendD1701.Location = new System.Drawing.Point(199, 6);
            this.btnSendD1701.Name = "btnSendD1701";
            this.btnSendD1701.Size = new System.Drawing.Size(144, 23);
            this.btnSendD1701.TabIndex = 2;
            this.btnSendD1701.Text = "D1701 설정 Send";
            this.btnSendD1701.UseVisualStyleBackColor = true;
            this.btnSendD1701.Click += new System.EventHandler(this.BtnSendD1701_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "패턴 번호";
            // 
            // tbxD1701
            // 
            this.tbxD1701.Location = new System.Drawing.Point(93, 8);
            this.tbxD1701.Name = "tbxD1701";
            this.tbxD1701.Size = new System.Drawing.Size(100, 21);
            this.tbxD1701.TabIndex = 0;
            this.tbxD1701.Text = "1";
            this.tbxD1701.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFixToProg
            // 
            this.btnFixToProg.Location = new System.Drawing.Point(8, 233);
            this.btnFixToProg.Name = "btnFixToProg";
            this.btnFixToProg.Size = new System.Drawing.Size(372, 23);
            this.btnFixToProg.TabIndex = 39;
            this.btnFixToProg.Text = "D101-104 Fix->Prog(패턴)모드로 전환";
            this.btnFixToProg.UseVisualStyleBackColor = true;
            this.btnFixToProg.Click += new System.EventHandler(this.BtnFixToProg_Click);
            // 
            // btnProgToFix
            // 
            this.btnProgToFix.Location = new System.Drawing.Point(8, 262);
            this.btnProgToFix.Name = "btnProgToFix";
            this.btnProgToFix.Size = new System.Drawing.Size(372, 23);
            this.btnProgToFix.TabIndex = 40;
            this.btnProgToFix.Text = "D101-104 Prog(패턴)모드->Fix로 전환";
            this.btnProgToFix.UseVisualStyleBackColor = true;
            this.btnProgToFix.Click += new System.EventHandler(this.BtnProgToFix_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(386, 233);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(168, 23);
            this.button23.TabIndex = 41;
            this.button23.Text = "운전시작 RUN W";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.Button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(386, 262);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(168, 23);
            this.button24.TabIndex = 42;
            this.button24.Text = "운전중지 STOP W";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.Button24_Click);
            // 
            // HmiCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "HmiCtrl";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTempSetValue1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxD1708;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxD1707;
        private System.Windows.Forms.Button btnSendD1707;
        private System.Windows.Forms.Button btnSendD1702;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxD1702;
        private System.Windows.Forms.Button btnSendD1701;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxD1701;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetD1725_D1733;
        private System.Windows.Forms.Button btnSendD1708;
        private System.Windows.Forms.Button btnReadPatternNo;
        private System.Windows.Forms.Button btnD100;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxD100;
        private System.Windows.Forms.Button btnProgToFix;
        private System.Windows.Forms.Button btnFixToProg;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        //================================================================================================================================




        private static readonly ILog log = LogManager.GetLogger("Measure");
        public static HmiCtrl mIns;
        public HmiCtrl()
        {
            InitializeComponent();
            log.Info("=============  Started application  =============");

            log.Info("프로그램 시작 설정합니다.");
            richTextBox1.Text = "";
            DaqSetting();
            _temi2500 = new TEMI2500();
            _temi2500.RunLoopSettings();
        }

        public HmiCtrl(string refLib)
        {
            InitializeComponent();
            m_refLib = refLib;
            mIns = this;
            log.Info("=============" + this.Name + " Started application  =============");
            log.Info("프로그램 시작 설정합니다.");
            richTextBox1.Text = "";
            DaqSetting();
            _temi2500 = new TEMI2500();
            _temi2500.RunLoopSettings();
        }

        readonly string m_refLib;

        readonly TEMI2500 _temi2500;
        enum OP_MODE
        {
            PROG = 0,
            PATTERN = 0,
            FIX = 1
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(m_refLib))
            { return; }
        }

        private void DaqSetting()
        {
            TEMI2500.IP = "192.168.0.151";
            log.Info(TEMI2500.ModelName + "Comport 정보 로드 완료.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "연결";
            }
            else
            {
                checkBox1.Text = "연결해제";
            }
        }

        //private bool StringCheck(string strValue)
        //{
        //    return string.IsNullOrEmpty(strValue);
        //}

        private void BtnTempSetValue1_Click(object sender, EventArgs e)
        {
            GetD0002();
        }

        private void TcplPortSend(string sData)
        {
            byte[] bMadeData = _temi2500.MakeByteData(sData);
            Protocol.IsAcqureEnd = false;
            _temi2500.Write(bMadeData, 0, bMadeData.Length);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GetD0006();

        }
        public string GetD0001()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D1;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D1, 1);

            log.Info("현재 TEMP2500 현재 온도 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD1, 1);
            log.Info("현재 TEMP2500 현재 온도 값 요청 완료.");

            return Protocol.RecvD1.ToString();
        }
        public string GetD0002()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D2;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D2, 1);
            log.Info("현재 TEMP2500 설정온도 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD2, 1);
            log.Info("현재 TEMP2500 설정온도 값 요청 완료.");

            if (Protocol.RecvD2 != null)
                return Protocol.RecvD2.ToString();
            else
                return string.Empty;
        }
        public string GetD0005()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D5;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D5, 1);

            log.Info("현재 TEMP2500 현재 습도 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD5, 1);
            log.Info("현재 TEMP2500 현재 습도 값 요청 완료.");

            return Protocol.RecvD5.ToString();
        }
        public string GetD0006()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D6;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D6, 1);

            log.Info("현재 TEMP2500 설정 습도 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD6, 1);
            log.Info("현재 TEMP2500 설정 습도 값 요청 완료.");

            return Protocol.RecvD6.ToString();
        }
        private string GetD001_D0005()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RRD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D1D5;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D1, Protocol.D_REGISTER.D5, 2);

            log.Info("TEMP2500 현재 온도, 습도 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD1D5, 1);
            log.Info("TEMP2500 현재 온도, 습도 값 요청 완료.");

            if (Protocol.RecvD1D5 != null)
                return Protocol.RecvD1D5.ToString();
            else
                return string.Empty;
        }
        private string GetD0002_D0006()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RRD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D2D6;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D2, Protocol.D_REGISTER.D6, 2);

            log.Info("TEMP2500 설정 온도, 습도 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD2D6, 1);
            log.Info("TEMP2500 설정 온도, 습도 값 요청 완료.");

            return Protocol.RecvD2D6.ToString();
        }
        public string GetD1D2D5D6()
        {
            try
            {
                Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RRD;
                Protocol.SignalDregister = Protocol.D_REGISTER.D1D2D5D6;
                string[] strArray = new string[4];
                strArray[0] = Protocol.D_REGISTER.D1;
                strArray[1] = Protocol.D_REGISTER.D2;
                strArray[2] = Protocol.D_REGISTER.D5;
                strArray[3] = Protocol.D_REGISTER.D6;
                string sData = Protocol.ReadCommand(strArray, strArray.Length);

                log.Info("TEMP2500 설정-온도, 습도, 현재-온도,습도 값 요청 시작.");
                TcplPortSend(sData);

                if (string.IsNullOrEmpty(sData))
                {
                    log.Info("sData is Null");

                }
                else
                {
                    Task.Delay(500);
                    log.Info(Protocol.RecvD1D2D5D6);

                    if (Protocol.RecvD1D2D5D6 != null)
                    {
                        TextBoxUpdate(Protocol.RecvD1D2D5D6, 0);
                    }
                    else
                    {
                        log.Info("TEMP2500 설정-온도, 습도, 현재-온도,습도 값 요청 실패.");
                    }

                    log.Info("TEMP2500 설정-온도, 습도, 현재-온도,습도 값 요청 완료.");
                }

            }
            catch (Exception exc)
            {
                log.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }
            finally
            {

            }

            if (Protocol.RecvD1D2D5D6 != null)
                return Protocol.RecvD1D2D5D6.ToString();
            else
                return string.Empty;

        }

        public string GetD1D2D5D6D24D25D26()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RRD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D1D2D5D6D24D25D26;
            string[] strArray = new string[7];
            strArray[0] = Protocol.D_REGISTER.D1;
            strArray[1] = Protocol.D_REGISTER.D2;
            strArray[2] = Protocol.D_REGISTER.D5;
            strArray[3] = Protocol.D_REGISTER.D6;
            strArray[4] = Protocol.D_REGISTER.D24;
            strArray[5] = Protocol.D_REGISTER.D25;
            strArray[6] = Protocol.D_REGISTER.D26;
            string sData = Protocol.ReadCommand(strArray, strArray.Length);

            log.Info("TEMP2500 설정-온도, 습도, 현재-온도,습도, 시분초 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(200).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD1D2D5D6D24D25D26, 1);
            log.Info("TEMP2500 설정-온도, 습도, 현재-온도,습도, 시분초 값 요청 완료.");

            if (Protocol.RecvD1D2D5D6D24D25D26 != null)
                return Protocol.RecvD1D2D5D6D24D25D26.ToString();
            else
                return string.Empty;
        }
        public string GetD0007()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D7;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D7, 1);

            log.Info("현재 TEMP2500 온도 출력 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD7, 1);
            log.Info("현재 TEMP2500 온도 출력 값 요청 완료.");

            return Protocol.RecvD7.ToString();
        }
        public string GetD0008()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D8;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D7, 1);

            log.Info("현재 TEMP2500 습도 출력 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD8, 1);
            log.Info("현재 TEMP2500 습도 출력 값 요청 완료.");

            return Protocol.RecvD8.ToString();
        }

        public string GetD0010()
        {
            try
            {
                Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
                Protocol.SignalDregister = Protocol.D_REGISTER.D10;
                string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D10, 1);

                log.Info("현재 TEMP2500 운전 상태 값 요청 시작.");
                TcplPortSend(sData);

                TextBoxUpdate(sData, 1);
                Task.Delay(200).GetAwaiter().GetResult();
                TextBoxUpdate(Protocol.RecvD10, 1);
                log.Info("현재 TEMP2500 운전 상태 값 요청 완료.");
            }
            catch (Exception exc)
            {
                log.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }

            return Protocol.RecvD10.ToString();
        }
        public string GetD0024()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D24;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D24, 1);

            log.Info("현재 TEMP2500 운전시간 시 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD24, 1);
            log.Info("현재 TEMP2500 운전시간 시 값 요청 완료.");

            return Protocol.RecvD24.ToString();
        }
        public string GetD0025()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D25;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D25, 1);

            log.Info("현재 TEMP2500 운전시간 분 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD25, 1);
            log.Info("현재 TEMP2500 운전시간 분 값 요청 완료.");

            return Protocol.RecvD25.ToString();
        }
        public string GetD0026()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D26;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D26, 1);

            log.Info("현재 TEMP2500 운전시간 초 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD26, 1);
            log.Info("현재 TEMP2500 운전시간 초 값 요청 완료.");

            return Protocol.RecvD26.ToString();
        }
        public string GetD0024To0026()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D24D25D26;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D24, 3);

            log.Info("현재 TEMP2500 운전시간 시분초 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD24D25D26, 1);
            log.Info("현재 TEMP2500 운전시간 시분초 값 요청 완료.");

            return Protocol.RecvD24D25D26.ToString();
        }
        public string GetD0104()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D104;
            string sData = Protocol.ReadCommand(addr: Protocol.D_REGISTER.D10, count: 1);

            log.Info("현재 TEMP2500 OP.MODE 상태 값 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(200).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD104, 1);
            log.Info("현재 TEMP2500 OP.MODE 상태 값 요청 완료.");

            return Protocol.RecvD104.ToString();
        }
        private void TextBoxUpdate(object str, int iTextUpdate)
        {
            if (iTextUpdate == 1)
            {
                if (richTextBox1.InvokeRequired)
                {
                    richTextBox1.Invoke(new MethodInvoker(delegate ()
                    {
                        if (richTextBox1.Text.Length > 1000)
                        {
                            richTextBox1.Text = "";
                        }
                        if (str != null)
                        {
                            richTextBox1.Text += str.ToString() + "\r\n";
                            richTextBox1.Select(richTextBox1.Text.Length, 0);
                            richTextBox1.ScrollToCaret();

                        }
                    }));
                }
                else
                {
                    if (richTextBox1.Text.Length > 1000)
                    {
                        richTextBox1.Text = "";
                    }
                    if (str != null)
                    {
                        richTextBox1.Text += str.ToString() + "\r\n";
                        richTextBox1.Select(richTextBox1.Text.Length, 0);
                        richTextBox1.ScrollToCaret();

                    }

                }
            }
            else
            { }
        }

        private void TextBoxUpdate(RichTextBox tbx, object str)
        {
            if (tbx.Text.Length > 1000)
            {
                tbx.Text = "";
            }
            if (str != null)
            {
                tbx.Text += str.ToString() + "\r\n";
                tbx.Select(tbx.Text.Length, 0);
                tbx.ScrollToCaret();

            }
            tbx.Refresh();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            GetD0001();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            GetD0005();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            GetD0007();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            GetD0008();

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            GetD0024();

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            GetD0025();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            GetD0026();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            GetD0024To0026();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            SetD0101_1();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            SetD0101_4();

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            string val1 = textBox1.Text;
            SetD0102(val1);

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            string val2 = textBox2.Text;
            SetD0106(val2);
        }

        public bool IsOpen()
        {
            // Ping Check
            bool isOk = IsOpenPing(TEMI2500.IP);
            if (isOk)
            {
                //Port Ping Check
                isOk = IsOpenPortPing(TEMI2500.IP, TEMI2500.PORT_FIX);
                if (isOk) { }
                else
                {
                    isOk = false;
                }
            }
            else
            {
                isOk = false;
            }
            return isOk;
        }

        public bool IsOpen(string ipa, string port)
        {
            // Ping Check
            bool isOk = IsOpenPing(ipa);
            if (isOk)
            {
                //Port Ping Check
                isOk = IsOpenPortPing(ipa, port);
                if (isOk) { }
                else
                {
                    isOk = false;
                }
            }
            else
            {
                isOk = false;
            }
            return isOk;
        }
        public bool IsOpenPing(string strIpAddress)
        {
            NetworkDTO nwdto = new NetworkDTO();

            int iRtn = nwdto.SendToPing(strIpAddress);
            System.Diagnostics.Trace.WriteLine(iRtn);
            bool isRtn = iRtn == 1;
            return isRtn;
        }
        private bool IsOpenPortPing(string strIpAddress, string strPort)
        {
            NetworkDTO nwdto = new NetworkDTO();

            int iRtn = nwdto.SendToTcping(strIpAddress, strPort, 3000);
            System.Diagnostics.Trace.WriteLine(iRtn);
            bool isRtn = iRtn == 1;
            return isRtn;
        }

        public string SetD0101_1()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.WSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D101;
            string sData = Protocol.WriteCommand(Protocol.D_REGISTER.D101, 1, (int)Protocol.I32DecimalPoint.Zero, "1");

            log.Info("현재 TEMP2500 운전시작 RUN 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(200).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvDataOK, 1);
            log.Info("현재 TEMP2500 운전시작 RUN 요청 완료.");

            return GetD0010(); //10번지 읽기
        }



        public string SetD0101_4()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.WSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D101;
            string sData = Protocol.WriteCommand(Protocol.D_REGISTER.D101, 1, (int)Protocol.I32DecimalPoint.Zero, "4");

            log.Info("현재 TEMP2500 운전중지 STOP 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvDataOK, 1);
            log.Info("현재 TEMP2500 운전중지 STOP 요청 완료.");

            return GetD0010(); //10번지 읽기
        }

        public string SetD0102(string val1)
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.WSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D102;

            string strSetValue = val1;
            string sData = Protocol.WriteCommand(Protocol.D_REGISTER.D102, 1, (int)Protocol.I32DecimalPoint.F1, strSetValue);

            log.Info("현재 TEMP2500 온도설정 W 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvDataOK, 1);
            log.Info("현재 TEMP2500 온도설정 W 요청 완료.");

            return GetD0002();
        }

        /// <summary>
        /// D0104 ProgMode 설정(0), FixMode 설정(1)
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private string SetD0104(int iMode)
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.WSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D104;
            switch (iMode)
            {
                case 0:
                    log.Info("현재 TEMP2500 Fix->Pattern 모드  요청 시작.");
                    break;
                case 1:
                    log.Info("현재 TEMP2500 Pattern->Fix 모드 STOP 요청 시작.");
                    break;
            }
            string sData = Protocol.WriteCommand(Protocol.D_REGISTER.D104, 1, (int)Protocol.I32DecimalPoint.Zero, iMode.ToString());


            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvDataOK, 1);

            switch (iMode)
            {
                case 0:
                    log.Info("현재 TEMP2500 Fix->Pattern 모드  요청 완료.");
                    break;
                case 1:
                    log.Info("현재 TEMP2500 Pattern->Fix 모드 요청 완료.");
                    break;
            }

            return GetD0104(); //104번지 읽기
        }

        public string GetD0102()
        {
            return GetD0002();
        }

        public string SetD0106(string val2)
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.WSD;
            string strSetValue = val2;
            //string sData = "01WRD,01,0101,01F4";
            string sData = Protocol.WriteCommand(Protocol.D_REGISTER.D103, 1, (int)Protocol.I32DecimalPoint.F1, strSetValue);

            log.Info("현재 TEMP2500 습도설정 W 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvDataOK, 1);
            log.Info("현재 TEMP2500 습도설정 W 요청 완료.");

            return GetD0006();
        }

        public string GetD0106()
        {
            return GetD0006();
        }

        public string SetDmap(string addr, string val3, string deciPoint)
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.WSD;
            string strSetValue = val3;

            DialogResult dr1 = new DialogResult();
            int ideciPoint = Convert.ToInt32(deciPoint);
            switch (ideciPoint)
            {
                case 0:
                case 1:
                case 2:
                    break;
                default:
                    dr1 = MessageBox.Show("소수점 자릿수를 체크하세요.", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            if (dr1 == DialogResult.OK)
            {
                return "";
            }
            string sData = Protocol.WriteCommand(addr, 1, ideciPoint, strSetValue);

            log.Info("TEMP2500 " + addr + " " + val3 + " W 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvDataOK, 1);
            log.Info("TEMP2500 " + addr + "  " + val3 + " W 요청 완료.");

            return Protocol.RecvDataOK.ToString();
        }

        public string GetDmap(string addr, int count)
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = addr;// Protocol.D_REGISTER.D26;
            string sData = Protocol.ReadCommand(addr, count);

            log.Info("TEMP2500 " + addr + " " + count + " R 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();

            //select
            string strRtn = "";
            switch (addr)
            {
                case D_REGISTER.D1: strRtn = Protocol.RecvD1.ToString(); break;
                case D_REGISTER.D2: strRtn = Protocol.RecvD2.ToString(); break;
                case D_REGISTER.D5: strRtn = Protocol.RecvD5.ToString(); break;
                case D_REGISTER.D6: strRtn = Protocol.RecvD6.ToString(); break;
                case D_REGISTER.D7: strRtn = Protocol.RecvD7.ToString(); break;
                case D_REGISTER.D8: strRtn = Protocol.RecvD8.ToString(); break;
                case D_REGISTER.D24: strRtn = Protocol.RecvD24.ToString(); break;
                case D_REGISTER.D25: strRtn = Protocol.RecvD25.ToString(); break;
                case D_REGISTER.D26: strRtn = Protocol.RecvD26.ToString(); break;
                case D_REGISTER.D24D25D26: strRtn = Protocol.RecvD24.ToString(); break;
                case D_REGISTER.D101: strRtn = Protocol.RecvD10.ToString(); break;
                case D_REGISTER.D102: strRtn = Protocol.RecvD2.ToString(); break;
                case D_REGISTER.D103: strRtn = Protocol.RecvD6.ToString(); break;
            }
            TextBoxUpdate(strRtn, 1);
            log.Info("TEMP2500 " + addr + " " + count + " R 요청 완료.");

            return strRtn;
        }


        private void Button14_Click(object sender, EventArgs e)
        {

            GetD0002_D0006();
        }



        private void Button15_Click(object sender, EventArgs e)
        {
            GetD001_D0005();
        }



        private void Button16_Click(object sender, EventArgs e)
        {
            GetD1D2D5D6();
        }



        private void BtnSendD1701_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxD1701.Text)) return;
            SetD1701(iPatternNo: Convert.ToInt32(tbxD1701.Text));


            //  return GetD0010(); //10번지 읽기
        }

        private void BtnSendD1702_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxD1702.Text)) return;
            SetD1702(iSegNo: Convert.ToInt32(tbxD1702.Text));

        }

        private void BtnSendD1707_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxD1707.Text)) return;

            SetD1707(iTrigger: Convert.ToInt32(tbxD1707.Text));
        }

        private void BtnSendD1708_Click(object sender, EventArgs e)
        {
            tbxD1708.Text = GetD1708();
        }

        private void BtnGetD1725_D1733_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = GetD1725_TO_D1733();

        }



        private void BtnReadPatternNo_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            ReadPattenNo(1);

        }



        private void SetD1701(int iPatternNo)
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.WSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D1701;
            string value = iPatternNo.ToString();
            string sData = Protocol.WriteCommand(Protocol.D_REGISTER.D1701, 1, (int)Protocol.I32DecimalPoint.Zero, value);

            log.Info("프로그램 패턴 번호를 설정 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();

            TextBoxUpdate(Protocol.RecvDataOK, 1);
            log.Info("프로그램 패턴 번호를 설정 요청 완료.");
        }

        private void SetD1702(int iSegNo)
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.WSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D1702;

            string value = iSegNo.ToString();
            string sData = Protocol.WriteCommand(Protocol.D_REGISTER.D1702, 1, (int)Protocol.I32DecimalPoint.Zero, value);

            log.Info("세그먼트 번호를 설정 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();

            TextBoxUpdate(Protocol.RecvDataOK, 1);
            log.Info("세그먼트 번호를 설정 요청 완료.");
        }

        private void SetD1707(int iTrigger)
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.WSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D1707;

            //Read Trigger ('2')
            //Write Trigger ('3')
            //PT Copy Trigger ('4')
            //PT Del Trigger ('5')
            string value = iTrigger.ToString();
            string sData = Protocol.WriteCommand(Protocol.D_REGISTER.D1707, 1, (int)Protocol.I32DecimalPoint.Zero, value);

            log.Info("세그먼트 번호를 설정 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();

            TextBoxUpdate(Protocol.RecvDataOK, 1);
            log.Info("세그먼트 번호를 설정 요청 완료.");
        }

        private string GetD1708()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D1708;
            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D1708, 1);

            log.Info("DONE('1')  될 때까지 대기 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD1708, 1);
            log.Info("DONE('1')  될 때까지 대기 요청 완료.");

            if (Protocol.RecvD1708 == null)
            {
                return "";
            }
            else
            {
                return Protocol.RecvD1708.ToString();
            }
        }

        private string GetD1725_TO_D1733()
        {
            Protocol.I32RecvTypeCheck = (int)Protocol.I32RecvType.RSD;
            Protocol.SignalDregister = Protocol.D_REGISTER.D1725_TO_D1733;

            string sData = Protocol.ReadCommand(Protocol.D_REGISTER.D1725, 9);

            //log.Info("D1725~D1733에 기록된 온도, 습도 TSP와 세그먼트 시간을 읽음 요청 시작.");
            log.Info("세그먼트 설정 정보 읽기 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(100).GetAwaiter().GetResult();
            TextBoxUpdate(Protocol.RecvD1725_TO_D1733, 1);
            log.Info("세그먼트 설정 정보 읽기 요청  완료.");

            return Protocol.RecvD1725_TO_D1733.ToString();
        }

        private void BtnD100_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxD100.Text)) return;
            SetD100(iPatternNo: Convert.ToInt32(tbxD100.Text));
        }

        private void SetD100(int iPatternNo)
        {
            Protocol.SignalDregister = Protocol.D_REGISTER.D100;
            //F815 - modbus RTU
            //CrLf - AscII
            //D100에 운전번호 2로 설정
            bool isUseFunctionCode = false;
            string sData = "";
            if (isUseFunctionCode)
            {
                //----------------------06 기능코드 사용할지 여부
                //string sHeader = ":";
                //string sCommAddr = "01";
                //string sFunctionCode = "06";
                //string sD_regiHigh = "00";
                //string sD_regiLow = "63";
                //string sWriteData_high = "00";
                //string sWriteData_low = "02";
                //string sErrCode = "94";
                //string sTail = "\r\n";//CR+LF
            }
            else
            {
                string value = iPatternNo.ToString();
                sData = Protocol.WriteCommand(addr: Protocol.D_REGISTER.D100, count: 1, decimal_point: (int)Protocol.I32DecimalPoint.Zero, value);
            }

            log.Info("프로그램 운전할 패턴 번호를 설정 요청 시작.");
            TcplPortSend(sData);

            TextBoxUpdate(sData, 1);
            Task.Delay(1000).GetAwaiter().GetResult();

            TextBoxUpdate(Protocol.RecvDataOK, 1);
            log.Info("프로그램 운전할 패턴 번호를 설정 요청 완료.");
        }

        public ArrayList ReadPattenNo(int iPatternNo)
        {
            ArrayList list = new ArrayList();
            if (iPatternNo < 0) return null;
            SetD1701(iPatternNo: iPatternNo);

            try
            {
                for (int i = 1; i <= 99; i++)
                {
                    SetD1702(iSegNo: i);//1~99
                    SetD1707(iTrigger: 2);
                    string sGetData = GetD1708();//0~5
                    string sRtn = "";
                    int iValue = Convert.ToInt32(sGetData);
                    switch (iValue)
                    {
                        case 0: sRtn = "0-FULL : TEMI2500에 패턴 또는 세그먼트 수가 제한 초과"; break;
                        case 1: sRtn = "1-DONE: D1707(Trigger) 명령이 정상적으로 처리됨"; break;
                        case 2: sRtn = "PT EMPTY : 해당 패턴에 설정된 내용이 없음"; break;
                        case 3: sRtn = "SEG EMPTY : 해당 세그먼트에 설정된 내용이 없음"; break;
                        case 4: sRtn = "PT RUN : 해당 패턴이 현제 PROG RUN 상태"; break;
                        case 5: sRtn = "PARA ERROR : D1701~D1707의 설정오류"; break;
                    }
                    System.Diagnostics.Debug.WriteLine(sRtn);
                    if (iValue == 1)
                    {
                        string sDataRtn = GetD1725_TO_D1733();

                        TextBoxUpdate(richTextBox2, sDataRtn);
                        string[] sDataCheck = sDataRtn.Split(',');
                        if (sDataCheck.Length > 0)
                        {
                            if (sDataCheck[3].Equals("-1"))
                            {
                                break;
                            }
                            else
                                list.Add(i.ToString() + "," + sDataRtn);
                        }
                        else { break; }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception e) { System.Diagnostics.Debug.WriteLine(e.ToString()); }
            finally { }
            TextBoxUpdate("The End Patten & Segment Data", 1);
            return list;
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            SetD0101_1();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            SetD0101_4();
        }

        private void BtnFixToProg_Click(object sender, EventArgs e)
        {
            SetPatternMode();
        }

        private void BtnProgToFix_Click(object sender, EventArgs e)
        {
            SetFixMode();

        }
        public bool SetPatternMode()
        {
            try
            {
                SetD0101_4();
                SetD0104((int)OP_MODE.PATTERN);

            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool SetFixMode()
        {
            try
            {
                SetD0101_4();
                SetD0104((int)OP_MODE.FIX);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void SetHmiPatternNo(int iPtnNo)
        {
            SetD100(iPatternNo: iPtnNo);
        }
    }
}
