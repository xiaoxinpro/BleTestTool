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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolCmdWrite = new System.Windows.Forms.ToolStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewBleTest = new System.Windows.Forms.ListView();
            this.listViewSerialReceived = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // toolCmdWrite
            // 
            this.toolCmdWrite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolCmdWrite.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolCmdWrite.Location = new System.Drawing.Point(3, 39);
            this.toolCmdWrite.Name = "toolCmdWrite";
            this.toolCmdWrite.Size = new System.Drawing.Size(720, 25);
            this.toolCmdWrite.TabIndex = 11;
            this.toolCmdWrite.Text = "toolStrip1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolCmdWrite;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListView listViewBleTest;
        public System.Windows.Forms.ListView listViewSerialReceived;
    }
}