namespace DeviceTestLib
{
    partial class frmBeautyTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeautyTest));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewBleTest = new System.Windows.Forms.ListView();
            this.listViewSerialReceived = new System.Windows.Forms.ListView();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolCmdWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolCmdWrite);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送命令";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewBleTest);
            this.groupBox2.Controls.Add(this.listViewSerialReceived);
            this.groupBox2.Location = new System.Drawing.Point(13, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 237);
            this.groupBox2.TabIndex = 2;
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
            this.toolCmdWrite.Location = new System.Drawing.Point(3, 39);
            this.toolCmdWrite.Name = "toolCmdWrite";
            this.toolCmdWrite.Size = new System.Drawing.Size(720, 25);
            this.toolCmdWrite.TabIndex = 9;
            this.toolCmdWrite.Text = "toolStrip1";
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
            // frmBeautyTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBeautyTest";
            this.Text = "frmBeautyTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolCmdWrite.ResumeLayout(false);
            this.toolCmdWrite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListView listViewBleTest;
        public System.Windows.Forms.ListView listViewSerialReceived;
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
        public System.Windows.Forms.ToolStrip toolCmdWrite;
    }
}