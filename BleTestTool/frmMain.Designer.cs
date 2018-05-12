namespace BleTestTool
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbConfigCom = new System.Windows.Forms.GroupBox();
            this.btnSerialPortSwitch = new System.Windows.Forms.Button();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSerialWrite = new System.Windows.Forms.GroupBox();
            this.toolBleWrite = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelBle = new System.Windows.Forms.ToolStripLabel();
            this.toolBtnBleInit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorBle1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnBleFind = new System.Windows.Forms.ToolStripButton();
            this.toolComboBle = new System.Windows.Forms.ToolStripComboBox();
            this.toolBtnBleLink = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorBle2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnBleResite = new System.Windows.Forms.ToolStripButton();
            this.toolCmdWrite = new System.Windows.Forms.ToolStrip();
            this.toolBtnAuto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnHot = new System.Windows.Forms.ToolStripButton();
            this.toolBtnMotor = new System.Windows.Forms.ToolStripButton();
            this.toolBtnCool = new System.Windows.Forms.ToolStripButton();
            this.toolBtnPn1 = new System.Windows.Forms.ToolStripButton();
            this.toolBtnPn2 = new System.Windows.Forms.ToolStripButton();
            this.toolBtnL = new System.Windows.Forms.ToolStripButton();
            this.toolBtnRh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnStop = new System.Windows.Forms.ToolStripButton();
            this.rioString = new System.Windows.Forms.RadioButton();
            this.rioHex = new System.Windows.Forms.RadioButton();
            this.btnSerialWrite = new System.Windows.Forms.Button();
            this.txtSerialWrite = new System.Windows.Forms.TextBox();
            this.gbSerialLog = new System.Windows.Forms.GroupBox();
            this.chkLogHex = new System.Windows.Forms.CheckBox();
            this.chkShowError = new System.Windows.Forms.CheckBox();
            this.chkShowTime = new System.Windows.Forms.CheckBox();
            this.chkShowWrite = new System.Windows.Forms.CheckBox();
            this.btnLogClear = new System.Windows.Forms.Button();
            this.txtDataReceived = new System.Windows.Forms.TextBox();
            this.labBleStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSerialReceived = new System.Windows.Forms.TabPage();
            this.listViewSerialReceived = new System.Windows.Forms.ListView();
            this.tabBleTest = new System.Windows.Forms.TabPage();
            this.labTestStatus = new System.Windows.Forms.Label();
            this.listViewBleTest = new System.Windows.Forms.ListView();
            this.imageListStatus = new System.Windows.Forms.ImageList(this.components);
            this.gbConfigCom.SuspendLayout();
            this.gbSerialWrite.SuspendLayout();
            this.toolBleWrite.SuspendLayout();
            this.toolCmdWrite.SuspendLayout();
            this.gbSerialLog.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSerialReceived.SuspendLayout();
            this.tabBleTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConfigCom
            // 
            this.gbConfigCom.Controls.Add(this.btnSerialPortSwitch);
            this.gbConfigCom.Controls.Add(this.cbParity);
            this.gbConfigCom.Controls.Add(this.cbStop);
            this.gbConfigCom.Controls.Add(this.cbBaudRate);
            this.gbConfigCom.Controls.Add(this.cbDataBits);
            this.gbConfigCom.Controls.Add(this.cbSerial);
            this.gbConfigCom.Controls.Add(this.label5);
            this.gbConfigCom.Controls.Add(this.label4);
            this.gbConfigCom.Controls.Add(this.label3);
            this.gbConfigCom.Controls.Add(this.label2);
            this.gbConfigCom.Controls.Add(this.label6);
            this.gbConfigCom.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.gbConfigCom.Location = new System.Drawing.Point(11, 11);
            this.gbConfigCom.Margin = new System.Windows.Forms.Padding(2);
            this.gbConfigCom.Name = "gbConfigCom";
            this.gbConfigCom.Padding = new System.Windows.Forms.Padding(2);
            this.gbConfigCom.Size = new System.Drawing.Size(148, 268);
            this.gbConfigCom.TabIndex = 5;
            this.gbConfigCom.TabStop = false;
            this.gbConfigCom.Text = "蓝牙配置";
            // 
            // btnSerialPortSwitch
            // 
            this.btnSerialPortSwitch.Location = new System.Drawing.Point(8, 213);
            this.btnSerialPortSwitch.Name = "btnSerialPortSwitch";
            this.btnSerialPortSwitch.Size = new System.Drawing.Size(131, 39);
            this.btnSerialPortSwitch.TabIndex = 10;
            this.btnSerialPortSwitch.Text = "打开串口";
            this.btnSerialPortSwitch.UseVisualStyleBackColor = true;
            this.btnSerialPortSwitch.Click += new System.EventHandler(this.btnSerialPortSwitch_Click);
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParity.Location = new System.Drawing.Point(68, 174);
            this.cbParity.Margin = new System.Windows.Forms.Padding(2);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(71, 25);
            this.cbParity.TabIndex = 9;
            // 
            // cbStop
            // 
            this.cbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStop.Location = new System.Drawing.Point(68, 138);
            this.cbStop.Margin = new System.Windows.Forms.Padding(2);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(71, 25);
            this.cbStop.TabIndex = 8;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "115200",
            "128000"});
            this.cbBaudRate.Location = new System.Drawing.Point(68, 66);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(71, 25);
            this.cbBaudRate.TabIndex = 7;
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(68, 102);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(71, 25);
            this.cbDataBits.TabIndex = 6;
            // 
            // cbSerial
            // 
            this.cbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerial.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(68, 30);
            this.cbSerial.Margin = new System.Windows.Forms.Padding(2);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(71, 25);
            this.cbSerial.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "检验位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "停止位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "端口号：";
            // 
            // gbSerialWrite
            // 
            this.gbSerialWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSerialWrite.Controls.Add(this.toolBleWrite);
            this.gbSerialWrite.Controls.Add(this.toolCmdWrite);
            this.gbSerialWrite.Controls.Add(this.rioString);
            this.gbSerialWrite.Controls.Add(this.rioHex);
            this.gbSerialWrite.Controls.Add(this.btnSerialWrite);
            this.gbSerialWrite.Controls.Add(this.txtSerialWrite);
            this.gbSerialWrite.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.gbSerialWrite.Location = new System.Drawing.Point(171, 12);
            this.gbSerialWrite.Name = "gbSerialWrite";
            this.gbSerialWrite.Size = new System.Drawing.Size(490, 121);
            this.gbSerialWrite.TabIndex = 10;
            this.gbSerialWrite.TabStop = false;
            this.gbSerialWrite.Text = "发送数据";
            // 
            // toolBleWrite
            // 
            this.toolBleWrite.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBleWrite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelBle,
            this.toolBtnBleInit,
            this.toolStripSeparatorBle1,
            this.toolBtnBleFind,
            this.toolComboBle,
            this.toolBtnBleLink,
            this.toolStripSeparatorBle2,
            this.toolBtnBleResite});
            this.toolBleWrite.Location = new System.Drawing.Point(3, 23);
            this.toolBleWrite.Name = "toolBleWrite";
            this.toolBleWrite.Size = new System.Drawing.Size(484, 25);
            this.toolBleWrite.TabIndex = 9;
            this.toolBleWrite.Text = "toolStrip1";
            this.toolBleWrite.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolBleWrite_ItemClicked);
            // 
            // toolStripLabelBle
            // 
            this.toolStripLabelBle.Name = "toolStripLabelBle";
            this.toolStripLabelBle.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabelBle.Text = "蓝牙操作：";
            // 
            // toolBtnBleInit
            // 
            this.toolBtnBleInit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnBleInit.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnBleInit.Image")));
            this.toolBtnBleInit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnBleInit.Name = "toolBtnBleInit";
            this.toolBtnBleInit.Size = new System.Drawing.Size(60, 22);
            this.toolBtnBleInit.Tag = "0";
            this.toolBtnBleInit.Text = "初始命令";
            // 
            // toolStripSeparatorBle1
            // 
            this.toolStripSeparatorBle1.Name = "toolStripSeparatorBle1";
            this.toolStripSeparatorBle1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnBleFind
            // 
            this.toolBtnBleFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnBleFind.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnBleFind.Image")));
            this.toolBtnBleFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnBleFind.Name = "toolBtnBleFind";
            this.toolBtnBleFind.Size = new System.Drawing.Size(60, 22);
            this.toolBtnBleFind.Tag = "1";
            this.toolBtnBleFind.Text = "搜索蓝牙";
            // 
            // toolComboBle
            // 
            this.toolComboBle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolComboBle.Name = "toolComboBle";
            this.toolComboBle.Size = new System.Drawing.Size(230, 25);
            // 
            // toolBtnBleLink
            // 
            this.toolBtnBleLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnBleLink.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnBleLink.Image")));
            this.toolBtnBleLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnBleLink.Name = "toolBtnBleLink";
            this.toolBtnBleLink.Size = new System.Drawing.Size(36, 22);
            this.toolBtnBleLink.Tag = "2";
            this.toolBtnBleLink.Text = "连接";
            // 
            // toolStripSeparatorBle2
            // 
            this.toolStripSeparatorBle2.Name = "toolStripSeparatorBle2";
            this.toolStripSeparatorBle2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnBleResite
            // 
            this.toolBtnBleResite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnBleResite.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnBleResite.Image")));
            this.toolBtnBleResite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnBleResite.Name = "toolBtnBleResite";
            this.toolBtnBleResite.Size = new System.Drawing.Size(60, 21);
            this.toolBtnBleResite.Tag = "3";
            this.toolBtnBleResite.Text = "重启蓝牙";
            // 
            // toolCmdWrite
            // 
            this.toolCmdWrite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolCmdWrite.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolCmdWrite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAuto,
            this.toolStripSeparator1,
            this.toolBtnHot,
            this.toolBtnMotor,
            this.toolBtnCool,
            this.toolBtnPn1,
            this.toolBtnPn2,
            this.toolBtnL,
            this.toolBtnRh,
            this.toolStripSeparator2,
            this.toolBtnStop});
            this.toolCmdWrite.Location = new System.Drawing.Point(3, 93);
            this.toolCmdWrite.Name = "toolCmdWrite";
            this.toolCmdWrite.Size = new System.Drawing.Size(484, 25);
            this.toolCmdWrite.TabIndex = 8;
            this.toolCmdWrite.Text = "toolStrip1";
            this.toolCmdWrite.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolCmdWrite_ItemClicked);
            // 
            // toolBtnAuto
            // 
            this.toolBtnAuto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnAuto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolBtnAuto.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnAuto.Image")));
            this.toolBtnAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAuto.Name = "toolBtnAuto";
            this.toolBtnAuto.Size = new System.Drawing.Size(60, 22);
            this.toolBtnAuto.Tag = "0";
            this.toolBtnAuto.Text = "自动测试";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnHot
            // 
            this.toolBtnHot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnHot.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnHot.Image")));
            this.toolBtnHot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnHot.Name = "toolBtnHot";
            this.toolBtnHot.Size = new System.Drawing.Size(36, 22);
            this.toolBtnHot.Tag = "1";
            this.toolBtnHot.Text = "加热";
            // 
            // toolBtnMotor
            // 
            this.toolBtnMotor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnMotor.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnMotor.Image")));
            this.toolBtnMotor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnMotor.Name = "toolBtnMotor";
            this.toolBtnMotor.Size = new System.Drawing.Size(60, 22);
            this.toolBtnMotor.Tag = "2";
            this.toolBtnMotor.Text = "震动电机";
            // 
            // toolBtnCool
            // 
            this.toolBtnCool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnCool.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnCool.Image")));
            this.toolBtnCool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnCool.Name = "toolBtnCool";
            this.toolBtnCool.Size = new System.Drawing.Size(36, 22);
            this.toolBtnCool.Tag = "3";
            this.toolBtnCool.Text = "制冷";
            // 
            // toolBtnPn1
            // 
            this.toolBtnPn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnPn1.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnPn1.Image")));
            this.toolBtnPn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPn1.Name = "toolBtnPn1";
            this.toolBtnPn1.Size = new System.Drawing.Size(48, 22);
            this.toolBtnPn1.Tag = "4";
            this.toolBtnPn1.Text = "正脉冲";
            // 
            // toolBtnPn2
            // 
            this.toolBtnPn2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnPn2.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnPn2.Image")));
            this.toolBtnPn2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPn2.Name = "toolBtnPn2";
            this.toolBtnPn2.Size = new System.Drawing.Size(48, 22);
            this.toolBtnPn2.Tag = "5";
            this.toolBtnPn2.Text = "负脉冲";
            // 
            // toolBtnL
            // 
            this.toolBtnL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnL.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnL.Image")));
            this.toolBtnL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnL.Name = "toolBtnL";
            this.toolBtnL.Size = new System.Drawing.Size(60, 22);
            this.toolBtnL.Tag = "6";
            this.toolBtnL.Text = "皮肤接触";
            // 
            // toolBtnRh
            // 
            this.toolBtnRh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnRh.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnRh.Image")));
            this.toolBtnRh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRh.Name = "toolBtnRh";
            this.toolBtnRh.Size = new System.Drawing.Size(60, 22);
            this.toolBtnRh.Tag = "7";
            this.toolBtnRh.Text = "皮肤水份";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnStop
            // 
            this.toolBtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnStop.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnStop.Image")));
            this.toolBtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnStop.Name = "toolBtnStop";
            this.toolBtnStop.Size = new System.Drawing.Size(60, 22);
            this.toolBtnStop.Tag = "8";
            this.toolBtnStop.Text = "停止测试";
            // 
            // rioString
            // 
            this.rioString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rioString.AutoSize = true;
            this.rioString.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rioString.Location = new System.Drawing.Point(352, 61);
            this.rioString.Name = "rioString";
            this.rioString.Size = new System.Drawing.Size(62, 21);
            this.rioString.TabIndex = 7;
            this.rioString.Text = "字符串";
            this.rioString.UseVisualStyleBackColor = true;
            // 
            // rioHex
            // 
            this.rioHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rioHex.AutoSize = true;
            this.rioHex.Checked = true;
            this.rioHex.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rioHex.Location = new System.Drawing.Point(298, 61);
            this.rioHex.Name = "rioHex";
            this.rioHex.Size = new System.Drawing.Size(48, 21);
            this.rioHex.TabIndex = 6;
            this.rioHex.TabStop = true;
            this.rioHex.Text = "Hex";
            this.rioHex.UseVisualStyleBackColor = true;
            // 
            // btnSerialWrite
            // 
            this.btnSerialWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialWrite.Location = new System.Drawing.Point(420, 58);
            this.btnSerialWrite.Name = "btnSerialWrite";
            this.btnSerialWrite.Size = new System.Drawing.Size(64, 27);
            this.btnSerialWrite.TabIndex = 1;
            this.btnSerialWrite.Text = "发送";
            this.btnSerialWrite.UseVisualStyleBackColor = true;
            this.btnSerialWrite.Click += new System.EventHandler(this.btnSerialWrite_Click);
            // 
            // txtSerialWrite
            // 
            this.txtSerialWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialWrite.Location = new System.Drawing.Point(7, 58);
            this.txtSerialWrite.Name = "txtSerialWrite";
            this.txtSerialWrite.Size = new System.Drawing.Size(285, 27);
            this.txtSerialWrite.TabIndex = 0;
            // 
            // gbSerialLog
            // 
            this.gbSerialLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSerialLog.Controls.Add(this.chkLogHex);
            this.gbSerialLog.Controls.Add(this.chkShowError);
            this.gbSerialLog.Controls.Add(this.chkShowTime);
            this.gbSerialLog.Controls.Add(this.chkShowWrite);
            this.gbSerialLog.Controls.Add(this.btnLogClear);
            this.gbSerialLog.Controls.Add(this.txtDataReceived);
            this.gbSerialLog.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.gbSerialLog.Location = new System.Drawing.Point(171, 414);
            this.gbSerialLog.Name = "gbSerialLog";
            this.gbSerialLog.Size = new System.Drawing.Size(490, 156);
            this.gbSerialLog.TabIndex = 9;
            this.gbSerialLog.TabStop = false;
            this.gbSerialLog.Text = "输出日志";
            // 
            // chkLogHex
            // 
            this.chkLogHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkLogHex.AutoSize = true;
            this.chkLogHex.Location = new System.Drawing.Point(289, 125);
            this.chkLogHex.Name = "chkLogHex";
            this.chkLogHex.Size = new System.Drawing.Size(76, 24);
            this.chkLogHex.TabIndex = 5;
            this.chkLogHex.Text = "16进制";
            this.chkLogHex.UseVisualStyleBackColor = true;
            // 
            // chkShowError
            // 
            this.chkShowError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowError.AutoSize = true;
            this.chkShowError.Location = new System.Drawing.Point(101, 125);
            this.chkShowError.Name = "chkShowError";
            this.chkShowError.Size = new System.Drawing.Size(88, 24);
            this.chkShowError.TabIndex = 4;
            this.chkShowError.Text = "显示错误";
            this.chkShowError.UseVisualStyleBackColor = true;
            // 
            // chkShowTime
            // 
            this.chkShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowTime.AutoSize = true;
            this.chkShowTime.Location = new System.Drawing.Point(195, 125);
            this.chkShowTime.Name = "chkShowTime";
            this.chkShowTime.Size = new System.Drawing.Size(88, 24);
            this.chkShowTime.TabIndex = 3;
            this.chkShowTime.Text = "显示时间";
            this.chkShowTime.UseVisualStyleBackColor = true;
            // 
            // chkShowWrite
            // 
            this.chkShowWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowWrite.AutoSize = true;
            this.chkShowWrite.Location = new System.Drawing.Point(7, 125);
            this.chkShowWrite.Name = "chkShowWrite";
            this.chkShowWrite.Size = new System.Drawing.Size(88, 24);
            this.chkShowWrite.TabIndex = 2;
            this.chkShowWrite.Text = "显示发送";
            this.chkShowWrite.UseVisualStyleBackColor = true;
            // 
            // btnLogClear
            // 
            this.btnLogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogClear.Location = new System.Drawing.Point(420, 123);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(64, 27);
            this.btnLogClear.TabIndex = 1;
            this.btnLogClear.Text = "清空";
            this.btnLogClear.UseVisualStyleBackColor = true;
            this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
            // 
            // txtDataReceived
            // 
            this.txtDataReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataReceived.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtDataReceived.Location = new System.Drawing.Point(7, 26);
            this.txtDataReceived.Multiline = true;
            this.txtDataReceived.Name = "txtDataReceived";
            this.txtDataReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataReceived.Size = new System.Drawing.Size(477, 91);
            this.txtDataReceived.TabIndex = 0;
            // 
            // labBleStatus
            // 
            this.labBleStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labBleStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labBleStatus.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBleStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.labBleStatus.Location = new System.Drawing.Point(171, 136);
            this.labBleStatus.Name = "labBleStatus";
            this.labBleStatus.Size = new System.Drawing.Size(490, 28);
            this.labBleStatus.TabIndex = 12;
            this.labBleStatus.Text = "蓝牙状态";
            this.labBleStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabSerialReceived);
            this.tabControl1.Controls.Add(this.tabBleTest);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(171, 167);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 241);
            this.tabControl1.TabIndex = 13;
            // 
            // tabSerialReceived
            // 
            this.tabSerialReceived.Controls.Add(this.listViewSerialReceived);
            this.tabSerialReceived.Location = new System.Drawing.Point(4, 26);
            this.tabSerialReceived.Name = "tabSerialReceived";
            this.tabSerialReceived.Padding = new System.Windows.Forms.Padding(3);
            this.tabSerialReceived.Size = new System.Drawing.Size(482, 211);
            this.tabSerialReceived.TabIndex = 0;
            this.tabSerialReceived.Text = "接收数据解析";
            this.tabSerialReceived.UseVisualStyleBackColor = true;
            // 
            // listViewSerialReceived
            // 
            this.listViewSerialReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSerialReceived.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.listViewSerialReceived.Location = new System.Drawing.Point(6, 6);
            this.listViewSerialReceived.Name = "listViewSerialReceived";
            this.listViewSerialReceived.Size = new System.Drawing.Size(470, 199);
            this.listViewSerialReceived.TabIndex = 1;
            this.listViewSerialReceived.UseCompatibleStateImageBehavior = false;
            // 
            // tabBleTest
            // 
            this.tabBleTest.Controls.Add(this.labTestStatus);
            this.tabBleTest.Controls.Add(this.listViewBleTest);
            this.tabBleTest.Location = new System.Drawing.Point(4, 26);
            this.tabBleTest.Name = "tabBleTest";
            this.tabBleTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabBleTest.Size = new System.Drawing.Size(482, 211);
            this.tabBleTest.TabIndex = 1;
            this.tabBleTest.Text = "测试结果";
            this.tabBleTest.UseVisualStyleBackColor = true;
            // 
            // labTestStatus
            // 
            this.labTestStatus.BackColor = System.Drawing.Color.Green;
            this.labTestStatus.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTestStatus.ForeColor = System.Drawing.Color.White;
            this.labTestStatus.Location = new System.Drawing.Point(6, 167);
            this.labTestStatus.Name = "labTestStatus";
            this.labTestStatus.Size = new System.Drawing.Size(470, 37);
            this.labTestStatus.TabIndex = 1;
            this.labTestStatus.Text = "PASS";
            this.labTestStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewBleTest
            // 
            this.listViewBleTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBleTest.Location = new System.Drawing.Point(6, 6);
            this.listViewBleTest.Name = "listViewBleTest";
            this.listViewBleTest.Size = new System.Drawing.Size(470, 158);
            this.listViewBleTest.TabIndex = 0;
            this.listViewBleTest.UseCompatibleStateImageBehavior = false;
            // 
            // imageListStatus
            // 
            this.imageListStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStatus.ImageStream")));
            this.imageListStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStatus.Images.SetKeyName(0, "BleTestTool_Status_0.png");
            this.imageListStatus.Images.SetKeyName(1, "BleTestTool_Status_1.png");
            this.imageListStatus.Images.SetKeyName(2, "BleTestTool_Status_2.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labBleStatus);
            this.Controls.Add(this.gbSerialWrite);
            this.Controls.Add(this.gbSerialLog);
            this.Controls.Add(this.gbConfigCom);
            this.MinimumSize = new System.Drawing.Size(685, 616);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口蓝牙测试工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbConfigCom.ResumeLayout(false);
            this.gbConfigCom.PerformLayout();
            this.gbSerialWrite.ResumeLayout(false);
            this.gbSerialWrite.PerformLayout();
            this.toolBleWrite.ResumeLayout(false);
            this.toolBleWrite.PerformLayout();
            this.toolCmdWrite.ResumeLayout(false);
            this.toolCmdWrite.PerformLayout();
            this.gbSerialLog.ResumeLayout(false);
            this.gbSerialLog.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSerialReceived.ResumeLayout(false);
            this.tabBleTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfigCom;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSerialPortSwitch;
        private System.Windows.Forms.GroupBox gbSerialWrite;
        private System.Windows.Forms.RadioButton rioString;
        private System.Windows.Forms.RadioButton rioHex;
        private System.Windows.Forms.Button btnSerialWrite;
        private System.Windows.Forms.TextBox txtSerialWrite;
        private System.Windows.Forms.GroupBox gbSerialLog;
        private System.Windows.Forms.TextBox txtDataReceived;
        private System.Windows.Forms.CheckBox chkShowError;
        private System.Windows.Forms.CheckBox chkShowTime;
        private System.Windows.Forms.CheckBox chkShowWrite;
        private System.Windows.Forms.Button btnLogClear;
        private System.Windows.Forms.ToolStrip toolCmdWrite;
        private System.Windows.Forms.ToolStripButton toolBtnAuto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBtnHot;
        private System.Windows.Forms.ToolStripButton toolBtnMotor;
        private System.Windows.Forms.ToolStripButton toolBtnCool;
        private System.Windows.Forms.ToolStripButton toolBtnPn1;
        private System.Windows.Forms.ToolStripButton toolBtnPn2;
        private System.Windows.Forms.ToolStripButton toolBtnL;
        private System.Windows.Forms.ToolStripButton toolBtnRh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolBtnStop;
        private System.Windows.Forms.ToolStrip toolBleWrite;
        private System.Windows.Forms.ToolStripLabel toolStripLabelBle;
        private System.Windows.Forms.ToolStripButton toolBtnBleInit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorBle1;
        private System.Windows.Forms.ToolStripButton toolBtnBleFind;
        private System.Windows.Forms.ToolStripComboBox toolComboBle;
        private System.Windows.Forms.ToolStripButton toolBtnBleLink;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorBle2;
        private System.Windows.Forms.ToolStripButton toolBtnBleResite;
        private System.Windows.Forms.CheckBox chkLogHex;
        private System.Windows.Forms.Label labBleStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSerialReceived;
        private System.Windows.Forms.ListView listViewSerialReceived;
        private System.Windows.Forms.TabPage tabBleTest;
        private System.Windows.Forms.ListView listViewBleTest;
        private System.Windows.Forms.ImageList imageListStatus;
        private System.Windows.Forms.Label labTestStatus;
    }
}

