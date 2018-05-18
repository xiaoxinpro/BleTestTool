namespace DeviceTestLib
{
    partial class frmHumidTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHumidTest));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolCmdWrite = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboLight = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripBtnOpenWhiteLight = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOpenYellowLight = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOpenAllLight = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCloseLight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboHumid = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripBtnOpenHumid = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCloseHumid = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewBleTest = new System.Windows.Forms.ListView();
            this.listViewSerialReceived = new System.Windows.Forms.ListView();
            this.toolStripBtnChangeLight = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolCmdWrite.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolCmdWrite);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送命令";
            // 
            // toolCmdWrite
            // 
            this.toolCmdWrite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolCmdWrite.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolCmdWrite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboLight,
            this.toolStripBtnChangeLight,
            this.toolStripBtnOpenWhiteLight,
            this.toolStripBtnOpenYellowLight,
            this.toolStripBtnOpenAllLight,
            this.toolStripBtnCloseLight,
            this.toolStripSeparator1,
            this.toolStripComboHumid,
            this.toolStripBtnOpenHumid,
            this.toolStripBtnCloseHumid,
            this.toolStripSeparator2});
            this.toolCmdWrite.Location = new System.Drawing.Point(3, 72);
            this.toolCmdWrite.Name = "toolCmdWrite";
            this.toolCmdWrite.Size = new System.Drawing.Size(720, 25);
            this.toolCmdWrite.TabIndex = 0;
            this.toolCmdWrite.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "智能加湿器：";
            // 
            // toolStripComboLight
            // 
            this.toolStripComboLight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboLight.Items.AddRange(new object[] {
            "10%亮度",
            "20%亮度",
            "30%亮度",
            "40%亮度",
            "50%亮度",
            "60%亮度",
            "70%亮度",
            "80%亮度",
            "90%亮度",
            "100%亮度"});
            this.toolStripComboLight.Name = "toolStripComboLight";
            this.toolStripComboLight.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripBtnOpenWhiteLight
            // 
            this.toolStripBtnOpenWhiteLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnOpenWhiteLight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpenWhiteLight.Image")));
            this.toolStripBtnOpenWhiteLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenWhiteLight.Name = "toolStripBtnOpenWhiteLight";
            this.toolStripBtnOpenWhiteLight.Size = new System.Drawing.Size(48, 22);
            this.toolStripBtnOpenWhiteLight.Text = "开白灯";
            // 
            // toolStripBtnOpenYellowLight
            // 
            this.toolStripBtnOpenYellowLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnOpenYellowLight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpenYellowLight.Image")));
            this.toolStripBtnOpenYellowLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenYellowLight.Name = "toolStripBtnOpenYellowLight";
            this.toolStripBtnOpenYellowLight.Size = new System.Drawing.Size(48, 22);
            this.toolStripBtnOpenYellowLight.Text = "开黄灯";
            // 
            // toolStripBtnOpenAllLight
            // 
            this.toolStripBtnOpenAllLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnOpenAllLight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpenAllLight.Image")));
            this.toolStripBtnOpenAllLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenAllLight.Name = "toolStripBtnOpenAllLight";
            this.toolStripBtnOpenAllLight.Size = new System.Drawing.Size(60, 22);
            this.toolStripBtnOpenAllLight.Text = "开白黄灯";
            // 
            // toolStripBtnCloseLight
            // 
            this.toolStripBtnCloseLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnCloseLight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCloseLight.Image")));
            this.toolStripBtnCloseLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCloseLight.Name = "toolStripBtnCloseLight";
            this.toolStripBtnCloseLight.Size = new System.Drawing.Size(36, 22);
            this.toolStripBtnCloseLight.Text = "关灯";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboHumid
            // 
            this.toolStripComboHumid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboHumid.Items.AddRange(new object[] {
            "10%雾化",
            "20%雾化",
            "30%雾化",
            "40%雾化",
            "50%雾化",
            "60%雾化",
            "70%雾化",
            "80%雾化",
            "90%雾化",
            "100%雾化"});
            this.toolStripComboHumid.Name = "toolStripComboHumid";
            this.toolStripComboHumid.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripBtnOpenHumid
            // 
            this.toolStripBtnOpenHumid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnOpenHumid.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpenHumid.Image")));
            this.toolStripBtnOpenHumid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenHumid.Name = "toolStripBtnOpenHumid";
            this.toolStripBtnOpenHumid.Size = new System.Drawing.Size(48, 22);
            this.toolStripBtnOpenHumid.Text = "开雾化";
            // 
            // toolStripBtnCloseHumid
            // 
            this.toolStripBtnCloseHumid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnCloseHumid.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCloseHumid.Image")));
            this.toolStripBtnCloseHumid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCloseHumid.Name = "toolStripBtnCloseHumid";
            this.toolStripBtnCloseHumid.Size = new System.Drawing.Size(48, 22);
            this.toolStripBtnCloseHumid.Text = "关雾化";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewBleTest);
            this.groupBox2.Controls.Add(this.listViewSerialReceived);
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收命令";
            // 
            // listViewBleTest
            // 
            this.listViewBleTest.Location = new System.Drawing.Point(370, 20);
            this.listViewBleTest.Name = "listViewBleTest";
            this.listViewBleTest.Size = new System.Drawing.Size(350, 211);
            this.listViewBleTest.TabIndex = 1;
            this.listViewBleTest.UseCompatibleStateImageBehavior = false;
            // 
            // listViewSerialReceived
            // 
            this.listViewSerialReceived.Location = new System.Drawing.Point(6, 20);
            this.listViewSerialReceived.Name = "listViewSerialReceived";
            this.listViewSerialReceived.Size = new System.Drawing.Size(358, 211);
            this.listViewSerialReceived.TabIndex = 0;
            this.listViewSerialReceived.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripBtnChangeLight
            // 
            this.toolStripBtnChangeLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnChangeLight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnChangeLight.Image")));
            this.toolStripBtnChangeLight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnChangeLight.Name = "toolStripBtnChangeLight";
            this.toolStripBtnChangeLight.Size = new System.Drawing.Size(60, 22);
            this.toolStripBtnChangeLight.Text = "改变亮度";
            // 
            // frmHumidTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHumidTest";
            this.Text = "frmHumidTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolCmdWrite.ResumeLayout(false);
            this.toolCmdWrite.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListView listViewBleTest;
        public System.Windows.Forms.ListView listViewSerialReceived;
        public System.Windows.Forms.ToolStrip toolCmdWrite;
        public System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripComboBox toolStripComboLight;
        public System.Windows.Forms.ToolStripButton toolStripBtnOpenWhiteLight;
        public System.Windows.Forms.ToolStripButton toolStripBtnOpenYellowLight;
        public System.Windows.Forms.ToolStripButton toolStripBtnOpenAllLight;
        public System.Windows.Forms.ToolStripButton toolStripBtnCloseLight;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripComboBox toolStripComboHumid;
        public System.Windows.Forms.ToolStripButton toolStripBtnOpenHumid;
        public System.Windows.Forms.ToolStripButton toolStripBtnCloseHumid;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnChangeLight;
    }
}