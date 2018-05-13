namespace BleTestTool
{
    partial class frmBleConfig
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewBleNameReplace = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBleName = new System.Windows.Forms.TextBox();
            this.txtBleReplace = new System.Windows.Forms.TextBox();
            this.btnBleNameReplace = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBleNameReplace);
            this.groupBox1.Controls.Add(this.txtBleReplace);
            this.groupBox1.Controls.Add(this.txtBleName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listViewBleNameReplace);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(372, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "蓝牙名称替换";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(14, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "蓝牙黑名单";
            // 
            // listViewBleNameReplace
            // 
            this.listViewBleNameReplace.Location = new System.Drawing.Point(8, 92);
            this.listViewBleNameReplace.Name = "listViewBleNameReplace";
            this.listViewBleNameReplace.Size = new System.Drawing.Size(356, 131);
            this.listViewBleNameReplace.TabIndex = 0;
            this.listViewBleNameReplace.UseCompatibleStateImageBehavior = false;
            this.listViewBleNameReplace.View = System.Windows.Forms.View.Details;
            this.listViewBleNameReplace.SelectedIndexChanged += new System.EventHandler(this.listViewBleNameReplace_SelectedIndexChanged);
            this.listViewBleNameReplace.DoubleClick += new System.EventHandler(this.listViewBleNameReplace_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "蓝牙名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "替换内容：";
            // 
            // txtBleName
            // 
            this.txtBleName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.txtBleName.Location = new System.Drawing.Point(92, 30);
            this.txtBleName.Name = "txtBleName";
            this.txtBleName.Size = new System.Drawing.Size(182, 25);
            this.txtBleName.TabIndex = 3;
            // 
            // txtBleReplace
            // 
            this.txtBleReplace.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.txtBleReplace.Location = new System.Drawing.Point(92, 61);
            this.txtBleReplace.Name = "txtBleReplace";
            this.txtBleReplace.Size = new System.Drawing.Size(182, 25);
            this.txtBleReplace.TabIndex = 4;
            // 
            // btnBleNameReplace
            // 
            this.btnBleNameReplace.Location = new System.Drawing.Point(280, 30);
            this.btnBleNameReplace.Name = "btnBleNameReplace";
            this.btnBleNameReplace.Size = new System.Drawing.Size(84, 56);
            this.btnBleNameReplace.TabIndex = 5;
            this.btnBleNameReplace.Text = "添加";
            this.btnBleNameReplace.UseVisualStyleBackColor = true;
            this.btnBleNameReplace.Click += new System.EventHandler(this.btnBleNameReplace_Click);
            // 
            // frmBleConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "frmBleConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "蓝牙高级配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBleConfig_FormClosing);
            this.Load += new System.EventHandler(this.frmBleConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewBleNameReplace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBleNameReplace;
        private System.Windows.Forms.TextBox txtBleReplace;
        private System.Windows.Forms.TextBox txtBleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}