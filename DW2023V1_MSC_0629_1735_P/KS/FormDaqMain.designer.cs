namespace DoOneDaqSystemKSx3267
{
    partial class FormDaqMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cboPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPortBaudRate = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timerSensorRecv1 = new System.Windows.Forms.Timer(this.components);
            this.btnSendNodeInfo1 = new System.Windows.Forms.Button();
            this.btnSendSensorList1 = new System.Windows.Forms.Button();
            this.btnSendSensorValue1 = new System.Windows.Forms.Button();
            this.btnSendCtrlValue1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnSendSensorValue_autoStart = new System.Windows.Forms.Button();
            this.btnSendSensorValue_autoStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendSensorValueLora_autoStop = new System.Windows.Forms.Button();
            this.cboPortNameLora = new System.Windows.Forms.ComboBox();
            this.btnSendSensorValueLora_autoStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.cboPortBaudRateLora = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenLora = new System.Windows.Forms.Button();
            this.btnSendSensorValue1Lora = new System.Windows.Forms.Button();
            this.btnCloseLora = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.timerSensorRecv1Lora = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort1_PinChanged);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cboPortName
            // 
            this.cboPortName.FormattingEnabled = true;
            this.cboPortName.Location = new System.Drawing.Point(69, 20);
            this.cboPortName.Name = "cboPortName";
            this.cboPortName.Size = new System.Drawing.Size(121, 20);
            this.cboPortName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baudrate";
            // 
            // cboPortBaudRate
            // 
            this.cboPortBaudRate.FormattingEnabled = true;
            this.cboPortBaudRate.Location = new System.Drawing.Point(69, 46);
            this.cboPortBaudRate.Name = "cboPortBaudRate";
            this.cboPortBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cboPortBaudRate.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(34, 72);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 46);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open Port";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(115, 72);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 46);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close Port";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerSensorRecv1
            // 
            this.timerSensorRecv1.Interval = 1000;
            this.timerSensorRecv1.Tick += new System.EventHandler(this.timerSensorRecv1_Tick);
            // 
            // btnSendNodeInfo1
            // 
            this.btnSendNodeInfo1.Location = new System.Drawing.Point(15, 173);
            this.btnSendNodeInfo1.Name = "btnSendNodeInfo1";
            this.btnSendNodeInfo1.Size = new System.Drawing.Size(94, 46);
            this.btnSendNodeInfo1.TabIndex = 6;
            this.btnSendNodeInfo1.Text = "노드 정보";
            this.btnSendNodeInfo1.UseVisualStyleBackColor = true;
            this.btnSendNodeInfo1.Click += new System.EventHandler(this.btnSendNodeInfo1_Click);
            // 
            // btnSendSensorList1
            // 
            this.btnSendSensorList1.Enabled = false;
            this.btnSendSensorList1.Location = new System.Drawing.Point(13, 225);
            this.btnSendSensorList1.Name = "btnSendSensorList1";
            this.btnSendSensorList1.Size = new System.Drawing.Size(96, 46);
            this.btnSendSensorList1.TabIndex = 7;
            this.btnSendSensorList1.Text = "센서 리스트";
            this.btnSendSensorList1.UseVisualStyleBackColor = true;
            this.btnSendSensorList1.Click += new System.EventHandler(this.btnSendSensorList1_Click);
            // 
            // btnSendSensorValue1
            // 
            this.btnSendSensorValue1.Location = new System.Drawing.Point(15, 277);
            this.btnSendSensorValue1.Name = "btnSendSensorValue1";
            this.btnSendSensorValue1.Size = new System.Drawing.Size(94, 46);
            this.btnSendSensorValue1.TabIndex = 8;
            this.btnSendSensorValue1.Text = "센서 값 확인";
            this.btnSendSensorValue1.UseVisualStyleBackColor = true;
            this.btnSendSensorValue1.Click += new System.EventHandler(this.btnSendSensorValue1_Click);
            // 
            // btnSendCtrlValue1
            // 
            this.btnSendCtrlValue1.Enabled = false;
            this.btnSendCtrlValue1.Location = new System.Drawing.Point(13, 329);
            this.btnSendCtrlValue1.Name = "btnSendCtrlValue1";
            this.btnSendCtrlValue1.Size = new System.Drawing.Size(96, 46);
            this.btnSendCtrlValue1.TabIndex = 9;
            this.btnSendCtrlValue1.Text = "제어값 조회";
            this.btnSendCtrlValue1.UseVisualStyleBackColor = true;
            this.btnSendCtrlValue1.Click += new System.EventHandler(this.btnSendCtrlValue1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(196, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(176, 292);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(378, 20);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(409, 292);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // btnSendSensorValue_autoStart
            // 
            this.btnSendSensorValue_autoStart.Location = new System.Drawing.Point(13, 399);
            this.btnSendSensorValue_autoStart.Name = "btnSendSensorValue_autoStart";
            this.btnSendSensorValue_autoStart.Size = new System.Drawing.Size(122, 46);
            this.btnSendSensorValue_autoStart.TabIndex = 12;
            this.btnSendSensorValue_autoStart.Text = "AUTO 센서 값 확인";
            this.btnSendSensorValue_autoStart.UseVisualStyleBackColor = true;
            this.btnSendSensorValue_autoStart.Click += new System.EventHandler(this.btnSendSensorValue_auto_Click);
            // 
            // btnSendSensorValue_autoStop
            // 
            this.btnSendSensorValue_autoStop.Location = new System.Drawing.Point(141, 399);
            this.btnSendSensorValue_autoStop.Name = "btnSendSensorValue_autoStop";
            this.btnSendSensorValue_autoStop.Size = new System.Drawing.Size(148, 46);
            this.btnSendSensorValue_autoStop.TabIndex = 13;
            this.btnSendSensorValue_autoStop.Text = "AUTO 센서 값 확인 중지";
            this.btnSendSensorValue_autoStop.UseVisualStyleBackColor = true;
            this.btnSendSensorValue_autoStop.Click += new System.EventHandler(this.btnSendSensorValue_autoStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.btnSendSensorValue_autoStop);
            this.groupBox1.Controls.Add(this.cboPortName);
            this.groupBox1.Controls.Add(this.btnSendSensorValue_autoStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.cboPortBaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSendCtrlValue1);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnSendSensorValue1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSendSensorList1);
            this.groupBox1.Controls.Add(this.btnSendNodeInfo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 453);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "유선 - KS3267";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendSensorValueLora_autoStop);
            this.groupBox2.Controls.Add(this.cboPortNameLora);
            this.groupBox2.Controls.Add(this.btnSendSensorValueLora_autoStart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.richTextBox4);
            this.groupBox2.Controls.Add(this.cboPortBaudRateLora);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnOpenLora);
            this.groupBox2.Controls.Add(this.btnSendSensorValue1Lora);
            this.groupBox2.Controls.Add(this.btnCloseLora);
            this.groupBox2.Location = new System.Drawing.Point(12, 471);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 453);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "무선 - KS3267 (LoRa)";
            // 
            // btnSendSensorValueLora_autoStop
            // 
            this.btnSendSensorValueLora_autoStop.Location = new System.Drawing.Point(141, 399);
            this.btnSendSensorValueLora_autoStop.Name = "btnSendSensorValueLora_autoStop";
            this.btnSendSensorValueLora_autoStop.Size = new System.Drawing.Size(148, 46);
            this.btnSendSensorValueLora_autoStop.TabIndex = 13;
            this.btnSendSensorValueLora_autoStop.Text = "AUTO 센서 값 확인 중지";
            this.btnSendSensorValueLora_autoStop.UseVisualStyleBackColor = true;
            this.btnSendSensorValueLora_autoStop.Visible = false;
            this.btnSendSensorValueLora_autoStop.Click += new System.EventHandler(this.btnSendSensorValueLora_autoStop_Click);
            // 
            // cboPortNameLora
            // 
            this.cboPortNameLora.FormattingEnabled = true;
            this.cboPortNameLora.Location = new System.Drawing.Point(69, 20);
            this.cboPortNameLora.Name = "cboPortNameLora";
            this.cboPortNameLora.Size = new System.Drawing.Size(121, 20);
            this.cboPortNameLora.TabIndex = 0;
            // 
            // btnSendSensorValueLora_autoStart
            // 
            this.btnSendSensorValueLora_autoStart.Location = new System.Drawing.Point(13, 399);
            this.btnSendSensorValueLora_autoStart.Name = "btnSendSensorValueLora_autoStart";
            this.btnSendSensorValueLora_autoStart.Size = new System.Drawing.Size(122, 46);
            this.btnSendSensorValueLora_autoStart.TabIndex = 12;
            this.btnSendSensorValueLora_autoStart.Text = "AUTO 센서 값 확인";
            this.btnSendSensorValueLora_autoStart.UseVisualStyleBackColor = true;
            this.btnSendSensorValueLora_autoStart.Visible = false;
            this.btnSendSensorValueLora_autoStart.Click += new System.EventHandler(this.btnSendSensorValueLora_autoStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Device";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(196, 20);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(591, 373);
            this.richTextBox4.TabIndex = 11;
            this.richTextBox4.Text = "";
            // 
            // cboPortBaudRateLora
            // 
            this.cboPortBaudRateLora.FormattingEnabled = true;
            this.cboPortBaudRateLora.Location = new System.Drawing.Point(69, 46);
            this.cboPortBaudRateLora.Name = "cboPortBaudRateLora";
            this.cboPortBaudRateLora.Size = new System.Drawing.Size(121, 20);
            this.cboPortBaudRateLora.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Baudrate";
            // 
            // btnOpenLora
            // 
            this.btnOpenLora.Location = new System.Drawing.Point(34, 72);
            this.btnOpenLora.Name = "btnOpenLora";
            this.btnOpenLora.Size = new System.Drawing.Size(75, 46);
            this.btnOpenLora.TabIndex = 4;
            this.btnOpenLora.Text = "Open Port";
            this.btnOpenLora.UseVisualStyleBackColor = true;
            this.btnOpenLora.Click += new System.EventHandler(this.btnOpenLora_Click);
            // 
            // btnSendSensorValue1Lora
            // 
            this.btnSendSensorValue1Lora.Location = new System.Drawing.Point(15, 266);
            this.btnSendSensorValue1Lora.Name = "btnSendSensorValue1Lora";
            this.btnSendSensorValue1Lora.Size = new System.Drawing.Size(94, 46);
            this.btnSendSensorValue1Lora.TabIndex = 8;
            this.btnSendSensorValue1Lora.Text = "센서 값 확인";
            this.btnSendSensorValue1Lora.UseVisualStyleBackColor = true;
            this.btnSendSensorValue1Lora.Visible = false;
            this.btnSendSensorValue1Lora.Click += new System.EventHandler(this.btnSendSensorValue1Lora_Click);
            // 
            // btnCloseLora
            // 
            this.btnCloseLora.Location = new System.Drawing.Point(115, 72);
            this.btnCloseLora.Name = "btnCloseLora";
            this.btnCloseLora.Size = new System.Drawing.Size(75, 46);
            this.btnCloseLora.TabIndex = 5;
            this.btnCloseLora.Text = "Close Port";
            this.btnCloseLora.UseVisualStyleBackColor = true;
            this.btnCloseLora.Click += new System.EventHandler(this.btnCloseLora_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM6";
            this.serialPort2.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort2_ErrorReceived);
            this.serialPort2.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort2_PinChanged);
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // timerSensorRecv1Lora
            // 
            this.timerSensorRecv1Lora.Interval = 1000;
            this.timerSensorRecv1Lora.Tick += new System.EventHandler(this.timerSensorRecv1Lora_Tick);
            // 
            // FormDaqMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 961);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDaqMain";
            this.Text = "DoOne Daq System V1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cboPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPortBaudRate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timerSensorRecv1;
        private System.Windows.Forms.Button btnSendNodeInfo1;
        private System.Windows.Forms.Button btnSendSensorList1;
        private System.Windows.Forms.Button btnSendSensorValue1;
        private System.Windows.Forms.Button btnSendCtrlValue1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnSendSensorValue_autoStart;
        private System.Windows.Forms.Button btnSendSensorValue_autoStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendSensorValueLora_autoStop;
        private System.Windows.Forms.ComboBox cboPortNameLora;
        private System.Windows.Forms.Button btnSendSensorValueLora_autoStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.ComboBox cboPortBaudRateLora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenLora;
        private System.Windows.Forms.Button btnSendSensorValue1Lora;
        private System.Windows.Forms.Button btnCloseLora;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Timer timerSensorRecv1Lora;
    }
}

