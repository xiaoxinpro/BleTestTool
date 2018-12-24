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
            this.btnBleConfig = new System.Windows.Forms.Button();
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
            this.toolCmdWrite = new System.Windows.Forms.ToolStrip();
            this.toolBleWrite = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelBle = new System.Windows.Forms.ToolStripLabel();
            this.toolBtnBleInit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorBle1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnBleFind = new System.Windows.Forms.ToolStripButton();
            this.toolComboBle = new System.Windows.Forms.ToolStripComboBox();
            this.toolBtnBleLink = new System.Windows.Forms.ToolStripButton();
            this.rioString = new System.Windows.Forms.RadioButton();
            this.rioHex = new System.Windows.Forms.RadioButton();
            this.btnSerialWrite = new System.Windows.Forms.Button();
            this.txtSerialWrite = new System.Windows.Forms.TextBox();
            this.labBleStatus = new System.Windows.Forms.Label();
            this.imageListStatus = new System.Windows.Forms.ImageList(this.components);
            this.btnLoadDeviceLib = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSerialReceived = new System.Windows.Forms.TabPage();
            this.listViewSerialReceived = new System.Windows.Forms.ListView();
            this.tabBleTest = new System.Windows.Forms.TabPage();
            this.labTestStatus = new System.Windows.Forms.Label();
            this.listViewBleTest = new System.Windows.Forms.ListView();
            this.gbSerialLog = new System.Windows.Forms.GroupBox();
            this.chkLogHex = new System.Windows.Forms.CheckBox();
            this.chkShowError = new System.Windows.Forms.CheckBox();
            this.chkShowTime = new System.Windows.Forms.CheckBox();
            this.chkShowWrite = new System.Windows.Forms.CheckBox();
            this.btnLogClear = new System.Windows.Forms.Button();
            this.txtDataReceived = new System.Windows.Forms.TextBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDriverName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDriverVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBleStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.gbBleFuction = new System.Windows.Forms.GroupBox();
            this.numBleAutoReLink = new System.Windows.Forms.NumericUpDown();
            this.chkBleAutoReLink = new System.Windows.Forms.CheckBox();
            this.gbBleLinkTest = new System.Windows.Forms.GroupBox();
            this.labelBleLinkTestCount = new System.Windows.Forms.Label();
            this.numBleLinkCount = new System.Windows.Forms.NumericUpDown();
            this.numBleLinkInterval = new System.Windows.Forms.NumericUpDown();
            this.txtBlelinkLogPath = new System.Windows.Forms.Label();
            this.btnBleLinkLog = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chkBleLinkTest = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbConfigCom.SuspendLayout();
            this.gbSerialWrite.SuspendLayout();
            this.toolBleWrite.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSerialReceived.SuspendLayout();
            this.tabBleTest.SuspendLayout();
            this.gbSerialLog.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.gbBleFuction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBleAutoReLink)).BeginInit();
            this.gbBleLinkTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBleLinkCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBleLinkInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConfigCom
            // 
            this.gbConfigCom.Controls.Add(this.btnBleConfig);
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
            this.gbConfigCom.Size = new System.Drawing.Size(148, 301);
            this.gbConfigCom.TabIndex = 5;
            this.gbConfigCom.TabStop = false;
            this.gbConfigCom.Text = "蓝牙配置";
            // 
            // btnBleConfig
            // 
            this.btnBleConfig.Location = new System.Drawing.Point(8, 255);
            this.btnBleConfig.Name = "btnBleConfig";
            this.btnBleConfig.Size = new System.Drawing.Size(131, 32);
            this.btnBleConfig.TabIndex = 11;
            this.btnBleConfig.Text = "高级配置";
            this.btnBleConfig.UseVisualStyleBackColor = true;
            this.btnBleConfig.Click += new System.EventHandler(this.btnBleConfig_Click);
            // 
            // btnSerialPortSwitch
            // 
            this.btnSerialPortSwitch.Location = new System.Drawing.Point(8, 213);
            this.btnSerialPortSwitch.Name = "btnSerialPortSwitch";
            this.btnSerialPortSwitch.Size = new System.Drawing.Size(131, 32);
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
            this.gbSerialWrite.Controls.Add(this.toolCmdWrite);
            this.gbSerialWrite.Controls.Add(this.toolBleWrite);
            this.gbSerialWrite.Controls.Add(this.rioString);
            this.gbSerialWrite.Controls.Add(this.rioHex);
            this.gbSerialWrite.Controls.Add(this.btnSerialWrite);
            this.gbSerialWrite.Controls.Add(this.txtSerialWrite);
            this.gbSerialWrite.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.gbSerialWrite.Location = new System.Drawing.Point(174, 12);
            this.gbSerialWrite.Name = "gbSerialWrite";
            this.gbSerialWrite.Size = new System.Drawing.Size(519, 121);
            this.gbSerialWrite.TabIndex = 10;
            this.gbSerialWrite.TabStop = false;
            this.gbSerialWrite.Text = "发送数据";
            // 
            // toolCmdWrite
            // 
            this.toolCmdWrite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolCmdWrite.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolCmdWrite.Location = new System.Drawing.Point(3, 93);
            this.toolCmdWrite.Name = "toolCmdWrite";
            this.toolCmdWrite.Size = new System.Drawing.Size(513, 25);
            this.toolCmdWrite.TabIndex = 10;
            this.toolCmdWrite.Text = "toolStrip1";
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
            this.toolBtnBleLink});
            this.toolBleWrite.Location = new System.Drawing.Point(3, 23);
            this.toolBleWrite.Name = "toolBleWrite";
            this.toolBleWrite.Size = new System.Drawing.Size(513, 25);
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
            // rioString
            // 
            this.rioString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rioString.AutoSize = true;
            this.rioString.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rioString.Location = new System.Drawing.Point(381, 61);
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
            this.rioHex.Location = new System.Drawing.Point(327, 61);
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
            this.btnSerialWrite.Location = new System.Drawing.Point(449, 58);
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
            this.txtSerialWrite.Size = new System.Drawing.Size(314, 27);
            this.txtSerialWrite.TabIndex = 0;
            // 
            // labBleStatus
            // 
            this.labBleStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labBleStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labBleStatus.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBleStatus.ForeColor = System.Drawing.Color.Blue;
            this.labBleStatus.Location = new System.Drawing.Point(174, 136);
            this.labBleStatus.Name = "labBleStatus";
            this.labBleStatus.Size = new System.Drawing.Size(519, 28);
            this.labBleStatus.TabIndex = 12;
            this.labBleStatus.Text = "蓝牙状态";
            this.labBleStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageListStatus
            // 
            this.imageListStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStatus.ImageStream")));
            this.imageListStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStatus.Images.SetKeyName(0, "BleTestTool_Status_0.png");
            this.imageListStatus.Images.SetKeyName(1, "BleTestTool_Status_1.png");
            this.imageListStatus.Images.SetKeyName(2, "BleTestTool_Status_2.png");
            // 
            // btnLoadDeviceLib
            // 
            this.btnLoadDeviceLib.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadDeviceLib.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadDeviceLib.Location = new System.Drawing.Point(11, 586);
            this.btnLoadDeviceLib.Name = "btnLoadDeviceLib";
            this.btnLoadDeviceLib.Size = new System.Drawing.Size(148, 39);
            this.btnLoadDeviceLib.TabIndex = 14;
            this.btnLoadDeviceLib.Text = "加载驱动";
            this.btnLoadDeviceLib.UseVisualStyleBackColor = true;
            this.btnLoadDeviceLib.Click += new System.EventHandler(this.btnLoadDeviceLib_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(171, 167);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1MinSize = 95;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbSerialLog);
            this.splitContainer1.Panel2MinSize = 110;
            this.splitContainer1.Size = new System.Drawing.Size(525, 467);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabSerialReceived);
            this.tabControl1.Controls.Add(this.tabBleTest);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 258);
            this.tabControl1.TabIndex = 14;
            // 
            // tabSerialReceived
            // 
            this.tabSerialReceived.Controls.Add(this.listViewSerialReceived);
            this.tabSerialReceived.Location = new System.Drawing.Point(4, 26);
            this.tabSerialReceived.Name = "tabSerialReceived";
            this.tabSerialReceived.Padding = new System.Windows.Forms.Padding(3);
            this.tabSerialReceived.Size = new System.Drawing.Size(511, 228);
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
            this.listViewSerialReceived.Size = new System.Drawing.Size(499, 220);
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
            this.tabBleTest.Size = new System.Drawing.Size(511, 220);
            this.tabBleTest.TabIndex = 1;
            this.tabBleTest.Text = "测试结果";
            this.tabBleTest.UseVisualStyleBackColor = true;
            // 
            // labTestStatus
            // 
            this.labTestStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTestStatus.BackColor = System.Drawing.Color.Green;
            this.labTestStatus.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTestStatus.ForeColor = System.Drawing.Color.White;
            this.labTestStatus.Location = new System.Drawing.Point(6, 176);
            this.labTestStatus.Name = "labTestStatus";
            this.labTestStatus.Size = new System.Drawing.Size(499, 41);
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
            this.listViewBleTest.Size = new System.Drawing.Size(499, 167);
            this.listViewBleTest.TabIndex = 0;
            this.listViewBleTest.UseCompatibleStateImageBehavior = false;
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
            this.gbSerialLog.Location = new System.Drawing.Point(3, 3);
            this.gbSerialLog.Name = "gbSerialLog";
            this.gbSerialLog.Size = new System.Drawing.Size(519, 190);
            this.gbSerialLog.TabIndex = 10;
            this.gbSerialLog.TabStop = false;
            this.gbSerialLog.Text = "输出日志";
            // 
            // chkLogHex
            // 
            this.chkLogHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkLogHex.AutoSize = true;
            this.chkLogHex.Location = new System.Drawing.Point(289, 159);
            this.chkLogHex.Name = "chkLogHex";
            this.chkLogHex.Size = new System.Drawing.Size(76, 24);
            this.chkLogHex.TabIndex = 5;
            this.chkLogHex.Text = "16进制";
            this.chkLogHex.UseVisualStyleBackColor = true;
            this.chkLogHex.CheckedChanged += new System.EventHandler(this.SaveSerialLogConfing);
            // 
            // chkShowError
            // 
            this.chkShowError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowError.AutoSize = true;
            this.chkShowError.Location = new System.Drawing.Point(101, 159);
            this.chkShowError.Name = "chkShowError";
            this.chkShowError.Size = new System.Drawing.Size(88, 24);
            this.chkShowError.TabIndex = 4;
            this.chkShowError.Text = "显示错误";
            this.chkShowError.UseVisualStyleBackColor = true;
            this.chkShowError.CheckedChanged += new System.EventHandler(this.SaveSerialLogConfing);
            // 
            // chkShowTime
            // 
            this.chkShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowTime.AutoSize = true;
            this.chkShowTime.Location = new System.Drawing.Point(195, 159);
            this.chkShowTime.Name = "chkShowTime";
            this.chkShowTime.Size = new System.Drawing.Size(88, 24);
            this.chkShowTime.TabIndex = 3;
            this.chkShowTime.Text = "显示时间";
            this.chkShowTime.UseVisualStyleBackColor = true;
            this.chkShowTime.CheckedChanged += new System.EventHandler(this.SaveSerialLogConfing);
            // 
            // chkShowWrite
            // 
            this.chkShowWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowWrite.AutoSize = true;
            this.chkShowWrite.Location = new System.Drawing.Point(7, 159);
            this.chkShowWrite.Name = "chkShowWrite";
            this.chkShowWrite.Size = new System.Drawing.Size(88, 24);
            this.chkShowWrite.TabIndex = 2;
            this.chkShowWrite.Text = "显示发送";
            this.chkShowWrite.UseVisualStyleBackColor = true;
            this.chkShowWrite.CheckedChanged += new System.EventHandler(this.SaveSerialLogConfing);
            // 
            // btnLogClear
            // 
            this.btnLogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogClear.Location = new System.Drawing.Point(449, 157);
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
            this.txtDataReceived.Size = new System.Drawing.Size(506, 125);
            this.txtDataReceived.TabIndex = 0;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDriverName,
            this.toolStripStatusLabelDriverVersion,
            this.toolStripStatusLabelBleStatus,
            this.toolStripStatusLabelTime});
            this.statusStripMain.Location = new System.Drawing.Point(0, 637);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(704, 25);
            this.statusStripMain.TabIndex = 16;
            this.statusStripMain.Text = "状态栏";
            // 
            // toolStripStatusLabelDriverName
            // 
            this.toolStripStatusLabelDriverName.Name = "toolStripStatusLabelDriverName";
            this.toolStripStatusLabelDriverName.Size = new System.Drawing.Size(79, 20);
            this.toolStripStatusLabelDriverName.Text = "待加载驱动";
            // 
            // toolStripStatusLabelDriverVersion
            // 
            this.toolStripStatusLabelDriverVersion.Name = "toolStripStatusLabelDriverVersion";
            this.toolStripStatusLabelDriverVersion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripStatusLabelDriverVersion.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabelDriverVersion.Text = "V1.1.1.0";
            this.toolStripStatusLabelDriverVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelBleStatus
            // 
            this.toolStripStatusLabelBleStatus.AutoSize = false;
            this.toolStripStatusLabelBleStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabelBleStatus.Name = "toolStripStatusLabelBleStatus";
            this.toolStripStatusLabelBleStatus.Size = new System.Drawing.Size(341, 20);
            this.toolStripStatusLabelBleStatus.Spring = true;
            this.toolStripStatusLabelBleStatus.Text = "蓝牙状态";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.AutoSize = false;
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(200, 20);
            this.toolStripStatusLabelTime.Text = "2018-6-19 星期二 12:45:42";
            this.toolStripStatusLabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerStatus
            // 
            this.timerStatus.Enabled = true;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // gbBleFuction
            // 
            this.gbBleFuction.Controls.Add(this.numBleAutoReLink);
            this.gbBleFuction.Controls.Add(this.chkBleAutoReLink);
            this.gbBleFuction.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.gbBleFuction.Location = new System.Drawing.Point(11, 317);
            this.gbBleFuction.Name = "gbBleFuction";
            this.gbBleFuction.Size = new System.Drawing.Size(148, 61);
            this.gbBleFuction.TabIndex = 17;
            this.gbBleFuction.TabStop = false;
            this.gbBleFuction.Text = "蓝牙连接选项";
            // 
            // numBleAutoReLink
            // 
            this.numBleAutoReLink.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.numBleAutoReLink.Location = new System.Drawing.Point(89, 26);
            this.numBleAutoReLink.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBleAutoReLink.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBleAutoReLink.Name = "numBleAutoReLink";
            this.numBleAutoReLink.Size = new System.Drawing.Size(50, 23);
            this.numBleAutoReLink.TabIndex = 3;
            this.numBleAutoReLink.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numBleAutoReLink.Visible = false;
            // 
            // chkBleAutoReLink
            // 
            this.chkBleAutoReLink.AutoSize = true;
            this.chkBleAutoReLink.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chkBleAutoReLink.Location = new System.Drawing.Point(18, 27);
            this.chkBleAutoReLink.Name = "chkBleAutoReLink";
            this.chkBleAutoReLink.Size = new System.Drawing.Size(75, 21);
            this.chkBleAutoReLink.TabIndex = 0;
            this.chkBleAutoReLink.Text = "断线重连";
            this.chkBleAutoReLink.UseVisualStyleBackColor = true;
            this.chkBleAutoReLink.CheckedChanged += new System.EventHandler(this.chkBleAutoReLink_CheckedChanged);
            // 
            // gbBleLinkTest
            // 
            this.gbBleLinkTest.Controls.Add(this.labelBleLinkTestCount);
            this.gbBleLinkTest.Controls.Add(this.numBleLinkCount);
            this.gbBleLinkTest.Controls.Add(this.numBleLinkInterval);
            this.gbBleLinkTest.Controls.Add(this.txtBlelinkLogPath);
            this.gbBleLinkTest.Controls.Add(this.btnBleLinkLog);
            this.gbBleLinkTest.Controls.Add(this.label8);
            this.gbBleLinkTest.Controls.Add(this.chkBleLinkTest);
            this.gbBleLinkTest.Controls.Add(this.label7);
            this.gbBleLinkTest.Controls.Add(this.label1);
            this.gbBleLinkTest.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.gbBleLinkTest.Location = new System.Drawing.Point(11, 384);
            this.gbBleLinkTest.Name = "gbBleLinkTest";
            this.gbBleLinkTest.Size = new System.Drawing.Size(148, 174);
            this.gbBleLinkTest.TabIndex = 18;
            this.gbBleLinkTest.TabStop = false;
            this.gbBleLinkTest.Text = "蓝牙连接测试";
            // 
            // labelBleLinkTestCount
            // 
            this.labelBleLinkTestCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBleLinkTestCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBleLinkTestCount.Location = new System.Drawing.Point(79, 26);
            this.labelBleLinkTestCount.Name = "labelBleLinkTestCount";
            this.labelBleLinkTestCount.Size = new System.Drawing.Size(60, 19);
            this.labelBleLinkTestCount.TabIndex = 8;
            this.labelBleLinkTestCount.Text = "0";
            this.labelBleLinkTestCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numBleLinkCount
            // 
            this.numBleLinkCount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.numBleLinkCount.Location = new System.Drawing.Point(79, 82);
            this.numBleLinkCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBleLinkCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBleLinkCount.Name = "numBleLinkCount";
            this.numBleLinkCount.Size = new System.Drawing.Size(46, 23);
            this.numBleLinkCount.TabIndex = 7;
            this.numBleLinkCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numBleLinkInterval
            // 
            this.numBleLinkInterval.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.numBleLinkInterval.Location = new System.Drawing.Point(79, 53);
            this.numBleLinkInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBleLinkInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBleLinkInterval.Name = "numBleLinkInterval";
            this.numBleLinkInterval.Size = new System.Drawing.Size(46, 23);
            this.numBleLinkInterval.TabIndex = 6;
            this.numBleLinkInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // txtBlelinkLogPath
            // 
            this.txtBlelinkLogPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBlelinkLogPath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtBlelinkLogPath.Location = new System.Drawing.Point(8, 137);
            this.txtBlelinkLogPath.Name = "txtBlelinkLogPath";
            this.txtBlelinkLogPath.Size = new System.Drawing.Size(131, 19);
            this.txtBlelinkLogPath.TabIndex = 5;
            this.txtBlelinkLogPath.Text = "目录";
            // 
            // btnBleLinkLog
            // 
            this.btnBleLinkLog.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnBleLinkLog.Location = new System.Drawing.Point(79, 111);
            this.btnBleLinkLog.Name = "btnBleLinkLog";
            this.btnBleLinkLog.Size = new System.Drawing.Size(60, 23);
            this.btnBleLinkLog.TabIndex = 4;
            this.btnBleLinkLog.Text = "选择";
            this.btnBleLinkLog.UseVisualStyleBackColor = true;
            this.btnBleLinkLog.Click += new System.EventHandler(this.btnBleLinkLog_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label8.Location = new System.Drawing.Point(6, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "日志输出：";
            // 
            // chkBleLinkTest
            // 
            this.chkBleLinkTest.AutoSize = true;
            this.chkBleLinkTest.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chkBleLinkTest.Location = new System.Drawing.Point(8, 26);
            this.chkBleLinkTest.Name = "chkBleLinkTest";
            this.chkBleLinkTest.Size = new System.Drawing.Size(75, 21);
            this.chkBleLinkTest.TabIndex = 0;
            this.chkBleLinkTest.Text = "开启测试";
            this.chkBleLinkTest.UseVisualStyleBackColor = true;
            this.chkBleLinkTest.CheckedChanged += new System.EventHandler(this.chkBleLinkTest_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "有效数据量：            个";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "测试间隔：               秒";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 662);
            this.Controls.Add(this.gbBleLinkTest);
            this.Controls.Add(this.gbBleFuction);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnLoadDeviceLib);
            this.Controls.Add(this.labBleStatus);
            this.Controls.Add(this.gbSerialWrite);
            this.Controls.Add(this.gbConfigCom);
            this.MinimumSize = new System.Drawing.Size(720, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口蓝牙测试工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.gbConfigCom.ResumeLayout(false);
            this.gbConfigCom.PerformLayout();
            this.gbSerialWrite.ResumeLayout(false);
            this.gbSerialWrite.PerformLayout();
            this.toolBleWrite.ResumeLayout(false);
            this.toolBleWrite.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSerialReceived.ResumeLayout(false);
            this.tabBleTest.ResumeLayout(false);
            this.gbSerialLog.ResumeLayout(false);
            this.gbSerialLog.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.gbBleFuction.ResumeLayout(false);
            this.gbBleFuction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBleAutoReLink)).EndInit();
            this.gbBleLinkTest.ResumeLayout(false);
            this.gbBleLinkTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBleLinkCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBleLinkInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStrip toolBleWrite;
        private System.Windows.Forms.ToolStripLabel toolStripLabelBle;
        private System.Windows.Forms.ToolStripButton toolBtnBleInit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorBle1;
        private System.Windows.Forms.ToolStripButton toolBtnBleFind;
        private System.Windows.Forms.ToolStripComboBox toolComboBle;
        private System.Windows.Forms.ToolStripButton toolBtnBleLink;
        private System.Windows.Forms.Label labBleStatus;
        private System.Windows.Forms.ImageList imageListStatus;
        private System.Windows.Forms.Button btnBleConfig;
        private System.Windows.Forms.Button btnLoadDeviceLib;
        private System.Windows.Forms.ToolStrip toolCmdWrite;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSerialReceived;
        private System.Windows.Forms.ListView listViewSerialReceived;
        private System.Windows.Forms.TabPage tabBleTest;
        private System.Windows.Forms.Label labTestStatus;
        private System.Windows.Forms.ListView listViewBleTest;
        private System.Windows.Forms.GroupBox gbSerialLog;
        private System.Windows.Forms.CheckBox chkLogHex;
        private System.Windows.Forms.CheckBox chkShowError;
        private System.Windows.Forms.CheckBox chkShowTime;
        private System.Windows.Forms.CheckBox chkShowWrite;
        private System.Windows.Forms.Button btnLogClear;
        private System.Windows.Forms.TextBox txtDataReceived;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDriverName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDriverVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBleStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.GroupBox gbBleFuction;
        private System.Windows.Forms.NumericUpDown numBleAutoReLink;
        private System.Windows.Forms.CheckBox chkBleAutoReLink;
        private System.Windows.Forms.GroupBox gbBleLinkTest;
        private System.Windows.Forms.NumericUpDown numBleLinkCount;
        private System.Windows.Forms.NumericUpDown numBleLinkInterval;
        private System.Windows.Forms.Label txtBlelinkLogPath;
        private System.Windows.Forms.Button btnBleLinkLog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBleLinkTest;
        private System.Windows.Forms.Label labelBleLinkTestCount;
    }
}

