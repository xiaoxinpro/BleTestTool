namespace DeviceTestLib
{
    partial class frmBreastTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBreastTest));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labTestStatus = new System.Windows.Forms.Label();
            this.listViewBleTest = new System.Windows.Forms.ListView();
            this.listViewSerialReceived = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolCmdWrite = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnOpenFan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboElect = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripBtnOpenElect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnOpenHot = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCloseHot = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnOFF = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolCmdWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labTestStatus);
            this.groupBox2.Controls.Add(this.listViewBleTest);
            this.groupBox2.Controls.Add(this.listViewSerialReceived);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 237);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收命令";
            // 
            // labTestStatus
            // 
            this.labTestStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTestStatus.BackColor = System.Drawing.Color.Green;
            this.labTestStatus.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTestStatus.ForeColor = System.Drawing.Color.White;
            this.labTestStatus.Location = new System.Drawing.Point(370, 190);
            this.labTestStatus.Name = "labTestStatus";
            this.labTestStatus.Size = new System.Drawing.Size(350, 41);
            this.labTestStatus.TabIndex = 3;
            this.labTestStatus.Text = "PASS";
            this.labTestStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewBleTest
            // 
            this.listViewBleTest.Location = new System.Drawing.Point(370, 20);
            this.listViewBleTest.Name = "listViewBleTest";
            this.listViewBleTest.Size = new System.Drawing.Size(350, 167);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolCmdWrite);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送命令";
            // 
            // toolCmdWrite
            // 
            this.toolCmdWrite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolCmdWrite.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolCmdWrite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripBtnOpenFan,
            this.toolStripSeparator1,
            this.toolStripComboElect,
            this.toolStripBtnOpenElect,
            this.toolStripSeparator2,
            this.toolStripBtnStop,
            this.toolStripSeparator3,
            this.toolStripBtnOpenHot,
            this.toolStripBtnCloseHot,
            this.toolStripSeparator4,
            this.toolStripBtnOFF});
            this.toolCmdWrite.Location = new System.Drawing.Point(3, 72);
            this.toolCmdWrite.Name = "toolCmdWrite";
            this.toolCmdWrite.Size = new System.Drawing.Size(720, 25);
            this.toolCmdWrite.TabIndex = 0;
            this.toolCmdWrite.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "丰胸仪：";
            // 
            // toolStripBtnOpenFan
            // 
            this.toolStripBtnOpenFan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnOpenFan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpenFan.Image")));
            this.toolStripBtnOpenFan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenFan.Name = "toolStripBtnOpenFan";
            this.toolStripBtnOpenFan.Size = new System.Drawing.Size(60, 22);
            this.toolStripBtnOpenFan.Text = "开启电机";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboElect
            // 
            this.toolStripComboElect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboElect.DropDownWidth = 75;
            this.toolStripComboElect.Items.AddRange(new object[] {
            "1档",
            "2档",
            "3档",
            "4档",
            "5档",
            "6档",
            "7档",
            "8档",
            "9档",
            "10档"});
            this.toolStripComboElect.Name = "toolStripComboElect";
            this.toolStripComboElect.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripBtnOpenElect
            // 
            this.toolStripBtnOpenElect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnOpenElect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpenElect.Image")));
            this.toolStripBtnOpenElect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenElect.Name = "toolStripBtnOpenElect";
            this.toolStripBtnOpenElect.Size = new System.Drawing.Size(60, 22);
            this.toolStripBtnOpenElect.Text = "开启电疗";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnOpenHot
            // 
            this.toolStripBtnOpenHot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnOpenHot.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpenHot.Image")));
            this.toolStripBtnOpenHot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenHot.Name = "toolStripBtnOpenHot";
            this.toolStripBtnOpenHot.Size = new System.Drawing.Size(60, 22);
            this.toolStripBtnOpenHot.Text = "开启加热";
            // 
            // toolStripBtnCloseHot
            // 
            this.toolStripBtnCloseHot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnCloseHot.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCloseHot.Image")));
            this.toolStripBtnCloseHot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCloseHot.Name = "toolStripBtnCloseHot";
            this.toolStripBtnCloseHot.Size = new System.Drawing.Size(60, 22);
            this.toolStripBtnCloseHot.Text = "关闭加热";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnStop
            // 
            this.toolStripBtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStop.Image")));
            this.toolStripBtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStop.Name = "toolStripBtnStop";
            this.toolStripBtnStop.Size = new System.Drawing.Size(36, 22);
            this.toolStripBtnStop.Text = "停止";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtnOFF
            // 
            this.toolStripBtnOFF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnOFF.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOFF.Image")));
            this.toolStripBtnOFF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOFF.Name = "toolStripBtnOFF";
            this.toolStripBtnOFF.Size = new System.Drawing.Size(36, 22);
            this.toolStripBtnOFF.Text = "关机";
            // 
            // frmBreastTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBreastTest";
            this.Text = "frmBreastTest";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolCmdWrite.ResumeLayout(false);
            this.toolCmdWrite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label labTestStatus;
        public System.Windows.Forms.ListView listViewBleTest;
        public System.Windows.Forms.ListView listViewSerialReceived;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ToolStrip toolCmdWrite;
        public System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpenFan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpenHot;
        private System.Windows.Forms.ToolStripButton toolStripBtnCloseHot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripBtnStop;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpenElect;
        public System.Windows.Forms.ToolStripComboBox toolStripComboElect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBtnOFF;
    }
}